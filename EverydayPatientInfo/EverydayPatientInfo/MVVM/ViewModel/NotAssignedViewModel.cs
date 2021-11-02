using EverydayPatientInfo.Core;
using EverydayPatientInfo.ProjectStructure.ProjectWorkaround;

namespace EverydayPatientInfo.MVVM.ViewModel
{
    class NotAssignedViewModel : ObservableObject
    {
        #region Private fields

        private MainContentViewModel baseVM;

        #endregion

        #region Public properties

        public MainContentViewModel BaseVM { get => baseVM; }

        #endregion

        public NotAssignedViewModel(MainContentViewModel baseVM)
        {
            this.baseVM = baseVM;
        }
    }
}
