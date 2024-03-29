﻿using System;
using System.Windows.Input;

namespace EverydayPatientInfo.Core
{












    /// <summary>
    /// A basic command that runs an Action
    /// </summary>
    public class RelayCommand : ICommand
    {








        #region Private Members

        /// <summary>
        /// The action to run
        /// </summary>
        private Action mAction;











        #endregion

        #region Public Events
        /// <summary>
                                      /// The event that fires the <see cref="CanExecute(object)"/> value has changed
                                      /// </summary>
        public event EventHandler CanExecuteChanged = (sender, e) => { };













        #endregion

        #region Constructor

        /// <summary>
        /// Defaut constructor
        /// </summary>
        /// <param name="action"></param>
        public RelayCommand(Action action)
        {
            mAction = action;
        }















        #endregion

        #region Command Methods

        /// <summary>
        /// A relay command can always execute
        /// </summary>
        /// <param name="parameter"></param>
        /// <returns></returns>
        public bool CanExecute(object parameter) => true;


        public void Execute(object parameter)
        {
            mAction();
        }



        #endregion
    }
}
