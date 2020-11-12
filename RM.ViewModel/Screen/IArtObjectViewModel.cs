using System.Collections.Generic;
using System.Windows.Input;
using RM.Common;

namespace RM.ViewModel
{
    public interface IArtObjectViewModel
    {
        IEnumerable<ArtObject> ListOfArtObjects { get; set; }
        ICommand GetDetailsCommand { get; }
    }
}