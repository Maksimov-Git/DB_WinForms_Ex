using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;

namespace DB_WinForms_Ex0
{
    public partial class DBLoginForm : Form
    {
        public DBLoginForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            


            SqlConBuilder.SqlConnectionString.UserID = Login.Text;
            SqlConBuilder.SqlConnectionString.Password = Pass.Text;
            SqlConBuilder.SqlConnectionString.Pooling = true;

            if (SqlConBuilder.ConnectionTest()==true)
            {
                MessageBox.Show("соединение установлено успешно");
            }
            else 
            {
                MessageBox.Show(" что-то пошло не так");
            }
            

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Pass_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
