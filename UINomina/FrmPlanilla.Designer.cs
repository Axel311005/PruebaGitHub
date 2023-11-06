namespace UINomina
{
    partial class FrmPlanilla
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPlanilla));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            btnSeleccionEmp = new Button();
            btnRegresar = new Button();
            btnBuscar = new Button();
            lvEmpleados = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            columnHeader9 = new ColumnHeader();
            columnHeader10 = new ColumnHeader();
            columnHeader11 = new ColumnHeader();
            columnHeader12 = new ColumnHeader();
            columnHeader13 = new ColumnHeader();
            columnHeader14 = new ColumnHeader();
            columnHeader15 = new ColumnHeader();
            columnHeader16 = new ColumnHeader();
            columnHeader17 = new ColumnHeader();
            columnHeader18 = new ColumnHeader();
            label1 = new Label();
            txtBusqueda = new TextBox();
            tabPage2 = new TabPage();
            btnLimpiar = new Button();
            btnCalcular = new Button();
            btnExportar = new Button();
            dtpFechaFin = new DateTimePicker();
            label13 = new Label();
            DGVNomina = new DataGridView();
            Fecha = new DataGridViewTextBoxColumn();
            FechaFin = new DataGridViewTextBoxColumn();
            SalarioBase = new DataGridViewTextBoxColumn();
            SalarioQuincenal = new DataGridViewTextBoxColumn();
            SalarioDia = new DataGridViewTextBoxColumn();
            SalarioHora = new DataGridViewTextBoxColumn();
            SalarioNeto = new DataGridViewTextBoxColumn();
            HorasExtras = new DataGridViewTextBoxColumn();
            Comisiones = new DataGridViewTextBoxColumn();
            ViaticoA = new DataGridViewTextBoxColumn();
            ViaticoT = new DataGridViewTextBoxColumn();
            DeprecV = new DataGridViewTextBoxColumn();
            RiesgoLaboral = new DataGridViewTextBoxColumn();
            Nocturnidad = new DataGridViewTextBoxColumn();
            IngresoVacaciones = new DataGridViewTextBoxColumn();
            Aguinaldo = new DataGridViewTextBoxColumn();
            Indemizacion = new DataGridViewTextBoxColumn();
            ImpuestoRenta = new DataGridViewTextBoxColumn();
            INSS = new DataGridViewTextBoxColumn();
            Prestamos = new DataGridViewTextBoxColumn();
            Embargos = new DataGridViewTextBoxColumn();
            INATEC = new DataGridViewTextBoxColumn();
            INSSPatronal = new DataGridViewTextBoxColumn();
            IDEmpleado = new DataGridViewTextBoxColumn();
            txtDeprecVehiculo = new TextBox();
            label12 = new Label();
            txtEmbargos = new TextBox();
            label11 = new Label();
            txtPrestamos = new TextBox();
            label10 = new Label();
            txtViaticoTransporte = new TextBox();
            label9 = new Label();
            txtViaticoAlimentacion = new TextBox();
            label8 = new Label();
            panelComisiones = new Panel();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            cmbMetaVenta = new ComboBox();
            txtPorcentaje = new TextBox();
            txtVenta = new TextBox();
            label4 = new Label();
            panelHorasExtras = new Panel();
            txtHora = new TextBox();
            label3 = new Label();
            dtpFecha = new DateTimePicker();
            label2 = new Label();
            panel1 = new Panel();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGVNomina).BeginInit();
            panelComisiones.SuspendLayout();
            panelHorasExtras.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tabControl1.Location = new Point(2, 47);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1113, 632);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(btnSeleccionEmp);
            tabPage1.Controls.Add(btnRegresar);
            tabPage1.Controls.Add(btnBuscar);
            tabPage1.Controls.Add(lvEmpleados);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(txtBusqueda);
            tabPage1.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            tabPage1.ForeColor = Color.Black;
            tabPage1.Location = new Point(4, 26);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1105, 602);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Empleado";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnSeleccionEmp
            // 
            btnSeleccionEmp.FlatAppearance.BorderSize = 0;
            btnSeleccionEmp.FlatAppearance.MouseDownBackColor = Color.FromArgb(96, 60, 220);
            btnSeleccionEmp.FlatAppearance.MouseOverBackColor = Color.FromArgb(96, 60, 220);
            btnSeleccionEmp.FlatStyle = FlatStyle.Flat;
            btnSeleccionEmp.Image = Properties.Resources.editar__1___1_;
            btnSeleccionEmp.Location = new Point(1023, 137);
            btnSeleccionEmp.Name = "btnSeleccionEmp";
            btnSeleccionEmp.Size = new Size(63, 46);
            btnSeleccionEmp.TabIndex = 57;
            btnSeleccionEmp.UseVisualStyleBackColor = true;
            btnSeleccionEmp.Click += btnSeleccionEmp_Click;
            // 
            // btnRegresar
            // 
            btnRegresar.FlatAppearance.BorderSize = 0;
            btnRegresar.FlatAppearance.MouseDownBackColor = Color.FromArgb(96, 60, 220);
            btnRegresar.FlatAppearance.MouseOverBackColor = Color.FromArgb(96, 60, 220);
            btnRegresar.FlatStyle = FlatStyle.Flat;
            btnRegresar.Image = (Image)resources.GetObject("btnRegresar.Image");
            btnRegresar.Location = new Point(338, 111);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(33, 28);
            btnRegresar.TabIndex = 56;
            btnRegresar.UseVisualStyleBackColor = true;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.FlatAppearance.BorderSize = 0;
            btnBuscar.FlatAppearance.MouseDownBackColor = Color.FromArgb(96, 60, 220);
            btnBuscar.FlatAppearance.MouseOverBackColor = Color.FromArgb(96, 60, 220);
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.Image = (Image)resources.GetObject("btnBuscar.Image");
            btnBuscar.Location = new Point(299, 111);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(33, 28);
            btnBuscar.TabIndex = 55;
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // lvEmpleados
            // 
            lvEmpleados.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6, columnHeader7, columnHeader8, columnHeader9, columnHeader10, columnHeader11, columnHeader12, columnHeader13, columnHeader14, columnHeader15, columnHeader16, columnHeader17, columnHeader18 });
            lvEmpleados.GridLines = true;
            lvEmpleados.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            lvEmpleados.Location = new Point(6, 189);
            lvEmpleados.Name = "lvEmpleados";
            lvEmpleados.Size = new Size(1093, 214);
            lvEmpleados.TabIndex = 2;
            lvEmpleados.UseCompatibleStateImageBehavior = false;
            lvEmpleados.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "ID";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Numero cedula";
            columnHeader2.TextAlign = HorizontalAlignment.Center;
            columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Numero INSS";
            columnHeader3.TextAlign = HorizontalAlignment.Center;
            columnHeader3.Width = 200;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Numero RUC";
            columnHeader4.TextAlign = HorizontalAlignment.Center;
            columnHeader4.Width = 180;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Primer Nombre";
            columnHeader5.TextAlign = HorizontalAlignment.Center;
            columnHeader5.Width = 150;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Segundo nombre";
            columnHeader6.TextAlign = HorizontalAlignment.Center;
            columnHeader6.Width = 150;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Primer apellido";
            columnHeader7.TextAlign = HorizontalAlignment.Center;
            columnHeader7.Width = 150;
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "Segundo apellido";
            columnHeader8.TextAlign = HorizontalAlignment.Center;
            columnHeader8.Width = 150;
            // 
            // columnHeader9
            // 
            columnHeader9.Text = "Fecha nacimiento";
            columnHeader9.TextAlign = HorizontalAlignment.Center;
            columnHeader9.Width = 150;
            // 
            // columnHeader10
            // 
            columnHeader10.Text = "Sexo";
            columnHeader10.TextAlign = HorizontalAlignment.Center;
            columnHeader10.Width = 80;
            // 
            // columnHeader11
            // 
            columnHeader11.Text = "Estado Civil";
            columnHeader11.TextAlign = HorizontalAlignment.Center;
            columnHeader11.Width = 100;
            // 
            // columnHeader12
            // 
            columnHeader12.Text = "Direccion";
            columnHeader12.TextAlign = HorizontalAlignment.Center;
            columnHeader12.Width = 220;
            // 
            // columnHeader13
            // 
            columnHeader13.Text = "Telefono";
            columnHeader13.TextAlign = HorizontalAlignment.Center;
            columnHeader13.Width = 120;
            // 
            // columnHeader14
            // 
            columnHeader14.Text = "Celular";
            columnHeader14.TextAlign = HorizontalAlignment.Center;
            columnHeader14.Width = 120;
            // 
            // columnHeader15
            // 
            columnHeader15.Text = "Fecha contratacion";
            columnHeader15.TextAlign = HorizontalAlignment.Center;
            columnHeader15.Width = 150;
            // 
            // columnHeader16
            // 
            columnHeader16.Text = "Salario base";
            columnHeader16.TextAlign = HorizontalAlignment.Center;
            columnHeader16.Width = 150;
            // 
            // columnHeader17
            // 
            columnHeader17.Text = "Cargo";
            columnHeader17.TextAlign = HorizontalAlignment.Center;
            columnHeader17.Width = 180;
            // 
            // columnHeader18
            // 
            columnHeader18.Text = "Horario";
            columnHeader18.TextAlign = HorizontalAlignment.Center;
            columnHeader18.Width = 180;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 97);
            label1.Name = "label1";
            label1.Size = new Size(76, 16);
            label1.TabIndex = 1;
            label1.Text = "Busqueda:";
            // 
            // txtBusqueda
            // 
            txtBusqueda.Location = new Point(6, 116);
            txtBusqueda.Name = "txtBusqueda";
            txtBusqueda.Size = new Size(287, 23);
            txtBusqueda.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(btnLimpiar);
            tabPage2.Controls.Add(btnCalcular);
            tabPage2.Controls.Add(btnExportar);
            tabPage2.Controls.Add(dtpFechaFin);
            tabPage2.Controls.Add(label13);
            tabPage2.Controls.Add(DGVNomina);
            tabPage2.Controls.Add(txtDeprecVehiculo);
            tabPage2.Controls.Add(label12);
            tabPage2.Controls.Add(txtEmbargos);
            tabPage2.Controls.Add(label11);
            tabPage2.Controls.Add(txtPrestamos);
            tabPage2.Controls.Add(label10);
            tabPage2.Controls.Add(txtViaticoTransporte);
            tabPage2.Controls.Add(label9);
            tabPage2.Controls.Add(txtViaticoAlimentacion);
            tabPage2.Controls.Add(label8);
            tabPage2.Controls.Add(panelComisiones);
            tabPage2.Controls.Add(panelHorasExtras);
            tabPage2.Controls.Add(dtpFecha);
            tabPage2.Controls.Add(label2);
            tabPage2.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            tabPage2.Location = new Point(4, 26);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1105, 602);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Nomina";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            btnLimpiar.FlatAppearance.BorderSize = 0;
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.Image = Properties.Resources.limpiar;
            btnLimpiar.Location = new Point(523, 561);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(97, 34);
            btnLimpiar.TabIndex = 21;
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnCalcular
            // 
            btnCalcular.FlatAppearance.BorderSize = 0;
            btnCalcular.FlatStyle = FlatStyle.Flat;
            btnCalcular.Image = (Image)resources.GetObject("btnCalcular.Image");
            btnCalcular.Location = new Point(704, 554);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(109, 42);
            btnCalcular.TabIndex = 20;
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // btnExportar
            // 
            btnExportar.FlatAppearance.BorderSize = 0;
            btnExportar.FlatStyle = FlatStyle.Flat;
            btnExportar.Image = Properties.Resources.sobresalir;
            btnExportar.Location = new Point(620, 554);
            btnExportar.Name = "btnExportar";
            btnExportar.Size = new Size(88, 41);
            btnExportar.TabIndex = 19;
            btnExportar.UseVisualStyleBackColor = true;
            btnExportar.Click += btnExportar_Click;
            // 
            // dtpFechaFin
            // 
            dtpFechaFin.Format = DateTimePickerFormat.Custom;
            dtpFechaFin.Location = new Point(212, 38);
            dtpFechaFin.Name = "dtpFechaFin";
            dtpFechaFin.Size = new Size(179, 22);
            dtpFechaFin.TabIndex = 18;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(212, 6);
            label13.Name = "label13";
            label13.Size = new Size(63, 16);
            label13.TabIndex = 17;
            label13.Text = "Fecha fin:";
            // 
            // DGVNomina
            // 
            dataGridViewCellStyle1.BackColor = Color.FromArgb(244, 147, 166);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(244, 141, 30);
            DGVNomina.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            DGVNomina.BackgroundColor = Color.FromArgb(243, 68, 100);
            DGVNomina.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(244, 141, 30);
            dataGridViewCellStyle2.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(244, 147, 166);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            DGVNomina.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            DGVNomina.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVNomina.Columns.AddRange(new DataGridViewColumn[] { Fecha, FechaFin, SalarioBase, SalarioQuincenal, SalarioDia, SalarioHora, SalarioNeto, HorasExtras, Comisiones, ViaticoA, ViaticoT, DeprecV, RiesgoLaboral, Nocturnidad, IngresoVacaciones, Aguinaldo, Indemizacion, ImpuestoRenta, INSS, Prestamos, Embargos, INATEC, INSSPatronal, IDEmpleado });
            DGVNomina.Location = new Point(8, 219);
            DGVNomina.Name = "DGVNomina";
            DGVNomina.RowTemplate.Height = 25;
            DGVNomina.Size = new Size(1091, 313);
            DGVNomina.TabIndex = 16;
            // 
            // Fecha
            // 
            Fecha.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle3.BackColor = Color.White;
            Fecha.DefaultCellStyle = dataGridViewCellStyle3;
            Fecha.FillWeight = 120F;
            Fecha.HeaderText = "Fecha";
            Fecha.Name = "Fecha";
            Fecha.Width = 120;
            // 
            // FechaFin
            // 
            FechaFin.HeaderText = "Fecha Fin";
            FechaFin.Name = "FechaFin";
            FechaFin.Width = 120;
            // 
            // SalarioBase
            // 
            SalarioBase.HeaderText = "Salario base";
            SalarioBase.Name = "SalarioBase";
            SalarioBase.Width = 150;
            // 
            // SalarioQuincenal
            // 
            SalarioQuincenal.HeaderText = "Salario quincenal";
            SalarioQuincenal.Name = "SalarioQuincenal";
            SalarioQuincenal.Width = 150;
            // 
            // SalarioDia
            // 
            SalarioDia.HeaderText = "Salario por dia";
            SalarioDia.Name = "SalarioDia";
            SalarioDia.Width = 150;
            // 
            // SalarioHora
            // 
            SalarioHora.HeaderText = "Salario por hora";
            SalarioHora.Name = "SalarioHora";
            SalarioHora.Width = 150;
            // 
            // SalarioNeto
            // 
            SalarioNeto.HeaderText = "Salario neto";
            SalarioNeto.Name = "SalarioNeto";
            SalarioNeto.Width = 150;
            // 
            // HorasExtras
            // 
            HorasExtras.HeaderText = "Hora extras";
            HorasExtras.Name = "HorasExtras";
            HorasExtras.Width = 150;
            // 
            // Comisiones
            // 
            Comisiones.HeaderText = "Comisiones";
            Comisiones.Name = "Comisiones";
            Comisiones.Width = 150;
            // 
            // ViaticoA
            // 
            ViaticoA.HeaderText = "Viatico alimentacion";
            ViaticoA.Name = "ViaticoA";
            ViaticoA.Width = 150;
            // 
            // ViaticoT
            // 
            ViaticoT.HeaderText = "Viatico transporte";
            ViaticoT.Name = "ViaticoT";
            ViaticoT.Width = 150;
            // 
            // DeprecV
            // 
            DeprecV.HeaderText = "Depreciacion vehiculo";
            DeprecV.Name = "DeprecV";
            DeprecV.Width = 150;
            // 
            // RiesgoLaboral
            // 
            RiesgoLaboral.HeaderText = "Riesgo laboral";
            RiesgoLaboral.Name = "RiesgoLaboral";
            RiesgoLaboral.Width = 150;
            // 
            // Nocturnidad
            // 
            Nocturnidad.HeaderText = "Nocturnidad";
            Nocturnidad.Name = "Nocturnidad";
            Nocturnidad.Width = 150;
            // 
            // IngresoVacaciones
            // 
            IngresoVacaciones.HeaderText = "Ingreso vacaciones";
            IngresoVacaciones.Name = "IngresoVacaciones";
            IngresoVacaciones.Width = 150;
            // 
            // Aguinaldo
            // 
            Aguinaldo.HeaderText = "Aguinaldo";
            Aguinaldo.Name = "Aguinaldo";
            Aguinaldo.Width = 150;
            // 
            // Indemizacion
            // 
            Indemizacion.HeaderText = "Indemizacion";
            Indemizacion.Name = "Indemizacion";
            Indemizacion.Width = 150;
            // 
            // ImpuestoRenta
            // 
            ImpuestoRenta.HeaderText = "IR";
            ImpuestoRenta.Name = "ImpuestoRenta";
            ImpuestoRenta.Width = 150;
            // 
            // INSS
            // 
            INSS.HeaderText = "INSS";
            INSS.Name = "INSS";
            // 
            // Prestamos
            // 
            Prestamos.HeaderText = "Prestamos";
            Prestamos.Name = "Prestamos";
            Prestamos.Width = 150;
            // 
            // Embargos
            // 
            Embargos.HeaderText = "Embargos";
            Embargos.Name = "Embargos";
            Embargos.Width = 150;
            // 
            // INATEC
            // 
            INATEC.HeaderText = "INATEC";
            INATEC.Name = "INATEC";
            INATEC.Width = 150;
            // 
            // INSSPatronal
            // 
            INSSPatronal.HeaderText = "INSS Patronal";
            INSSPatronal.Name = "INSSPatronal";
            INSSPatronal.Width = 150;
            // 
            // IDEmpleado
            // 
            IDEmpleado.HeaderText = "ID Empleado";
            IDEmpleado.Name = "IDEmpleado";
            // 
            // txtDeprecVehiculo
            // 
            txtDeprecVehiculo.Location = new Point(508, 131);
            txtDeprecVehiculo.Name = "txtDeprecVehiculo";
            txtDeprecVehiculo.Size = new Size(172, 22);
            txtDeprecVehiculo.TabIndex = 15;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(505, 102);
            label12.Name = "label12";
            label12.Size = new Size(161, 16);
            label12.TabIndex = 14;
            label12.Text = "Depreciacion de vehiculo";
            // 
            // txtEmbargos
            // 
            txtEmbargos.Location = new Point(946, 35);
            txtEmbargos.Name = "txtEmbargos";
            txtEmbargos.Size = new Size(153, 22);
            txtEmbargos.TabIndex = 13;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(943, 6);
            label11.Name = "label11";
            label11.Size = new Size(65, 16);
            label11.TabIndex = 12;
            label11.Text = "Embargos";
            // 
            // txtPrestamos
            // 
            txtPrestamos.Location = new Point(778, 35);
            txtPrestamos.Name = "txtPrestamos";
            txtPrestamos.Size = new Size(153, 22);
            txtPrestamos.TabIndex = 11;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(778, 6);
            label10.Name = "label10";
            label10.Size = new Size(66, 16);
            label10.TabIndex = 10;
            label10.Text = "Prestamos";
            // 
            // txtViaticoTransporte
            // 
            txtViaticoTransporte.Location = new Point(602, 35);
            txtViaticoTransporte.Name = "txtViaticoTransporte";
            txtViaticoTransporte.Size = new Size(153, 22);
            txtViaticoTransporte.TabIndex = 9;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(599, 6);
            label9.Name = "label9";
            label9.Size = new Size(109, 16);
            label9.TabIndex = 8;
            label9.Text = "Viatico transporte";
            // 
            // txtViaticoAlimentacion
            // 
            txtViaticoAlimentacion.Location = new Point(413, 35);
            txtViaticoAlimentacion.Name = "txtViaticoAlimentacion";
            txtViaticoAlimentacion.Size = new Size(153, 22);
            txtViaticoAlimentacion.TabIndex = 7;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(410, 6);
            label8.Name = "label8";
            label8.Size = new Size(129, 16);
            label8.TabIndex = 6;
            label8.Text = "Viatico Alimentacion";
            // 
            // panelComisiones
            // 
            panelComisiones.Controls.Add(label7);
            panelComisiones.Controls.Add(label6);
            panelComisiones.Controls.Add(label5);
            panelComisiones.Controls.Add(cmbMetaVenta);
            panelComisiones.Controls.Add(txtPorcentaje);
            panelComisiones.Controls.Add(txtVenta);
            panelComisiones.Controls.Add(label4);
            panelComisiones.Location = new Point(6, 72);
            panelComisiones.Name = "panelComisiones";
            panelComisiones.Size = new Size(468, 98);
            panelComisiones.TabIndex = 5;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(338, 30);
            label7.Name = "label7";
            label7.Size = new Size(127, 16);
            label7.TabIndex = 9;
            label7.Text = "Porcentaje comision";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(189, 33);
            label6.Name = "label6";
            label6.Size = new Size(74, 16);
            label6.TabIndex = 8;
            label6.Text = "Meta Venta";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(20, 35);
            label5.Name = "label5";
            label5.Size = new Size(44, 16);
            label5.TabIndex = 7;
            label5.Text = "Venta:";
            // 
            // cmbMetaVenta
            // 
            cmbMetaVenta.FormattingEnabled = true;
            cmbMetaVenta.Location = new Point(189, 52);
            cmbMetaVenta.Name = "cmbMetaVenta";
            cmbMetaVenta.Size = new Size(140, 24);
            cmbMetaVenta.TabIndex = 6;
            cmbMetaVenta.SelectedIndexChanged += cmbMetaVenta_SelectedIndexChanged;
            // 
            // txtPorcentaje
            // 
            txtPorcentaje.Location = new Point(345, 49);
            txtPorcentaje.Name = "txtPorcentaje";
            txtPorcentaje.ReadOnly = true;
            txtPorcentaje.Size = new Size(120, 22);
            txtPorcentaje.TabIndex = 5;
            // 
            // txtVenta
            // 
            txtVenta.Location = new Point(20, 54);
            txtVenta.Name = "txtVenta";
            txtVenta.Size = new Size(153, 22);
            txtVenta.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(196, 0);
            label4.Name = "label4";
            label4.Size = new Size(74, 16);
            label4.TabIndex = 3;
            label4.Text = "Comisiones";
            // 
            // panelHorasExtras
            // 
            panelHorasExtras.Controls.Add(txtHora);
            panelHorasExtras.Controls.Add(label3);
            panelHorasExtras.Location = new Point(713, 97);
            panelHorasExtras.Name = "panelHorasExtras";
            panelHorasExtras.Size = new Size(160, 73);
            panelHorasExtras.TabIndex = 4;
            // 
            // txtHora
            // 
            txtHora.Location = new Point(4, 33);
            txtHora.Name = "txtHora";
            txtHora.Size = new Size(153, 22);
            txtHora.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(0, 4);
            label3.Name = "label3";
            label3.Size = new Size(79, 16);
            label3.TabIndex = 3;
            label3.Text = "Horas Extras:";
            // 
            // dtpFecha
            // 
            dtpFecha.Format = DateTimePickerFormat.Custom;
            dtpFecha.Location = new Point(23, 38);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(160, 22);
            dtpFecha.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 6);
            label2.Name = "label2";
            label2.Size = new Size(47, 16);
            label2.TabIndex = 2;
            label2.Text = "Fecha:";
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.Group_39;
            panel1.Location = new Point(-7, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1123, 41);
            panel1.TabIndex = 1;
            // 
            // FrmPlanilla
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1115, 680);
            Controls.Add(panel1);
            Controls.Add(tabControl1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmPlanilla";
            Text = "FrmPlanilla";
            Load += FrmPlanilla_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DGVNomina).EndInit();
            panelComisiones.ResumeLayout(false);
            panelComisiones.PerformLayout();
            panelHorasExtras.ResumeLayout(false);
            panelHorasExtras.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Panel panel1;
        private ListView lvEmpleados;
        private Label label1;
        private TextBox txtBusqueda;
        private Button btnRegresar;
        private Button btnBuscar;
        private Button btnSeleccionEmp;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private ColumnHeader columnHeader9;
        private ColumnHeader columnHeader10;
        private ColumnHeader columnHeader11;
        private ColumnHeader columnHeader12;
        private ColumnHeader columnHeader13;
        private ColumnHeader columnHeader14;
        private ColumnHeader columnHeader15;
        private ColumnHeader columnHeader16;
        private ColumnHeader columnHeader17;
        private ColumnHeader columnHeader18;
        private Panel panelHorasExtras;
        private Panel panelComisiones;
        private TextBox txtVenta;
        private Label label4;
        private TextBox txtHora;
        private Label label3;
        private DateTimePicker dtpFecha;
        private Label label2;
        private TextBox txtEmbargos;
        private Label label11;
        private TextBox txtPrestamos;
        private Label label10;
        private TextBox txtViaticoTransporte;
        private Label label9;
        private TextBox txtViaticoAlimentacion;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private ComboBox cmbMetaVenta;
        private TextBox txtPorcentaje;
        private DataGridView DGVNomina;
        private TextBox txtDeprecVehiculo;
        private Label label12;
        private DateTimePicker dtpFechaFin;
        private Label label13;
        private Button btnCalcular;
        private Button btnExportar;
        private DataGridViewTextBoxColumn Fecha;
        private DataGridViewTextBoxColumn FechaFin;
        private DataGridViewTextBoxColumn SalarioBase;
        private DataGridViewTextBoxColumn SalarioQuincenal;
        private DataGridViewTextBoxColumn SalarioDia;
        private DataGridViewTextBoxColumn SalarioHora;
        private DataGridViewTextBoxColumn SalarioNeto;
        private DataGridViewTextBoxColumn HorasExtras;
        private DataGridViewTextBoxColumn Comisiones;
        private DataGridViewTextBoxColumn ViaticoA;
        private DataGridViewTextBoxColumn ViaticoT;
        private DataGridViewTextBoxColumn DeprecV;
        private DataGridViewTextBoxColumn RiesgoLaboral;
        private DataGridViewTextBoxColumn Nocturnidad;
        private DataGridViewTextBoxColumn IngresoVacaciones;
        private DataGridViewTextBoxColumn Aguinaldo;
        private DataGridViewTextBoxColumn Indemizacion;
        private DataGridViewTextBoxColumn ImpuestoRenta;
        private DataGridViewTextBoxColumn INSS;
        private DataGridViewTextBoxColumn Prestamos;
        private DataGridViewTextBoxColumn Embargos;
        private DataGridViewTextBoxColumn INATEC;
        private DataGridViewTextBoxColumn INSSPatronal;
        private DataGridViewTextBoxColumn IDEmpleado;
        private Button btnLimpiar;
    }
}