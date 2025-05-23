using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.Windows.Forms;
using ClientePagos.PagosServiceRef;


namespace ClientePagos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            
            cmbEmpresas.Items.Add("CESSA");
            cmbEmpresas.Items.Add("ELAPAS");
            cmbEmpresas.SelectedIndex = 0;

            
            btnRegistrarPago.Enabled = false;
        }

        private async void btnObtenerDeudas_Click(object sender, EventArgs e)
        {
            lblResultado.Text = "";
            lstDeudas.Items.Clear();
            btnRegistrarPago.Enabled = false;

            string ci = txtCI.Text.Trim();
            string nombres = txtNombres.Text.Trim();
            string ape = txtApellido.Text.Trim();

            if (ci == "" || nombres == "" || ape == "")
            {
                lblResultado.Text = "CI, Nombres y Apellido son obligatorios.";
                return;
            }

            try
            {
                // Crear cliente SOAP
                var client = new PagosServiceSoapClient();
                // Llamar al método verDeuda
                var deudas = client.verDeuda(ci, ape, nombres);

                if (deudas == null)
                {
                    lblResultado.Text = "No se encontraron deudas o datos inválidos.";
                    return;
                }

                // Poblar ListBox
                foreach (var d in deudas)
                {
                    // Mostramos texto amigable, guardando el objeto
                    lstDeudas.Items.Add(new ListItem<Deuda>(d, $"{d.Id} - {d.Concepto} (${d.Monto})"));
                }

                lblResultado.Text = $"Se encontraron {deudas.Length} deuda(s).";
                btnRegistrarPago.Enabled = true;
            }
            catch (Exception ex)
            {
                lblResultado.Text = "Error al obtener deudas: " + ex.Message;
            }
        }

        private async void btnRegistrarPago_Click(object sender, EventArgs e)
        {
            lblResultado.Text = "";

            if (lstDeudas.SelectedItem == null)
            {
                lblResultado.Text = "Seleccione una deuda de la lista.";
                return;
            }

            // Extraer Deuda del item
            var selected = (ListItem<Deuda>)lstDeudas.SelectedItem;
            var deuda = selected.Value;

            string ci = txtCI.Text.Trim();
            string empresa = cmbEmpresas.SelectedItem.ToString();

            try
            {
                var client = new PagosServiceSoapClient();
                bool ok = client.registrarPago(deuda.Id, ci, empresa);

                if (ok)
                    lblResultado.Text = "Pago registrado correctamente en " + empresa + ".";
                else
                    lblResultado.Text = "Error al registrar pago.";
            }
            catch (Exception ex)
            {
                lblResultado.Text = "Error al registrar pago: " + ex.Message;
            }
        }

        // Clase auxiliar para asociar objeto con texto en ListBox
        private class ListItem<T>
        {
            public T Value { get; }
            private readonly string _display;
            public ListItem(T value, string display) { Value = value; _display = display; }
            public override string ToString() => _display;
        }
    }

}
