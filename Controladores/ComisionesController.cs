using Modelo;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace Controladores
{
    public class ComisionesController
    {
        private string conexion = "Data Source=DESKTOP-PBRTD4G\\DYLANSQL;Initial Catalog = nomina; User ID = sa; Password=dylanaraica123";

        public void InsertarComision(Comisiones comisiones)
        {
            using (SqlConnection conection = new SqlConnection(conexion))
            {
                conection.Open();
                string query = "INSERT INTO comisiones (idCargo, porcentajeComision, MetaVentas) VALUES(@idCargo, @porcentajeComision, @Metaventas)";
                using (SqlCommand comando = new(query, conection))
                {
                    comando.Parameters.AddWithValue("@idCargo", comisiones.IDCargo);
                    comando.Parameters.AddWithValue("@porcentajeComision", comisiones.PorcentajeComision);
                    comando.Parameters.AddWithValue("@MetaVentas", comisiones.MetaVentas);

                    comando.ExecuteNonQuery();
                }
            }
        }
        public bool ComisionYaExiste(int idCargo, string metaVentas)
        {
            using (SqlConnection connection = new SqlConnection(conexion))
            {
                connection.Open();
                string query = "SELECT COUNT(*) FROM comisiones WHERE idCargo = @idCargo AND MetaVentas = @MetaVentas";

                using (SqlCommand command = new(query, connection))
                {
                    command.Parameters.AddWithValue("@idCargo", idCargo);
                    command.Parameters.AddWithValue("@MetaVentas", metaVentas);

                    int count = (int)command.ExecuteScalar();

                    return count > 0;
                }
            }
        }
        public List<Comisiones> ObtenerComisiones()
        {
            using (SqlConnection connection = new SqlConnection(conexion))
            {
                connection.Open();

                string query = "SELECT id, idCargo, porcentajeComision, MetaVentas FROM comisiones";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    List<Comisiones> comisiones = new List<Comisiones>();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Comisiones comision = new Comisiones
                            {
                                ID = reader.GetInt32(0),
                                IDCargo = reader.GetInt32(1),
                                PorcentajeComision = reader.GetDecimal(2),
                                MetaVentas = reader.GetString(3)
                            };

                            comisiones.Add(comision);
                        }
                    }

                    return comisiones;
                }
            }
        }
    }
}