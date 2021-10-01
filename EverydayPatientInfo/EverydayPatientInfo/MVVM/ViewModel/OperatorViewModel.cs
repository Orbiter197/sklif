using EverydayPatientInfo.Core;
using EverydayPatientInfo.MVVM.Model;
using EverydayPatientInfo.ProjectStructure.ProjectWorkaround;
using System.Windows.Input;

namespace EverydayPatientInfo.MVVM.ViewModel
{
    class OperatorViewModel : ObservableObject
    {
        public OperatorViewModel()
        {
            Instances.OperatorVM = this;
        }
    }
}
