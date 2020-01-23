using Hitech.Business;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hitech.GUI;
using System.Data.SqlClient;

namespace Hitech.DataAccess
{
    public static class EmployeeDA
    {
        static string filePath = Application.StartupPath + @"\Employee.txt";
        static string filePath2 = Application.StartupPath + @"\Temp.txt";
        static string filePathPass = Application.StartupPath + @"\Password.txt";

        //public static List<Employees> GetEmployeeList()
        //{
        //    List<Employees> listEmp = new List<Employees>();
        //    // Connect and open database
        //    SqlConnection connDB = UtilityDB.ConnectDB();
        //    // Perform insert statement
        //    //create an object of type SqlCommand
        //    SqlCommand cmd = new SqlCommand();
        //    cmd.Connection = connDB;
        //    cmd.CommandText = "SELECT * FROM Employees";
        //    SqlDataReader sqlReader = cmd.ExecuteReader();
        //    Employees emp;
        //    while (sqlReader.Read())
        //    {
        //        emp = new Employees();
        //        emp.EmployeeId = Convert.ToInt32(sqlReader["EmployeeId"]);
        //        emp.FirstName = sqlReader["FirstName"].ToString();
        //        emp.LastName = sqlReader["LastName"].ToString();
        //        emp.Email = sqlReader["Email"].ToString();
        //        emp.JobTitle = sqlReader["JobTitle"].ToString();
        //        listEmp.Add(emp);
        //    }
        //    // close database
        //    connDB.Close();
        //    return listEmp;
        //}

        //save eployee to file
        public static void SaveRecord(Employees ee)
        {
            
        }



        //check employee  id is unique or not
        public static bool IsDuplicatedId(int id)
        {
            if (File.Exists(filePath))
            {
                StreamReader sr = new StreamReader(filePath);
                string line = sr.ReadLine();
                while (line != null && line != "")
                {
                    string[] fields = line.Split(',');
                    if (Convert.ToInt32(fields[0]) == id)
                    {
                        sr.Close();
                        return true;
                    }
                    line = sr.ReadLine();
                }
                sr.Close();
            }
            return false;
        }

        //search by employee id,only one can be found, but i return a list cause when show result is easy to deal with
        

        //search by firstname or lastname, it can be found more than one employee
        //public static List<Employees> SearchRecord(string name, bool bFirstName = true)
        //{
        //    name = name.ToUpper();
        //    List<Employees> eeList = new List<Employees>();
        //    if (File.Exists(filePath))
        //    {
        //        Employees ee = null;
        //        StreamReader sr = new StreamReader(filePath);
        //        string line = sr.ReadLine();
        //        while (line != null)
        //        {
        //            string[] fields = line.Split(',');
        //            if ((bFirstName && fields[1].ToUpper().CompareTo(name) == 0)
        //                || (!bFirstName && fields[2].ToUpper().CompareTo(name) == 0))
        //            {
        //                ee = new Employees();
        //                ee.EmployeeId = Convert.ToInt32(fields[0]);
        //                ee.FirstName = fields[1];
        //                ee.LastName = fields[2];
        //                ee.JobTitle = fields[3];
        //                ee.Email = fields[4];
        //                eeList.Add(ee);
        //            }
        //            line = sr.ReadLine();
        //        }
        //        sr.Close();
        //        return eeList;
        //    }
        //    return null;
        //}



        //read all employee form file
        public static List<Employees> ReadAllRecord()
        {
            List<Employees> eeList = new List<Employees>();
            if (File.Exists(filePath))
            {
                StreamReader sr = new StreamReader(filePath);
                string line = sr.ReadLine();
                while (line != null)
                {
                    string[] index = line.Split(',');
                    Employees ee = new Employees();
                    ee.EmployeeId = Convert.ToInt32(index[0]);
                    ee.FirstName = index[1];
                    ee.LastName = index[2];
                    ee.JobTitle = index[3];             
                    ee.Email = index[4];
                    eeList.Add(ee);
                    line = sr.ReadLine();
                }
                sr.Close();
            }
            if (eeList.Count() <= 0)
                MessageBox.Show("Employee not found!", "Error");
            return eeList;
        }

        
        public static void DeleteEmployee(Employees del)
        {
            //public static void SaveOrder(Employee ee)
            
                using (StreamWriter sw = new StreamWriter(filePath, true))
                {
                    sw.WriteLine();
                }
                using (StreamWriter swp = new StreamWriter(filePathPass, true))
                {
                    swp.WriteLine();
                }
                MessageBox.Show("Employee deleted success!", "Message");
            

            //StreamReader sr = new StreamReader(filePath);
            //StreamWriter sw = new StreamWriter(filePath2);
            //string line = sr.ReadLine();
            //while (line != null)
            //{
            //    string[] field = line.Split(',');
            //    if (del.EmployeeId != Convert.ToInt32(field[0]))
            //    {
            //        sw.WriteLine(field[0] + "," + field[1] + "," + field[2] + "," + field[3] + "," + field[4] + "," + field[5] + "," + field[6]);

            //    }
            //    line = sr.ReadLine();
            //}
            //sw.WriteLine(del.EmployeeId + "," + del.FirstName + "," + emp.LastName + "," + emp.Position + "," + emp.Nas + "," + emp.Phone + "," + emp.Email);
            //sw.Close();
            //sr.Close();
            //File.Delete(filePath);
            //File.Move(filePath2, filePath);
            //MessageBox.Show("Update successfully!");
        }
    }
}


