using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// System.Data.OleDb is namespace in the .NET Framework that provides a set of classes for accessing data in a variety of data sources using the OLE DB data provider.
using System.Data.OleDb;

namespace StockScale___Gacer__Masilac__Gavino
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        // Connection to database
        OleDbConnection conn;
        // Commands to insert delete or update, select, and Reader (ExecuteReader() and ExecuteNonQuery())
        OleDbCommand cmd;
        // To Connect the Tools like datagridview, textbox direct to database
        OleDbDataAdapter adapter;

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=DataFile_InventorySystemITEC103.accdb";
                string query = "SELECT COUNT(*) FROM loginAccount WHERE Username = @username AND Password = @password";
                using (OleDbConnection connection = new OleDbConnection(connectionString))
                using (OleDbCommand command = new OleDbCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@username", txtUsername.Text);
                    command.Parameters.AddWithValue("@password", txtPassword.Text);
                    connection.Open();
                    int result = (int)command.ExecuteScalar();
                    if (result > 0)
                    {
                        Form1 form1 = new Form1();
                        form1.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Invalid Username and Password");
                    }
                }
            }
            catch
            {
                MessageBox.Show("Error In Database");
            }
        }
        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
