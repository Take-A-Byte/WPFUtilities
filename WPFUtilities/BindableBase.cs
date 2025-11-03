using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace WPFUtilities
{
    public class BindableBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        public bool OnPropertyChanged(object oldValue, object newValue, [CallerMemberName]string? propertyName = null)
        {
            if (oldValue.Equals(newValue))
            {
                return false;
            }

            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
            return true;
        }
    }
}
