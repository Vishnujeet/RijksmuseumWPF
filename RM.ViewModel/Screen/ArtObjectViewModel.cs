using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Input;
using RM.Cache;
using RM.Common;
using RM.Service;
using RM.Utils;
using RM.ViewModel.Helpers;

namespace RM.ViewModel.Screen
{
    public class ArtObjectViewModel : ViewModelBase, IArtObjectViewModel
    {
        private readonly IRMService apiService;
        private readonly IArtViewerViewModel artViewerViewModel;
        private ISingleArt singleArtObject;

        public ArtObjectViewModel()
        {
            apiService = Container.Resolve<IRMService>();
            artViewerViewModel = Container.Resolve<IArtViewerViewModel>();
            singleArtObject = Container.Resolve<ISingleArt>();
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
                singleArtObject = DataCache.Get<SingleArt>(firstName.ToString());
                if (singleArtObject == null)
                {
                    singleArtObject = await apiService.GetArtObjectDetails(firstName.ToString());
                    DataCache.Add(singleArtObject, singleArtObject.artObject.objectNumber);
                }
                artViewerViewModel.ArtUrl = singleArtObject.artObject.webImage.url;
                artViewerViewModel.Description = singleArtObject.artObject.description;
                artViewerViewModel.Title = singleArtObject.artObject.longTitle;
                artViewerViewModel.Maker = singleArtObject.artObject.principalOrFirstMaker;
                Container.Resolve<IDataContextProvider>().ViewActivator.ArtViewScreen(artViewerViewModel);
            }
            catch (Exception e)
            {
                Container.Resolve<IDataContextProvider>().ViewActivator.ActivateErrorMessageBoxScreen("Data not found!");
            }
        }
    }
}