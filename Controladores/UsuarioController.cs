using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;

namespace Controladores
{
    public class UsuarioController
    {
        private string conexion = "Data Source=DESKTOP-PBRTD4G\\DYLANSQL;Initial Catalog = nomina; User ID = sa; Password=dylanaraica123";

        public void InsertarUsuario(Usuario usuario)
        {
            using (SqlConnection conection = new SqlConnection(conexion))
            {
                conection.Open();
                string query = "INSERT INTO usuario (nombre, segundoNombre, primerApellido, segundoApellido, nombre_usuario, password, correo_electronico, fecha_nac, fecha_registro, idRol) " +
                          "VALUES (@nombre, @segundoNombre, @primerApellido, @segundoApellido, @nombre_usuario, @password, @correo_electronico, @fecha_nac, @fecha_registro, @idRol)";
                using (SqlCommand command = new SqlCommand(query, conection))
                {
                    command.Parameters.AddWithValue("@nombre", usuario.Nombre);
                    command.Parameters.AddWithValue("@segundoNombre", usuario.SegundoNombre);
                    command.Parameters.AddWithValue("@primerApellido", usuario.PrimerApellido);
                    command.Parameters.AddWithValue("@segundoApellido", usuario.SegundoApellido);
                    command.Parameters.AddWithValue("@nombre_usuario", usuario.NombreUsuario);
                    command.Parameters.AddWithValue("@password", usuario.Password);
                    command.Parameters.AddWithValue("@correo_electronico", usuario.CorreoElectronico);



                }
            }

        }
    }
}
