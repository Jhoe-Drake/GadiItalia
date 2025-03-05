using Drk.Core.Utilities;
using Drk.Core;

using FornitoriApp.DataProviders;
using FornitoriApp.Models;
using FornitoriApp.Utilities;
using FornitoriApp.ViewModels;
using FornitoriApp.Views;
using System.Configuration;
using System.Data;
using System.Windows;
using System.Xml.XPath;
using Drk.Core.Interfaces;
using System.IO;

namespace FornitoriApp
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public AppBootstrapper Bootstrapper { get; private set; }
        public App()
        {
            Bootstrapper = new AppBootstrapper();
        }

        private void Application_Startup(object sender, StartupEventArgs e)
        {
            if (sender is App app)
            { 
               InitializeAppBootstrapper(app);
               InitializeWithMokData(app);
            }
        }

        private void InitializeAppBootstrapper(App application)
        {
            var bootstrapper = application.Bootstrapper;
            LoadConfigurations(bootstrapper);
            bootstrapper.RegisterResourceManager(FornitoriApp.Properties.Resources.ResourceManager);
            
            var navigator = new NavigatorController();
            bootstrapper.RegisterNavigator(navigator);

            RegisterDataContainer(bootstrapper);
         
            RegisterViews(bootstrapper);
            RegisterViewModels(bootstrapper);

            var shell = Bootstrapper.GetViewModel<MainViewModel>() as IShell;
            bootstrapper.RegisterShell(shell);


            InitializeDataAccess();


            
            
            
        }

        private void InitializeDataAccess()
        {
            
        }

        private void LoadConfigurations(AppBootstrapper bootstrapper)
        {
            var languages = ConfigurationManager.AppSettings["languages"].Split(";");
            var defLang = ConfigurationManager.AppSettings["default_language"].ToString();
            bootstrapper.InitializeLanaguages(languages.ToList(), defLang);

            LanguagesUtilities.ChangeLanguage(bootstrapper.DefaultLanguage.Code);

            string assetPath = Path.Combine(bootstrapper.ApplicationRootPath,Constants.ApplicationFolder, Constants.AssetsFolderName);
            if(!Directory.Exists(assetPath))
                Directory.CreateDirectory(assetPath);

            if (!Directory.Exists(Path.Combine(assetPath, Constants.ImagesFolderName)))
               Directory.CreateDirectory(Path.Combine(assetPath, Constants.ImagesFolderName));

            if (!Directory.Exists(Path.Combine(assetPath, Constants.TemplatesFolderName)))
                Directory.CreateDirectory(Path.Combine(assetPath, Constants.TemplatesFolderName));

            if (!Directory.Exists(Path.Combine(assetPath, Constants.TempPdfFolderName)))
                Directory.CreateDirectory(Path.Combine(assetPath, Constants.TempPdfFolderName));

        }

        private void RegisterViews(AppBootstrapper bootstrapper)
        {
            bootstrapper.RegisterView(new FornitoriView(), "Fornitori");
            bootstrapper.RegisterView(new FornitoreDetailsView(), "Dettaglio Fornitore");
            
        }

        private void RegisterViewModels(AppBootstrapper bootstrapper)
        {
            bootstrapper.RegisterViewModel(new FornitoriViewModel());
            bootstrapper.RegisterViewModel(new FornioreDetailViewModel());
            bootstrapper.RegisterViewModel(new HeaderViewModel());


            bootstrapper.RegisterViewModel(new MainViewModel());


        }

        private void RegisterDataContainer(AppBootstrapper bootstrapper)
        {

            bootstrapper.RegisterDataContainer(new DataContainer());
        }

        private void InitializeWithMokData(App application)
        {
            IDataContainer dataContainer = application.Bootstrapper.DataContainer;
            IDataProvider<FornitoreDto> provider = dataContainer.GetProvider<FornitoreDto>();

            


        }
    }

}
