using Drk.Core;
using Drk.Core.Interfaces;
using Drk.Core.ViewModels;
using FornitoriApp.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace FornitoriApp.ViewModels
{
    public class FornitoriViewModel: Notifiable, IViewModel
    {
        private IDataProvider<FornitoreDto> dataProvider;

        public ObservableCollection<FornitoreDto> Fornitori { get { return dataProvider.All(); } }
        public FornitoriViewModel() 
        {
            App app = Application.Current as App;
            InitializeData(app.Bootstrapper);
        }

        private void InitializeData(AppBootstrapper bootstrapper)
        { 
            dataProvider = bootstrapper.DataContainer.GetProvider<FornitoreDto>();
        }

        public void LoadData(object data)
        {
           
        }
    }
}
