using Modelo;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Controladores
{
    public class EmpeladoController
    {
        private string conexion = "Data Source=DESKTOP-PBRTD4G\\DYLANSQL;Initial Catalog = nomina; User ID = sa; Password=dylanaraica123";

        public void InsertarEmpleado(Empleado empleado)
        {
            using(SqlConnection conection = new SqlConnection(conexion))
            {
                conection.Open();

                string query = "INSERT INTO empleado (numeroCedula, numeroINSS, numeroRUC, primerNombre, segundoNombre, primerApellido, segundoApellido, fechaNacimiento, sexo, estadoCivil, direccion, telefono, celular, fechaContratacion, salarioOridinario, activo, idCargo, idHorario)" +
                    "VALUES (@numeroCedula, @numeroINSS, @numeroRUC, @primerNombre,@segundoNombre,@primerApellido, @segundoApellido, @fechaNacimiento,@sexo,@estadoCivil,@direccion,@telefono,@celular, @fechaContratacion, @salarioOrdinario, 1, @idCargo, @idHorario)";

                using(SqlCommand comando = new SqlCommand(query, conection))
                {
                    comando.Parameters.AddWithValue("@numeroCedula", empleado.NumeroCedula);
                    comando.Parameters.AddWithValue("@numeroINSS", empleado.NumeroINSS);
                    comando.Parameters.AddWithValue("@numeroRUC", empleado.NumeroRUC);
                    comando.Parameters.AddWithValue("@primerNombre", empleado.PrimerNombre);
                    comando.Parameters.AddWithValue("@segundoNombre", empleado.SegundoNombre);
                    comando.Parameters.AddWithValue("@primerApellido", empleado.PrimerApellido);
                    comando.Parameters.AddWithValue("@segundoApellido", empleado.SegundoApellido);
                    comando.Parameters.AddWithValue("@fechaNacimiento", empleado.FechaNacimiento);
                    comando.Parameters.AddWithValue("@sexo", empleado.Sexo);
                    comando.Parameters.AddWithValue("@estadoCivil", empleado.EstadoCivil);
                    comando.Parameters.AddWithValue("@direccion", empleado.Direccion);
                    comando.Parameters.AddWithValue("@telefono", empleado.Telefono);
                    comando.Parameters.AddWithValue("@celular", empleado.Celular);
                    comando.Parameters.AddWithValue("@fechaContratacion", empleado.FechaContratacion);
                    comando.Parameters.AddWithValue("@salarioOrdinario", empleado.SalarioOrdinario);
                    comando.Parameters.AddWithValue("@idCargo", empleado.IDCargo);
                    comando.Parameters.AddWithValue("@idHorario", empleado.IDHorario);
                    comando.ExecuteNonQuery();
                }
            }
        }
    }
}
