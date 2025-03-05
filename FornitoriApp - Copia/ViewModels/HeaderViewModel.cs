using Drk.Core;
using Drk.Core.Interfaces;
using Drk.Core.ViewModels;

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace FornitoriApp.ViewModels
{
    public class HeaderViewModel: Notifiable, IViewModel
    {
        #region fields
        private ObservableCollection<BreadcrumbViewModel> _breadcrumbs;
        #endregion

        #region properties
        public ICommand QuitCommand { get; private set; }
        public ObservableCollection<BreadcrumbViewModel> Breadcrumbs { get => _breadcrumbs; set { _breadcrumbs = value; OnPropertyChanged(); } }
        #endregion

        #region contructors

        public HeaderViewModel() 
        { 
            InitializeViewModel();
            InitializeCommands();
        }
        #endregion

        #region methods

        public void UpdateBreradCrumb(string crumb, string destination, int level)
        {
            if (_breadcrumbs.Count >= level)
            { 
                var toRemove = _breadcrumbs.Where(x=> x.Level >= level).ToList();
                foreach (var item in toRemove) 
                    _breadcrumbs.Remove(item);

            }
            App application = Application.Current as App;
            var crumbVM = new BreadcrumbViewModel(crumb, destination, level, application.Bootstrapper.NavigationContainer);
            
            if (Breadcrumbs.Count > 0)
            {
                var divider = CreateDividerElement(level);
                _breadcrumbs.Add(divider);
            }
            Breadcrumbs.Add(crumbVM);
            OnPropertyChanged(nameof(Breadcrumbs));
        }
        private void InitializeViewModel()
        { 
            _breadcrumbs = new ObservableCollection<BreadcrumbViewModel>();

        }
        private void InitializeCommands()
        {
            QuitCommand = new Command(param =>  QuitApplication(), canExecute => true);
        }

        private void QuitApplication()
        { 
            Application.Current.Shutdown();
        }
        private BreadcrumbViewModel CreateDividerElement(int level)
        {
            var divider = new BreadcrumbViewModel("/", string.Empty, level, null)
            {
                IsEnabled = false
            };
            return divider;
        }

        public void LoadData(object data)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
