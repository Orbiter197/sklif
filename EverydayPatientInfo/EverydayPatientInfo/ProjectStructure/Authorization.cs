using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace EverydayPatientInfo.ProjectStructure
{
    public static class Authorization
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
        public static bool SignIn(string cardID, string password)
        {
            MySqlCommand command = new("SELECT * FROM employees WHERE card_id = @ui AND pass = @up;", DB.Connection);
            command.Parameters.Add("@ui", MySqlDbType.VarChar).Value = cardID;
            command.Parameters.Add("@up", MySqlDbType.VarChar).Value = password;

            MySqlDataAdapter adapter = new(command);
            DataTable table = new();
            adapter.Fill(table);

            return table.Rows.Count > 0;
        }

        public static bool ResetPassword(string cardID, string password1, string password2)
        {
            if (password1 != password2)
                return false;
            DB.Open();
            MySqlCommand command = new("UPDATE employees SET pass = @up WHERE card_id = @ui");
            command.Parameters.Add("@ui", MySqlDbType.VarChar).Value = cardID;
            command.Parameters.Add("@up", MySqlDbType.VarChar).Value = password1;
            bool res = command.ExecuteNonQuery() != 0;
            DB.Close();
            return res;
        }

        public static bool SignUp(string lastName, string firstName, string patronymic, string dateOfBirth, string cardID, string password1, string password2)
        {
            MySqlCommand command = new("SELECT * FROM employees WHERE card_id = @ui;", DB.Connection);
            command.Parameters.Add("@ui", MySqlDbType.VarChar).Value = cardID;
            MySqlDataAdapter adapter = new(command);
            DataTable table = new();
            adapter.Fill(table);
            if (table.Rows.Count > 0)
                return false;

            DB.Open();
            command = new("INSERT INTO employees(card_id,pass,last_name,first_name) VALUES(@card_id, @pass, @last_name, @first_name);", DB.Connection);
            command.Parameters.Add("@card_id", MySqlDbType.VarChar).Value = cardID;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = password1;
            command.Parameters.Add("@last_name", MySqlDbType.VarChar).Value = lastName;
            command.Parameters.Add("@first_name", MySqlDbType.VarChar).Value = firstName;
            command.ExecuteNonQuery();
            DB.Close();
            return true;
        }
        #endregion
    }
}
