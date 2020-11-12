using System;
using RM.ViewModel.Screen;

namespace RM.ViewModel
{
    public interface IMainScreenViewModel : IDisposable
    {
        IArtObjectViewModel ArtObjectViewModel { get; set; }
        IArtViewerViewModel ArtViewerViewModel { get; set; }
    }
}