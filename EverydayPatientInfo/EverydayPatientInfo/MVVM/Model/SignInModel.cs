using EverydayPatientInfo.MVVM.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace EverydayPatientInfo.MVVM.Model
{
    /// <summary>
    /// The model for "Sign in" window that handles all logic
    /// </summary>
    class SignInModel
    {
        #region Private properties

        /// <summary>
        /// Username 
        /// </summary>
        private string username;

        /// <summary>
        /// Password 
        /// </summary>
        private string password;

        /// <summary>
        /// Password 
        /// </summary>
        private readonly SignInViewModel viewModel;
        #endregion

        #region Public properties

        /// <summary>
        /// Username 
        /// </summary>
        public string Username
        {
            get => username;
            set
            {
                if (value != username)
                {
                    username = value;
                    if (viewModel != null) viewModel.Username = username;
                }
            }
        }

        /// <summary>
        /// Password 
        /// </summary>
        public string Password
        {
            get => password;
            set
            {
                if (value != password)
                {
                    password = value;
                    if (viewModel != null) viewModel.Password = password;
                }
            }
        }
        #endregion

        #region

        // TODO: check spelling
        /// <summary>
        /// The model of autorisation 
        /// </summary>
        /// <param name="viewModel">The current instance of <see cref="SignInViewModel"/></param>
        public SignInModel(SignInViewModel viewModel)
        {
            this.Username = "Default Username";
            this.Password = "Default Password";

            this.viewModel = viewModel;
        }

        #endregion
    }
}
