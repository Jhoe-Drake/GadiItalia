using Drk.Core.Localization;
using Drk.Core.Utilities;
using Drk.Core.Interfaces;
using Drk.Core.ViewModels;
using Drk.Core;


using FornitoriApp.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.IO.Packaging;
using System.IO;
using FornitoriApp.Utilities;
using System.Diagnostics;
using System.Threading;



namespace FornitoriApp.ViewModels
{
    public class FornioreDetailViewModel: Notifiable, IViewModel, IViewModel<FornitoreDto>
    {
        #region events 
        public delegate void PreviewPDFFileEventHandler(object source, Uri pdfFilePath);
        public event PreviewPDFFileEventHandler PreviewPDFFileChanged;

        
        public event PreviewPDFFileEventHandler PreviewPDFFileChanging;

        public delegate void PrintPreviewFileEventHandler();
        public event PrintPreviewFileEventHandler PrintPreviewFile;

        #endregion
        #region fields
        
        private Language _selectedLang;
        private string _previousfile;
        private ObservableCollection<Language> _languages;
        private ResourceManager _resources;
        private FornitoreDto _model;
        
        private string _tempPdfpreviewName;
        #endregion

        #region properties

       
        public ObservableCollection<Language> Languages { get => _languages; set { _languages = value; OnPropertyChanged(); } }
        public FornitoreDto Fornitore { get => _model; }
        public Language SelectedLanguage
        { 
            get => _selectedLang; 
            set 
            {
                _previousfile = GetPDFPreviewPath();
                _selectedLang = value; 
                OnPropertyChanged(); 
                UpdateLanguage(_selectedLang);

                OnPreviewPDFFileChanging();
                

                if (_model != null)
                    CreatePreviewPDF();

                OnPreviewPDFFileChanged();

            } 
        }
        public Uri PdfPreviewFileUri { get { return GetPDFPreviewUri(); }  }

        public string CodiceFornitoreText { get => LanguagesUtilities.GetString("CodiceFornitoreText", _resources); }
        public string NomeFornitoreText { get => LanguagesUtilities.GetString("NomeFornitoreText", _resources); }
        public string NomeInternoText { get => LanguagesUtilities.GetString("NomeInternoText", _resources); }
        public string ActivitiesText { get => LanguagesUtilities.GetString("ActivitiesText", _resources); }
        public string DestinazioneText { get => LanguagesUtilities.GetString("DestinazioneText", _resources); }
        public string ResponsabileText { get => LanguagesUtilities.GetString("ResponsabileText", _resources); }
        public string IndirizzoText { get => LanguagesUtilities.GetString("IndirizzoText", _resources); }
        public string ComuneText { get => LanguagesUtilities.GetString("ComuneText", _resources); }
        public string CAPText { get => LanguagesUtilities.GetString("CAPText", _resources); }
        public string ProvinciaText { get => LanguagesUtilities.GetString("ProvinciaText", _resources); }
        public string StatoText { get => LanguagesUtilities.GetString("StatoText", _resources); }
        public string ImmaginiText { get => LanguagesUtilities.GetString("ImmaginiText", _resources); }

        #endregion

        #region constructors
        public FornioreDetailViewModel() 
        { 
           
            App application = Application.Current as App;
            _resources = application.Bootstrapper.ResourceManager;
           
            _tempPdfpreviewName = string.Empty;
           

            InitializeViewModel(application.Bootstrapper);
            InitializeCommands();
            

        }
        #endregion

        #region methods

        private void InitializeViewModel(AppBootstrapper bootstrapper)
        {
            _languages = new ObservableCollection<Language>();
            foreach (Language language in bootstrapper.Languages)
            {
                _languages.Add(language);
            }
            
            SelectedLanguage = bootstrapper.DefaultLanguage;

           
        }

