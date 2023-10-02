namespace RegresionLineal
{
    partial class Principal
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
            btnPuntoAlto = new Button();
            btnRegresion = new Button();
            label1 = new Label();
            btnSalir = new Button();
            SuspendLayout();
            // 
            // btnPuntoAlto
            // 
            btnPuntoAlto.Location = new Point(44, 198);
            btnPuntoAlto.Name = "btnPuntoAlto";
            btnPuntoAlto.Size = new Size(279, 46);
            btnPuntoAlto.TabIndex = 0;
            btnPuntoAlto.Text = "Punto Alto Punto Bajo";
            btnPuntoAlto.UseVisualStyleBackColor = true;
            btnPuntoAlto.Click += btnPuntoAlto_Click;
            // 
            // btnRegresion
            // 
            btnRegresion.Location = new Point(424, 198);
            btnRegresion.Name = "btnRegresion";
            btnRegresion.Size = new Size(265, 46);
            btnRegresion.TabIndex = 1;
            btnRegresion.Text = "Regresion Lineal";
            btnRegresion.UseVisualStyleBackColor = true;
            btnRegresion.Click += btnRegresion_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(128, 65);
            label1.Name = "label1";
            label1.Size = new Size(492, 45);
            label1.TabIndex = 2;
            label1.Text = "ESCOJA ENTRE LAS OPCIONES";
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(539, 301);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(150, 46);
            btnSalir.TabIndex = 3;
            btnSalir.Text = "SALIR";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // Principal
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(738, 368);
            Controls.Add(btnSalir);
            Controls.Add(label1);
            Controls.Add(btnRegresion);
            Controls.Add(btnPuntoAlto);
            Name = "Principal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Principal";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnPuntoAlto;
        private Button btnRegresion;
        private Label label1;
        private Button btnSalir;
    }
}