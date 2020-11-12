using RM.Service;
using RM.Utils;
using RM.ViewModel.Screen;
using Microsoft.Practices.Unity;

namespace RM.ViewModel
{
    public class DataContextProvider : IDataContextProvider
    {
        public IViewActivator ViewActivator { get; set; }

        public IMainScreenViewModel MainScreenViewModel { get; private set; }

        public void CreateStartupDialogViewModels()
        {
            IocConfig();
            MainScreenViewModel = new MainScreenViewModel(this);
        }

        private void IocConfig()
        {
            Container.Instance.RegisterInstance<IDataContextProvider>(this);
            Container.Instance.RegisterType<IArtObjectViewModel, ArtObjectViewModel>();
            Container.Instance.RegisterType<IArtViewerViewModel, ArtViewerViewModel>();
            Container.Instance.RegisterType<IRMService, RMService>();
        }
    }
}