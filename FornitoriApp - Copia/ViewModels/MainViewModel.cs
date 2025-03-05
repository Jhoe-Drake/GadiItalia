using Drk.Core.Interfaces;
using Drk.Core.ViewModels;

using FornitoriApp.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace FornitoriApp.ViewModels
{
    public class MainViewModel:Notifiable, IShell
    {
        #region fields
        private IContentView _currentContent;

        #endregion

        #region properties
        public IContentView CurrentContent { get { return _currentContent; } set { _currentContent = value; OnPropertyChanged(); } }
        
        #endregion


        #region constructors
        public MainViewModel() 
        {
            InitializeViewModel();
        }
        #endregion

        #region methods

        private void InitializeViewModel() 
        {
            //App app = Application.Current as App;
            //var fornView = app.Bootstrapper.GetView<FornitoriView>();
            //CurrentContent = fornView;

            Navigate("Fornitori", 0);
            
            
        }

        
        public void Navigate(string destination, int level)
        {
            App app = Application.Current as App;
            var content = app.Bootstrapper.GetView(destination) as IContentView;
            SetContent(content);
            
            
        }

        public void SetContent(IContentView view)
        {
            CurrentContent = view;
            UpdateHeader(view.ContentName, view.ContentLevel);
        }

        private void UpdateHeader(string destination, int level)
        {
            App app = Application.Current as App;
            var header = app.Bootstrapper.GetViewModel<HeaderViewModel>();
            header.UpdateBreradCrumb(destination, destination, level);
        }


        #endregion
    }
}
