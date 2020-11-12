using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RM.ViewModel.Helpers
{
    public abstract class ViewModelBase
        : INotifyPropertyChanged, IDisposable, IDataErrorInfo
    {
        private bool mDisposed;

        #region IDataErrorInfo Members

        public virtual string this[string columnName] => throw new NotImplementedException();

        public string Error => string.Empty;

        #endregion

        #region IDisposable Members

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        #endregion

        #region INotifyPropertyChanged Members

        public event PropertyChangedEventHandler PropertyChanged;

        #endregion

        [Conditional("DEBUG")]
        public void VerifyPropertyName(string propertyName)
        {
            if (TypeDescriptor.GetProperties(this)[propertyName] == null)
            {
                var msg = "Invalid property name: " + propertyName;
                throw new ArgumentException(msg);
            }
        }
        protected virtual void OnPropertyChanged(string propertyName)
        {
            VerifyPropertyName(propertyName);

            var handler = PropertyChanged;
            if (handler != null)
            {
                var e = new PropertyChangedEventArgs(propertyName);
                handler(this, e);
            }
        }
        protected void NotifyPropertyChanged(string info)
        {
            if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs(info));
        }
        protected void Dispose(bool disposing)
        {
            if (!mDisposed)
                if (disposing)

                    PropertyChanged = null;
            mDisposed = true;
        }
    }
}