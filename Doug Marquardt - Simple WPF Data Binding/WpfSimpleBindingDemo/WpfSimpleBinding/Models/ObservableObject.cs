#if MIN_TARGET_35
#else
using System.Runtime.CompilerServices;
#endif

namespace WpfSimpleBinding.Models
{
    internal abstract class ObservableObject : System.ComponentModel.INotifyPropertyChanged
    {
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

#if MIN_TARGET_35
        protected bool SetProperty<T>(ref T storage, T value, string propertyName)
        {
            return DoSetProperty(ref storage, value, propertyName);
        }

        protected void NotifyPropertyChanged(string propertyName)
        {
            DoNotifyPropertyChanged(propertyName);
        }
#else
        protected bool SetProperty<T>(ref T storage, T value, [CallerMemberName]string propertyName = "")
        {
            return DoSetProperty(ref storage, value, propertyName);
        }

        protected void NotifyPropertyChanged([CallerMemberName]string propertyName = "")
        {
            DoNotifyPropertyChanged(propertyName);
        }
#endif

        private bool DoSetProperty<T>(ref T storage, T value, string propertyName)
        {
            if (Equals(storage, value)) return false;

            storage = value;

            PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));

            return true;
        }

        private void DoNotifyPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
        }
    }
}
