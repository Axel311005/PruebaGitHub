namespace UINomina
{
    partial class FrmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            panel1 = new Panel();
            button1 = new Button();
            btnPlanilla = new Button();
            btnEmpleados = new Button();
            btnConfig = new Button();
            btnLogOut = new Button();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panelContenedor = new Panel();
            PBMinimizar = new PictureBox();
            PBCerrar = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PBMinimizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PBCerrar).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(31, 38, 62);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(btnPlanilla);
            panel1.Controls.Add(btnEmpleados);
            panel1.Controls.Add(btnConfig);
            panel1.Controls.Add(btnLogOut);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-2, -3);
            panel1.Name = "panel1";
            panel1.Size = new Size(152, 686);
            panel1.TabIndex = 0;
            panel1.MouseDown += panel1_MouseDown;
            // 
            // button1
            // 
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(48, 55, 80);
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(48, 55, 80);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(3, 129);
            button1.Name = "button1";
            button1.Padding = new Padding(1, 0, 1, 1);
            button1.Size = new Size(149, 27);
            button1.TabIndex = 7;
            button1.Text = "Home";
            button1.UseVisualStyleBackColor = true;
            // 
            // btnPlanilla
            // 
            btnPlanilla.BackgroundImage = (Image)resources.GetObject("btnPlanilla.BackgroundImage");
            btnPlanilla.BackgroundImageLayout = ImageLayout.None;
            btnPlanilla.FlatAppearance.BorderSize = 0;
            btnPlanilla.FlatAppearance.MouseDownBackColor = Color.FromArgb(48, 55, 80);
            btnPlanilla.FlatAppearance.MouseOverBackColor = Color.FromArgb(48, 55, 80);
            btnPlanilla.FlatStyle = FlatStyle.Flat;
            btnPlanilla.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnPlanilla.ForeColor = Color.White;
            btnPlanilla.Location = new Point(3, 298);
            btnPlanilla.Name = "btnPlanilla";
            btnPlanilla.Padding = new Padding(1, 0, 1, 1);
            btnPlanilla.Size = new Size(149, 37);
            btnPlanilla.TabIndex = 6;
            btnPlanilla.Text = "Planilla";
            btnPlanilla.UseVisualStyleBackColor = true;
            // 
            // btnEmpleados
            // 
            btnEmpleados.BackgroundImage = (Image)resources.GetObject("btnEmpleados.BackgroundImage");
            btnEmpleados.BackgroundImageLayout = ImageLayout.None;
            btnEmpleados.FlatAppearance.BorderSize = 0;
            btnEmpleados.FlatAppearance.MouseDownBackColor = Color.FromArgb(48, 55, 80);
            btnEmpleados.FlatAppearance.MouseOverBackColor = Color.FromArgb(48, 55, 80);
            btnEmpleados.FlatStyle = FlatStyle.Flat;
            btnEmpleados.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnEmpleados.ForeColor = Color.White;
            btnEmpleados.Location = new Point(3, 212);
            btnEmpleados.Name = "btnEmpleados";
            btnEmpleados.Padding = new Padding(1, 0, 1, 1);
            btnEmpleados.Size = new Size(149, 33);
            btnEmpleados.TabIndex = 5;
            btnEmpleados.Text = "Empleados";
            btnEmpleados.UseVisualStyleBackColor = true;
            // 
            // btnConfig
            // 
            btnConfig.BackgroundImage = (Image)resources.GetObject("btnConfig.BackgroundImage");
            btnConfig.BackgroundImageLayout = ImageLayout.None;
            btnConfig.FlatAppearance.BorderSize = 0;
            btnConfig.FlatAppearance.MouseDownBackColor = Color.FromArgb(48, 55, 80);
            btnConfig.FlatAppearance.MouseOverBackColor = Color.FromArgb(48, 55, 80);
            btnConfig.FlatStyle = FlatStyle.Flat;
            btnConfig.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnConfig.ForeColor = Color.White;
            btnConfig.Location = new Point(3, 609);
            btnConfig.Name = "btnConfig";
            btnConfig.Padding = new Padding(1, 0, 1, 1);
            btnConfig.Size = new Size(149, 25);
            btnConfig.TabIndex = 4;
            btnConfig.Text = "Configuraciones";
            btnConfig.UseVisualStyleBackColor = true;
            btnConfig.Click += btnConfig_Click;
            // 
            // btnLogOut
            // 
            btnLogOut.BackgroundImage = Properties.Resources.Power_Off;
            btnLogOut.BackgroundImageLayout = ImageLayout.None;
            btnLogOut.FlatAppearance.BorderSize = 0;
            btnLogOut.FlatAppearance.MouseDownBackColor = Color.FromArgb(48, 55, 80);
            btnLogOut.FlatAppearance.MouseOverBackColor = Color.FromArgb(48, 55, 80);
            btnLogOut.FlatStyle = FlatStyle.Flat;
            btnLogOut.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnLogOut.ForeColor = Color.White;
            btnLogOut.Location = new Point(3, 661);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Padding = new Padding(1, 0, 1, 1);
            btnLogOut.Size = new Size(149, 25);
            btnLogOut.TabIndex = 3;
            btnLogOut.Text = "Log Out";
            btnLogOut.UseVisualStyleBackColor = true;
            btnLogOut.Click += btnLogOut_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(32, 554);
            label2.Name = "label2";
            label2.Size = new Size(78, 23);
            label2.TabIndex = 2;
            label2.Text = "Cuenta";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Full_Colour;
            pictureBox1.Location = new Point(14, 10);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(34, 31);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(54, 17);
            label1.Name = "label1";
            label1.Size = new Size(92, 22);
            label1.TabIndex = 0;
            label1.Text = "NOMINA";
            // 
            // panelContenedor
            // 
            panelContenedor.Controls.Add(PBMinimizar);
            panelContenedor.Controls.Add(PBCerrar);
            panelContenedor.Location = new Point(150, 0);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Size = new Size(1115, 683);
            panelContenedor.TabIndex = 4;
            panelContenedor.MouseDown += panelContenedor_MouseDown;
            // 
            // PBMinimizar
            // 
            PBMinimizar.BackColor = Color.White;
            PBMinimizar.Image = Properties.Resources.minimizar_signo;
            PBMinimizar.Location = new Point(1035, 3);
            PBMinimizar.Name = "PBMinimizar";
            PBMinimizar.Size = new Size(35, 29);
            PBMinimizar.TabIndex = 5;
            PBMinimizar.TabStop = false;
            PBMinimizar.Click += PBMinimizar_Click_1;
            // 
            // PBCerrar
            // 
            PBCerrar.BackColor = Color.White;
            PBCerrar.Image = Properties.Resources.cerrar;
            PBCerrar.Location = new Point(1076, 3);
            PBCerrar.Name = "PBCerrar";
            PBCerrar.Size = new Size(35, 29);
            PBCerrar.TabIndex = 4;
            PBCerrar.TabStop = false;
            PBCerrar.Click += PBCerrar_Click_1;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1264, 681);
            Controls.Add(panelContenedor);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmPrincipal";
            Load += FrmPrincipal_Load;
            MouseDown += FrmPrincipal_MouseDown;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelContenedor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PBMinimizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)PBCerrar).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Button btnLogOut;
        private Button btnConfig;
        private Button btnEmpleados;
        private Button btnPlanilla;
        private Panel panelContenedor;
        private PictureBox PBMinimizar;
        private PictureBox PBCerrar;
        private Button button1;
    }
}