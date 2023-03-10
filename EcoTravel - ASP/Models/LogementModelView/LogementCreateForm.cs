using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EcoTravel___ASP.Models.LogementModelView
{
    public class LogementCreateForm
    {
        [DisplayName("Identitfiant")]
        [ScaffoldColumn(false)]
        public int id_Proprietaire { get; set; }
        [Required]
        [MaxLength(50)]
        [MinLength(1)]
        [DisplayName("Nom : ")]
        public string nom { get; set; }
        [Required]
        [MaxLength(16)]
        [MinLength(1)]
        [DisplayName("Rue :")]
        public string adresseRue { get; set; }
        [Required]
        [MaxLength(16)]
        [MinLength(1)]
        [DisplayName("Numéro :")]
        public string adresseNumero { get; set; }
        [Required]
        [MaxLength(16)]
        [MinLength(1)]
        [DataType(DataType.PostalCode)]
        [DisplayName("Code Postal :")]
        public string adresseCodePostal { get; set; }
        [Required]
        [MaxLength(16)]
        [MinLength(1)]
        [DisplayName("Pays :")]
        public string adressePays { get; set; }
        [Required]
        [Range(-180, 180)]
        [DisplayName("Latitude :")]
        public decimal latitude { get; set; }
        [Required]
        [Range(-180, 180)]
        [DisplayName("Longitude :")]
        public decimal longitude { get; set; }
        [Required]
        [MaxLength(255)]
        [MinLength(1)]
        [DisplayName("Decription Courte :")]
        public string descCourte { get; set; }
        [Required]
        [MaxLength(1000)]
        [MinLength(1)]
        [DisplayName("Plus de détails :")]
        public string descLongue { get; set; }
        [Required]
        [DisplayName("Nombre de chambre :")]
        public int nbChambre { get; set; }
        [Required]
        [DisplayName("Nombre de pièce :")]
        public int nbPiece { get; set; }
        [Required]
        [DisplayName("Nombre de personne :")]
        public int nbPersonne { get; set; }
        [Required]
        [DisplayName("Nombre de salle de bain :")]
        public int nbDouche { get; set; }
        [Required]
        [DisplayName("Nombre de toilette :")]
        public int nbWC { get; set; }
        [Required]
        [DisplayName("Balcon :")]
        public bool balcon { get; set; }
        [Required]
        [DisplayName("Air conditionnée:")]
        public bool airCo { get; set; }
        [Required]
        [DisplayName("Wifi :")]
        public bool wifi { get; set; }
        [Required]
        [DisplayName("Mini Bar :")]
        public bool miniBar { get; set; }
        [Required]
        [DisplayName("Animaux autorisé :")]
        public bool animaux { get; set; }
        [Required]
        [DisplayName("Piscine :")]
        public bool piscine { get; set; }
        [Required]
        [DisplayName("Voiturier disponible :")]
        public bool voiturier { get; set; }
        [Required]
        [DisplayName("Room Service :")]
        public bool roomService { get; set; }
        [Required]
        [DataType(DataType.Currency)]
        [DisplayName("Prix du logement :")]
        public int prix { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [DisplayName("Date de création :")]
        public DateTime dateCreation { get; set; }
    }
}
