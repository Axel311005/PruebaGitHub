namespace RegresionLineal
{
    partial class PuntoAltoPuntoBajo
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
            lvDetalle = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            txtCostos = new TextBox();
            txtHoras = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnAgregar = new Button();
            btnCalcular = new Button();
            btnSalir = new Button();
            CT = new Label();
            label5 = new Label();
            label6 = new Label();
            txtCostosTotales = new TextBox();
            txtCostosFijos = new TextBox();
            txtCostosVariables = new TextBox();
            label4 = new Label();
            label7 = new Label();
            SuspendLayout();
            // 
            // lvDetalle
            // 
            lvDetalle.BackColor = Color.MistyRose;
            lvDetalle.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2 });
            lvDetalle.GridLines = true;
            lvDetalle.Location = new Point(14, 94);
            lvDetalle.Margin = new Padding(2, 1, 2, 1);
            lvDetalle.Name = "lvDetalle";
            lvDetalle.Size = new Size(441, 214);
            lvDetalle.TabIndex = 0;
            lvDetalle.UseCompatibleStateImageBehavior = false;
            lvDetalle.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Costos";
            columnHeader1.Width = 330;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Horas/Unidades";
            columnHeader2.Width = 330;
            // 
            // txtCostos
            // 
            txtCostos.Location = new Point(14, 58);
            txtCostos.Margin = new Padding(2, 1, 2, 1);
            txtCostos.Name = "txtCostos";
            txtCostos.Size = new Size(110, 23);
            txtCostos.TabIndex = 1;
            txtCostos.KeyPress += txtCostos_KeyPress;
            // 
            // txtHoras
            // 
            txtHoras.Location = new Point(162, 58);
            txtHoras.Margin = new Padding(2, 1, 2, 1);
            txtHoras.Name = "txtHoras";
            txtHoras.Size = new Size(110, 23);
            txtHoras.TabIndex = 2;
            txtHoras.KeyPress += txtHoras_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(66, 4);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(224, 21);
            label1.TabIndex = 3;
            label1.Text = "PUNTO ALTO PUNTO BAJO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(43, 34);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(50, 15);
            label2.TabIndex = 4;
            label2.Text = "COSTOS";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(177, 34);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(79, 15);
            label3.TabIndex = 5;
            label3.Text = "HORAS/UNID";
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(384, 57);
            btnAgregar.Margin = new Padding(2, 1, 2, 1);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(81, 22);
            btnAgregar.TabIndex = 6;
            btnAgregar.Text = "AGREGAR";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(299, 57);
            btnCalcular.Margin = new Padding(2, 1, 2, 1);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(81, 22);
            btnCalcular.TabIndex = 7;
            btnCalcular.Text = "CALCULAR";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(299, 347);
            btnSalir.Margin = new Padding(2, 1, 2, 1);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(81, 22);
            btnSalir.TabIndex = 8;
            btnSalir.Text = "SALIR";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // CT
            // 
            CT.AutoSize = true;
            CT.Location = new Point(37, 327);
            CT.Margin = new Padding(2, 0, 2, 0);
            CT.Name = "CT";
            CT.Size = new Size(21, 15);
            CT.TabIndex = 9;
            CT.Text = "CT";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(134, 327);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(27, 15);
            label5.TabIndex = 10;
            label5.Text = "CFT";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(239, 327);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(28, 15);
            label6.TabIndex = 11;
            label6.Text = "CVT";
            // 
            // txtCostosTotales
            // 
            txtCostosTotales.Enabled = false;
            txtCostosTotales.Location = new Point(14, 349);
            txtCostosTotales.Margin = new Padding(2, 1, 2, 1);
            txtCostosTotales.Name = "txtCostosTotales";
            txtCostosTotales.Size = new Size(76, 23);
            txtCostosTotales.TabIndex = 12;
            // 
            // txtCostosFijos
            // 
            txtCostosFijos.Enabled = false;
            txtCostosFijos.Location = new Point(117, 349);
            txtCostosFijos.Margin = new Padding(2, 1, 2, 1);
            txtCostosFijos.Name = "txtCostosFijos";
            txtCostosFijos.Size = new Size(72, 23);
            txtCostosFijos.TabIndex = 13;
            // 
            // txtCostosVariables
            // 
            txtCostosVariables.Enabled = false;
            txtCostosVariables.Location = new Point(220, 347);
            txtCostosVariables.Margin = new Padding(2, 1, 2, 1);
            txtCostosVariables.Name = "txtCostosVariables";
            txtCostosVariables.Size = new Size(68, 23);
            txtCostosVariables.TabIndex = 14;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(92, 349);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(15, 15);
            label4.TabIndex = 15;
            label4.Text = "=";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(195, 351);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(15, 15);
            label7.TabIndex = 16;
            label7.Text = "+";
            // 
            // PuntoAltoPuntoBajo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(466, 400);
            Controls.Add(label7);
            Controls.Add(label4);
            Controls.Add(txtCostosVariables);
            Controls.Add(txtCostosFijos);
            Controls.Add(txtCostosTotales);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(CT);
            Controls.Add(btnSalir);
            Controls.Add(btnCalcular);
            Controls.Add(btnAgregar);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtHoras);
            Controls.Add(txtCostos);
            Controls.Add(lvDetalle);
            Margin = new Padding(2, 1, 2, 1);
            Name = "PuntoAltoPuntoBajo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PuntoAltoPuntoBajo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView lvDetalle;
        private TextBox txtCostos;
        private TextBox txtHoras;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnAgregar;
        private Button btnCalcular;
        private Button btnSalir;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private Label CT;
        private Label label5;
        private Label label6;
        private TextBox txtCostosTotales;
        private TextBox txtCostosFijos;
        private TextBox txtCostosVariables;
        private Label label4;
        private Label label7;
    }
}