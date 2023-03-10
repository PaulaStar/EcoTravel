using BLL.Entities;
using COMMON.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    class ReservationService : IRepository<Reservation, int>
    {
        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Reservation> Get()
        {
            throw new NotImplementedException();
        }

        public Reservation Get(int id)
        {
            throw new NotImplementedException();
        }

        public int Insert(Reservation entity)
        {
            throw new NotImplementedException();
        }

        public bool Update(int id, Reservation entity)
        {
            throw new NotImplementedException();
        }
    }
}
