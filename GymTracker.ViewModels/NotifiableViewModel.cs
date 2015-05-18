using System.ComponentModel;
using System.Runtime.CompilerServices;
using GymTracker.ViewModels.Annotations;

namespace GymTracker.ViewModels
{
    public abstract class NotifiableViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}