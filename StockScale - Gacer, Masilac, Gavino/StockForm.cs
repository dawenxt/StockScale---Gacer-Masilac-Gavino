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
using System.Runtime.InteropServices;

namespace StockScale___Gacer__Masilac__Gavino
{
    public partial class StockForm : Form
    {
        // Importing Rounded Corner
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );

        public StockForm()
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

        void dgLists()
        {
            // File Path of Database and to test Data (Go to Server Explorer right click Data Connections (Add New Connection))
            // then select data source Microsoft Access Database File (OLE DB) then paste your Database Access File Name Location
            // next is click advance and copy the Provider at the bottom.
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
            dataGridView1.DataSource = table;

            // Database Close to run the Program
            conn.Close();

        }

        // Textbox Search
        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                // creating new variable name to call the Database Access file Location to exist in current context
                string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=DataFile_InventorySystemITEC103.accdb";
                // kapag ikaw ay nag type sa text box with name txt.search
                string searchTerm = tbSearch.Text;
                // dito ilalagay or kukunin yung database info (SELECT DATABASE Column and Rows)
                string query = "SELECT * FROM StockInventory WHERE productNum LIKE '%" + searchTerm + "%'";

                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    // First is select database info and second is to direct save in our database ( variable name query is "SELECT" and variable name connection is the file path to "SAVE" data )
                    OleDbCommand command = new OleDbCommand(query, connection);
                    // Opening Database File
                    connection.Open();
                    // Open Database Reader
                    OleDbDataReader reader = command.ExecuteReader();

                    // 1st Condition
                    if (reader.HasRows)
                    {
                        // This Section Print the result in Label (resultId, resultNo, resultName, resultBrgy, resultDate)
                        reader.Read();
                        lblid.Text = reader["ID"].ToString();
                        lblproduct.Text = reader["productNum"].ToString();
                        lblDes.Text = reader["description"].ToString();
                        lblStock.Text = reader["openingStock"].ToString();
                        lblValue.Text = reader["stockValue"].ToString();
                        lblOut.Text = reader["out"].ToString();
                        lblSales.Text = reader["sales"].ToString();
                        lblOn.Text = reader["status"].ToString();
                        lblStorage.Text = reader["storageNumber"].ToString();
                        lblLast.Text = reader["lastUpdate"].ToString();
                        lblReorder.Text = reader["reorder"].ToString();
                        lblNext.Text = reader["nextStock"].ToString();

                    }
                    else
                    {
                        // This section shows a message box indicating that the data was not found
                        MessageBox.Show("This Data Not Found in Our Database");
                        // Delete the List if the error Appears 
                        lblid.Text = "";
                        lblproduct.Text = "";
                        lblDes.Text = "";
                        lblStock.Text = "";
                        lblValue.Text = "";
                        lblOut.Text = "";
                        lblSales.Text = "";
                        lblStorage.Text = "";
                        lblLast.Text = "";
                        lblOn.Text = "";
                        lblNext.Text = "";
                        lblReorder.Text = "";
                    }
                }
            }
            catch
            {
                // If the error is not out of bound
                MessageBox.Show("This is Error in our Database, Sorry!");
            }
            
        }

        private void StockForm_Load(object sender, EventArgs e)
        {
            // Database
            dgLists();
            dataGridView1.DefaultCellStyle.Font = new Font("Lexend", 10);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            EditStockForm edit = new EditStockForm();
            edit.Show();
        }

        // Button Refresh
        private void btnRefresh_Click(object sender, EventArgs e)
        {

        }

        private void btnViewProduct_Click(object sender, EventArgs e)
        {
            ViewProductForm view = new ViewProductForm();
            view.Show();
        }

        private void panelStock_Paint(object sender, PaintEventArgs e)
        {
            panelStock.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panelStock.Width, panelStock.Height, 25, 25));
        }

        private void panelSearchStock_Paint(object sender, PaintEventArgs e)
        {
            panelSearchStock.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panelSearchStock.Width, panelSearchStock.Height, 25, 25));
        }

        private void designPanel_Paint(object sender, PaintEventArgs e)
        {
            designPanel.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, designPanel.Width, designPanel.Height, 25, 25));
        }
    }
}
