using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drk.Core.Interfaces
{
    public interface IContentView
    {
        event EventHandler<IViewModel> ContentLoaded;
        string ContentName { get; }
        int ContentLevel { get; }
        IViewModel GetViewModel();
    }
}
