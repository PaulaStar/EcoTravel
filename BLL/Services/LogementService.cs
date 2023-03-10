using BLL.Entities;
using D = DAL.Entities;
using COMMON.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class LogementService : ILogementRepository<Logement, int>
    {
        private readonly ILogementRepository<D.Logement, int> _repository;
        
        public LogementService(ILogementRepository<D.Logement, int> repository)
        {
            _repository = repository;
        }

        public IEnumerable<Logement> Get()
        {
            return _repository.Get().Select(e => e.ToBLL());
        }

        public Logement Get(int id)
        {
            throw new NotImplementedException();
        }

        public int Insert(Logement entity)
        {
            return _repository.Insert(entity.ToDAL());
        }

        public bool Update(int id, Logement entity)
        {
            return _repository.Update(id, entity.ToDAL());
        }
        public bool Delete(int id)
        {
            return _repository.Delete(id);
        }
    }
}
