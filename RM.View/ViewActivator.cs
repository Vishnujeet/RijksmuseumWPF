using System;
using System.Windows;
using RM.View.Screen;
using RM.ViewModel;
using RM.ViewModel.Screen;

namespace RM.View
{
    public class ViewActivator: IViewActivator
    {
        private MainScreenView mainScreen;
        private readonly IDataContextProvider dataContextProvider;
        public ViewActivator(IDataContextProvider dataProvider) => dataContextProvider = dataProvider;

        public void ActivateMainScreen()
        {
            mainScreen = new MainScreenView()
            {
                DataContext = dataContextProvider.MainScreenViewModel,
                WindowStartupLocation = WindowStartupLocation.CenterScreen,
            };
            mainScreen.ShowDialog();
        }
        private bool? ShowDialog(Window dialog)
        {
            dialog.Owner = mainScreen;
            dialog.WindowStartupLocation = WindowStartupLocation.CenterOwner;
            dialog.Width = mainScreen.ActualWidth;
            dialog.Height = mainScreen.ActualHeight;
            dialog.WindowState = mainScreen.WindowState;
            return dialog.ShowDialog();
        }
        public void CloseMainScreen()
        {
            if (mainScreen == null) return;
            mainScreen.Close();
            mainScreen = null;
        }

        public void ArtViewScreen(IArtViewerViewModel artViewerViewModel)
        {
            var artview = new SingleArtViewer()
            {
                DataContext = artViewerViewModel
            };
            artViewerViewModel.OnClose += (sender, args) => { artview.Close(); };
            ShowDialog(artview);
        }
    }
}