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
            lvDetalle.Location = new Point(26, 201);
            lvDetalle.Margin = new Padding(4, 2, 4, 2);
            lvDetalle.Name = "lvDetalle";
            lvDetalle.Size = new Size(669, 452);
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
            txtCostos.Location = new Point(26, 124);
            txtCostos.Margin = new Padding(4, 2, 4, 2);
            txtCostos.Name = "txtCostos";
            txtCostos.Size = new Size(201, 39);
            txtCostos.TabIndex = 1;
            txtCostos.KeyPress += txtCostos_KeyPress;
            // 
            // txtHoras
            // 
            txtHoras.Location = new Point(301, 124);
            txtHoras.Margin = new Padding(4, 2, 4, 2);
            txtHoras.Name = "txtHoras";
            txtHoras.Size = new Size(201, 39);
            txtHoras.TabIndex = 2;
            txtHoras.KeyPress += txtHoras_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(123, 9);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(445, 45);
            label1.TabIndex = 3;
            label1.Text = "PUNTO ALTO PUNTO BAJO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(80, 73);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(102, 32);
            label2.TabIndex = 4;
            label2.Text = "COSTOS";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(329, 73);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(157, 32);
            label3.TabIndex = 5;
            label3.Text = "HORAS/UNID";
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(555, 73);
            btnAgregar.Margin = new Padding(4, 2, 4, 2);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(150, 47);
            btnAgregar.TabIndex = 6;
            btnAgregar.Text = "AGREGAR";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(555, 137);
            btnCalcular.Margin = new Padding(4, 2, 4, 2);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(150, 47);
            btnCalcular.TabIndex = 7;
            btnCalcular.Text = "CALCULAR";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(569, 683);
            btnSalir.Margin = new Padding(4, 2, 4, 2);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(150, 47);
            btnSalir.TabIndex = 8;
            btnSalir.Text = "SALIR";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // CT
            // 
            CT.AutoSize = true;
            CT.Location = new Point(69, 698);
            CT.Margin = new Padding(4, 0, 4, 0);
            CT.Name = "CT";
            CT.Size = new Size(42, 32);
            CT.TabIndex = 9;
            CT.Text = "CT";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(249, 698);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(54, 32);
            label5.TabIndex = 10;
            label5.Text = "CFT";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(444, 698);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(57, 32);
            label6.TabIndex = 11;
            label6.Text = "CVT";
            // 
            // txtCostosTotales
            // 
            txtCostosTotales.Enabled = false;
            txtCostosTotales.Location = new Point(26, 745);
            txtCostosTotales.Margin = new Padding(4, 2, 4, 2);
            txtCostosTotales.Name = "txtCostosTotales";
            txtCostosTotales.Size = new Size(138, 39);
            txtCostosTotales.TabIndex = 12;
            // 
            // txtCostosFijos
            // 
            txtCostosFijos.Enabled = false;
            txtCostosFijos.Location = new Point(217, 745);
            txtCostosFijos.Margin = new Padding(4, 2, 4, 2);
            txtCostosFijos.Name = "txtCostosFijos";
            txtCostosFijos.Size = new Size(130, 39);
            txtCostosFijos.TabIndex = 13;
            // 
            // txtCostosVariables
            // 
            txtCostosVariables.Enabled = false;
            txtCostosVariables.Location = new Point(409, 740);
            txtCostosVariables.Margin = new Padding(4, 2, 4, 2);
            txtCostosVariables.Name = "txtCostosVariables";
            txtCostosVariables.Size = new Size(123, 39);
            txtCostosVariables.TabIndex = 14;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(171, 745);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(30, 32);
            label4.TabIndex = 15;
            label4.Text = "=";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(362, 749);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(30, 32);
            label7.TabIndex = 16;
            label7.Text = "+";
            // 
            // PuntoAltoPuntoBajo
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(750, 853);
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
            Margin = new Padding(4, 2, 4, 2);
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