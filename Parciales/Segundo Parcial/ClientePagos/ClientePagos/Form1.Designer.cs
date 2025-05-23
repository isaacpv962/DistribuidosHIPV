namespace ClientePagos
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblCI = new System.Windows.Forms.Label();
            this.lblNombres = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtCI = new System.Windows.Forms.TextBox();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.btnObtenerDeudas = new System.Windows.Forms.Button();
            this.btnRegistrarPago = new System.Windows.Forms.Button();
            this.lstDeudas = new System.Windows.Forms.ListBox();
            this.lblEmpresa = new System.Windows.Forms.Label();
            this.cmbEmpresas = new System.Windows.Forms.ComboBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCI
            // 
            this.lblCI.AutoSize = true;
            this.lblCI.Location = new System.Drawing.Point(116, 69);
            this.lblCI.Name = "lblCI";
            this.lblCI.Size = new System.Drawing.Size(19, 16);
            this.lblCI.TabIndex = 0;
            this.lblCI.Text = "CI";
            // 
            // lblNombres
            // 
            this.lblNombres.AutoSize = true;
            this.lblNombres.Location = new System.Drawing.Point(116, 112);
            this.lblNombres.Name = "lblNombres";
            this.lblNombres.Size = new System.Drawing.Size(56, 16);
            this.lblNombres.TabIndex = 1;
            this.lblNombres.Text = "Nombre";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(116, 155);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(99, 16);
            this.lblApellido.TabIndex = 2;
            this.lblApellido.Text = "Primer Apellido";
            // 
            // txtCI
            // 
            this.txtCI.Location = new System.Drawing.Point(222, 62);
            this.txtCI.Name = "txtCI";
            this.txtCI.Size = new System.Drawing.Size(100, 22);
            this.txtCI.TabIndex = 3;
            // 
            // txtNombres
            // 
            this.txtNombres.Location = new System.Drawing.Point(222, 112);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(100, 22);
            this.txtNombres.TabIndex = 4;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(222, 155);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(100, 22);
            this.txtApellido.TabIndex = 5;
            // 
            // btnObtenerDeudas
            // 
            this.btnObtenerDeudas.Location = new System.Drawing.Point(119, 260);
            this.btnObtenerDeudas.Name = "btnObtenerDeudas";
            this.btnObtenerDeudas.Size = new System.Drawing.Size(183, 23);
            this.btnObtenerDeudas.TabIndex = 6;
            this.btnObtenerDeudas.Text = "Obtener Detalle Deudas";
            this.btnObtenerDeudas.UseVisualStyleBackColor = true;
            this.btnObtenerDeudas.Click += new System.EventHandler(this.btnObtenerDeudas_Click);
            // 
            // btnRegistrarPago
            // 
            this.btnRegistrarPago.Location = new System.Drawing.Point(426, 260);
            this.btnRegistrarPago.Name = "btnRegistrarPago";
            this.btnRegistrarPago.Size = new System.Drawing.Size(145, 23);
            this.btnRegistrarPago.TabIndex = 7;
            this.btnRegistrarPago.Text = "Registrar Pago";
            this.btnRegistrarPago.UseVisualStyleBackColor = true;
            // 
            // lstDeudas
            // 
            this.lstDeudas.FormattingEnabled = true;
            this.lstDeudas.ItemHeight = 16;
            this.lstDeudas.Location = new System.Drawing.Point(451, 62);
            this.lstDeudas.Name = "lstDeudas";
            this.lstDeudas.Size = new System.Drawing.Size(120, 84);
            this.lstDeudas.TabIndex = 8;
            // 
            // lblEmpresa
            // 
            this.lblEmpresa.AutoSize = true;
            this.lblEmpresa.Location = new System.Drawing.Point(390, 158);
            this.lblEmpresa.Name = "lblEmpresa";
            this.lblEmpresa.Size = new System.Drawing.Size(62, 16);
            this.lblEmpresa.TabIndex = 9;
            this.lblEmpresa.Text = "Empresa";
            // 
            // cmbEmpresas
            // 
            this.cmbEmpresas.FormattingEnabled = true;
            this.cmbEmpresas.Location = new System.Drawing.Point(450, 155);
            this.cmbEmpresas.Name = "cmbEmpresas";
            this.cmbEmpresas.Size = new System.Drawing.Size(121, 24);
            this.cmbEmpresas.TabIndex = 10;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(328, 327);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(69, 16);
            this.lblResultado.TabIndex = 11;
            this.lblResultado.Text = "Resultado";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.cmbEmpresas);
            this.Controls.Add(this.lblEmpresa);
            this.Controls.Add(this.lstDeudas);
            this.Controls.Add(this.btnRegistrarPago);
            this.Controls.Add(this.btnObtenerDeudas);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombres);
            this.Controls.Add(this.txtCI);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblNombres);
            this.Controls.Add(this.lblCI);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCI;
        private System.Windows.Forms.Label lblNombres;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txtCI;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Button btnObtenerDeudas;
        private System.Windows.Forms.Button btnRegistrarPago;
        private System.Windows.Forms.ListBox lstDeudas;
        private System.Windows.Forms.Label lblEmpresa;
        private System.Windows.Forms.ComboBox cmbEmpresas;
        private System.Windows.Forms.Label lblResultado;
    }
}

