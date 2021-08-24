using System;
using System.Collections.Generic;
using System.Text;
using EverydayPatientInfo.Core;

namespace EverydayPatientInfo.MVVM.ViewModel
{
    /// <summary>
    /// A view model for main window"/>
    /// </summary>
    class MainWindowViewModel : ObservableObject
    {
        #region Private fields

        /// <summary>
        /// 
        /// </summary>
        private object _currentView;

        #endregion

        #region Public fields

        #endregion

        #region Constructor 

        /// <summary>
        /// Constucts a view model for main window and sets a 
        /// </summary>
        public MainWindowViewModel()
        {
            HomeVM = new MainContentViewModel();
            CurrentView = HomeVM;
        }

        #endregion

        #region Helpers

        #endregion
        public MainContentViewModel HomeVM;

        
        public object CurrentView 
        { 
            get => _currentView; 
            set => _currentView = value; 
        }
       

        
    }
}
