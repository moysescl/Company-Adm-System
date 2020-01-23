using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hitech.Business;
using System.Data.SqlClient;
using System.Windows.Forms;
using Hitech.GUI;

namespace Hitech.DataAccess
{
    public static class EmployeeDB
    {
        public static void SaveRecord(Employees emp)
        {
            // Connect and open database
            SqlConnection connDB = UtilityDB.ConnectDB();
            // Perform insert statement
            //create an object of type SqlCommand
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connDB;
            string sqlInsert = "INSERT INTO Employees " +
                               "(EmployeeId,FirstName,LastName,JobTitle,Email)" +
                               " VALUES (@EmployeeId,@FirstName,@LastName,@JobTitle,@Email)";
            cmd.Parameters.AddWithValue("@EmployeeId", emp.EmployeeId);
            cmd.Parameters.AddWithValue("@FirstName", emp.FirstName);
            cmd.Parameters.AddWithValue("@LastName", emp.LastName);
            cmd.Parameters.AddWithValue("@JobTitle", emp.JobTitle);            
            cmd.Parameters.AddWithValue("@Email", emp.Email);            
            cmd.CommandText = sqlInsert;
            cmd.ExecuteNonQuery();
            // close database
            connDB.Close();
            MessageBox.Show("Employee record has been saved successfully", "Confirmation");
        }

        public static int GetEmployeeId()
        {
            int nextId = 1001;
            // connect and open the database
            SqlConnection connDB = UtilityDB.ConnectDB();
            // create and customize the SqlCommand object
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT max(EmployeeId) as TempId " +
                              " FROM Employees";
            cmd.Connection = connDB;
            SqlDataReader sqlReader = cmd.ExecuteReader();
            if (sqlReader.Read())
            {
                if (!sqlReader.IsDBNull(0))
                {
                    nextId = Convert.ToInt32(sqlReader["TempId"]) + 1;
                }

            }
            // close the database
            connDB.Close();
            //return the nextId
            return nextId;
        }

        public static List<Employees> GetEmployeeList()
        {
            List<Employees> listEmp = new List<Employees>();
            // Connect and open database
            SqlConnection connDB = UtilityDB.ConnectDB();
            // Perform insert statement
            //create an object of type SqlCommand
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connDB;
            cmd.CommandText = "SELECT * FROM Employees";
            SqlDataReader sqlReader = cmd.ExecuteReader();
            Employees emp;
            while (sqlReader.Read())
            {
                emp = new Employees();
                emp.EmployeeId = Convert.ToInt32(sqlReader["EmployeeId"]);
                emp.FirstName = sqlReader["FirstName"].ToString();
                emp.LastName = sqlReader["LastName"].ToString();
                emp.JobTitle = sqlReader["JobTitle"].ToString();              
                emp.Email = sqlReader["Email"].ToString();
                listEmp.Add(emp);
            }
            // close database
            connDB.Close();
            return listEmp;
        }

        public static Employees SearchRecordId(int empId)
        {            
            Employees emp = new Employees();

            // Connect Database
            SqlConnection connDB = UtilityDB.ConnectDB();

            // Create SQl command
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = connDB;

            // Create the Select Statement
            cmd.CommandText = "SELECT * FROM Employees" +
                              " WHERE EmployeeId = " + empId;//+
                              //" OR FirstName = " + empId;

            SqlDataReader sqlReader = cmd.ExecuteReader();

            if (sqlReader.Read())
            {
                emp.EmployeeId = Convert.ToInt32(sqlReader["EmployeeId"]);
                emp.FirstName = sqlReader["FirstName"].ToString();
                emp.LastName = sqlReader["LastName"].ToString();
                emp.JobTitle = sqlReader["JobTitle"].ToString();
                emp.Email = sqlReader["Email"].ToString();
                
            }
            else
            {
                emp = null;
            }
            return emp;
        }
        public static Employees SearchRecordFn(string empFn)
        {
            Employees emp = new Employees();
            
            // Connect Database
            SqlConnection connDB = UtilityDB.ConnectDB();

            // Create SQl command
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = connDB;

            // Create the Select Statement
            cmd.CommandText = "SELECT * FROM Employees" +
                              " WHERE FirstName = '" + empFn+"'";//+
                                                             //" OR FirstName = " + empId;

            SqlDataReader sqlReader = cmd.ExecuteReader();

            if (sqlReader.Read())
            {
                emp.EmployeeId = Convert.ToInt32(sqlReader["EmployeeId"]);
                emp.FirstName = sqlReader["FirstName"].ToString();
                emp.LastName = sqlReader["LastName"].ToString();
                emp.JobTitle = sqlReader["JobTitle"].ToString();
                emp.Email = sqlReader["Email"].ToString();

            }
            else
            {
                emp = null;
            }
            return emp;
        }
        public static void UpdateRecord(Employees emp)
        {
            //Connect and open the database : SqlConnection
            SqlConnection connDb = UtilityDB.ConnectDB();

            // Perform the Update operation : SqlCommand
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.Connection = connDb;


            sqlCmd.CommandText = "Update Employees " +
                                 "SET EmployeeId = @EmployeeId, " +
                                 "    FirstName = @FirstName, " +
                                 "    LastName = @LastName, " +
                                 "    JobTitle = @JobTitle, " +
                                 "    Email = @Email " +
                                 " WHERE EmployeeId = @EmployeeId";
            sqlCmd.Parameters.AddWithValue("@EmployeeId", emp.EmployeeId);
            sqlCmd.Parameters.AddWithValue("@FirstName", emp.FirstName);
            sqlCmd.Parameters.AddWithValue("@LastName", emp.LastName);
            sqlCmd.Parameters.AddWithValue("@JobTitle", emp.JobTitle);
            sqlCmd.Parameters.AddWithValue("@Email", emp.Email);
            

            sqlCmd.ExecuteNonQuery();

            //Close the database
            connDb.Close();
            MessageBox.Show("Employee record has been updated successully..", "Confirmation");
        }
        public static void DeleteRecord(int empId)
        {
            SqlConnection conndb = UtilityDB.ConnectDB();
            try
            {

                string sqlDelete = "DELETE from Employees " +
                               " WHERE EmployeeId = " + empId;

                SqlCommand cmd = new SqlCommand(sqlDelete, conndb);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record deleted Successfully.");

            }
            catch (FormatException)
            {
                throw;
            }
            finally
            {
                conndb.Close();
            }
        }
    }
}
