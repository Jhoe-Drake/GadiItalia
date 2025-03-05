using Drk.Core;
using Drk.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace FornitoriApp.Utilities
{
    public class NavigatorController : INavigationContainer
    {
        
        private Dictionary<string, object>  dataToLoad;
        public NavigatorController()
        { 
          dataToLoad = new Dictionary<string, object>();
        }
        public void NavigateTo(Type type, int level, object data)
        {
            
            NavigateTo(type.Name, level, data);
        }

        public void NavigateTo(string destination, int level, object data)
        {
            var bootstrapper = (App.Current as App).Bootstrapper;
            var shell = bootstrapper.Shell;
            var content = bootstrapper.GetView(destination) as IContentView;

            content.ContentLoaded -= Content_ContentLoaded;
            content.ContentLoaded += Content_ContentLoaded;

            if (dataToLoad.ContainsKey(content.ContentName))
            {
                dataToLoad[content.ContentName] = data;
            }
            else
            {
                dataToLoad.Add(content.ContentName, data);
            }
            shell.SetContent(content);
            
            

        }

        private void Content_ContentLoaded(object? sender, IViewModel e)
        {
            if (sender is IContentView content)
            {
                object data = null;
                if(dataToLoad.ContainsKey(content.ContentName))
                    data = dataToLoad[content.ContentName];

                var viewModel = content.GetViewModel();
                if (viewModel != null)
                    viewModel.LoadData(data);

                dataToLoad.Remove(content.ContentName);
                
            }
        }
    }
}
