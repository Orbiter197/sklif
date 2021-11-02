using EverydayPatientInfo.Core;
using EverydayPatientInfo.ProjectStructure;
using EverydayPatientInfo.ProjectStructure.ProjectWorkaround;
using System.Windows.Input;

namespace EverydayPatientInfo.MVVM.ViewModel
{
    class MainContentViewModel : ObservableObject
    {
        #region Private fields

        private MainWindowViewModel baseVM;
        #endregion

        #region Public properties

        public MainWindowViewModel BaseVM { get => baseVM; }
        #endregion

        private object currentView;

        public string CardID { get; set; }
        public string Name { get; set; }
        public string Role
        {
            get => ProjectMainClass.Role.ToString();
            set => ProjectMainClass.Role = int.Parse(value);
        }

        public ICommand ViewProfileCommand { get; set; }
        public ICommand ChangRoleCommand { get; set; }
        public object CurrentView
        {
            get => currentView;
            set => currentView = value;
        }

        private void ViewProfile()
        {
            CurrentView = Instances.SettingsVM;
        }
        private void ChnageRole()
        {
            CurrentView = Instances.ChangeRoleVM;
        }




        public MainContentViewModel(MainWindowViewModel baseVM)
        {
            this.baseVM = baseVM;

            CurrentView = new NotAssignedViewModel();
            _ = new DoctorViewModel();
            _ = new OperatorViewModel();
            _ = new SettingsViewModel();
            _ = new ChangeRoleViewModel();

            ViewProfileCommand = new RelayCommand(ViewProfile);
            ChangRoleCommand = new RelayCommand(ChnageRole);

            CardID = Instances.CardID;
            Name = Instances.Name;
        }


    }
}
