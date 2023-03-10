using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EcoTravel___ASP.Models.ClientModelView
{
    public class ClientListItem
    {
        [DisplayName("Identitfiant")]
        [ScaffoldColumn(false)]
        public int id_Client { get; set; }
        [DisplayName("Nom :")]
        public string nom { get; set; }
        [DisplayName("Prénom :")]
        public string prenom { get; set; }
        [DisplayName("Email :")]
        public string email { get; set; }
        [DisplayName("Téléphone :")]
        public int telephone { get; set; }
        [DisplayName("Pays :")]
        public string pays { get; set; }
    }
}
