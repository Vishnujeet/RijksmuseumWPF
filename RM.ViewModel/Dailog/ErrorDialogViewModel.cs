using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RM.ViewModel.Dailog
{
    public interface Idialog
    {
        string Message { get; set; }
    }
    public class ErrorDialogViewModel
    {
        public string Message { get; set; }
    }
}
