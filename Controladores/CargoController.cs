using Modelo;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace Controladores
{
    public class CargoController
    {
        private string conexion = "Data Source=DESKTOP-PBRTD4G\\DYLANSQL;Initial Catalog = nomina; User ID = sa; Password=dylanaraica123";

        public List<Cargo> ObtenerCargos()
        {
            List<Cargo> cargos = new List<Cargo>();

            using (SqlConnection connection = new SqlConnection(conexion))
            {
                connection.Open();

                string query = "SELECT id, nombre FROM cargo";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Cargo cargo = new Cargo
                            {
                                IDCargo = reader.GetInt32(0),
                                Nombre = reader.GetString(1)
                            };

                            cargos.Add(cargo);
                        }
                    }
                }
            }

            return cargos;
        }

        public Cargo ObtenerCargoPorId(int id)
        {
            using (SqlConnection connection = new SqlConnection(conexion))
            {
                connection.Open();

                string query = "SELECT nombre FROM cargo WHERE id = @id";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", id);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Cargo
                            {
                                IDCargo= id,
                                Nombre = reader.GetString(0)
                            };
                        }
                    }
                }
            }

            return null; // En caso de que no se encuentre el cargo con el ID especificado
        }
    }
}
