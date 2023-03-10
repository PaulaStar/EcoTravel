using COMMON.Repositories;
using DAL.Entities;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Services
{
    class ReservationService : BaseService, IReservationRepository<Reservation, int>
    {
        /*private string ConnectionString { get; set; } = @"Data Source=(localDB)\MSSQLlocaldb;Initial Catalog = DBEcoTravel; Integrated Security = True";*/
        public ReservationService(IConfiguration config) : base(config, "Theatre-DB")
        {
        }


        public IEnumerable<Reservation> Get()
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "Select [id_Reservation], [dateArrivee], [dateDepart], [nbAdulte], [nbEnfant], [Assurance], [id_Logement], [id_Client] FROM [Reservation]";
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            yield return Mapper.ToReservation(reader);
                        }
                    }
                }
            }
        }

        public Reservation Get(int id)
        {
            throw new NotImplementedException();
        }

        public int Insert(Reservation entity)
        {
            throw new NotImplementedException();
        }

        public bool Update(int id, Reservation entity)
        {
            throw new NotImplementedException();
        }
        public bool Delete(int id)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "DELETE FROM [Representation] WHERE [idRespresentation] = @id";
                    command.Parameters.AddWithValue("id", id);
                    connection.Open();
                    return command.ExecuteNonQuery() > 0;
                }
            }
        }
    }
}
