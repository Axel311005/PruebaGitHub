using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Controladores;
using Modelo;

namespace UINomina
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal(int userID)
        {
            InitializeComponent();
            AbrirFormHija(new FrmHome());
            UsuarioController userController = new UsuarioController();
            Usuario user = userController.SelectUserPorID(userID);

            if (user != null)
            {
                lbNombres.Text = $"{user.Nombre} {user.PrimerApellido}";
                if (user.IdRol == (int)Rol.IdAdministrador)
                    lbRol.Text = "Adminsitrador";
                else if (user.IdRol == (int)Rol.IdGerente)
                    lbRol.Text = "Gerente";
                else if (user.IdRol == (int)Rol.IdContadorGeneral)
                    lbRol.Text = "Contador General";
                else
                    lbRol.Text = "Asistente Contable";

                int verticalPosition = (panel5.Height - lbNombres.Height - lbRol.Height) / 2;

                // Establece las ubicaciones verticales de las etiquetas en el panel
                lbNombres.Top = verticalPosition;
                lbRol.Top = lbNombres.Bottom;

            }

        }
        [DllImport("user32.dll")]
        private static extern int ReleaseCapture();
        [DllImport("user32.dll")]
        private static extern int SendMessage(IntPtr hwnd, int msg, int wParam, int lParam);
        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;


        private void PBCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PBMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void FrmPrincipal_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void panelContenedor_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            FrmLogin login = new();
            login.Show();
            this.Hide();
        }
        private void AbrirFormHija(object formulario)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            Form fh = formulario as Form;
            fh.TopLevel = false;
            fh.MouseDown += FrmPrincipal_MouseDown;
            fh.Controls.Add(PBCerrar);
            fh.Controls.Add(PBMinimizar);
            PBCerrar.Visible = true;
            PBMinimizar.Visible = true;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Show();

        }
        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);

            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }


        private void btnConfig_Click(object sender, EventArgs e)
        {
            FrmConfiguraciones frmConfig = new FrmConfiguraciones();
            AbrirFormHija(frmConfig);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            FrmHome frmhome = new FrmHome();
            AbrirFormHija(frmhome);

        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            subMenuEmpleado.Visible = true;
        }

        private void btnAgregarEmp_Click(object sender, EventArgs e)
        {
            subMenuEmpleado.Visible = false;
            FrmAgregarEmpleado frmAggEmp = new();
            PBCerrar.Visible = false;
            PBMinimizar.Visible = false;
            AbrirFormHija(frmAggEmp);

        }

        private void btnAdminEmp_Click(object sender, EventArgs e)
        {
            subMenuEmpleado.Visible = false;
        }

        private void btnAggCargo_Click(object sender, EventArgs e)
        {
            subMenuEmpleado.Visible = false;
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            FrmHome frmhome = new FrmHome();
            AbrirFormHija(frmhome);
        }

        private void PBCerrar_Click_2(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PBMinimizar_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
