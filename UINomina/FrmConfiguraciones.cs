using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Runtime.InteropServices;
using Controladores;
using Modelo;

namespace UINomina
{
    public partial class FrmConfiguraciones : Form
    {
        public FrmConfiguraciones()
        {
            InitializeComponent();
        }


        private void FrmConfiguraciones_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void Esconder_Click(object sender, EventArgs e)
        {
            Esconder.Visible = false;
            Ver.Visible = true;
            txtContraseña.UseSystemPasswordChar = false;
        }

        private void Ver_Click(object sender, EventArgs e)
        {
            Ver.Visible = false;
            Esconder.Visible = true;
            txtContraseña.UseSystemPasswordChar = true;
        }

        private void FrmConfiguraciones_Load(object sender, EventArgs e)
        {
            Usuario user = new();
            UsuarioController US = new();
            int ID = (int)UsuarioAutentificado.id;
            user = US.SelectUserPorID(ID);
            if (user != null)
            {
                txtNombre.Text = user.Nombre;
                txtSegundoNombre.Text = user.SegundoNombre;
                txtApellido.Text = user.PrimerApellido;
                txtSegundoApellido.Text = user.SegundoApellido;
                txtContraseña.Text = user.Password;
                txtUser.Text = user.NombreUsuario;
                txtCorreo.Text = user.CorreoElectronico;
                string formato = "dd/MM/yyyy";
                string fechaNacimientoTexto = user.FechaNac.ToString(formato);
                txtFechaNacimiento.Text = fechaNacimientoTexto;
                txtTelefono.Text = user.Telefono;
                if (user.IdRol == (int)Rol.IdAdministrador)
                    txtRol.Text = "Administrador";
                else if (user.IdRol == (int)Rol.IdGerente)
                    txtRol.Text = "Gerente";
                else if (user.IdRol == (int)Rol.IdContadorGeneral)
                    txtRol.Text = "Contador General";
                else if (user.IdRol == (int)Rol.IdAsistenteContable)
                    txtRol.Text = "Asistente Contable";
            }
            else
                MessageBox.Show("Usuario nulo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


        }

        private void pbEditar_Click(object sender, EventArgs e)
        {
            FrmEditarUsuario ediUser = new();
            ediUser.ShowDialog();
        }
    }
}
