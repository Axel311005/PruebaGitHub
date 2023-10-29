using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Modelo;

namespace Controladores
{
    public class SubsidioController
    {
        private string conexion = "Data Source=DESKTOP-PBRTD4G\\DYLANSQL;Initial Catalog=nomina;User ID=sa;Password=dylanaraica123";

        public bool VerificarSubsidioEnQuincena(int empleadoId, DateTime fechaInicio, DateTime fechaFin)
        {
            bool enSubsidio = false;

            using (SqlConnection connection = new SqlConnection(conexion))
            {
                connection.Open();

                string query = "SELECT COUNT(*) FROM Subsidio WHERE idEmpleado= @EmpleadoId " +
                               "AND FechaInicio <= @FechaFin AND FechaFin >= @FechaInicio";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@EmpleadoId", empleadoId);
                    command.Parameters.AddWithValue("@FechaInicio", fechaInicio);
                    command.Parameters.AddWithValue("@FechaFin", fechaFin);

                    int count = (int)command.ExecuteScalar();
                    enSubsidio = (count > 0);
                }
            }

            return enSubsidio;
        }
        public int ObtenerDiasEnSubsidioEnQuincena(int empleadoId, DateTime fechaQuincenaInicio, DateTime fechaQuincenaFin)
        {
            int diasEnSubsidio = 0;

            using (SqlConnection connection = new SqlConnection(conexion))
            {
                connection.Open();

                string query = "SELECT SUM(DATEDIFF(DAY, FechaInicio, FechaFin) + 1) " +
                               "FROM Subsidio WHERE idEmpleado = @EmpleadoId " +
                               "AND FechaInicio <= @FechaFin AND FechaFin >= @FechaInicio " +
                               "AND FechaInicio <= @QuincenaFin AND FechaFin >= @QuincenaInicio";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@EmpleadoId", empleadoId);
                    command.Parameters.AddWithValue("@FechaInicio", fechaQuincenaInicio);
                    command.Parameters.AddWithValue("@FechaFin", fechaQuincenaFin);
                    command.Parameters.AddWithValue("@QuincenaInicio", fechaQuincenaInicio);
                    command.Parameters.AddWithValue("@QuincenaFin", fechaQuincenaFin);

                    object result = command.ExecuteScalar();
                    if (result != DBNull.Value)
                    {
                        diasEnSubsidio = Convert.ToInt32(result);
                    }
                }
            }

            return diasEnSubsidio;
        }

        public void InsertarSubsidio(Subsidio subsidio)
        {
            using(SqlConnection conection = new SqlConnection(conexion)) 
            {
                conection.Open();
                string query = "INSER INTO Subsidio (idEmpleado, FechaInicio, FechaFin) " +
                    "VALUES (@idEmpleado, @FechaInicio, @FechaFin)";

                using(SqlCommand command = new SqlCommand(query, conection))
                {
                    command.Parameters.AddWithValue("@idEmpleado", subsidio.IDEmpleado);
                    command.Parameters.AddWithValue("@FechaInicio", subsidio.FechaInicio);
                    command.Parameters.AddWithValue("@FechaFin", subsidio.FechaFin);

                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
