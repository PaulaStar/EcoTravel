using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EcoTravel___ASP.Models.LogementModelView
{
    public class LogementDelete
    {
        [DisplayName("Identitfiant")]
        [ScaffoldColumn(false)]
        public int id_Logement { get; set; }
        [DisplayName("Nom :")]
        public string nom { get; set; }
        [DisplayName("Rue :")]
        public string adresseRue { get; set; }
        [DisplayName("Numéro :")]
        public string adresseNumero { get; set; }
        [DisplayName("Code Postal :")]
        public string adresseCodePostal { get; set; }
        [DisplayName("Pays :")]
        public string adressePays { get; set; }
        [DisplayName("Latitude :")]
        public decimal latitude { get; set; }
        [DisplayName("Longitude :")]
        public decimal longitude { get; set; }
        [DisplayName("Decription Courte :")]
        public string descCourte { get; set; }
        [DisplayName("Plus de détails :")]
        public string descLongue { get; set; }
        [DisplayName("Nombre de chambre :")]
        public int nbChambre { get; set; }
        [DisplayName("Nombre de pièce :")]
        public int nbPiece { get; set; }
        [DisplayName("Nombre de personne :")]
        public int nbPersonne { get; set; }
        [DisplayName("Nombre de salle de bain :")]
        public int nbDouche { get; set; }
        [DisplayName("Nombre de toilette :")]
        public int nbWC { get; set; }
        [DisplayName("Balcon :")]
        public bool balcon { get; set; }
        [DisplayName("Air conditionnée:")]
        public bool airCo { get; set; }
        [DisplayName("Wifi :")]
        public bool wifi { get; set; }
        [DisplayName("Mini Bar :")]
        public bool miniBar { get; set; }
        [DisplayName("Animaux autorisé :")]
        public bool animaux { get; set; }
        [DisplayName("Piscine :")]
        public bool piscine { get; set; }
        [DisplayName("Voiturier disponible :")]
        public bool voiturier { get; set; }
        [DisplayName("Room Service :")]
        public bool roomService { get; set; }
        [DisplayName("Prix du logement :")]
        public int prix { get; set; }
        [DisplayName("Date de création :")]
        public DateTime dateCreation { get; set; }
        [DisplayName("Identitfiant du propriétaire")]
        [ScaffoldColumn(false)]
        public int id_Proprietaire { get; set; }
        [DisplayName("Identitfiant du type de logement")]
        [ScaffoldColumn(false)]
        public int id_TypeLogement { get; set; }
    }
}
