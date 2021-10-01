using EverydayPatientInfo.Core;
using EverydayPatientInfo.MVVM.Model;
using EverydayPatientInfo.ProjectStructure.ProjectWorkaround;
using System.Windows.Input;

namespace EverydayPatientInfo.MVVM.ViewModel
{
    class ChangeRoleViewModel : ObservableObject
    {
        public string Role
        { 
            get => Instances.Role;
            
        }

        public string NotAssignedRoleAvaliable { get; set; }
        public string DoctorRoleAvaliable { get; set; }
        public string OperatorRoleAvaliable { get; set; }

        public ICommand NotAssignedCommand { get; set; }
        public ICommand DoctorCommand { get; set; }
        public ICommand OperatorCommand { get; set; }

        public ChangeRoleViewModel()
        {
            Instances.ChangeRoleVM = this;

            NotAssignedCommand = new RelayCommand( () => Instances.Role = "Not assigned"  );
            DoctorCommand = new RelayCommand(() => Instances.Role = "Doctor");
            OperatorCommand = new RelayCommand(() => Instances.Role = "Operator");

            if (Instances.Role == "Not assigned")
            {
                NotAssignedRoleAvaliable = "Your current role";
                DoctorRoleAvaliable = "Avaliable";
                OperatorRoleAvaliable = "Occupied";
            }
            else if (Instances.Role == "Doctor")
            {
                NotAssignedRoleAvaliable = "Avaliable";
                DoctorRoleAvaliable = "Your current role";
                OperatorRoleAvaliable = "Occupied";
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
