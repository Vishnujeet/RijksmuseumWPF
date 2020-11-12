using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using RM.View;
using RM.ViewModel;

namespace RM
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private IDataContextProvider mDataContextProvider;

        private void OnApplicationStartup(object sender, StartupEventArgs e)
        {
            try

            {
                mDataContextProvider = new DataContextProvider();
                mDataContextProvider.ViewActivator = new ViewActivator(mDataContextProvider);
                mDataContextProvider.CreateStartupDialogViewModels();
                mDataContextProvider.ViewActivator.ActivateMainScreen();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                throw;
            }
        }

        private void Application_Exit(object sender, ExitEventArgs e)
        {
        }
    }
}