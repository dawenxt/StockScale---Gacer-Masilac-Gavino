using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// They can be used to search for specific words or phrases, extract data from text.
using System.Text.RegularExpressions;

using System.Data.OleDb;

namespace StockScale___Gacer__Masilac__Gavino
{
    public partial class NewOrderForm : Form
    {
        public NewOrderForm()
        {
            InitializeComponent();
        }

        // Set variable name to System.Data.OleDB (Line 18)

        // Connection to database
        OleDbConnection conn;
        // Commands to insert delete or update, select, and Reader (ExecuteReader() and ExecuteNonQuery())
        OleDbCommand cmd;
        // To Connect the Tools like datagridview direct to database
        OleDbDataAdapter adapter;
        // This is a column and rows in our database and inserting in our Forms ( Database access to Windows Form )
        DataTable table;

        // This method retrieves data from the database and fills the DataGridView
        void dgLists()
        {
            // ...

            conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=DataFile_InventorySystemITEC103.accdb");

            // And yung database file na nasa folder is babasahin nya yung name na myLists sa access database at magcreate siya ng table
            table = new DataTable();

            // Icoconnect na ang adapter at para mailagay siya sa database using tools
            adapter = new OleDbDataAdapter("SELECT * FROM OrderHistory", conn);

            // Opening the Database
            conn.Open();

            // Dito ireread niya yung column at rows sa database and ififill nya ito sa datagridview
            adapter.Fill(table);

            // Database Close to run the Program
            conn.Close();

            // ...
        }

        private void NewOrderForm_Load(object sender, EventArgs e)
        {
            dgLists();
        }

        // Button Add
        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Using try Catch to lessen bugs
            try
            {
                string studentNo = txtStudent.Text;
                // Need this pattern to insert in Student Number
                string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
                // Comparing 2 variable if the condition success if the condition not follow the error show.
                bool isValid = Regex.IsMatch(studentNo, pattern);

                if (isValid)
                {
                    string addNew = "INSERT INTO OrderHistory (orderNumber,studentNumber,productId,quantity,totalCost,paymentMethod,orderDate) VALUES (@orderNumber,@studentNumber,@productId,@quantity,@totalCost,@paymentMethod,@orderDate)";

                    cmd = new OleDbCommand(addNew, conn);

                    cmd.Parameters.AddWithValue("@orderNumber", txtOrder.Text);
                    cmd.Parameters.AddWithValue("@studentNumber", txtStudent.Text);
                    cmd.Parameters.AddWithValue("@productId", cbBox.Text);
                    cmd.Parameters.AddWithValue("@quantity", txtQuantity.Text);
                    cmd.Parameters.AddWithValue("@totalCost", txtCost.Text);
                    cmd.Parameters.AddWithValue("@paymentMethod", cbList.Text);
                    cmd.Parameters.AddWithValue("@orderDate", time.Value.ToString("yyyy-MM-dd"));
                    try
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Success Insert to Database, Please fill out new form");
                        txtOrder.Text = "";
                        txtStudent.Text = "";
                        cbBox.Text = "";
                        txtQuantity.Text = "";
                        txtCost.Text = "";
                        cbList.Text = "";

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                    finally
                    {
                        conn.Close();
                        dgLists();
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a valid email address");
                }
            }
            catch (Exception ex)
            {
                // Bug Catches
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        // Close Button
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
