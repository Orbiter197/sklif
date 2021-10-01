using EverydayPatientInfo.Core;
using EverydayPatientInfo.MVVM.Model;
using EverydayPatientInfo.ProjectStructure.ProjectWorkaround;
using System.Windows.Input;

namespace EverydayPatientInfo.MVVM.ViewModel
{
    class MainContentViewModel : ObservableObject
    {
        private object currentView;

        public string CardID { get; set; }
        public string Name { get; set; }
        public string Role { get; set; }

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




        public MainContentViewModel()
        {
            Instances.MainContentVMInstance = this;

            CurrentView = new NotAssignedViewModel();
            _ = new DoctorViewModel();
            _ = new OperatorViewModel();
            _ = new SettingsViewModel();
            _ = new ChangeRoleViewModel();

            ViewProfileCommand = new RelayCommand(ViewProfile);
            ChangRoleCommand = new RelayCommand(ChnageRole);

            CardID = Instances.CardID;
            Name = Instances.Name;
            Role = Instances.Role;
        }

        
    }
}
