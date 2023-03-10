using COMMON.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace COMMON.Repositories
{
    public interface ILogementRepository<TEntity, TId> : IRepository<TEntity, TId> where TEntity : ILogement
    {

    }
}
