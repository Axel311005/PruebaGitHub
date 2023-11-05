namespace UINomina
{
    partial class FrmAgregarCargo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAgregarCargo));
            label1 = new Label();
            pictureBox1 = new PictureBox();
            txtCargo = new TextBox();
            pictureBox2 = new PictureBox();
            panel2 = new Panel();
            RBFalseComisiones = new RadioButton();
            RBTrueComisiones = new RadioButton();
            label6 = new Label();
            panel1 = new Panel();
            RBFalseRiesgoLaboral = new RadioButton();
            RBTrueRiesgoLaboral = new RadioButton();
            label2 = new Label();
            lvCargos = new ListView();
            label3 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(492, 77);
            label1.Name = "label1";
            label1.Size = new Size(151, 23);
            label1.TabIndex = 0;
            label1.Text = "Agregar Cargo";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Rectangle_43_Copy__1_;
            pictureBox1.Location = new Point(-4, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1124, 49);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // txtCargo
            // 
            txtCargo.BackColor = Color.White;
            txtCargo.BorderStyle = BorderStyle.None;
            txtCargo.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtCargo.ForeColor = Color.Black;
            txtCargo.Location = new Point(225, 162);
            txtCargo.Name = "txtCargo";
            txtCargo.Size = new Size(168, 16);
            txtCargo.TabIndex = 4;
            txtCargo.Text = "Nombre de cargo";
            txtCargo.Enter += txtCargo_Enter;
            txtCargo.Leave += txtCargo_Leave;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(194, 187);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(199, 22);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(RBFalseComisiones);
            panel2.Controls.Add(RBTrueComisiones);
            panel2.Controls.Add(label6);
            panel2.Location = new Point(433, 136);
            panel2.Name = "panel2";
            panel2.Size = new Size(223, 115);
            panel2.TabIndex = 43;
            // 
            // RBFalseComisiones
            // 
            RBFalseComisiones.AutoSize = true;
            RBFalseComisiones.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            RBFalseComisiones.Location = new Point(22, 75);
            RBFalseComisiones.Name = "RBFalseComisiones";
            RBFalseComisiones.Size = new Size(45, 21);
            RBFalseComisiones.TabIndex = 37;
            RBFalseComisiones.TabStop = true;
            RBFalseComisiones.Text = "No";
            RBFalseComisiones.UseVisualStyleBackColor = true;
            // 
            // RBTrueComisiones
            // 
            RBTrueComisiones.AutoSize = true;
            RBTrueComisiones.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            RBTrueComisiones.Location = new Point(22, 46);
            RBTrueComisiones.Name = "RBTrueComisiones";
            RBTrueComisiones.Size = new Size(35, 21);
            RBTrueComisiones.TabIndex = 33;
            RBTrueComisiones.TabStop = true;
            RBTrueComisiones.Text = "Sí";
            RBTrueComisiones.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(22, 9);
            label6.Name = "label6";
            label6.Size = new Size(195, 20);
            label6.TabIndex = 32;
            label6.Text = "¿Se le aplica comisiones?";
            // 
            // panel1
            // 
            panel1.Controls.Add(RBFalseRiesgoLaboral);
            panel1.Controls.Add(RBTrueRiesgoLaboral);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(689, 136);
            panel1.Name = "panel1";
            panel1.Size = new Size(237, 115);
            panel1.TabIndex = 44;
            // 
            // RBFalseRiesgoLaboral
            // 
            RBFalseRiesgoLaboral.AutoSize = true;
            RBFalseRiesgoLaboral.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            RBFalseRiesgoLaboral.Location = new Point(28, 75);
            RBFalseRiesgoLaboral.Name = "RBFalseRiesgoLaboral";
            RBFalseRiesgoLaboral.Size = new Size(45, 21);
            RBFalseRiesgoLaboral.TabIndex = 36;
            RBFalseRiesgoLaboral.TabStop = true;
            RBFalseRiesgoLaboral.Text = "No";
            RBFalseRiesgoLaboral.UseVisualStyleBackColor = true;
            // 
            // RBTrueRiesgoLaboral
            // 
            RBTrueRiesgoLaboral.AutoSize = true;
            RBTrueRiesgoLaboral.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            RBTrueRiesgoLaboral.Location = new Point(28, 46);
            RBTrueRiesgoLaboral.Name = "RBTrueRiesgoLaboral";
            RBTrueRiesgoLaboral.Size = new Size(35, 21);
            RBTrueRiesgoLaboral.TabIndex = 35;
            RBTrueRiesgoLaboral.TabStop = true;
            RBTrueRiesgoLaboral.Text = "Sí";
            RBTrueRiesgoLaboral.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(16, 9);
            label2.Name = "label2";
            label2.Size = new Size(218, 20);
            label2.TabIndex = 32;
            label2.Text = "¿Se le aplica Riesgo laboral?";
            // 
            // lvCargos
            // 
            lvCargos.Location = new Point(42, 385);
            lvCargos.Name = "lvCargos";
            lvCargos.Size = new Size(997, 205);
            lvCargos.TabIndex = 45;
            lvCargos.UseCompatibleStateImageBehavior = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(492, 336);
            label3.Name = "label3";
            label3.Size = new Size(135, 23);
            label3.TabIndex = 46;
            label3.Text = "Editar Cargos";
            // 
            // button1
            // 
            button1.Location = new Point(469, 274);
            button1.Name = "button1";
            button1.Size = new Size(148, 41);
            button1.TabIndex = 47;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(176, 618);
            button2.Name = "button2";
            button2.Size = new Size(148, 29);
            button2.TabIndex = 48;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(369, 618);
            button3.Name = "button3";
            button3.Size = new Size(148, 29);
            button3.TabIndex = 49;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            // 
            // FrmAgregarCargo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1115, 680);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(lvCargos);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(txtCargo);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmAgregarCargo";
            Text = "FrmAgregarCargo";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private TextBox txtCargo;
        private PictureBox pictureBox2;
        private Panel panel2;
        private RadioButton RBMixto;
        private RadioButton RBNocturno;
        private RadioButton RBTrueComisiones;
        private Label label6;
        private Panel panel1;
        private Label label2;
        private RadioButton RBFalseRiesgoLaboral;
        private RadioButton RBTrueRiesgoLaboral;
        private ListView lvCargos;
        private Label label3;
        private Button button1;
        private Button button2;
        private Button button3;
        private RadioButton RBFalseComisiones;
    }
}