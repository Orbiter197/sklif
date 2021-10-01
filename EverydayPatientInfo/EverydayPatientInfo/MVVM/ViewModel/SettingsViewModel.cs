using EverydayPatientInfo.Core;
using EverydayPatientInfo.MVVM.Model;
using EverydayPatientInfo.ProjectStructure.ProjectWorkaround;
using System.Windows.Input;

namespace EverydayPatientInfo.MVVM.ViewModel
{
    class SettingsViewModel : ObservableObject
    {
        public SettingsViewModel()
        {
            Instances.SettingsVM = this;
        }
    }
}
