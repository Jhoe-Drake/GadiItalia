using Drk.Core;
using Drk.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Drk.Core.ViewModels
{
    public class BreadcrumbViewModel:Notifiable
    {
        
        #region fields
        private string _content;
        private object _data;
        private string _navigationParameter;
        private int _level;
        private INavigationContainer _navigatorContainer;
        #endregion

        #region properties
        public string Content { get => _content; set { _content = value; OnPropertyChanged(); } }
        public ICommand NavigateCommand { get; private set; }
        public string NavigationParameter { get => _navigationParameter; set { _navigationParameter = value; OnPropertyChanged(); } }
        public int Level { get => _level; }
        public bool IsEnabled { get; set; }
        #endregion

        #region constructors
        public BreadcrumbViewModel(string content,string destination, int level, INavigationContainer navigator, object data = null ) 
        {
            
            _navigatorContainer = navigator;

            InitializeViewModel(content, destination, level, data);
            InitializeCommands();
        }
        #endregion

        #region methods

        private void InitializeViewModel(string content,string destination, int level, object data)
        {
            _content = content;
            _data = data;
            _navigationParameter = destination;
            IsEnabled = true;
            _level = level;
        }
        private void InitializeCommands()
        {
            NavigateCommand = new Command(param => OnNavigation(param.ToString()), canExecute => true);
        }
        private void OnNavigation(string destination)
        { 
            _navigatorContainer.NavigateTo(destination, _level, _data);
        }
        #endregion
    }
}
