using System;
using System.Windows.Input;

namespace RM.ViewModel.Screen
{
    public interface IArtViewerViewModel
    {
        string Title { get; set; }
        object CopyrightHolder { get; set; }

        string Description { get; set; }
        string ArtUrl { get; set; }
        string Maker { get; set; }
        event EventHandler OnClose;
        void Close();
        ICommand CloseCommand { get; }
    }
}