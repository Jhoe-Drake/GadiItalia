using Drk.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Drk.DAL
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        private DbSet<TEntity> _dbSet;
        public Repository(DbSet<TEntity> dbSet) 
        { 
            _dbSet = dbSet;
        }
        public List<TEntity> All()
        {
            return _dbSet.AsEnumerable().ToList();
        }

        public void Delete(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public TEntity Find(int id)
        {
            throw new NotImplementedException();
        }

        public List<TEntity> FindBy(Func<TEntity, bool> predicate)
        {
            List<TEntity> list = new List<TEntity>();
            list = _dbSet.Where(predicate).ToList();

            return list;

        }

        public TEntity FindOneBy()
        {
            throw new NotImplementedException();
        }

        public void Save(TEntity entity)
        {
            throw new NotImplementedException();
        }
    }


}
