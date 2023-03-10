using BLL.Entities;
using EcoTravel___ASP.Models.ClientModelView;
using EcoTravel___ASP.Models.LogementModelView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcoTravel___ASP.Handlers
{
    public static class Mapper
    {
        public static ClientListItem ToListItem(this Client entity)
        {
            if (entity is null) return null;
            return new ClientListItem()
            {
                id_Client = entity.id_Client,
                nom = entity.nom,
                prenom = entity.prenom,
                email = entity.email,
                telephone = entity.telephone,
                pays = entity.pays
            };
        }
        public static BLL.Entities.Client ToBLL(this ClientCreateForm entity)
        {
            if (entity is null) return null;
            return new BLL.Entities.Client()
            {
                nom = entity.nom,
                prenom = entity.prenom,
                email = entity.email,
                telephone = entity.telephone,
                pays = entity.pays,
                password = entity.password,
                confirmPass = entity.confirmPass,
            };
        }
        public static ClientDetails ToDetails(this Client entity)
        {
            if (entity is null) return null;
            return new ClientDetails()
            {
                nom = entity.nom,
                prenom = entity.prenom,
                email = entity.email,
                telephone = entity.telephone,
                pays = entity.pays
            };
        }
        public static LogementListItem ToListItem(this Logement entity)
        {
            if (entity is null) return null;
            return new LogementListItem()
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
        public static Logement ToBLL(this LogementCreateForm entity)
        {
            if (entity is null) return null;
            return new Logement()
            {
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
            };
        }
    }
}
