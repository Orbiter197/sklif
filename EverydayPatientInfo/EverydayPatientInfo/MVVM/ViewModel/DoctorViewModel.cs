using EverydayPatientInfo.Core;


namespace EverydayPatientInfo.MVVM.ViewModel
{
    class DoctorViewModel : ObservableObject
    {
        #region Private fields

        private MainContentViewModel baseVM;

        #endregion

        #region Public properties

        public MainContentViewModel BaseVM { get => baseVM; }

        #endregion

        public DoctorViewModel(MainContentViewModel baseVM)
        {
            this.baseVM = baseVM;
        }
    }
}
