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
            btnExportar = new Button();
            pictureBox1 = new PictureBox();
            lvDetalle = new ListView();
            colCosto = new ColumnHeader();
            colCantidad = new ColumnHeader();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(6, 83);
            txtCantidad.Margin = new Padding(2, 1, 2, 1);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(83, 23);
            txtCantidad.TabIndex = 1;
            txtCantidad.KeyPress += txtCantidad_KeyPress;
            // 
            // txtCostos
            // 
            txtCostos.Location = new Point(107, 83);
            txtCostos.Margin = new Padding(2, 1, 2, 1);
            txtCostos.Name = "txtCostos";
            txtCostos.Size = new Size(86, 23);
            txtCostos.TabIndex = 2;
            txtCostos.KeyPress += txtCostos_KeyPress;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(387, 125);
            btnAgregar.Margin = new Padding(2, 1, 2, 1);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(81, 22);
            btnAgregar.TabIndex = 3;
            btnAgregar.Text = "AGREGAR";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(387, 159);
            btnCalcular.Margin = new Padding(2, 1, 2, 1);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(81, 22);
            btnCalcular.TabIndex = 4;
            btnCalcular.Text = "CALCULAR";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(131, 9);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(164, 21);
            label1.TabIndex = 5;
            label1.Text = "REGRESION LINEAL";
            // 
            // txtA
            // 
            txtA.Enabled = false;
            txtA.Location = new Point(32, 307);
            txtA.Margin = new Padding(2, 1, 2, 1);
            txtA.Name = "txtA";
            txtA.Size = new Size(110, 23);
            txtA.TabIndex = 6;
            // 
            // txtB
            // 
            txtB.Enabled = false;
            txtB.Location = new Point(185, 307);
            txtB.Margin = new Padding(2, 1, 2, 1);
            txtB.Name = "txtB";
            txtB.Size = new Size(110, 23);
            txtB.TabIndex = 7;
            // 
            // txtY
            // 
            txtY.Enabled = false;
            txtY.Location = new Point(107, 361);
            txtY.Margin = new Padding(2, 1, 2, 1);
            txtY.Name = "txtY";
            txtY.Size = new Size(110, 23);
            txtY.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 285);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(73, 15);
            label2.TabIndex = 9;
            label2.Text = "El valor de a:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(199, 285);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(74, 15);
            label3.TabIndex = 10;
            label3.Text = "El valor de b:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(12, 51);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(65, 15);
            label4.TabIndex = 11;
            label4.Text = "CANTIDAD";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(120, 51);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(50, 15);
            label5.TabIndex = 12;
            label5.Text = "COSTOS";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(126, 338);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(70, 15);
            label6.TabIndex = 13;
            label6.Text = "El valor de y";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(327, 87);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(48, 15);
            label7.TabIndex = 14;
            label7.Text = "y=a+bx";
            // 
            // txtQ
            // 
            txtQ.Location = new Point(210, 83);
            txtQ.Margin = new Padding(2, 1, 2, 1);
            txtQ.Name = "txtQ";
            txtQ.Size = new Size(78, 23);
            txtQ.TabIndex = 15;
            txtQ.KeyPress += txtQ_KeyPress;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = SystemColors.ButtonHighlight;
            label8.Location = new Point(213, 51);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(61, 15);
            label8.TabIndex = 16;
            label8.Text = "Valor de Q";
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(369, 358);
            btnSalir.Margin = new Padding(2, 1, 2, 1);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(81, 22);
            btnSalir.TabIndex = 17;
            btnSalir.Text = "SALIR";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnExportar
            // 
            btnExportar.Location = new Point(387, 197);
            btnExportar.Name = "btnExportar";
            btnExportar.Size = new Size(75, 23);
            btnExportar.TabIndex = 19;
            btnExportar.Text = "EXPORTAR";
            btnExportar.UseVisualStyleBackColor = true;
            btnExportar.Click += btnExportar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.sigma__1_;
            pictureBox1.Location = new Point(87, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(39, 31);
            pictureBox1.TabIndex = 20;
            pictureBox1.TabStop = false;
            // 
            // lvDetalle
            // 
            lvDetalle.Columns.AddRange(new ColumnHeader[] { colCosto, colCantidad });
            lvDetalle.GridLines = true;
            lvDetalle.Location = new Point(15, 135);
            lvDetalle.Name = "lvDetalle";
            lvDetalle.Size = new Size(354, 132);
            lvDetalle.TabIndex = 21;
            lvDetalle.UseCompatibleStateImageBehavior = false;
            lvDetalle.View = View.Details;
            // 
            // colCosto
            // 
            colCosto.Text = "Costo";
            colCosto.Width = 180;
            // 
            // colCantidad
            // 
            colCantidad.Text = "Cantidad";
            colCantidad.TextAlign = HorizontalAlignment.Center;
            colCantidad.Width = 170;
            // 
            // RegresionLineal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SkyBlue;
            ClientSize = new Size(479, 414);
            Controls.Add(lvDetalle);
            Controls.Add(pictureBox1);
            Controls.Add(btnExportar);
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
            Margin = new Padding(2, 1, 2, 1);
            Name = "RegresionLineal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RegresionLineal";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
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
        private TextBox txtQ;
        private Label label8;
        private Button btnSalir;
        private Button btnExportar;
        private PictureBox pictureBox1;
        private ListView lvDetalle;
        private ColumnHeader colCosto;
        private ColumnHeader colCantidad;
    }
}