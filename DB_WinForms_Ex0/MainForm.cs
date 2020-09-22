using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//
using System.Data.SqlClient;

namespace DB_WinForms_Ex0
{
    


    public partial class MainForm : Form
    {
        public DBLoginForm LoginForm;

        public MainForm()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            
            

        }

        private void dataBaseConnectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
           // sqlConnectionString = new SqlConnectionStringBuilder();
            LoginForm = new DBLoginForm();
            LoginForm.Owner = this;
            LoginForm.ShowDialog();
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            SqlConBuilder.Command.CommandText = "SELECT TOP(1000) *FROM[TSOOPEX].[Person].[Address]";

            if (SqlConBuilder.Read() == true)
            {
                MessageBox.Show("чтение прошло успешно");
            
            }
            else
            {
                MessageBox.Show(" что-то пошло не так! ");
            }
        }
    }
}
