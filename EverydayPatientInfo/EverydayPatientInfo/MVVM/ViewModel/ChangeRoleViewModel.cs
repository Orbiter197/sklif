using EverydayPatientInfo.Core;
using EverydayPatientInfo.MVVM.Model;
using EverydayPatientInfo.ProjectStructure.ProjectWorkaround;
using System.Windows.Input;

namespace EverydayPatientInfo.MVVM.ViewModel
{
    /// <summary>
    /// A view model for "Change role" window
    /// 
    /// </summary>
    class ChangeRoleViewModel : ObservableObject
    {

        
        public string Role
        { 
            get => Instances.Role;
            
        }

        public string NotAssignedRoleAvaliable { get; set; }
        public string DoctorRoleAvaliable { get; set; }
        public string OperatorRoleAvaliable { get; set; }

        public ICommand commandICommand { get; set; }

       

        public ICommand NotAssignedCommand { get; set; }
        public ICommand DoctorCommand { get; set; }
        public ICommand OperatorCommand { get; set; }

        public ICommand PickUpRoleCommand { get; set; }
        

        private int selected = 0;

        private void ChangeRole()
        {
            switch (selected)
            {
                case 0:
                    Instances.MainContentVMInstance.Role = "Not assigned";
                    Instances.MainContentVMInstance.CurrentView = Instances.NotAssignedVM;
                    break;
                case 1:
                    Instances.MainContentVMInstance.Role = "Doctor";
                    Instances.MainContentVMInstance.CurrentView = Instances.DoctorVM;
                    break;
                case 2:
                    Instances.MainContentVMInstance.Role = "Operator";
                    Instances.MainContentVMInstance.CurrentView = Instances.OperatorVM;
                    break;
                default:
                    break;
            }
        }

        public ChangeRoleViewModel()
        {
            Instances.ChangeRoleVM = this;

            

            
            NotAssignedCommand = new RelayCommand(() => selected = 0);
            DoctorCommand = new RelayCommand(() => selected = 1);
            OperatorCommand = new RelayCommand(() => selected = 2);
            PickUpRoleCommand = new RelayCommand(ChangeRole);
            

            if (Instances.Role == "Not assigned")
            {
                NotAssignedRoleAvaliable = "Your current role";
                DoctorRoleAvaliable = "Avaliable";
                OperatorRoleAvaliable = "Avaliable";
            }
            else if (Instances.Role == "Doctor")
            {
                NotAssignedRoleAvaliable = "Avaliable";
                DoctorRoleAvaliable = "Your current role";
                OperatorRoleAvaliable = "Avaliable";
            }
            else if (Instances.Role == "Not Assigned")
            {
                NotAssignedRoleAvaliable = "Avaliable";
                DoctorRoleAvaliable = "Avaliable";
                OperatorRoleAvaliable = "Your current role";
            }



        }
    }
}
