using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class Client
    {
        public int id_Client { get; set; }
        public string nom { get; set; }
        public string prenom { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string CheckPassword { get; set; }

        public int telephone { get; set; }
        public string pays { get; set; }
    }
}
