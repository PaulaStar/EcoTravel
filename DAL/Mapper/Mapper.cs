using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public static class Mapper
    {
        public static Client ToClient(this IDataRecord record)
        {
            if (record is null) return null;
            return new Client()
            {
                id_Client = (int)record[nameof(Client.id_Client)],
                nom = (string)record[nameof(Client.nom)],
                prenom = (string)record[nameof(Client.prenom)],
                email = (string)record[nameof(Client.email)],
                password = "********",
                telephone = (int)record[nameof(Client.telephone)],
                pays = (string)record[nameof(Client.pays)],
            };
        }
        public static Logement ToLogement(this IDataRecord record)
        {
            if (record is null) return null;
            return new Logement()
            {
                id_Logement = (int)record[nameof(Logement.id_Logement)],
                nom = (string)record[nameof(Logement.nom)],
                adresseRue = (string)record[nameof(Logement.adresseRue)],
                adresseNumero = (string)record[nameof(Logement.adresseNumero)],
                adresseCodePostal = (string)record[nameof(Logement.adresseCodePostal)],
                adressePays = (string)record[nameof(Logement.adressePays)],
                latitude = (decimal)record[nameof(Logement.latitude)],
                longitude = (decimal)record[nameof(Logement.longitude)],
                descCourte = (string)record[nameof(Logement.descCourte)],
                descLongue = (string)record[nameof(Logement.descLongue)],
                nbChambre = (int)record[nameof(Logement.nbChambre)],
                nbPiece = (int)record[nameof(Logement.nbPiece)],
                nbPersonne = (int)record[nameof(Logement.nbPersonne)],
                nbDouche = (int)record[nameof(Logement.nbDouche)],
                nbWC = (int)record[nameof(Logement.nbWC)],
                balcon = (bool)record[nameof(Logement.balcon)],
                airCo = (bool)record[nameof(Logement.airCo)],
                wifi = (bool)record[nameof(Logement.wifi)],
                miniBar = (bool)record[nameof(Logement.miniBar)],
                animaux = (bool)record[nameof(Logement.animaux)],
                piscine = (bool)record[nameof(Logement.piscine)],
                voiturier = (bool)record[nameof(Logement.voiturier)],
                roomService = (bool)record[nameof(Logement.roomService)],
                prix = (int)record[nameof(Logement.prix)],
                dateCreation = (DateTime)record[nameof(Logement.dateCreation)],
                id_Proprietaire = (int)record[nameof(Logement.id_Proprietaire)],
                id_TypeLogement = (int)record[nameof(Logement.id_TypeLogement)]
            };
        }
        public static Reservation ToReservation(this IDataRecord record)
        {
            if (record is null) return null;
            return new Reservation()
            {
                id_Reservation = (int)record[nameof(Reservation.id_Reservation)],
                dateArrivee = (DateTime)record[nameof(Reservation.dateArrivee)],
                dateDepart = (DateTime)record[nameof(Reservation.dateDepart)],
                nbAdulte = (int)record[nameof(Reservation.nbAdulte)],
                nbEnfant = (int)record[nameof(Reservation.nbEnfant)],
                assurance = (bool)record[nameof(Reservation.assurance)],
                id_Logement = (int)record[nameof(Reservation.id_Logement)],
                id_Client = (int)record[nameof(Reservation.id_Client)],
            };
        }
        
    }
}

