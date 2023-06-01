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

// Regex symbols or regular expression is a sequence of characters that define a search pattern.
// They can be used to search for specific words or phrases, extract data from text.
using System.Text.RegularExpressions;

namespace StockScale___Gacer__Masilac__Gavino
{
    public partial class EditOrderForm : Form
    {
        public EditOrderForm()
        {
            InitializeComponent();
        }

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

            // Ilalagay na niya sa table at yung mismong database information gamit itong method name dgLists
            list.DataSource = table;

            // Database Close to run the Program
            conn.Close();

            // ...
        }

        private void EditOrderForm_Load(object sender, EventArgs e)
        {
            dgLists();
        }

        // Button Save
        private void btnSave_Click(object sender, EventArgs e)
        {
            // Using try Catch to lessen bugs
            try
            {
                string studentNo = addStudent.Text;
                // Need this pattern to insert in Student Number
                string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
                // Comparing 2 variable if the condition success if the condition not follow the error show.
                bool isValid = Regex.IsMatch(studentNo, pattern);

                if (isValid)
                {
                    string addNew = "INSERT INTO OrderHistory (orderNumber,studentNumber,productId,quantity,totalCost,paymentMethod,orderDate) VALUES (@orderNumber,@studentNumber,@productId,@quantity,@totalCost,@paymentMethod,@orderDate)";
                    cmd = new OleDbCommand(addNew, conn);

                    cmd.Parameters.AddWithValue("@orderNumber", addOrder.Text);
                    cmd.Parameters.AddWithValue("@studentNumber", addStudent.Text);
                    cmd.Parameters.AddWithValue("@productId", addProduct.Text);
                    cmd.Parameters.AddWithValue("@quantity", addQuantity.Text);
                    cmd.Parameters.AddWithValue("@totalCost", addTotal.Text);
                    cmd.Parameters.AddWithValue("@paymentMethod", addPayment.Text);
                    cmd.Parameters.AddWithValue("@orderDate", dtTime.Value.ToString("yyyy-MM-dd"));

                    try
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Success Insert to Database");
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

        // Button Add new
        private void btnAddnew_Click(object sender, EventArgs e)
        {
            lblShow.Text = "Fill up new in Form";
            lblID.Text = "";
            addOrder.Text = "";
            addStudent.Text = "";
            addProduct.Text = "";
            addQuantity.Text = "";
            addTotal.Text = "";
            addPayment.Text = "";
        }

        // Button Delete
        private void btnDelete_Click(object sender, EventArgs e)
        {
            string deleteRecord = "DELETE FROM OrderHistory WHERE ID=@ID";
            cmd = new OleDbCommand(deleteRecord, conn);
            cmd.Parameters.AddWithValue("@ID", lblID.Text); // set the id of the record to be deleted
            conn.Open(); // Opening Database
            cmd.ExecuteNonQuery(); // Read Line 114
            conn.Close(); // Closing Database

            MessageBox.Show("Success Delete from Database");

            // You need to call the conn void to save in our Database (Line 88)
            dgLists();
        }

        // Button Update
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string studentNo = addStudent.Text;
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            bool isValid = Regex.IsMatch(studentNo, pattern);

            if (isValid)
            {
                string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=DataFile_InventorySystemITEC103.accdb";
                OleDbConnection connection = new OleDbConnection(connectionString);

                string insertQuery = "UPDATE OrderHistory SET orderNumber = @orderNumber, studentNumber=@studentNumber, productId=@productId, quantity=@quantity, totalCost=@totalCost, paymentMethod=@paymentMethod, orderDate = @orderDate WHERE ID=@ID";

                OleDbCommand cmd = new OleDbCommand(insertQuery, connection);

                cmd.Parameters.AddWithValue("@orderNumber", addOrder.Text);
                cmd.Parameters.AddWithValue("@studentNumber", addStudent.Text);
                cmd.Parameters.AddWithValue("@productId", addProduct.Text);
                cmd.Parameters.AddWithValue("@quantity", addQuantity.Text);
                cmd.Parameters.AddWithValue("@totalCost", addTotal.Text);
                cmd.Parameters.AddWithValue("@paymentMethod", addPayment.Text);
                cmd.Parameters.AddWithValue("@orderDate", dtTime.Value.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@ID", Convert.ToInt32(lblID.Text)); // set the id of the record to be updated
                try
                {
                    connection.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Success: Email added to database");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    connection.Close();

                }
                dgLists();
            }
            else
            {
                MessageBox.Show("Please enter a valid email address");
            }
        }

        // Cell enter
        private void list_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            lblShow.Text = "";
            lblID.Text = list.CurrentRow.Cells[0].Value.ToString();
            addOrder.Text = list.CurrentRow.Cells[1].Value.ToString();
            addStudent.Text = list.CurrentRow.Cells[2].Value.ToString();
            addProduct.Text = list.CurrentRow.Cells[3].Value.ToString();
            addQuantity.Text = list.CurrentRow.Cells[4].Value.ToString();
            addTotal.Text = list.CurrentRow.Cells[5].Value.ToString();
            addPayment.Text = list.CurrentRow.Cells[6].Value.ToString();
            DateTime dateValue;
            if (DateTime.TryParse(list.CurrentRow.Cells[7].Value.ToString(), out dateValue))
            {
                dtTime.Value = dateValue;
            }
        }

        // Button Cancel
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
