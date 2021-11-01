using EverydayPatientInfo.Core;
using EverydayPatientInfo.ProjectStructure.ProjectWorkaround;

namespace EverydayPatientInfo.MVVM.ViewModel
{
    class DoctorViewModel : ObservableObject
    {
        public DoctorViewModel()
        {
            Instances.DoctorVM = this;
        }
    }
}
