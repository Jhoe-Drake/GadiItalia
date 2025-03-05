using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drk.Core.Interfaces
{
    public interface INavigationContainer
    {
        void NavigateTo(Type type, int level, object data);
        void NavigateTo(string destination, int level, object data);
    }
}
