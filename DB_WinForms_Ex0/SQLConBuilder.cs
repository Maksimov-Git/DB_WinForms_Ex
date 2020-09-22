using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
namespace DB_WinForms_Ex0
{
    public static class SqlConBuilder
    {

        public static SqlConnectionStringBuilder SqlConnectionString;
        public static SqlConnection Connection;
        public static SqlCommand Command;
        public static SqlDataAdapter SqlAdapter;
        public static SqlDataReader Reader;
        public static Boolean ConnectionTest()
        {
            

            Connection.ConnectionString = SqlConnectionString.ConnectionString;
            try
            {
                Connection.Open();
                return true;
            }
            catch (Exception ex) // 
            {
                return false;
            }
            finally
            {
                Connection.Close();
            }





        }
        static SqlConBuilder()
        {
            Connection = new SqlConnection();
            SqlConnectionString = new SqlConnectionStringBuilder();
            SqlConnectionString.DataSource = "tsoop.c6oo9thiejqr.us-east-1.rds.amazonaws.com";
            SqlConnectionString.InitialCatalog = "TSOOPEX";

            Command = new SqlCommand("", Connection);
        }
        public static Boolean Read()
        {
            try
            {
                Connection.Open();
                Reader = Command.ExecuteReader();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                Connection.Close();
            }
        }
    }
}
