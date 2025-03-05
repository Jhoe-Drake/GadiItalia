using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drk.Core.Interfaces
{
    public interface IViewModel: IViewModel<object>
    {
        
    }

    public interface IViewModel<T> where T : class
    {
        void LoadData(T data);
    }
}
