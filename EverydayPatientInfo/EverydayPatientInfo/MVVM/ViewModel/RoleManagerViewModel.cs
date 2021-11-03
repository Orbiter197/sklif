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
    class RoleManagerViewModel : ObservableObject
    {
        #region Private fields

        MainContentViewModel baseVM;

        private int selected = 0;

        #endregion

        #region Public properties

        public MainContentViewModel BaseVM { get => baseVM; }

        #endregion

        #region Binding Properties

        public string Role { get => ProjectMainClass.DisplayedRole; }
        public string NotAssignedRoleAvaliable { get; set; }
        public string DoctorRoleAvaliable { get; set; }
        public string OperatorRoleAvaliable { get; set; }

        public ICommand commandICommand { get; set; }



        public ICommand NotAssignedCommand { get; set; }
        public ICommand DoctorCommand { get; set; }
        public ICommand OperatorCommand { get; set; }

        public ICommand PickUpRoleCommand { get; set; }


        #endregion




        private void ChangeRole()
        {

        }
        //ProjectMainClass.Role = selected;

        public RoleManagerViewModel(MainContentViewModel baseVM)
        {
            this.baseVM = baseVM;

            NotAssignedCommand = new RelayCommand(() => selected = 0);
            DoctorCommand = new RelayCommand(() => selected = 1);
            OperatorCommand = new RelayCommand(() => selected = 2);
            PickUpRoleCommand = new RelayCommand(ChangeRole);

        }
    }
}
