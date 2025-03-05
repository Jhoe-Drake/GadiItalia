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
using Microsoft.Extensions.Primitives;


namespace FornitoriApp.ViewModels
{
    public class FornioreDetailViewModel: Notifiable, IViewModel, IViewModel<FornitoreDto>
    {
        #region events 
        public delegate void PreviewPDFFileEventHandler(object source, Uri pdfFilePath);
        public event PreviewPDFFileEventHandler PreviewPDFFileChanged;

        public delegate void PrintPreviewFileEventHandler();
        public event PrintPreviewFileEventHandler PrintPreviewFile;

        #endregion
        #region fields
        
        private Language _selectedLang;
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
                _selectedLang = value; 
                OnPropertyChanged(); 
                UpdateLanguage(_selectedLang);
                OnPreviewPDFFileChanged();
            } 
        }
        public Uri PdfPreviewFileUri { get { return GetPDFPreviewUri(); }  }
        public string FornitoreText { get => LanguagesUtilities.GetString("FornitoreText", _resources); }
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
            OnPropertyChanged(nameof(FornitoreText));
        }

       

        

        public void LoadData(FornitoreDto data)
        {
            _model = data;
            _tempPdfpreviewName = $"preview_fornitore{_model.Id}";
           
            CreatePreviewPDF();

            OnPreviewPDFFileChanged();
            
        }

        private void CreatePreviewPDF()
        {
            string previewDest = GetPDFPreviewPath();
            string tplPath = Path.Combine(TemplateParser.TemplatePath, Constants.TemplatePDfPreview_Fornitore);
            var pdfDocument = TemplateParser.ParseTemplate(tplPath, _model);
            PDFManager.GeneratePreview(pdfDocument, previewDest);
            //PDFManager.GeneratePdf(previewDest);
        }

        public void LoadData(object data)
        {
            if(data is FornitoreDto) 
                LoadData(data as FornitoreDto);

            OnPropertyChanged(nameof(Fornitore));
        }

        
        private string GetPDFPreviewPath()
        {
            if (_tempPdfpreviewName == string.Empty)
                return null;

            App application = Application.Current as App;
            var bootstrapper = application.Bootstrapper;

            string ext = ".pdf";
            string path = Path.Combine(bootstrapper.ApplicationRootPath, Constants.ApplicationFolder, Constants.AssetsFolderName, Constants.TempPdfFolderName, $"{_tempPdfpreviewName}{ext}");
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
        #endregion
    }
}
