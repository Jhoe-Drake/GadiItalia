using Drk.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drk.Core.Data
{
    public abstract class DataProviderBase<T,TEntity> where T : class
    {
        
        protected IEntityManager em;

        protected abstract T ToDto(TEntity entity);
        protected abstract TEntity ToEntity(T dto);
        
    }
}
