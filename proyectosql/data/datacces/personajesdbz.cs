using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectosql.data.datacces
{
    internal class personajesdbz
    {
        private string connectionString = "server=localhost;Database=db_universidad;Uid=root; Pwd=BryanJRH0801";
        public bool probarconexion()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    return true;
                } catch (Exception ex)
                {
                    return false;
                }
            }
        }
        public DataTable LeerPersonajes()
        {
            DataTable personajes = new DataTable();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string sql = "SELECT * FROM personajes_dragon_ball";
                using (MySqlCommand command = new MySqlCommand(sql, connection))
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        adapter.Fill(personajes);
                    }
                }
            }

            return personajes;
        }
        public int CrearPersonaje(string nombre, string raza, int nivelPoder, DateTime FechaCreacion, string historia)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string sql = "INSERT INTO personajes_dragon_ball (nombre, raza, nivel_poder, Fecha_Creacion, Historia) VALUES (@nombre, @raza, @nivelPoder, @FechaCreacion, @Historia)";
                using (MySqlCommand command = new MySqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@nombre", nombre);
                    command.Parameters.AddWithValue("@raza", raza);
                    command.Parameters.AddWithValue("@nivelPoder", nivelPoder);
                    command.Parameters.AddWithValue("@FechaCreacion", FechaCreacion.ToString("yyyy-MM-dd HH:mm:ss"));
                    command.Parameters.AddWithValue("@Historia", historia);
                    return command.ExecuteNonQuery();
                }
            }
        }
        public DataTable BuscarPersonajePorId(int id)
        {
            DataTable personaje = new DataTable();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string sql = "SELECT * FROM personajes_dragon_ball WHERE id = @id";
                using (MySqlCommand command = new MySqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@id", id);

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        adapter.Fill(personaje);
                    }
                }
            }

            return personaje;
        }
        public DataTable NombreBuscar(string nombre)
        {
            DataTable personaje2 = new DataTable();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string sql = "SELECT * FROM personajes_dragon_ball WHERE nombre = @nombre";
                using (MySqlCommand command = new MySqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@nombre", nombre);

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        adapter.Fill(personaje2);
                    }
                }
            }

            return personaje2;
        }
        public int ActualizarPersonaje(int id, string nombre, string raza, int nivelPoder, string historia)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string sql = "update personajes_dragon_ball set nombre=@nombre, raza=@raza, nivel_poder=@nivelPoder,historia=@historia where id=@id";
                using (MySqlCommand command = new MySqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@id", id);
                    command.Parameters.AddWithValue("@nombre", nombre);
                    command.Parameters.AddWithValue("@raza", raza);
                    command.Parameters.AddWithValue("@nivelPoder", nivelPoder);
                    command.Parameters.AddWithValue("@historia", historia);
                    return command.ExecuteNonQuery();
                }
            }
        }
        public int EliminarPersonaje(int id)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string sql = "DELETE FROM personajes_dragon_ball WHERE id = @id";
                using (MySqlCommand command = new MySqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@id", id);

                    return command.ExecuteNonQuery();
                }
            }
        }
    }

}
