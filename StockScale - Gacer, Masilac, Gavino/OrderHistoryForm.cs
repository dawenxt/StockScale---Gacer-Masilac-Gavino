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
    public partial class OrderHistoryForm : Form
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

        public OrderHistoryForm()
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

        // This is a Save Info in Database and Fill the DataGridView to list all data input in our Database Access
        void dgLists()
        {
            // File Path of Database and to test Data (Go to Server Explorer right click Data Connections (Add New Connection))
            // then select data source Microsoft Access Database File (OLE DB) then paste your Database Access File Name Location
            // next is click advance and copy the Provider at the bottom.
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
            dgView.DataSource = table;

            // Database Close to run the Program
            conn.Close();

        }

     

        private void OrderHistoryForm_Load(object sender, EventArgs e)
        {
            dgLists();
            dgView.DefaultCellStyle.Font = new Font("Lexend", 12);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                // creating new variable name to call the Database Access file Location to exist in current context
                string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=DataFile_InventorySystemITEC103.accdb";
                // kapag ikaw ay nag type sa text box with name txt.search
                string searchTerm = txtSearch.Text;
                // dito ilalagay or kukunin yung database info (SELECT DATABASE Column and Rows)
                string query = "SELECT * FROM OrderHistory WHERE orderNumber LIKE '%" + searchTerm + "%'";

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
                        resId.Text = reader["ID"].ToString();
                        resOrder.Text = reader["orderNumber"].ToString();
                        resStudent.Text = reader["studentNumber"].ToString();
                        resProduct.Text = reader["productid"].ToString();
                        resQuan.Text = reader["quantity"].ToString();
                        resTotal.Text = reader["totalCost"].ToString();
                        resPayment.Text = reader["paymentMethod"].ToString();
                        resDate.Text = reader["orderDate"].ToString();

                    }
                    else
                    {
                        // This section shows a message box indicating that the data was not found
                        MessageBox.Show("This Data Not Found in Our Database");
                        // Delete the List if the error Appears 
                        resId.Text = "";
                        resOrder.Text = "";
                        resStudent.Text = "";
                        resProduct.Text = "";
                        resQuan.Text = "";
                        resTotal.Text = "";
                        resPayment.Text = "";
                        resDate.Text = "";
                    }
                }
            }
            catch
            {
                // If the error is not out of bound
                MessageBox.Show("This is Error in our Database, Sorry!");
            }
            
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            EditOrderForm edit = new EditOrderForm();
            edit.Show();
        }

        private void btnViewProduct_Click(object sender, EventArgs e)
        {
            ViewProductForm view = new ViewProductForm();
            view.Show();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {

        }

        private void lowerPanel1_Paint(object sender, PaintEventArgs e)
        {
            lowerPanel1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, lowerPanel1.Width, lowerPanel1.Height, 25, 25));
        }

        private void panelStockEdit_Paint(object sender, PaintEventArgs e)
        {
            panelStockEdit.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panelStockEdit.Width, panelStockEdit.Height, 25, 25));
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            panel2.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel2.Width, panel2.Height, 25, 25));
        }

        private void designPanel_Paint(object sender, PaintEventArgs e)
        {
            designPanel.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, designPanel.Width, designPanel.Height, 25, 25));
        }
    }
}
