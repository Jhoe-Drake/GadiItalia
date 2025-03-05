using Drk.DAL;
using Drk.Core.Interfaces;
using FornitoriApp.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FornitoriApp.DataProviders
{
    public class DataContainer: IDataContainer
    {
        
        
        private readonly IDataProvider<FornitoreDto> _fornitoriProvider;
        private IEntityManager _entityManager;

        private Dictionary<Type, object> _dataproviders;
        public IEntityManager EntityManager { get { return _entityManager; } }
        public IDataProvider<FornitoreDto> FornitoriProvider { get => _fornitoriProvider; }
        public DataContainer() 
        {
            _dataproviders = new Dictionary<Type, object>();

            _entityManager = new EntityManager();
            _fornitoriProvider = new FornitoriDataProvider(_entityManager);

            
            _dataproviders.Add(typeof(FornitoreDto), _fornitoriProvider);
        }

        public IDataProvider<T> GetProvider<T>() where T : class 
        {
            Type type = typeof(T);
            IDataProvider<T> provider = null;
            if (_dataproviders.ContainsKey(type))
                provider = _dataproviders[type] as IDataProvider<T>;

            return provider;
        }

        
    }


    
}
