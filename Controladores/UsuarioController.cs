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
                string query = "INSERT INTO usuario (nombre, segundoNombre, primerApellido, segundoApellido, nombre_usuario, password, correo_electronico, fecha_nac, fecha_registro, idRol, telefono) " +
                          "VALUES (@nombre, @segundoNombre, @primerApellido, @segundoApellido, @nombre_usuario, @password, @correo_electronico, @fecha_nac, GETDATE(), @idRol, @telefono)";
                using (SqlCommand command = new SqlCommand(query, conection))
                {
                    command.Parameters.AddWithValue("@nombre", usuario.Nombre);
                    command.Parameters.AddWithValue("@segundoNombre", usuario.SegundoNombre);
                    command.Parameters.AddWithValue("@primerApellido", usuario.PrimerApellido);
                    command.Parameters.AddWithValue("@segundoApellido", usuario.SegundoApellido);
                    command.Parameters.AddWithValue("@nombre_usuario", usuario.NombreUsuario);
                    command.Parameters.AddWithValue("@password", usuario.Password);
                    command.Parameters.AddWithValue("@correo_electronico", usuario.CorreoElectronico);
                    command.Parameters.AddWithValue("@fecha_nac", usuario.FechaNac);
                    command.Parameters.AddWithValue("@idRol", usuario.IdRol);
                    command.Parameters.AddWithValue("@telefono", usuario.Telefono);

                    command.ExecuteNonQuery();
                }
            }
        }

        public bool Login(Usuario user)
        {
            string query = "SELECT * FROM usuario WHERE nombre_usuario = @nombre_usuario AND password = @password";

            using (SqlConnection connection = new SqlConnection(conexion))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@nombre_usuario", user.NombreUsuario);
                    command.Parameters.AddWithValue("@password", user.Password);

                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            return true;
                        }
                        return false;
                    }
                }
            }
        }

        public void ActualizarUltimoAcceso(Usuario user)
        {
            string query = "UPDATE usuario SET ultimo_acceso = GETDATE() WHERE nombre_usuario = @nombre_usuario";
            using (SqlConnection conecction = new SqlConnection(conexion))
            {
                conecction.Open();

                using (SqlCommand command = new SqlCommand(query, conecction))
                {
                    command.Parameters.AddWithValue("@nombre_usuario", user.NombreUsuario);

                    command.ExecuteNonQuery();
                }
            }
        }

        public bool UsuarioExiste(string nombreUser)
        {
            using (SqlConnection conection = new SqlConnection(conexion))
            {
                conection.Open();
                string query = "SELECT COUNT(*) FROM usuario WHERE nombre_usuario = @nombre_usuario";

                using (SqlCommand command = new SqlCommand(query, conection))
                {
                    command.Parameters.AddWithValue("@nombre_usuario", nombreUser);
                    int count = (int)command.ExecuteScalar();
                    return count > 0;
                }
            }
        }

        public Usuario SelectUserPorID(int ID)
        {
            using (SqlConnection conection = new SqlConnection(conexion))
            {
                conection.Open();

                string query = "SELECT nombre, segundoNombre, primerApellido, segundoApellido, nombre_usuario, password," +
                    "correo_electronico, fecha_nac, idRol FROM usuario WHERE id = @id";

                using (SqlCommand comando = new SqlCommand(query, conection))
                {
                    comando.Parameters.AddWithValue("@id", ID);

                    using (SqlDataReader lector = comando.ExecuteReader())
                    {
                        if (lector.Read())
                        {
                            Usuario usuario = new Usuario();
                            usuario.Nombre = lector.GetString(0);
                            usuario.SegundoNombre = lector.GetString(1);
                            usuario.PrimerApellido = lector.GetString(2);
                            usuario.SegundoApellido = lector.GetString(3);
                            usuario.NombreUsuario = lector.GetString(4);
                            usuario.Password = lector.GetString(5);
                            usuario.CorreoElectronico = lector.GetString(6);
                            usuario.FechaNac = lector.GetDateTime(7);
                            usuario.IdRol = lector.GetInt32(8);
                            return usuario;
                        }
                    }
                    return null;
                }
            }
        }
        public Usuario SelectUserPorNombreUsuario(string nombreUsuario)
        {
            using (SqlConnection connection = new SqlConnection(conexion))
            {
                connection.Open();
                string query = "SELECT id, nombre, segundoNombre, primerApellido, segundoApellido, password," +
                    "correo_electronico, fecha_nac, idRol FROM usuario WHERE nombre_usuario = @nombre_usuario";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@nombre_usuario", nombreUsuario);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            Usuario usuario = new Usuario();
                            usuario.ID = reader.GetInt32(0);
                            usuario.Nombre = reader.GetString(1);
                            usuario.SegundoNombre = reader.GetString(2);
                            usuario.PrimerApellido = reader.GetString(3);
                            usuario.SegundoApellido = reader.GetString(4);
                            usuario.Password = reader.GetString(5);
                            usuario.CorreoElectronico = reader.GetString(6);
                            usuario.FechaNac = reader.GetDateTime(7);
                            usuario.IdRol = reader.GetInt32(8);
                            return usuario;
                        }
                    }
                    return null;
                }
            }
        }

        public void ActualizarUsuario(Usuario user)
        {
            string query = "UPDATE usuario SET nombre = @nuevoNombre,  segundoNombre = @nuevoSegundoNombre, primerApellido = @nuevoPrimerApellido, " +
                "segundoApellido = @nuevoSegundoApellido, password = @nuevapassword, correo_electronico = @nuevoCorreoElectronico, fecha_nac = @nuevaFechaNacimiento WHERE id = @id;";
            using (SqlConnection conecction = new SqlConnection(conexion))
            {
                conecction.Open();

                using (SqlCommand command = new SqlCommand(query, conecction))
                {
                    command.Parameters.AddWithValue("@nuevoNombre", user.Nombre);
                    command.Parameters.AddWithValue("@nuevoSegundoNombre",user.SegundoNombre);
                    command.Parameters.AddWithValue("@nuevoPrimerApellido", user.PrimerApellido);
                    command.Parameters.AddWithValue("@nuevoSegundoApellido", user.SegundoApellido);
                    command.Parameters.AddWithValue("@nuevapassword", user.Password);
                    


                    command.ExecuteNonQuery();
                }
            }
        }

    }
}
