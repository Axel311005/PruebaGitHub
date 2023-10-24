using Controladores;
using Microsoft.VisualBasic.ApplicationServices;
using Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UINomina
{
    public partial class FrmEditarUsuario : Form
    {
        private int ID = (int)UsuarioAutentificado.id;
        public FrmEditarUsuario()
        {
            InitializeComponent();
        }

        private void FrmEditarUsuario_Load(object sender, EventArgs e)
        {
            Usuario user = new();
            UsuarioController US = new();
            user = US.SelectUserPorID(ID);
            if (user != null)
            {
                txtNombre.Text = user.Nombre;
                txtSegundoNombre.Text = user.SegundoNombre;
                txtApellido.Text = user.PrimerApellido;
                txtSegundoApellido.Text = user.SegundoApellido;
                txtContraseña.Text = user.Password;
                txtConfirmPass.Text = user.Password;
                txtUser.Text = user.NombreUsuario;
                txtCorreo.Text = user.CorreoElectronico;
                dtFecha.Value = user.FechaNac;
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

        private void PBCerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void PBMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pbEditar_Click(object sender, EventArgs e)
        {
            UsuarioController usuarioController = new();
            Usuario nuevoUsuario = ObtenerDatosEditados();
            List<string> errores = UsuarioValidation.ValidarUsuario(nuevoUsuario);
            if (errores.Count == 0)
            {
                try
                {
                    usuarioController.ActualizarUsuario(nuevoUsuario);
                    MessageBox.Show("Usuario Actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al actualizar el usuario: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                string mensajeErrores = string.Join(Environment.NewLine, errores);
                MessageBox.Show("Errores de validación:" + Environment.NewLine + mensajeErrores, "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Usuario ObtenerDatosEditados()
        {
            Usuario usuario = new Usuario();
            usuario.Nombre = txtNombre.Text;
            usuario.SegundoNombre = txtSegundoNombre.Text;
            usuario.PrimerApellido = txtApellido.Text;
            usuario.SegundoApellido = txtSegundoApellido.Text;
            if (txtConfirmPass.Text == txtContraseña.Text)
                usuario.Password = txtConfirmPass.Text;
            else
                MessageBox.Show("Las contraseñas no coinciden, por favor ingrese de nuevo la confirmacion de contraseña", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            usuario.CorreoElectronico = txtCorreo.Text;
            usuario.FechaNac = dtFecha.Value;
            usuario.Telefono = txtTelefono.Text;
            usuario.CorreoElectronico = txtCorreo.Text;
            return usuario;
        }
    }
}
