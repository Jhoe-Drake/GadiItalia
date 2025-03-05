using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drk.Core.Interfaces
{
    public interface IDataProvider
    {
        ObservableCollection<IDto> All();
        IDto Get(int id);
        ObservableCollection<IDto> GetBy();
        void Add(IDto entity);
        void Delete(int id);
    }

    public interface IDataProvider<TDto>
    {
        ObservableCollection<TDto> All();
        TDto Get(int id);
        ObservableCollection<TDto> GetBy( Func<TDto, bool> predicate);
        void Add(TDto entity);
        void Delete(int id);
    }
}
