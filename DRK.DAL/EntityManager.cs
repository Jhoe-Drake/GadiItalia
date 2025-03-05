using Drk.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drk.DAL
{
    public class EntityManager : IEntityManager
    {
        private GadiItaliaEntities entityesContext;
        public EntityManager()
        {
            entityesContext = new GadiItaliaEntities();
            var first = entityesContext.Fornitori.First();
        }

        public IRepository<TEntity> GetRepository<TEntity>() where TEntity : class
        {
            
            var dbSet = entityesContext.Set<TEntity>();
            var repo = new Repository<TEntity>(dbSet);

            return repo;
            
        }
    }
}
