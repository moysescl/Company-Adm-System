using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient; // To work with Sql Server Database
using System.Configuration;


namespace Hitech.DataAccess
{
    public static class UtilityDB
    {
        public static SqlConnection ConnectDB()
        {
            SqlConnection sqlConn = new SqlConnection();            
            sqlConn.ConnectionString = ConfigurationManager.ConnectionStrings["connHiTechDB"].ConnectionString;
            sqlConn.Open();
            return sqlConn;

        }
    }
}
