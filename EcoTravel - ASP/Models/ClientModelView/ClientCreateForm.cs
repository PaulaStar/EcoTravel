using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EcoTravel___ASP.Models.ClientModelView
{
    public class ClientCreateForm
    {
        [Required]
        [MaxLength(50)]
        [MinLength(1)]
        [DisplayName("Nom : ")]
        public string nom { get; set; }
        [Required]
        [MaxLength(50)]
        [MinLength(1)]
        [DisplayName("Prénom : ")]
        public string prenom { get; set; }
        [Required]
        [MaxLength(250)]
        [MinLength(5)]
        [EmailAddress]
        [DisplayName("Adresse email : ")]
        public string email { get; set; }
       
        [Required]
        [DisplayName("Téléphone : ")]
        public int telephone { get; set; }
        [Required]
        [MaxLength(50)]
        [MinLength(5)]
        [DisplayName("Pays : ")]
        public string pays { get; set; } 
        [Required]
        [MaxLength(64)]
        [MinLength(8)]
        [DataType(DataType.Password)]
        [DisplayName("Mot de passe : ")]
        public string password { get; set; }
        [Required]
        [MaxLength(64)]
        [MinLength(8)]
        [DataType(DataType.Password)]
        [Compare(nameof(password))]
        [DisplayName("Confirmez le mot de passe : ")]
        public string confirmPass { get; set; }

    }
}
