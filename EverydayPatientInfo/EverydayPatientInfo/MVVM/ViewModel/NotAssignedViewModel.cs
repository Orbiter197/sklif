using EverydayPatientInfo.Core;
using EverydayPatientInfo.ProjectStructure.ProjectWorkaround;

namespace EverydayPatientInfo.MVVM.ViewModel
{
    class NotAssignedViewModel : ObservableObject
    {
        public NotAssignedViewModel()
        {
            Instances.NotAssignedVM = this;
        }
    }
}
