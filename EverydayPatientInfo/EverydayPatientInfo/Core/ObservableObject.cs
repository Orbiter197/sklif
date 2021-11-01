using PropertyChanged;
using System.ComponentModel;

namespace EverydayPatientInfo.Core
{
    /// <summary>
    /// A base view model that fires Property Changed events
    /// </summary>
    [AddINotifyPropertyChangedInterface]
    public class ObservableObject : INotifyPropertyChanged
    {
        /// <summary>
        /// The event that is fired when any child property changes its value
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged = (sender, e) => { };

        /// <summary>
        /// Call sthis to fire a <see cref="PropertyChanged"/> event
        /// </summary>
        /// <param name="name"></param>
        public void OnPropertyChanged(string name)
        {
            PropertyChanged(this, new PropertyChangedEventArgs(name));
        }
    }
}
