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
    /// Logica di interazione per FornitoreDetailsView.xaml
    /// </summary>
    public partial class FornitoreDetailsView : UserControl, IContentView
    {
        public event EventHandler<IViewModel> ContentLoaded;
        public string ContentName => "Dettaglio Fornitore";

        public int ContentLevel => 1;

        public FornitoreDetailsView()
        {
            InitializeComponent();
        }

        

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            App app = Application.Current as App;

            var vm = app.Bootstrapper.GetViewModel<FornioreDetailViewModel>();
            vm.PreviewPDFFileChanged += ViewModel_PreviewPDFFileChanged;
            


            DataContext = vm;
            OnContentLoaded();
        }

        

        private void ViewModel_PreviewPDFFileChanged(object source, Uri pdfFilePath)
        {
            pdfViewer.Navigate(pdfFilePath);
        }

        

        private void OnContentLoaded()
        {
            if (ContentLoaded != null)
                ContentLoaded(this, DataContext as IViewModel);
        }
        public IViewModel GetViewModel() 
        {
            return DataContext as IViewModel;
        }
    }
}
