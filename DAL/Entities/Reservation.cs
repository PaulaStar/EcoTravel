using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class Reservation
    {
        public int id_Reservation { get; set; }
        public DateTime dateArrivee { get; set; }
        public DateTime dateDepart { get; set; }
        public int nbAdulte { get; set; }
        public int nbEnfant { get; set; }
        public bool assurance { get; set; }
        public int id_Logement { get; set; }
        public int id_Client { get; set; }
    }
}
