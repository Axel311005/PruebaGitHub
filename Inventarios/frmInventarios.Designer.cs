namespace Inventarios
{
    partial class frmInventarios
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
            label8 = new Label();
            cboInventario = new ComboBox();
            lvFecha = new ListView();
            columnHeader1 = new ColumnHeader();
            label7 = new Label();
            label6 = new Label();
            lvSaldos = new ListView();
            columnHeader8 = new ColumnHeader();
            columnHeader9 = new ColumnHeader();
            columnHeader10 = new ColumnHeader();
            lvSalidas = new ListView();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            btnAgregar = new Button();
            btnSalir = new Button();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            txtValorUnit = new TextBox();
            txtCantidad = new TextBox();
            cboMovimiento = new ComboBox();
            label1 = new Label();
            lvEntradas = new ListView();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            btnExportar = new Button();
            SuspendLayout();
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(24, 47);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(102, 15);
            label8.TabIndex = 38;
            label8.Text = "Tipo de Inventario";
            // 
            // cboInventario
            // 
            cboInventario.FormattingEnabled = true;
            cboInventario.Location = new Point(11, 75);
            cboInventario.Margin = new Padding(2, 1, 2, 1);
            cboInventario.Name = "cboInventario";
            cboInventario.Size = new Size(132, 23);
            cboInventario.TabIndex = 37;
            cboInventario.Text = "Seleccione";
            // 
            // lvFecha
            // 
            lvFecha.Columns.AddRange(new ColumnHeader[] { columnHeader1 });
            lvFecha.GridLines = true;
            lvFecha.Location = new Point(28, 152);
            lvFecha.Margin = new Padding(2, 1, 2, 1);
            lvFecha.Name = "lvFecha";
            lvFecha.Size = new Size(115, 215);
            lvFecha.TabIndex = 36;
            lvFecha.UseCompatibleStateImageBehavior = false;
            lvFecha.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Fecha";
            columnHeader1.Width = 110;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(1362, 128);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(50, 15);
            label7.TabIndex = 35;
            label7.Text = "SALDOS";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(807, 128);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(52, 15);
            label6.TabIndex = 34;
            label6.Text = "SALIDAS";
            // 
            // lvSaldos
            // 
            lvSaldos.Columns.AddRange(new ColumnHeader[] { columnHeader8, columnHeader9, columnHeader10 });
            lvSaldos.GridLines = true;
            lvSaldos.Location = new Point(1106, 152);
            lvSaldos.Margin = new Padding(2, 1, 2, 1);
            lvSaldos.Name = "lvSaldos";
            lvSaldos.Size = new Size(496, 215);
            lvSaldos.TabIndex = 33;
            lvSaldos.UseCompatibleStateImageBehavior = false;
            lvSaldos.View = View.Details;
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "Cantidad";
            columnHeader8.Width = 160;
            // 
            // columnHeader9
            // 
            columnHeader9.Text = "Valor Unit";
            columnHeader9.Width = 160;
            // 
            // columnHeader10
            // 
            columnHeader10.Text = "Total";
            columnHeader10.Width = 170;
            // 
            // lvSalidas
            // 
            lvSalidas.Columns.AddRange(new ColumnHeader[] { columnHeader5, columnHeader6, columnHeader7 });
            lvSalidas.GridLines = true;
            lvSalidas.Location = new Point(613, 152);
            lvSalidas.Margin = new Padding(2, 1, 2, 1);
            lvSalidas.Name = "lvSalidas";
            lvSalidas.Size = new Size(425, 215);
            lvSalidas.TabIndex = 32;
            lvSalidas.UseCompatibleStateImageBehavior = false;
            lvSalidas.View = View.Details;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Cantidad";
            columnHeader5.Width = 160;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Valor Unit";
            columnHeader6.Width = 160;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Total";
            columnHeader7.Width = 170;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(623, 73);
            btnAgregar.Margin = new Padding(2, 1, 2, 1);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(81, 22);
            btnAgregar.TabIndex = 31;
            btnAgregar.Text = "AGREGAR";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(807, 378);
            btnSalir.Margin = new Padding(2, 1, 2, 1);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(81, 22);
            btnSalir.TabIndex = 30;
            btnSalir.Text = "SALIR";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(360, 128);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(65, 15);
            label5.TabIndex = 29;
            label5.Text = "ENTRADAS";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(488, 47);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(78, 15);
            label4.TabIndex = 28;
            label4.Text = "Valor Unitario";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(370, 47);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(55, 15);
            label3.TabIndex = 27;
            label3.Text = "Cantidad";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(211, 47);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(72, 15);
            label2.TabIndex = 26;
            label2.Text = "Movimiento";
            // 
            // txtValorUnit
            // 
            txtValorUnit.AllowDrop = true;
            txtValorUnit.Location = new Point(488, 75);
            txtValorUnit.Margin = new Padding(2, 1, 2, 1);
            txtValorUnit.Name = "txtValorUnit";
            txtValorUnit.Size = new Size(92, 23);
            txtValorUnit.TabIndex = 25;
            txtValorUnit.KeyPress += txtValorUnit_KeyPress;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(352, 75);
            txtCantidad.Margin = new Padding(2, 1, 2, 1);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(94, 23);
            txtCantidad.TabIndex = 24;
            txtCantidad.KeyPress += txtCantidad_KeyPress;
            // 
            // cboMovimiento
            // 
            cboMovimiento.FormattingEnabled = true;
            cboMovimiento.Location = new Point(181, 74);
            cboMovimiento.Margin = new Padding(2, 1, 2, 1);
            cboMovimiento.Name = "cboMovimiento";
            cboMovimiento.Size = new Size(132, 23);
            cboMovimiento.TabIndex = 23;
            cboMovimiento.Text = "Escoja";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(342, 10);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(188, 19);
            label1.TabIndex = 22;
            label1.Text = "METODOS DE INVENTARIO";
            // 
            // lvEntradas
            // 
            lvEntradas.Columns.AddRange(new ColumnHeader[] { columnHeader2, columnHeader3, columnHeader4 });
            lvEntradas.GridLines = true;
            lvEntradas.Location = new Point(181, 152);
            lvEntradas.Margin = new Padding(2, 1, 2, 1);
            lvEntradas.Name = "lvEntradas";
            lvEntradas.Size = new Size(410, 215);
            lvEntradas.TabIndex = 21;
            lvEntradas.UseCompatibleStateImageBehavior = false;
            lvEntradas.View = View.Details;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Cantidad";
            columnHeader2.Width = 160;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Valor Unit";
            columnHeader3.Width = 160;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Total";
            columnHeader4.Width = 170;
            // 
            // btnExportar
            // 
            btnExportar.Location = new Point(943, 377);
            btnExportar.Name = "btnExportar";
            btnExportar.Size = new Size(95, 24);
            btnExportar.TabIndex = 39;
            btnExportar.Text = "EXPORTAR";
            btnExportar.UseVisualStyleBackColor = true;
            btnExportar.Click += btnExportar_Click;
            // 
            // frmInventarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1613, 401);
            Controls.Add(btnExportar);
            Controls.Add(label8);
            Controls.Add(cboInventario);
            Controls.Add(lvFecha);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(lvSaldos);
            Controls.Add(lvSalidas);
            Controls.Add(btnAgregar);
            Controls.Add(btnSalir);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtValorUnit);
            Controls.Add(txtCantidad);
            Controls.Add(cboMovimiento);
            Controls.Add(label1);
            Controls.Add(lvEntradas);
            Margin = new Padding(2, 1, 2, 1);
            Name = "frmInventarios";
            Text = "frmInventarios";
            Load += frmInventarios_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label8;
        private ComboBox cboInventario;
        private ListView lvFecha;
        private ColumnHeader columnHeader1;
        private Label label7;
        private Label label6;
        private ListView lvSaldos;
        private ColumnHeader columnHeader8;
        private ColumnHeader columnHeader9;
        private ColumnHeader columnHeader10;
        private ListView lvSalidas;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private Button btnAgregar;
        private Button btnSalir;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txtValorUnit;
        private TextBox txtCantidad;
        private ComboBox cboMovimiento;
        private Label label1;
        private ListView lvEntradas;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private Button btnExportar;
    }
}