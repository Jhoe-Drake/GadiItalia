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
    /// Logica di interazione per HeaderBar.xaml
    /// </summary>
    public partial class HeaderBar : UserControl
    {
        public HeaderBar()
        {
            InitializeComponent();
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            App app = Application.Current as App;

            var vm = app.Bootstrapper.GetViewModel<HeaderViewModel>();

            DataContext = vm;
        }
    }
}
