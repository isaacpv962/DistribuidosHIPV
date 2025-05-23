
using System;
using System.Web.Services;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using GraphQL.Client.Http;
using GraphQL.Client.Serializer.Newtonsoft;
using ServidorPagos;

namespace ServidorPagos
{

    [WebService(Namespace = "http://usfx.edu.bo/pagos")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    public class PagosService : WebService
    {
        
        private const string SEGIP_GRAPHQL = "http://localhost:4000/graphql";

        
        /// Consulta al GraphQL de SEGIP y devuelve el array de Deuda
        
        [WebMethod(Description = "Verifica en SEGIP y devuelve el listado de deudas")]
        public Deuda[] verDeuda(string ci, string primerApellido, string nombres)
        {
          
            var persona = VerificarSegip(ci).GetAwaiter().GetResult();

            // Si no existe o no coincide, devolvemos arreglo vacío
            if (persona == null
                || !string.Equals(persona.primerApellido, primerApellido, StringComparison.OrdinalIgnoreCase)
                || !string.Equals(persona.nombres, nombres, StringComparison.OrdinalIgnoreCase))
            {
                return Array.Empty<Deuda>();
            }

            // lista de deudas que vino del GraphQL
            // persona.deudas ya es List<Deuda>
            return persona.deudas.ToArray();
        }

     
        /// Registra el pago delegando a la empresa vía REST
      
        [WebMethod(Description = "Registra el pago de la deuda en la empresa indicada")]
        public bool registrarPago(int deudaId, string ci, string empresa)
        {
            
            string url = empresa.Equals("CESSA", StringComparison.OrdinalIgnoreCase)
                ? "http://localhost:8001/api/facturas"
                : empresa.Equals("ELAPAS", StringComparison.OrdinalIgnoreCase)
                    ? "http://localhost:8002/api/facturas"
                    : null;

            if (url == null) return false;

            var factura = new
            {
                ci = ci,
                deudaId = deudaId,
                fecha_pago = DateTime.Now.ToString("yyyy-MM-dd")
            };

            using (var http = new HttpClient())
            {
                string json = JsonConvert.SerializeObject(factura);
                var content = new StringContent(json, Encoding.UTF8, "application/json");
                var resp = http.PostAsync(url, content).GetAwaiter().GetResult();
                return resp.IsSuccessStatusCode;
            }
        }

      
       
       
        private async Task<dynamic> VerificarSegip(string ci)
        {
            var client = new GraphQLHttpClient(SEGIP_GRAPHQL, new NewtonsoftJsonSerializer());

            var request = new GraphQLHttpRequest
            {
                Query = @"
                  query($ci: String!) {
                    persona(ci: $ci) {
                      CI
                      nombres
                      primerApellido
                      segundoApellido
                      deudas {
                        id
                        concepto
                        monto
                      }
                    }
                  }",
                Variables = new { ci = ci }
            };

            var response = await client.SendQueryAsync<dynamic>(request);
            var persona = response.Data.persona;
            if (persona == null) return null;

            // Mapeamos el array dinámico a List<Deuda>
            var lista = new System.Collections.Generic.List<Deuda>();
            foreach (var d in persona.deudas)
            {
                lista.Add(new Deuda
                {
                    Id = (int)d.id,
                    Concepto = (string)d.concepto,
                    Monto = (decimal)d.monto
                });
            }

            
            return new
            {
                CI = (string)persona.CI,
                nombres = (string)persona.nombres,
                primerApellido = (string)persona.primerApellido,
                segundoApellido = (string)persona.segundoApellido,
                deudas = lista
            };
        }
    }
}

