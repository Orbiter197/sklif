using EverydayPatientInfo.Core;
using System.Windows.Input;

namespace EverydayPatientInfo.MVVM.ViewModel
{
    class SettingsViewModel : ObservableObject
    {
        #region Private fields

        MainContentViewModel baseVM;

        #endregion

        #region Public properties

        public MainContentViewModel BaseVM { get => baseVM; }

        public string Saving { get; set; } = "C:\\EverydayPatientInfoRecoveryData\\Output.json";
        public string Reloading { get; set; } = "C:\\EverydayPatientInfoRecoveryData\\Input.json";

        public ICommand BackUpCommand { get; set; }
        public ICommand StopCommand { get; set; }
        public ICommand RestoreCommand { get; set; }
        public ICommand GoBackCommand { get; set; }


        #endregion
        public SettingsViewModel(MainContentViewModel baseVM)
        {
            this.baseVM = baseVM;

            BackUpCommand = new RelayCommand(() => ProjectStructure.Recovery.RecoveryHandler.BackUp(Saving));
            StopCommand = new RelayCommand(() => ProjectStructure.Recovery.RecoveryHandler.Drop());
            RestoreCommand = new RelayCommand(() => ProjectStructure.Recovery.RecoveryHandler.Restore(Reloading));
            GoBackCommand = new RelayCommand(baseVM.SwitchToHome);

        }

        
    }
}
