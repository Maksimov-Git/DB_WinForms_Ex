using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

using System.Windows.Forms;

namespace DB_WinForms_Ex0
{
    public static class SqlConBuilder
    {

        public static SqlConnectionStringBuilder SqlConnectionString;
        public static SqlConnection Connection;
        public static SqlCommand Command;
        public static SqlDataAdapter SqlAdapter;
        public static DataSet DatSet;
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
                MessageBox.Show(ex.Message);
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
           // SqlConnectionString.UserID = "admin";
           // SqlConnectionString.Password = "Geirby1799"; 
            Command = new SqlCommand("", Connection);
            Connection.ConnectionString = SqlConnectionString.ConnectionString;
        }
        public static Boolean Read(ref DataGridView data )
        {
            try
            {
                Connection.Open();
                SqlAdapter = new SqlDataAdapter(Command.CommandText, Connection);
                DatSet = new DataSet();
                SqlAdapter.Fill(DatSet);
                data.DataSource = DatSet.Tables[0];
            
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
