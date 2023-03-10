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
    public class LogementService : BaseService, ILogementRepository<Logement, int>
    {
        public LogementService(IConfiguration config) : base(config, "DBEcoTravel")
        {

        }
        /*private string ConnectionString { get; set; } = @"Data Source=(localDB)\MSSQLlocaldb;Initial Catalog = DBEcoTravel; Integrated Security = True";*/

        public bool Delete(int id)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "DELETE FROM [Logement] WHERE [id_Logement] = @id";
                    command.Parameters.AddWithValue("id", id);
                    connection.Open();
                    return command.ExecuteNonQuery() > 0;
                }
            }
        }
        public IEnumerable<Logement> Get()
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "Select [id_Logement], [nom], [adresseRue], [adresseNumero], [adresseCodePostal], [adressePays], [latitude], [longitude], [descCourte], [descLongue], [nbChambre], [nbPiece], [nbPersonne], [nbDouche],[nbWC], [balcon], [airCo], [wifi], [miniBar],[animaux], [piscine], [voiturier], [roomService], [prix], [dateCreation], [id_Proprietaire], [id_TypeLogement] FROM [Logement]";
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            yield return reader.ToLogement();
                        }
                    }
                }
            }
        }

        public Logement Get(int id)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT [id_Logement], [nom], [adresseRue], [adresseNumero], [adresseCodePostal], [adressePays], [latitude], [longitude], [descCourte], [descLongue], [nbChambre], [nbPiece], [nbPersonne], [nbDouche],[nbWC], [balcon], [airCo], [wifi], [miniBar],[animaux], [piscine], [voiturier], [roomService], [prix], [dateCreation], [id_Proprietaire], [id_TypeLogement] FROM [Logement] WHERE [id_Logement] = @id";
                    command.Parameters.AddWithValue("id", id);
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read()) return reader.ToLogement();
                        return null;
                    }
                }
            }
        }

        public int Insert(Logement entity)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = @"INSERT INTO [Logement] ([nom], [adresseRue], [adresseNumero], [adresseCodePostal], [adressePays], [latitude], [longitude], [descCourte], [descLongue], [nbChambre], [nbPiece], [nbPersonne], [nbDouche],[nbWC], [balcon], [airCo], [wifi], [miniBar],[animaux], [piscine], [voiturier], [roomService], [prix], [dateCreation], [id_Proprietaire], [id_TypeLogement])
                            OUTPUT [inserted].[id_Logement] VALUES (@nom, @adresseRue, @adresseNumero, @adresseCodePostal, @adressePays, @latitude, @longitude, @descCourte, @descLongue, @nbChambre, @nbPiece, @nbPersonne, @nbDouche, @nbWC, @balcon, @airCo, @wifi, @miniBar, @animaux, @piscine, @voiturier, @roomService, @prix, @dateCreation, @id_Proprietaire, @id_TypeLogement)";
                    command.Parameters.AddWithValue("id_Logement", entity.id_Logement);
                    command.Parameters.AddWithValue("nom", entity.nom);
                    command.Parameters.AddWithValue("adresseRue", entity.adresseRue);
                    command.Parameters.AddWithValue("adresseNumero", entity.adresseNumero);
                    command.Parameters.AddWithValue("adresseCodePostal", entity.adresseCodePostal);
                    command.Parameters.AddWithValue("adressePays", entity.adressePays);
                    command.Parameters.AddWithValue("latitude", entity.latitude);
                    command.Parameters.AddWithValue("longitude", entity.longitude);
                    command.Parameters.AddWithValue("descCourte", entity.descCourte);
                    command.Parameters.AddWithValue("descLongue", entity.descLongue);
                    command.Parameters.AddWithValue("nbChambre", entity.nbChambre);
                    command.Parameters.AddWithValue("nbPiece", entity.nbPiece);
                    command.Parameters.AddWithValue("nbPersonne", entity.nbPersonne);
                    command.Parameters.AddWithValue("nbDouche", entity.nbDouche);
                    command.Parameters.AddWithValue("nbWC", entity.nbWC);
                    command.Parameters.AddWithValue("balcon", entity.balcon);
                    command.Parameters.AddWithValue("airCo", entity.airCo);
                    command.Parameters.AddWithValue("wifi", entity.wifi);
                    command.Parameters.AddWithValue("miniBar", entity.miniBar);
                    command.Parameters.AddWithValue("animaux", entity.animaux);
                    command.Parameters.AddWithValue("piscine", entity.piscine);
                    command.Parameters.AddWithValue("voiturier", entity.voiturier);
                    command.Parameters.AddWithValue("roomService", entity.roomService);
                    command.Parameters.AddWithValue("prix", entity.prix);
                    command.Parameters.AddWithValue("dateCreation", entity.dateCreation);
                    command.Parameters.AddWithValue("id_Proprietaire", entity.id_Proprietaire);
                    command.Parameters.AddWithValue("id_TypeLogement", entity.id_TypeLogement);
                    connection.Open();
                    return (int)command.ExecuteScalar();
                }
            }
        }

        public bool Update(int id, Logement entity)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = @"UPDATE [Logement] 
                                            SET [nom] = @nom, [adresseRue] = @adresseRue, [adresseNumero] = @adresseNumero, [adresseCodePostal] = @adresseCodePostal, [adressePays] = @adressePays, [latitude] = @latitude, [longitude] = @longitude, [descCourte] = @descCourte, [descLongue] = @descLongue, [nbChambre] = @nbChambre, [nbPiece] = @nbPiece, [nbPersonne] = @nbPersonne, [nbDouche] = @nbDouche, [nbWC] = @nbWC, [balcon] = @balcon, [airCo] = @airCo, [wifi] = @wifi, [miniBar] = @miniBar, [animaux] = @animaux, [piscine] = @piscine, [voiturier] = @voiturier, [roomService] = @roomService, [prix] = @prix, [dateCreation] = @dateCreation, [id_Proprietaire] = @id_Proprietaire, [id_TypeLogement] = @id_TypeLogement
                                WHERE [id_Logement] = @id";
                    command.Parameters.AddWithValue("nom", entity.nom);
                    command.Parameters.AddWithValue("adresseRue", entity.adresseRue);
                    command.Parameters.AddWithValue("adresseNumero", entity.adresseNumero);
                    command.Parameters.AddWithValue("adresseCodePostal", entity.adresseCodePostal);
                    command.Parameters.AddWithValue("adressePays", entity.adressePays);
                    command.Parameters.AddWithValue("latitude", entity.latitude);
                    command.Parameters.AddWithValue("longitude", entity.longitude);
                    command.Parameters.AddWithValue("descCourte", entity.descCourte);
                    command.Parameters.AddWithValue("descLongue", entity.descLongue);
                    command.Parameters.AddWithValue("nbChambre", entity.nbChambre);
                    command.Parameters.AddWithValue("nbPiece", entity.nbPiece);
                    command.Parameters.AddWithValue("nbPersonne", entity.nbPersonne);
                    command.Parameters.AddWithValue("nbDouche", entity.nbDouche);
                    command.Parameters.AddWithValue("nbWC", entity.nbWC);
                    command.Parameters.AddWithValue("balcon", entity.balcon);
                    command.Parameters.AddWithValue("airCo", entity.airCo);
                    command.Parameters.AddWithValue("wifi", entity.wifi);
                    command.Parameters.AddWithValue("miniBar", entity.miniBar);
                    command.Parameters.AddWithValue("animaux", entity.animaux);
                    command.Parameters.AddWithValue("piscine", entity.piscine);
                    command.Parameters.AddWithValue("voiturier", entity.voiturier);
                    command.Parameters.AddWithValue("roomService", entity.roomService);
                    command.Parameters.AddWithValue("prix", entity.prix);
                    command.Parameters.AddWithValue("dateCreation", entity.dateCreation);
                    command.Parameters.AddWithValue("id_Proprietaire", entity.id_Proprietaire);
                    command.Parameters.AddWithValue("id_TypeLogement", entity.id_TypeLogement);
                    command.Parameters.AddWithValue("id", id);
                    connection.Open();
                    return command.ExecuteNonQuery() > 0;
                }
            }
        }
    }
}
