using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace EverydayPatientInfo.ProjectStructure
{

    /// <summary>
    /// This class is used to access the database
    /// </summary>
    static class Authorization
    {
        #region Private field

        /// <summary>
        /// The ID of a user that is using this application
        /// </summary>
        private static int? userID;

        #endregion

        #region Public properties

        /// <summary>
        /// The ID of a user that is using this application
        /// </summary>
        public static int? UserID { get => userID; }

        /// <summary>
        /// If user have sucsesfully signed in, returns true
        /// </summary>
        public static bool Access { get => userID != null; }

        #endregion

        #region Static constructor

        static Authorization()
        {
            userID = null;
        }

        #endregion

        #region Public methods

        /// <summary>
        /// Signs in employee 
        /// </summary>
        /// <param name="cardID"></param>
        /// <param name="password"></param>
        /// <returns>True if successful, otherwise false</returns>
        public static bool SignIn(string cardID, string password)
        {
            MySqlCommand command = new("SELECT * FROM employees WHERE card_id = @ui AND pass = @up;", DataBaseHandler.Connection);
            command.Parameters.Add("@ui", MySqlDbType.VarChar).Value = cardID;
            command.Parameters.Add("@up", MySqlDbType.VarChar).Value = password;

            DataBaseHandler.Open();
            MySqlDataReader reader = command.ExecuteReader();

            if (!reader.HasRows)
            {
                reader.Close();
                return false;
            }

            reader.Read();
            userID = reader.GetFieldValue<int>(0);
            reader.Close();

            DataBaseHandler.Close();

            ProjectMainClass.Update();

            return true;

            
        }

        /// <summary>
        /// Resets employees password 
        /// </summary>
        /// <param name="cardID">Employees cardID</param>
        /// <param name="password1">Employees new password</param>
        /// <param name="password2">Employees new password confirm</param>
        /// <returns>True if successful, otherwise false</returns>
        public static bool ResetPassword(string cardID, string password1, string password2)
        {
            if (password1 != password2)
                return false;

            DataBaseHandler.Open();
            MySqlCommand command = new("UPDATE employees SET pass = @up WHERE card_id = @ui");
            command.Parameters.Add("@ui", MySqlDbType.VarChar).Value = cardID;
            command.Parameters.Add("@up", MySqlDbType.VarChar).Value = password1;
            bool res = command.ExecuteNonQuery() != 0;
            DataBaseHandler.Close();
            return res;
        }

        /// <summary>
        /// Signs up an employee in the database
        /// </summary>
        /// <param name="lastName">Employees last name</param>
        /// <param name="firstName">Employees first name</param>
        /// <param name="patronymic">Employees patronymic</param>
        /// <param name="dateOfBirth">Employees date of birth</param>
        /// <param name="cardID">Employees cardID</param>
        /// <param name="password1">Employees new password</param>
        /// <param name="password2">Employees new password confirm</param>
        /// <returns>True if successful, otherwise false</returns>
        public static bool SignUp(string lastName, string firstName, string patronymic, string dateOfBirth, string cardID, string password1, string password2)
        {
            DataBaseHandler.Open();
            MySqlCommand command;

            command = new("SELECT * FROM employees WHERE card_id = @ui;", DataBaseHandler.Connection);
            command.Parameters.Add("@ui", MySqlDbType.VarChar).Value = cardID;
            MySqlDataReader reader = command.ExecuteReader();
            if(reader.HasRows)
            {
                reader.Close();
                return false;
            }
            reader.Close();
            DataBaseHandler.Close();

            DataBaseHandler.Open();
            command = new("INSERT INTO employees(card_id,pass,last_name,first_name, role) VALUES(@card_id, @pass, @last_name, @first_name, 0);", DataBaseHandler.Connection);
            command.Parameters.Add("@card_id", MySqlDbType.VarChar).Value = cardID;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = password1;
            command.Parameters.Add("@last_name", MySqlDbType.VarChar).Value = lastName;
            command.Parameters.Add("@first_name", MySqlDbType.VarChar).Value = firstName;
            command.ExecuteNonQuery();
            DataBaseHandler.Close();
            return true;
        }
        #endregion
    }
}
