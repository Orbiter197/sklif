using EverydayPatientInfo.Core;
using EverydayPatientInfo.ProjectStructure.ProjectWorkaround;

namespace EverydayPatientInfo.MVVM.ViewModel
{
    /// <summary>
    /// A view model for main window"/>
    /// </summary>
    class MainWindowViewModel : ObservableObject
    {

        #region Private fields

        /// <summary>
        /// Current view that is shown in main window
        /// </summary>
        private object currentView;

        #endregion

        #region Public properties

        public object CurrentView
        {
            get => currentView;
            set => currentView = value;
        }

        public SignInViewModel SignInVM { get; set; } = new();
        public RegisterationViewModel RegisterVM { get; set; } = new();
        public PasswordResetViewModel PasswordResetVM { get; set; } = new();
        public MainContentViewModel MainContentVM { get; set; } = new();


        #endregion



        #region Constructor 

        /// <summary>
        /// Constucts a view model for main window and sets a 
        /// </summary>
        public MainWindowViewModel()
        {
            Instances.MainWindowVMInstance = this;

            CurrentView = new SignInViewModel();
        }

        #endregion

        #region Helpers



        #endregion

    }
}
