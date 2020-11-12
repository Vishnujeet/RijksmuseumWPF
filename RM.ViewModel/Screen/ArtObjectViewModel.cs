using System;
using RM.Common;
using RM.Service;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Input;
using RM.Utils;
using RM.ViewModel.Helpers;
using RM.ViewModel.Screen;

namespace RM.ViewModel
{
    public class ArtObjectViewModel : ViewModelBase, IArtObjectViewModel
    {
        private readonly IRMService apiService;
        private readonly IArtViewerViewModel artViewerViewModel;

        public ArtObjectViewModel()
        {
            apiService = Container.Resolve<IRMService>();
            artViewerViewModel = Container.Resolve<IArtViewerViewModel>();
        }

        private IEnumerable<ArtObject> listOfArtObjects;

        public IEnumerable<ArtObject> ListOfArtObjects
        {
            get
            {
                if (listOfArtObjects == null)
                    new Task(async () =>
                    {
                        var result = await apiService.GetAllArtObject();
                        ListOfArtObjects = result.artObjects;
                    }).Start();

                return listOfArtObjects;
            }
            set
            {
                listOfArtObjects = value;
                NotifyPropertyChanged(nameof(ListOfArtObjects));
            }
        }

        public ICommand GetDetailsCommand => new RelayCommand(Search);

        private async void Search(object firstName)
        {
            try
            {
                var result = await apiService.GetArtObjectDetails(firstName.ToString());
                artViewerViewModel.ArtUrl = result.artObject.webImage.url;
                artViewerViewModel.Description = result.artObject.description;
                artViewerViewModel.Title = result.artObject.longTitle;
                artViewerViewModel.Maker = result.artObject.principalOrFirstMaker;
                Container.Resolve<IDataContextProvider>().ViewActivator.ArtViewScreen(artViewerViewModel);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            
        }
    }
}