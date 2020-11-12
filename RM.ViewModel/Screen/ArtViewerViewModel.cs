using System;
using System.Windows.Input;
using RM.ViewModel.Helpers;

namespace RM.ViewModel.Screen
{
    public class ArtViewerViewModel : ViewModelBase, IArtViewerViewModel
    {
        public event EventHandler OnClose;
        public string Title { get; set; }
        public object CopyrightHolder { get; set; }
        public string Description { get; set; }
        public string ArtUrl { get; set; }
        public string Maker { get; set; }

        public void Close()
        {
            OnClose?.Invoke(this, null);
        }

        public ICommand CloseCommand => new RelayCommand(x => Close());
    }
}