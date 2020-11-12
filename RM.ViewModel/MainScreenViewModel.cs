using RM.ViewModel.Helpers;
using RM.ViewModel.Screen;
using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.Configuration;
using Container = RM.Utils.Container;

namespace RM.ViewModel
{
    public class MainScreenViewModel : ViewModelBase, IMainScreenViewModel
    {
        private IArtObjectViewModel iartObjectViewModel;
        private IArtViewerViewModel artViewerViewModel;

        public IArtObjectViewModel ArtObjectViewModel
        {
            get => iartObjectViewModel;
            set
            {
                iartObjectViewModel = value;
                NotifyPropertyChanged(nameof(ArtObjectViewModel));
            }
        }


        public IArtViewerViewModel ArtViewerViewModel
        {
            get => artViewerViewModel;
            set
            {
                artViewerViewModel = value;
                NotifyPropertyChanged(nameof(ArtViewerViewModel));
            }
        }

        private readonly IDataContextProvider mDataContextProvider;

        public MainScreenViewModel(IDataContextProvider dataContextProvider)
        {
            mDataContextProvider = dataContextProvider;
            Initialize();
        }

        internal void Initialize()
        {
            ArtObjectViewModel = Container.Instance.Resolve<IArtObjectViewModel>();
            ArtViewerViewModel = Container.Instance.Resolve<IArtViewerViewModel>();
        }
    }
}