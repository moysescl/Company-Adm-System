using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hitech.Business;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace Hitech.DataAccess
{
    public static class UserDB
    {
        public static void SavePass(Userr au)
        {
            // Connect and open database
            SqlConnection connDB = UtilityDB.ConnectDB();
            // Perform insert statement
            //create an object of type SqlCommand
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connDB;
            string sqlInsert = "INSERT INTO Users " +
                               "(UserName,Password)" +
                               " VALUES (@UserName,@Password)";
            cmd.Parameters.AddWithValue("@UserName", au.UserName);
            cmd.Parameters.AddWithValue("@Password", au.Password);            
            cmd.CommandText = sqlInsert;
            cmd.ExecuteNonQuery();
            // close database
            connDB.Close();
            MessageBox.Show("Employee record has been saved successfully", "Confirmation");
        }
        public static bool IsValidUser(Userr myUser)
        {

            using (SqlConnection connectionDb = UtilityDB.ConnectDB())
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connectionDb;
                string sqlSelect = "SELECT UserName,Password FROM Users " +
                                   "WHERE UserName = @UserName AND Password = @Password";
                cmd.CommandText = sqlSelect;
                cmd.Parameters.AddWithValue("@UserName", myUser.UserName);
                cmd.Parameters.AddWithValue("@Password", myUser.Password);
                SqlDataReader sqlReader = cmd.ExecuteReader();
                if (sqlReader.Read())
                {

                    return true;
                }
                else
                {
                    return false;
                }

            }


        }
    }
}
