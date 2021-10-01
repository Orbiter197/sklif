using EverydayPatientInfo.Core;
using EverydayPatientInfo.MVVM.Model;
using EverydayPatientInfo.ProjectStructure.ProjectWorkaround;
using System.Windows.Input;

namespace EverydayPatientInfo.MVVM.ViewModel
{
    class MainContentViewModel : ObservableObject
    {
        public string CardID { get; set; }
        public string Name { get; set; }
        public string Role { get; set; }

        public ICommand ViewProfileCommand { get; set; }
        public ICommand ChangRoleCommand { get; set; }


        public MainContentViewModel()
        {
            Instances.MainContentVMInstance = this;

            

            CardID = Instances.CardID;
            Name = Instances.Name;
            Role = Instances.Role;
        }

        
    }
}
