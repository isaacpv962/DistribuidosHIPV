namespace SeduInfoClient
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtCI2 = new System.Windows.Forms.TextBox();
            this.txtResultado2 = new System.Windows.Forms.RichTextBox();
            this.btnAcademico2 = new System.Windows.Forms.Button();
            this.btnTutor2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(106, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "CI:";
            // 
            // txtCI2
            // 
            this.txtCI2.Location = new System.Drawing.Point(134, 55);
            this.txtCI2.Name = "txtCI2";
            this.txtCI2.Size = new System.Drawing.Size(100, 22);
            this.txtCI2.TabIndex = 1;
            // 
            // txtResultado2
            // 
            this.txtResultado2.Location = new System.Drawing.Point(390, 52);
            this.txtResultado2.Name = "txtResultado2";
            this.txtResultado2.Size = new System.Drawing.Size(100, 96);
            this.txtResultado2.TabIndex = 2;
            this.txtResultado2.Text = "";
            // 
            // btnAcademico2
            // 
            this.btnAcademico2.Location = new System.Drawing.Point(134, 220);
            this.btnAcademico2.Name = "btnAcademico2";
            this.btnAcademico2.Size = new System.Drawing.Size(100, 23);
            this.btnAcademico2.TabIndex = 3;
            this.btnAcademico2.Text = "Académico";
            this.btnAcademico2.UseVisualStyleBackColor = true;
            this.btnAcademico2.Click += new System.EventHandler(this.btnAcademico2_Click_1);
            // 
            // btnTutor2
            // 
            this.btnTutor2.Location = new System.Drawing.Point(303, 220);
            this.btnTutor2.Name = "btnTutor2";
            this.btnTutor2.Size = new System.Drawing.Size(75, 23);
            this.btnTutor2.TabIndex = 4;
            this.btnTutor2.Text = "Tutor";
            this.btnTutor2.UseVisualStyleBackColor = true;
            this.btnTutor2.Click += new System.EventHandler(this.btnTutor2_Click_1);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(669, 348);
            this.Controls.Add(this.btnTutor2);
            this.Controls.Add(this.btnAcademico2);
            this.Controls.Add(this.txtResultado2);
            this.Controls.Add(this.txtCI2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCI;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCI2;
        private System.Windows.Forms.RichTextBox txtResultado2;
        private System.Windows.Forms.Button btnAcademico2;
        private System.Windows.Forms.Button btnTutor2;
    }
}

