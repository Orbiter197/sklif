using System;
using System.Collections.Generic;
using System.Text;
using EverydayPatientInfo.Core;
using System.Windows.Input;

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
        private object _currentView;

        #endregion

        #region Public fields

        public object CurrentView
        {
            get => _currentView;
            set => _currentView = value;
        }

        public MainContentViewModel HomeVM;
        public SignInViewModel SignInVM;
        public SignUpViewModel SignUpVM;

        public ICommand SignInCommand { get; set; }
        public ICommand SignUpCommand { get; set; }

        #endregion

        #region Constructor 

        /// <summary>
        /// Constucts a view model for main window and sets a 
        /// </summary>
        public MainWindowViewModel()
        {
            HomeVM = new MainContentViewModel();
            SignInVM = new SignInViewModel();
            SignUpVM = new SignUpViewModel();

            CurrentView = SignInVM;

            SignInCommand = new RelayCommand(() => { CurrentView = SignInVM; });
            SignUpCommand = new RelayCommand(() => { CurrentView = SignUpVM; });
        }

        #endregion

        #region Helpers

       

        #endregion









    }
}
