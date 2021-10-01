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

        private static MainWindowViewModel instance;

        internal static MainWindowViewModel Instance 
        { 
            get => instance; 
            private set => instance = value; 
        }

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

        public SignInViewModel SignInVM { get; set; } = new SignInViewModel();
        public RegisterationViewModel RegisterVM { get; set; } = new RegisterationViewModel();
        public MainContentViewModel MainContentVM { get; set; } = new MainContentViewModel();
        

        #endregion



        #region Constructor 

        /// <summary>
        /// Constucts a view model for main window and sets a 
        /// </summary>
        public MainWindowViewModel()
        {
            CurrentView = new SignInViewModel();
            Instance = this;
        }

        #endregion

        #region Helpers

       

        #endregion

    }
}
