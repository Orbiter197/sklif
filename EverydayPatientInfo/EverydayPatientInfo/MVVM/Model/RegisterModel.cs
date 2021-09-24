using System;

using EverydayPatientInfo.Core;
using EverydayPatientInfo.MVVM.ViewModel;
using EverydayPatientInfo.ProjectStructure.UserStructure;

using System.Collections.Generic;
using System.Text;

namespace EverydayPatientInfo.MVVM.Model
{
    class RegisterModel
    {
        #region Private fields

        /// <summary>
        /// The viewmodel of Register window
        /// </summary>
        private RegisterViewModel viewmodel;

        #endregion

        #region Public fiels


        #endregion

        #region Public methods

        /// <summary>
        /// This method is used as a Command
        /// </summary>
        /// <param name="login"></param>
        /// <param name="password1"></param>
        /// <param name="password2"></param>
        public void SendData(string login, HashCode password1, HashCode password2)
        {
            
        }

        #endregion
    }
}
