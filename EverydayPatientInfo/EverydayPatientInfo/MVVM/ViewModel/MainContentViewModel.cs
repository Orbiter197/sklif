using EverydayPatientInfo.Core;
using EverydayPatientInfo.MVVM.Model;
using EverydayPatientInfo.ProjectStructure.ProjectWorkaround;

namespace EverydayPatientInfo.MVVM.ViewModel
{
    class MainContentViewModel : ObservableObject
    {
        public string CardID { get; set; }
        public string Name { get; set; }
        public string Role { get; set; }


        public MainContentViewModel()
        {
            Instances.MainContentVMInstance = this;
        }

        
    }
}
