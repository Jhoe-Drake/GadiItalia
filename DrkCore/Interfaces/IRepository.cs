using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drk.Core.Interfaces
{
    public interface IRepository :IRepository<object>
    {
        
    }
    public interface IRepository<TEntity> where TEntity : class
    {
        List<TEntity> All();
        List<TEntity> FindBy(Func<TEntity, bool> predicate);
        TEntity FindOneBy();
        TEntity Find(int id);

        void Delete(TEntity entity);
        void Save(TEntity entity);
    }
}
