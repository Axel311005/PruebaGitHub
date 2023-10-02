namespace RegresionLineal
{
    partial class RegresionLineal
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
            txtCantidad = new TextBox();
            txtCostos = new TextBox();
            btnAgregar = new Button();
            btnCalcular = new Button();
            label1 = new Label();
            txtA = new TextBox();
            txtB = new TextBox();
            txtY = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtQ = new TextBox();
            label8 = new Label();
            btnSalir = new Button();
            SuspendLayout();
            // 
            // lvDetalle
            // 
            lvDetalle.BackColor = SystemColors.InactiveCaption;
            lvDetalle.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2 });
            lvDetalle.GridLines = true;
            lvDetalle.Location = new Point(12, 250);
            lvDetalle.Name = "lvDetalle";
            lvDetalle.Size = new Size(668, 341);
            lvDetalle.TabIndex = 0;
            lvDetalle.UseCompatibleStateImageBehavior = false;
            lvDetalle.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Cantidad";
            columnHeader1.Width = 330;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Costos";
            columnHeader2.Width = 330;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(12, 178);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(151, 39);
            txtCantidad.TabIndex = 1;
            txtCantidad.KeyPress += txtCantidad_KeyPress;
            // 
            // txtCostos
            // 
            txtCostos.Location = new Point(198, 178);
            txtCostos.Name = "txtCostos";
            txtCostos.Size = new Size(157, 39);
            txtCostos.TabIndex = 2;
            txtCostos.KeyPress += txtCostos_KeyPress;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(718, 266);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(150, 46);
            btnAgregar.TabIndex = 3;
            btnAgregar.Text = "AGREGAR";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(718, 339);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(150, 46);
            btnCalcular.TabIndex = 4;
            btnCalcular.Text = "CALCULAR";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(208, 20);
            label1.Name = "label1";
            label1.Size = new Size(324, 45);
            label1.TabIndex = 5;
            label1.Text = "REGRESION LINEAL";
            // 
            // txtA
            // 
            txtA.Enabled = false;
            txtA.Location = new Point(59, 655);
            txtA.Name = "txtA";
            txtA.Size = new Size(200, 39);
            txtA.TabIndex = 6;
            // 
            // txtB
            // 
            txtB.Enabled = false;
            txtB.Location = new Point(343, 655);
            txtB.Name = "txtB";
            txtB.Size = new Size(200, 39);
            txtB.TabIndex = 7;
            // 
            // txtY
            // 
            txtY.Enabled = false;
            txtY.Location = new Point(198, 771);
            txtY.Name = "txtY";
            txtY.Size = new Size(200, 39);
            txtY.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(69, 607);
            label2.Name = "label2";
            label2.Size = new Size(149, 32);
            label2.TabIndex = 9;
            label2.Text = "El valor de a:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(370, 607);
            label3.Name = "label3";
            label3.Size = new Size(151, 32);
            label3.TabIndex = 10;
            label3.Text = "El valor de b:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(22, 108);
            label4.Name = "label4";
            label4.Size = new Size(129, 32);
            label4.TabIndex = 11;
            label4.Text = "CANTIDAD";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(223, 108);
            label5.Name = "label5";
            label5.Size = new Size(102, 32);
            label5.TabIndex = 12;
            label5.Text = "COSTOS";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(234, 721);
            label6.Name = "label6";
            label6.Size = new Size(144, 32);
            label6.TabIndex = 13;
            label6.Text = "El valor de y";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(608, 185);
            label7.Name = "label7";
            label7.Size = new Size(95, 32);
            label7.TabIndex = 14;
            label7.Text = "y=a+bx";
            // 
            // txtQ
            // 
            txtQ.Location = new Point(390, 178);
            txtQ.Name = "txtQ";
            txtQ.Size = new Size(142, 39);
            txtQ.TabIndex = 15;
            txtQ.KeyPress += txtQ_KeyPress;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = SystemColors.ButtonHighlight;
            label8.Location = new Point(395, 108);
            label8.Name = "label8";
            label8.Size = new Size(126, 32);
            label8.TabIndex = 16;
            label8.Text = "Valor de Q";
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(685, 764);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(150, 46);
            btnSalir.TabIndex = 17;
            btnSalir.Text = "SALIR";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // RegresionLineal
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SkyBlue;
            ClientSize = new Size(889, 849);
            Controls.Add(btnSalir);
            Controls.Add(label8);
            Controls.Add(txtQ);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtY);
            Controls.Add(txtB);
            Controls.Add(txtA);
            Controls.Add(label1);
            Controls.Add(btnCalcular);
            Controls.Add(btnAgregar);
            Controls.Add(txtCostos);
            Controls.Add(txtCantidad);
            Controls.Add(lvDetalle);
            Name = "RegresionLineal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RegresionLineal";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView lvDetalle;
        private TextBox txtCantidad;
        private TextBox txtCostos;
        private Button btnAgregar;
        private Button btnCalcular;
        private Label label1;
        private TextBox txtA;
        private TextBox txtB;
        private TextBox txtY;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private TextBox txtQ;
        private Label label8;
        private Button btnSalir;
    }
}