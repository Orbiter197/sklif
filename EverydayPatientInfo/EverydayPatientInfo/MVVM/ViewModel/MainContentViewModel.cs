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

        private object currentView;

        #endregion

        #region Public properties

        public MainWindowViewModel BaseVM { get => baseVM; }
        #endregion

        #region Binding properties

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

        #endregion

        #region Switching

        public void SwitchToHome()
        {
            CurrentView = ProjectMainClass.Role switch
                {
                    1 => new DoctorViewModel(this),
                    2 => new OperatorViewModel(this),
                    _ => new NotAssignedViewModel(this)
                };
        }
        
        public void SwitchToSettings() => CurrentView = new SettingsViewModel(this);
        public void SwitchToRoleManager() => CurrentView = new RoleManagerViewModel(this);

        #endregion

        #region Constructor

        public MainContentViewModel(MainWindowViewModel baseVM)
        {
            this.baseVM = baseVM;

            CurrentView = new NotAssignedViewModel(this);


            ViewProfileCommand = new RelayCommand(SwitchToSettings);
            ChangRoleCommand = new RelayCommand(SwitchToRoleManager);

            CardID = Instances.CardID;
            Name = Instances.Name;
        }

        #endregion
    }
}
