using EverydayPatientInfo.Core;
using EverydayPatientInfo.MVVM.Model;
/*
using System;
using System.Collections.Generic;
using System.Text;
*/

namespace EverydayPatientInfo.MVVM.ViewModel
{
    /// <summary>
    /// This view model is used when autification is needed
    /// </summary>
    class SignInViewModel : ObservableObject
    {
        /// <summary>
        /// The model that handles all logic
        /// </summary>
        private readonly SignInModel signInModel;       

        #region Public properties

        /// <summary>
        /// Username 
        /// </summary>
        public string Username
        {
            get => signInModel.Username;
            set => signInModel.Username = value;
        }

        /// <summary>
        /// Password 
        /// </summary>
        public string Password
        {
            get => signInModel.Password;
            set => signInModel.Password = value;
        }
        #endregion

        /// <summary>
        /// Default constructor
        /// </summary>
        public SignInViewModel()
        {
            signInModel = new SignInModel(this);
        }

    }
}
