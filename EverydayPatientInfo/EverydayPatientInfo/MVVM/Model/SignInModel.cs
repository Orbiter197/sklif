using EverydayPatientInfo.MVVM.ViewModel;
using EverydayPatientInfo.ProjectStructure.DataBaseStructure;

using System.Data;
using MySql.Data.MySqlClient;

namespace EverydayPatientInfo.MVVM.Model
{
    /// <summary>
    /// The model for "Sign in" window that handles all logic
    /// This class is used to send a login and a password to a database
    /// </summary>
    class SignInModel
    {
        #region Private properties

        /// <summary>
        /// Login 
        /// </summary>
        private string login;

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
        /// Login 
        /// </summary>
        public string Login
        {
            get => login;
            set
            {
                if (value != login)
                {
                    login = value;
                    if (viewModel != null) 
                        viewModel.Username = login;
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
                    if (viewModel != null) 
                        viewModel.Password = password;
                }
            }
        }
        #endregion

        #region Public methods

        public void SignIn()
        {
            DB db = new DB();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE 'login' = @login AND 'password' = @password",db.getConnection());
            command.Parameters.Add("@login", MySqlDbType.VarChar).Value = Login;
            command.Parameters.Add("@password", MySqlDbType.VarChar).Value = Password;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
                Register();
        }
        public void Register()
        {
            // TODO: send data   
        }
        public void ResetPassword()
        {
            // TODO: send data   
        }

        #endregion

        #region

        /// <summary>
        /// The model of authorization 
        /// </summary>
        /// <param name="viewModel">The current instance of <see cref="SignInViewModel"/></param>
        public SignInModel(SignInViewModel viewModel)
        {
            this.Login = "Default Login";
            this.Password = "Default Password";

            // This must be at the end of a constructor
            this.viewModel = viewModel;
        }

        #endregion
    }
}
