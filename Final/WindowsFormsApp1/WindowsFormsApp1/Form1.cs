using System;
using System.Windows.Forms;
using SeduInfoClient;
using WindowsFormsApp1.SeduinfoServiceRef;

namespace SeduInfoClient
{
    public partial class Form1 : Form
    {
        
        private WebService1SoapClient svc;

    
       
   

        public Form1()
        {
            InitializeComponent();
            
            svc = new WebService1SoapClient();
        }

      

        private void btnTutor2_Click_1(object sender, EventArgs e)
        {
            string ci = txtCI2.Text.Trim();
            if (string.IsNullOrEmpty(ci))
            {
                MessageBox.Show("Por favor ingresa un CI.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var est = svc.ObtenerDatosTutor(ci);
                txtResultado2.Text =
                    $"CI: {est.CI}\r\n" +
                    $"Estudiante: {est.Nombres}\r\n" +
                    $"Tutor: {est.TutorAsignado}\r\n" +
                    $"Correo Tutor: {est.CorreoTutor}\r\n" +
                    $"Teléfono Tutor: {est.TelefonoTutor}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al llamar al servicio:\r\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAcademico2_Click_1(object sender, EventArgs e)
        {
            string ci = txtCI2.Text.Trim();
            if (string.IsNullOrEmpty(ci))
            {
                MessageBox.Show("Por favor ingresa un CI.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var est = svc.ObtenerDatosAcademicos(ci);
                txtResultado2.Text =
                    $"CI: {est.CI}\r\n" +
                    $"Nombres: {est.Nombres}\r\n" +
                    $"Apellidos: {est.Apellidos}\r\n" +
                    $"Carrera: {est.Carrera}\r\n" +
                    $"Semestre: {est.Semestre}\r\n" +
                    $"Promedio: {est.Promedio}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al llamar al servicio:\r\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

