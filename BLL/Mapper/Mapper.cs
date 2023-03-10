using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.Entities;
using DAL.Entities;

namespace BLL
{
    public static class Mapper
    {
        public static BLL.Entities.Client ToBLL(this DAL.Entities.Client entity)
        {
            /*if (entity is null) return null;*/
            return new BLL.Entities.Client()
            {
                id_Client = entity.id_Client,
                nom = entity.nom,
                prenom = entity.prenom,
                email = entity.email,
                password = entity.password,
                telephone = entity.telephone,
                pays = entity.pays
            };

        }
        public static DAL.Entities.Client ToDAL(this BLL.Entities.Client entity)
        {
            if (entity is null) return null;
            return new DAL.Entities.Client()
            {
                id_Client = entity.id_Client,
                nom = entity.nom,
                prenom = entity.prenom,
                email = entity.email,
                password = entity.password,
                telephone = entity.telephone,
                pays = entity.pays
            };

        }

        public static BLL.Entities.Logement ToBLL(this DAL.Entities.Logement entity)
        {
            /*if (entity is null) return null;*/
            return new BLL.Entities.Logement()
            {
                 id_Logement = entity.id_Logement,
                 nom = entity.nom,
                 adresseRue = entity.adresseRue,
                 adresseNumero = entity.adresseNumero,
                 adresseCodePostal = entity.adresseCodePostal,
                 adressePays = entity.adressePays,
                 latitude = entity.latitude,
                 longitude = entity.longitude,
                 descCourte = entity.descCourte,
                 descLongue = entity.descLongue,
                 nbChambre = entity.nbChambre,
                 nbPiece = entity.nbPiece,
                 nbPersonne = entity.nbPersonne,
                 nbDouche = entity.nbDouche,
                 nbWC = entity.nbWC,
                 balcon = entity.balcon,
                 airCo = entity.airCo,
                 wifi = entity.wifi,
                 miniBar = entity.miniBar,
                 animaux = entity.animaux,
                 piscine = entity.piscine,
                 voiturier = entity.voiturier,
                 roomService = entity.roomService,
                 prix = entity.prix,
                 dateCreation = entity.dateCreation,
                 id_Proprietaire = entity.id_Proprietaire,
                 id_TypeLogement = entity.id_TypeLogement
            };

        }
        public static DAL.Entities.Logement ToDAL(this BLL.Entities.Logement entity)
        {
            if (entity is null) return null;
            return new DAL.Entities.Logement()
            {
                id_Logement = entity.id_Logement,
                nom = entity.nom,
                adresseRue = entity.adresseRue,
                adresseNumero = entity.adresseNumero,
                adresseCodePostal = entity.adresseCodePostal,
                adressePays = entity.adressePays,
                latitude = entity.latitude,
                longitude = entity.longitude,
                descCourte = entity.descCourte,
                descLongue = entity.descLongue,
                nbChambre = entity.nbChambre,
                nbPiece = entity.nbPiece,
                nbPersonne = entity.nbPersonne,
                nbDouche = entity.nbDouche,
                nbWC = entity.nbWC,
                balcon = entity.balcon,
                airCo = entity.airCo,
                wifi = entity.wifi,
                miniBar = entity.miniBar,
                animaux = entity.animaux,
                piscine = entity.piscine,
                voiturier = entity.voiturier,
                roomService = entity.roomService,
                prix = entity.prix,
                dateCreation = entity.dateCreation,
                id_Proprietaire = entity.id_Proprietaire,
                id_TypeLogement = entity.id_TypeLogement
            };

        }

        public static BLL.Entities.Reservation ToBLL(this DAL.Entities.Reservation entity)
        {
            /*if (entity is null) return null;*/
            return new BLL.Entities.Reservation()
            {
                id_Reservation = entity.id_Reservation,
                dateArrivee = entity.dateArrivee,
                dateDepart = entity.dateDepart,
                nbAdulte = entity.nbAdulte,
                nbEnfant = entity.nbEnfant,
                assurance = entity.assurance,
                id_Logement = entity.id_Logement,
                id_Client = entity.id_Client
            };
        }
        public static DAL.Entities.Reservation ToDAL(this BLL.Entities.Reservation entity)
        {
            if (entity is null) return null;
            return new DAL.Entities.Reservation()
            {
                id_Reservation = entity.id_Reservation,
                dateArrivee = entity.dateArrivee,
                dateDepart = entity.dateDepart,
                nbAdulte = entity.nbAdulte,
                nbEnfant = entity.nbEnfant,
                assurance = entity.assurance,
                id_Logement = entity.id_Logement,
                id_Client = entity.id_Client
            };

        }
    }
}
