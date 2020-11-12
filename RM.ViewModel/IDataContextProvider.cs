namespace RM.ViewModel
{
    public interface IDataContextProvider
    {
        IViewActivator ViewActivator { get; set; }
        IMainScreenViewModel MainScreenViewModel { get; }
        void CreateStartupDialogViewModels();
    }
}