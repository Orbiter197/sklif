using EverydayPatientInfo.Core;
using EverydayPatientInfo.ProjectStructure.ProjectWorkaround;

namespace EverydayPatientInfo.MVVM.ViewModel
{
    /// <summary>
    /// A view model for main window/>
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

        #endregion

        #region Switching

        public void SwitchToSignIn() => CurrentView = new SignInViewModel(this);
        public void SwitchToSignUp() => CurrentView = new SignUpViewModel(this);
        public void SwitchToPasswordReset() => CurrentView = new PasswordResetViewModel(this);
        public void SwitchToMainContent() => CurrentView = new MainContentViewModel(this);

        #endregion


        #region Constructor 

        /// <summary>
        /// Constucts a view model for main window and sets a 
        /// </summary>
        public MainWindowViewModel()
        {
            CurrentView = new SignInViewModel(this);
        }

        #endregion

    }
}
