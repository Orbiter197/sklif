using EverydayPatientInfo.MVVM.ViewModel;
using EverydayPatientInfo.ProjectStructure.DataBaseStructure;

using System.Data;
using MySql.Data.MySqlClient;

namespace EverydayPatientInfo.MVVM.Model
{
    /// <summary>
    /// The model for "Sign in" window that handles all logic
    /// This class is used to send a cardID and a password to a database
    /// </summary>
    class SignInModel
    {
        #region Private properties

        /// <summary>
        /// Password 
        /// </summary>
        private readonly SignInViewModel viewModel;
        #endregion

        #region Public methods

        /// <summary>
        /// 
        /// </summary>
        public bool SignIn(string login, string password)
        {
            DB db = new DB();

            db.GetConnection().Open();

            DataTable table = new();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE 'user_login' = @cardID AND 'user_password' = @password",db.GetConnection());
            command.Parameters.Add("@cardID", MySqlDbType.VarChar).Value = login;
            command.Parameters.Add("@password", MySqlDbType.VarChar).Value = password;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            db.GetConnection().Close();

            if (table.Rows.Count > 0)
            {
                Register();
                return true;
            }
            return false;
            
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
            this.viewModel = viewModel;
        }

        #endregion
    }
}