        private void InitializeCommands()
        {
           
        }
        private void UpdateLanguage(Language updatedLang)
        {
            LanguagesUtilities.ChangeLanguage(updatedLang.Code);

            OnPropertyChanged(nameof(CodiceFornitoreText));
            OnPropertyChanged(nameof(NomeFornitoreText));
            OnPropertyChanged(nameof(NomeInternoText));
            OnPropertyChanged(nameof(ActivitiesText));
            OnPropertyChanged(nameof(DestinazioneText));
            OnPropertyChanged(nameof(ResponsabileText));
            OnPropertyChanged(nameof(IndirizzoText));
            OnPropertyChanged(nameof(ComuneText));
            OnPropertyChanged(nameof(CAPText));
            OnPropertyChanged(nameof(ProvinciaText));
            OnPropertyChanged(nameof(StatoText));
            OnPropertyChanged(nameof(ImmaginiText));

        }

       

        

        
        private void UpdateModelImagePaths()
        {
            App application = Application.Current as App;
            var bootstrapper = application.Bootstrapper;
            string imageBasePath = Path.Combine(bootstrapper.ApplicationRootPath,Constants.ApplicationFolder, Constants.AssetsFolderName, Constants.ImagesFolderName);
            foreach (var immagine in _model.Immagini)
            {
                immagine.BasePath = imageBasePath;
            }
        }
        private Dictionary<string, string> GetTemplateLabels()
        {
            Dictionary<string, string> labels = new Dictionary<string, string>()
            {
                { "CodiceFornitore", CodiceFornitoreText },
                { "NomeFornitore", NomeFornitoreText },
                { "NomeInterno", NomeInternoText },
                { "Activities", ActivitiesText },
                { "Responsabile", ResponsabileText },
                { "Destinazione", DestinazioneText },
                { "Indirizzo", IndirizzoText },
                { "Comune", ComuneText },
                { "CAP", CAPText },
                { "Provincia", ProvinciaText },
                { "Stato", StatoText },
                { "Immagini", ImmaginiText },

            };
            


            return labels;
        }
        private object CreateTemplateModelData()
        {
            var labels = GetTemplateLabels();
            var tplModel = _model;
            List<string> immaginilist = new List<string>();
            tplModel.Immagini.ForEach(x =>
            {
                immaginilist.Add(x.FullPath);
            });

            return new
            {
                lbl_condice_fornitore = CodiceFornitoreText,
                lbl_stato = StatoText,
                lbl_ragione_sociale = NomeFornitoreText,
                lbl_nome_interno = NomeInternoText,
                lbl_responsabile = ResponsabileText,
                lbl_destinazione = DestinazioneText,
                lbl_indirizzo = IndirizzoText,
                lbl_comune = ComuneText,
                lbl_cap = CAPText,
                lbl_prov = ProvinciaText,
                lbl_images = ImmaginiText,

                codice_fornitore = tplModel.Id,
                ragione_sociale = tplModel.RagioneSociale,
                nome_interno = tplModel.NomeInterno,
                resposabile = tplModel.Responsabile.Description,

                stato = tplModel.IsActive ? "Attivo" : "Non Attivo",

                indirizzo = tplModel.SedeLegale.Indirizzo,
                city = tplModel.SedeLegale.City,
                cap = tplModel.SedeLegale.CAP,
                prov = tplModel.SedeLegale.Provincia,

                immagini = immaginilist,

            };

        }
        private void CreatePreviewPDF()
        {
            try
            {
                App application = Application.Current as App;
                var bootstrapper = application.Bootstrapper;

                string previewDest = GetPDFPreviewPath();
                string tplPath = Path.Combine(bootstrapper.ApplicationRootPath, TemplateParser.TemplatePath, Constants.TemplatePDfPreview_Fornitore);

                
                
                //var labels = GetTemplateLabels();
                //var pdfDocument = TemplateParser.ParseTemplate(tplPath, _model, labels);
                var tplModel = CreateTemplateModelData();
                var pdfDocument = TemplateParser.ParseTemplate(tplPath, tplModel);


                PDFManager.GeneratePreview(pdfDocument, previewDest);

                
                //PDFManager.GeneratePdf(previewDest);
            }
            catch (Exception ex)
            {
                Debugger.Break();
            }
            
        }

        public void LoadData(object data)
        {
            if(data is FornitoreDto) 
                LoadData(data as FornitoreDto);

            OnPropertyChanged(nameof(Fornitore));
        }
        public void LoadData(FornitoreDto data)
        {
            _model = data;
            UpdateModelImagePaths();

            _tempPdfpreviewName = $"preview_fornitore{_model.Id}";
            CreatePreviewPDF();

            OnPreviewPDFFileChanged();

        }

        private string GetPDFPreviewPath(bool getEmpty = false)
        {
            if (_tempPdfpreviewName == string.Empty)
                return null;

            App application = Application.Current as App;
            var bootstrapper = application.Bootstrapper;

            string ext = ".pdf";
            string filename = getEmpty ? "empty" : $"{_tempPdfpreviewName}_{SelectedLanguage.Culture}";
            string path = Path.Combine(bootstrapper.ApplicationRootPath, Constants.ApplicationFolder, Constants.AssetsFolderName, Constants.TempPdfFolderName, $"{filename}{ext}");
            return path;
        }
        private Uri GetPDFPreviewUri()
        {

           string path = GetPDFPreviewPath();
                      
            return new Uri($@"{Uri.UriSchemeFile}:\\\{path}");
        }
        
        private void OnPreviewPDFFileChanged()
        { 
            if(PreviewPDFFileChanged != null)
                PreviewPDFFileChanged.Invoke(this, PdfPreviewFileUri);
        }
        private void OnPreviewPDFFileChanging()
        {
            string path = GetPDFPreviewPath(true);

            var emptydocUri =  new Uri($@"{Uri.UriSchemeFile}:\\\{path}");

            if (PreviewPDFFileChanging != null)
                PreviewPDFFileChanging.Invoke(this, emptydocUri);
        }
        #endregion
    }
}
