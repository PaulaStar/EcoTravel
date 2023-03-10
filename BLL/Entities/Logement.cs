using COMMON.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Entities
{
    public class Logement : ILogement
    {
        public int id_Logement { get; set; }
        public string nom { get; set; }
        public string adresseRue { get; set; }
        public string adresseNumero { get; set; }
        public string adresseCodePostal { get; set; }
        public string adressePays { get; set; }
        public decimal latitude { get; set; }
        public decimal longitude { get; set; }
        public string descCourte { get; set; }
        public string descLongue { get; set; }
        public int nbChambre { get; set; }
        public int nbPiece { get; set; }
        public int nbPersonne { get; set; }
        public int nbDouche { get; set; }
        public int nbWC { get; set; }
        public bool balcon { get; set; }
        public bool airCo { get; set; }
        public bool wifi { get; set; }
        public bool miniBar { get; set; }
        public bool animaux { get; set; }
        public bool piscine { get; set; }
        public bool voiturier { get; set; }
        public bool roomService { get; set; }
        public int prix { get; set; }
        public DateTime dateCreation { get; set; }
        public int id_Proprietaire { get; set; }
        /*public Proprietaire proprietaire { get; set; }*/
        public int id_TypeLogement { get; set; }
        /*public Type_Logement type_Logement { get; set; }*/

    }
}
