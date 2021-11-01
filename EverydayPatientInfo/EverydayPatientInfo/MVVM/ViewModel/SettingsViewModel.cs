using EverydayPatientInfo.Core;
using EverydayPatientInfo.ProjectStructure.ProjectWorkaround;

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
