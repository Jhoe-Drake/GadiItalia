using Drk.Core.Interfaces;
using FornitoriApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FornitoriApp.Views
{
    /// <summary>
    /// Logica di interazione per FornitoriView.xaml
    /// </summary>
    public partial class FornitoriView : UserControl, IContentView
    {
        public FornitoriView()
        {
            InitializeComponent();
        }

        public string ContentName => "Fornitori";

        public int ContentLevel => 0;

        public event EventHandler<IViewModel> ContentLoaded;

        public IViewModel GetViewModel()
        {
            return DataContext as IViewModel;
        }

        private void DataGrid_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            App app = Application.Current as App;
            DataGrid dataGrid = sender as DataGrid;
            string destination = "Dettaglio Fornitore";
            int levelDetail = 1;


            INavigationContainer navigator = app.Bootstrapper.NavigationContainer;
            if (dataGrid != null)
                navigator.NavigateTo(destination, levelDetail, dataGrid.SelectedItem);
            else
                navigator.NavigateTo(destination, levelDetail, null);


        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            App app = Application.Current as App;

            var vm = app.Bootstrapper.GetViewModel<FornitoriViewModel>();

            DataContext = vm;
            OnContentLoaded();
        }
        private void OnContentLoaded()
        {
            if (ContentLoaded != null)
                ContentLoaded(this, DataContext as IViewModel);
        }
    }
}
