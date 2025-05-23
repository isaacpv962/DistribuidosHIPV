using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServidorPagos
{
    public class Deuda
    {
        public int Id { get; set; }
        public string Concepto { get; set; }
        public decimal Monto { get; set; }

        public Deuda(int id, string concepto)
        {
            Id = id;
            Concepto = concepto;
            Monto = 0;
        }

        public Deuda() { }
    
    }

}
