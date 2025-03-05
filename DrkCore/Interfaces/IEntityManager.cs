using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drk.Core.Interfaces
{
    public interface IEntityManager
    {
        IRepository<TEntity> GetRepository<TEntity>() where TEntity:class;
    }
}
