using Drk.Core.Localization;
using Drk.Core.Utilities;
using Drk.Core.Interfaces;

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.IO.Packaging;
using System.Reflection;


namespace Drk.Core
{
    public class AppBootstrapper
    {
        #region fields
        private Dictionary<Type, object> viewModelsContainer;
        private Dictionary<Type, Tuple<string,object>> viewContainer;

        private INavigationContainer _navigationContainer;
        private IShell _shell;

        private IDataContainer _dataContainer;
        

        private ObservableCollection<Language> _appLanguages;
        private Language _defaultLang;
        private ResourceManager _resourceManager;
        private string _rootPath;
        #endregion

        #region properties
        public IDataContainer DataContainer { get => _dataContainer; }
        public INavigationContainer NavigationContainer { get => _navigationContainer; }
        public IShell Shell { get => _shell; }
        public ObservableCollection<Language> Languages { get => _appLanguages; }
        public Language DefaultLanguage { get => _defaultLang; }
        public ResourceManager ResourceManager { get => _resourceManager; }
        public string ApplicationRootPath { get => _rootPath; }
        #endregion

        #region constructors
        public AppBootstrapper() 
        { 
            viewModelsContainer = new Dictionary<Type, object>();
            viewContainer = new Dictionary<Type, Tuple<string, object>>();
            _appLanguages = new ObservableCollection<Language>();

            
           _rootPath = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData);
        }
        #endregion


        #region methods
        public void RegisterResourceManager(ResourceManager resourceManager)
        { 
            _resourceManager = resourceManager;
        }
        public void RegisterShell(IShell shell)
        { 
            _shell = shell;
        }
        public void RegisterDataContainer(IDataContainer container)
        { 
            _dataContainer = container;
        }

        public void RegisterNavigator(INavigationContainer navigator)
        {
            _navigationContainer = navigator;
        }
        public void RegisterViewModel(Type viewModelType, object viewModel)
        {
            if (viewModelsContainer.ContainsKey(viewModelType))
                throw new Exception("View Model already Registered!");

            viewModelsContainer.Add(viewModelType, viewModel);
        }
        public void RegisterViewModel<T>(T viewModel) where T : class
        {
            Type type = typeof(T);
            if (viewModelsContainer.ContainsKey(type))
                throw new Exception("View Model already Registered!");

            viewModelsContainer.Add(type, viewModel);
        }
        public object GetViewModel(Type viewModelType) 
        {
            object viewModel = null;
            if(viewModelsContainer.ContainsKey(viewModelType))
               viewModel = viewModelsContainer[viewModelType];

            return viewModel;


        }
        public T GetViewModel<T>() where T : class
        {
            Type type = typeof(T);
            T viewModel = default(T);

            if (viewModelsContainer.ContainsKey(type))
                viewModel = viewModelsContainer[type] as T;

            return viewModel;


        }

        public void RegisterView(Type viewType, object view, string destinationName = null)
        {
            
            if (viewContainer.ContainsKey(viewType))
                throw new Exception("View already Registered!");

            if(destinationName is null)
                destinationName = viewType.Name;
            var tupla = new Tuple<string, object>(destinationName, view);
            viewContainer.Add(viewType, tupla);
        }
        public void RegisterView<T>(T view, string destinationName = null) where T : class
        {
            Type type = typeof(T);
            if (viewContainer.ContainsKey(type))
                throw new Exception("View Model already Registered!");
            
            if (destinationName is null)
                destinationName = type.Name;
            var tupla = new Tuple<string, object>(destinationName, view);

            viewContainer.Add(type, tupla);
        }

        
        public object GetView(Type viewType)
        {
            object view = null;
            if (viewContainer.ContainsKey(viewType))
            {
                var tupla = viewContainer[viewType];
                view = tupla.Item2;
            }

            return view;


        }
        public object GetView(string destinationName)
        { 
            object view = null;
            var key = viewContainer.FirstOrDefault(x => x.Value.Item1.Equals(destinationName, StringComparison.InvariantCultureIgnoreCase)).Value;
            if (key != null)
                view = key.Item2;
            return view;
        }
        public T GetView<T>(string destinationName = null) where T : class
        {
            Type type = typeof(T);
            T view = default(T);
            if(destinationName is null)
                destinationName = type.Name;
            view = GetView(destinationName) as T;

            //if (viewContainer.ContainsKey(type))
            //{
            //    view = viewContainer[type] as T;
            //}

            return view;


        }

        public void InitializeLanaguages(List<string> supportedLangs, string defaultLang)
        {
            var defaultLanguage = LanguagesUtilities.GetLanguage(defaultLang);
            foreach (var lang in supportedLangs)
            {
                var langs = LanguagesUtilities.GetLanguage(lang);
                var language = new Language()
                {
                    Code = langs,
                    Culture = LanguagesUtilities.GetCultureName(langs),
                    Description = langs.GetDescription()


                };

                Languages.Add(language);
                if (defaultLanguage == language.Code)
                    _defaultLang = language;
            }
        }
        #endregion
    }
}
