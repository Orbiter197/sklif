using EverydayPatientInfo.Core;


namespace EverydayPatientInfo.MVVM.ViewModel
{
    class SettingsViewModel : ObservableObject
    {
        #region Private fields

        MainContentViewModel baseVM;

        #endregion
        public SettingsViewModel(MainContentViewModel baseVM)
        {
            this.baseVM = baseVM;
        }
    }
}
