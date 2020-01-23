using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hitech.Business;

namespace Hitech.DataAccess
{
    //public static class OrdersDB
    //{
    //    public static void GenerateOrder(Orders order)
    //    {
    //        // Connect and open database
    //        SqlConnection connDB = UtilityDB.ConnectDB();
    //        // Perform insert statement
    //        //create an object of type SqlCommand
    //        SqlCommand cmd = new SqlCommand();
    //        cmd.Connection = connDB;
    //        string sqlInsert = "INSERT INTO Employees " +
    //                           "(EmployeeId,FirstName,LastName,Email,Phone)" +
    //                           " VALUES (@EmployeeId,@FirstName,@LastName,@Email,@Phone)";
    //        cmd.Parameters.AddWithValue("@EmployeeId", emp.EmployeeId);
    //        cmd.Parameters.AddWithValue("@FirstName", emp.FirstName);
    //        cmd.Parameters.AddWithValue("@LastName", emp.LastName);
    //        cmd.Parameters.AddWithValue("@Email", emp.Email);
    //        cmd.Parameters.AddWithValue("@Phone", emp.Phone);
    //        cmd.CommandText = sqlInsert;
    //        cmd.ExecuteNonQuery();
    //        // close database
    //        connDB.Close();
    //        MessageBox.Show("Employee record has been saved successfully", "Confirmation");
    //    }
    //}
}
