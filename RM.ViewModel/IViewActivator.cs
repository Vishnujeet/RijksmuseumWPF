using RM.ViewModel.Screen;

namespace RM.ViewModel
{
    public interface IViewActivator
    {
        void ActivateMainScreen();
        void CloseMainScreen();
        void ArtViewScreen(IArtViewerViewModel addEmployee);
        void ActivateErrorMessageBoxScreen(string message);
    }
}