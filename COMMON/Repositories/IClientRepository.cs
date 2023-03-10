using System;
using System.Collections.Generic;
using System.Text;

namespace COMMON.Repositories
{
    public interface IClientRepository<TEntity, Tid> : IRepository<TEntity, Tid>
    {
        int? CheckPassword(string email, string password);
    }
}
