using EverydayPatientInfo.Core;
using EverydayPatientInfo.MVVM.Model;
using EverydayPatientInfo.ProjectStructure.ProjectWorkaround;
using System.Windows.Input;

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
