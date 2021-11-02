using EverydayPatientInfo.Core;
using EverydayPatientInfo.ProjectStructure;
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
            get => ProjectMainClass.Role.ToString();

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


            



        }
    }
}
