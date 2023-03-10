using COMMON.Repositories;
using DAL.Entities;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Services
{
    public class ClientService : BaseService, IClientRepository<Client, int>
    {
        public ClientService(IConfiguration config) : base(config, "DBEcoTravel")
        {

        }
        /*private string ConnectionString { get; set; } = @"Data Source=(localDB)\MSSQLlocaldb;Initial Catalog = DBEcoTravel; Integrated Security = True";*/

        public IEnumerable<Client> Get()
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "Select [id_Client], [nom], [prenom], [email], [password], [telephone], [pays] FROM [Client]";
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            yield return reader.ToClient();
                        }
                    }
                }
            }
        }
        public Client Get(int id)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT [id_Client], [nom], [prenom], [email], [pays], '********' AS [password], [telephone] FROM [Client] WHERE [id_Client] = @id";
                    command.Parameters.AddWithValue("id", id);
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read()) return reader.ToClient();
                        return null;
                    }
                }
            }
        }
        public int Insert(Client entity)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = @"INSERT INTO [Client] ([nom], [prenom], [email], [password], [telephone], [pays])
                            OUTPUT [inserted].[id_Client] VALUES (@nom, @prenom, @email, HASHBYTES('SHA2_512', @password), @telephone, @pays)";
                    command.Parameters.AddWithValue("nom", entity.nom);
                    command.Parameters.AddWithValue("prenom", entity.prenom);
                    command.Parameters.AddWithValue("email", entity.email);
                    command.Parameters.AddWithValue("password", entity.password);
                    command.Parameters.AddWithValue("telephone", entity.telephone);
                    command.Parameters.AddWithValue("pays", entity.pays);
                    connection.Open();
                    return (int)command.ExecuteScalar();
                }
            }
        }
        public bool Update(int id, Client entity)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = @"UPDATE [Client] SET [nom] = @nom, [prenom] = @prenom, [email] = @email, [password] = @password, [telephone] = @telephone, [pays] = @pays";
                    command.Parameters.AddWithValue("nom", entity.nom);
                    command.Parameters.AddWithValue("prenom", entity.prenom);
                    command.Parameters.AddWithValue("email", entity.email);
                    command.Parameters.AddWithValue("password", entity.password);
                    command.Parameters.AddWithValue("telephone", entity.telephone);
                    command.Parameters.AddWithValue("pays", entity.pays);
                    connection.Open();
                    return command.ExecuteNonQuery() > 0;
                }
            }
        }
        public bool Delete(int id)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = @"DELETE FROM [Client] WHERE [id_Client] = @id";
                    command.Parameters.AddWithValue("id", id);
                    connection.Open();
                    return command.ExecuteNonQuery() > 0;
                }
            }
        }


        public int? CheckPassword(string email, string password)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT [id_Client] FROM [Client] WHERE [email] = @email AND [password] = @password";
                    SqlParameter p_email = new SqlParameter() { ParameterName = "@email", Value = email };
                    SqlParameter p_password = new SqlParameter() { ParameterName = "@password", Value = password };
                    command.Parameters.Add(p_email);
                    command.Parameters.Add(p_password);
                    connection.Open();
                    object result = command.ExecuteScalar();
                    return (int)result;
                    /*return (result is DBNull)int)result;*/
                }
            }
        }
    }
}
