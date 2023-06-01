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
    public partial class EditStockForm : Form
    {
        public EditStockForm()
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

        // DATABASE
        void dgLists()
        {
            // ...

            conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=DataFile_InventorySystemITEC103.accdb");

            // And yung database file na nasa folder is babasahin nya yung name na myLists sa access database at magcreate siya ng table
            table = new DataTable();

            // Icoconnect na ang adapter at para mailagay siya sa database using tools
            adapter = new OleDbDataAdapter("SELECT * FROM StockInventory", conn);

            // Opening the Database
            conn.Open();

            // Dito ireread niya yung column at rows sa database and ififill nya ito sa datagridview
            adapter.Fill(table);

            // Ilalagay na niya sa table at yung mismong database information gamit itong method name dgLists
            dataEdit.DataSource = table;

            // Database Close to run the Program
            conn.Close();

            // ...
        }

        private void EditStockForm_Load(object sender, EventArgs e)
        {
            dgLists();
        }

        // Button Delete
        private void btnAddnew_Click(object sender, EventArgs e)
        {
            lblFill.Text = "Fill Up new in Form";
            lblID.Text = "";
            lblProduct.Text = "";
            lblDescription.Text = "";
            txtOpening.Text = "";
            txtStock.Text = "";
            txtOut.Text = "";
            txtCost.Text = "";
            txtSales.Text = "";
            txtStatus.Text = "";
            txtStorage.Text = "";
            txtReorder.Text = "";
        }

        // Cancel
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Data Select
        private void dataEdit_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            lblID.Text = dataEdit.CurrentRow.Cells[0].Value.ToString();
            lblProduct.Text = dataEdit.CurrentRow.Cells[1].Value.ToString();
            lblDescription.Text = dataEdit.CurrentRow.Cells[2].Value.ToString();
            txtOpening.Text = dataEdit.CurrentRow.Cells[3].Value.ToString();
            txtStock.Text = dataEdit.CurrentRow.Cells[4].Value.ToString();
            txtOut.Text = dataEdit.CurrentRow.Cells[5].Value.ToString();
            txtCost.Text = dataEdit.CurrentRow.Cells[6].Value.ToString();
            txtSales.Text = dataEdit.CurrentRow.Cells[7].Value.ToString();
            txtStatus.Text = dataEdit.CurrentRow.Cells[8].Value.ToString();
            txtStorage.Text = dataEdit.CurrentRow.Cells[9].Value.ToString();
            DateTime dateValue;
            if (DateTime.TryParse(dataEdit.CurrentRow.Cells[10].Value.ToString(), out dateValue))
            {
                lastTime.Value = dateValue;
            }
            txtReorder.Text = dataEdit.CurrentRow.Cells[11].Value.ToString();
            DateTime dateValue1;
            if (DateTime.TryParse(dataEdit.CurrentRow.Cells[12].Value.ToString(), out dateValue1))
            {
                nextTime.Value = dateValue1;
            }
        }

        // Button Save
        private void btnSave_Click(object sender, EventArgs e)
        {
            // Using try Catch to lessen bugs
            try
            {
                string addNew = "INSERT INTO StockInventory (productNum,description,openingStock,stockValue,out,costItem,sales,status,storageNumber,lastUpdate,reorder,nextStock) VALUES (@productNum,@description,@openingStock,@stockValue,@out,@costItem,@sales,@status,@storageNumber,@lastUpdate,@reorder,@nextStock)";
                cmd = new OleDbCommand(addNew, conn);

                cmd.Parameters.AddWithValue("@productNum", lblProduct.Text);
                cmd.Parameters.AddWithValue("@description", lblDescription.Text);
                cmd.Parameters.AddWithValue("@openingStock", txtOpening.Text);
                cmd.Parameters.AddWithValue("@stockValue", txtStock.Text);
                cmd.Parameters.AddWithValue("@out", txtOut.Text);
                cmd.Parameters.AddWithValue("@costItem", txtCost.Text);
                cmd.Parameters.AddWithValue("@sales", txtSales.Text);
                cmd.Parameters.AddWithValue("@status", txtStatus.Text);
                cmd.Parameters.AddWithValue("@storageNumber", txtStorage.Text);
                cmd.Parameters.AddWithValue("@lastUpdate", lastTime.Value.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@reorder", txtReorder.Text);
                cmd.Parameters.AddWithValue("@nextStock", nextTime.Value.ToString("yyyy-MM-dd"));

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
            catch (Exception ex)
            {
                // Bug Catches
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        // button Update
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=DataFile_InventorySystemITEC103.accdb";
            OleDbConnection connection = new OleDbConnection(connectionString);

            string insertQuery = "UPDATE StockInventory SET productNum = @productNum, description=@description, openingStock=@openingStock, stockValue=@stockValue, out=@out, costItem=@costItem, sales = @sales, status = @status, storagenumber = @storageNumber, lastUpdate = @lastUpdate, reorder = @reorder, nextStock = @nextStock WHERE ID=@ID";

            OleDbCommand cmd = new OleDbCommand(insertQuery, connection);

            cmd.Parameters.AddWithValue("@productNum", lblProduct.Text);
            cmd.Parameters.AddWithValue("@description", lblDescription.Text);
            cmd.Parameters.AddWithValue("@openingStock", txtOpening.Text);
            cmd.Parameters.AddWithValue("@stockValue", txtStock.Text);
            cmd.Parameters.AddWithValue("@out", txtOut.Text);
            cmd.Parameters.AddWithValue("@costItem", txtCost.Text);
            cmd.Parameters.AddWithValue("@sales", txtSales.Text);
            cmd.Parameters.AddWithValue("@status", txtStatus.Text);
            cmd.Parameters.AddWithValue("@storageNumber", txtStorage.Text);
            cmd.Parameters.AddWithValue("@lastUpdate", lastTime.Value.ToString("yyyy-MM-dd"));
            cmd.Parameters.AddWithValue("@reorder", txtReorder.Text);
            cmd.Parameters.AddWithValue("@nextStock", nextTime.Value.ToString("yyyy-MM-dd"));
            cmd.Parameters.AddWithValue("@ID", Convert.ToInt32(lblID.Text)); // set the id of the record to be updated
            try
            {
                connection.Open();
                cmd.ExecuteNonQuery();
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

        // button Delete
        private void btnDelete_Click(object sender, EventArgs e)
        {
            string deleteRecord = "DELETE FROM StockInventory WHERE ID=@ID";
            cmd = new OleDbCommand(deleteRecord, conn);
            cmd.Parameters.AddWithValue("@ID", lblID.Text); // set the id of the record to be deleted
            conn.Open(); // Opening Database
            cmd.ExecuteNonQuery(); // Read Line 114
            conn.Close(); // Closing Database

            MessageBox.Show("Success Delete from Database");

            // You need to call the conn void to save in our Database (Line 88)
            dgLists();
        }
    }
}
