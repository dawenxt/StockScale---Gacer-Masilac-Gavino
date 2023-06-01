using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Windows.Forms.DataVisualization.Charting;
using System.Runtime.InteropServices;
using System.Drawing.Drawing2D;

namespace StockScale___Gacer__Masilac__Gavino
{
    public partial class DashboardForm : Form
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
        public DashboardForm()
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
            adapter = new OleDbDataAdapter("SELECT TOP 10 * FROM [OrderHistory] ORDER BY ID DESC", conn);

            // Opening the Database
            conn.Open();

            // Dito ireread niya yung column at rows sa database and ififill nya ito sa datagridview
            adapter.Fill(table);

            // Ilalagay na niya sa table at yung mismong database information gamit itong method name dgLists
            dgViewDashBoard.DataSource = table;

            // Database Close to run the Program
            conn.Close();

        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {
            dgLists();
            UpdateStockStatus();
            string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=DataFile_InventorySystemITEC103.accdb";
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                // Open the connection
                connection.Open();

                // Create a command object with your SQL query
                string query = "SELECT productId, SUM(quantity * totalCost) AS total_sales_value FROM OrderHistory GROUP BY productId";
                using (OleDbCommand command = new OleDbCommand(query, connection))
                {
                    // Execute the query and retrieve the results
                    using (OleDbDataReader reader = command.ExecuteReader())
                    {
                        // Create a new chart series
                        Series series = new Series("Sales");
                        series.ChartType = SeriesChartType.Doughnut;

                        // Add data points to the series
                        while (reader.Read())
                        {
                            string shirtName = reader["productId"].ToString();
                            double totalSalesValue = Convert.ToDouble(reader["total_sales_value"]);

                            series.Points.AddXY(shirtName, totalSalesValue);
                        }

                        // Add the series to the chart
                        chart1.Series.Add(series);
                        dgViewDashBoard.DefaultCellStyle.Font = new Font("Lexend", 14);
                    }
                }

                // Close the connection
                connection.Close();
            }
        }
        private void UpdateStockStatus()
        {
            // Retrieve stock data from the database
            string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=DataFile_InventorySystemITEC103.accdb";
            string query = "SELECT productNum, [StockInventory]![openingStock]-[StockInventory]![out] AS stock_status FROM StockInventory";

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                using (OleDbCommand command = new OleDbCommand(query, connection))
                {
                    connection.Open();
                    using (OleDbDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string itemName = reader["productNum"].ToString();
                            int stockStatus = Convert.ToInt32(reader["stock_status"]);

                            // Find the label control based on the item name
                            Label label = Controls.Find("label_" + itemName, true).FirstOrDefault() as Label;
                            Panel panel = Controls.Find("panel_" + itemName, true).FirstOrDefault() as Panel;
                            if (label != null)
                            {
                                // Update label's background color based on stock status
                                if (stockStatus == 0)
                                {
                                    panel.BackColor = Color.Red;
                                    label.BackColor = Color.Red; // No stock
                                    label.Text = "no stocks";
                                }
                                else if (stockStatus <= 10)
                                {
                                    panel.BackColor = Color.Orange;
                                    label.BackColor = Color.Orange;
                                    label.Text = "extremely low";
                                }
                                else if (stockStatus > 0 && stockStatus < 30)
                                {
                                    panel.BackColor = Color.Yellow;
                                    label.BackColor = Color.Yellow; // Low stock
                                    label.Text = "low in stocks";
                                    label.ForeColor = Color.Black;
                                }
                                else
                                {   
                                    panel.BackColor = Color.Green;
                                    label.BackColor = Color.Green; // Sufficient stock
                                    label.Text = "sufficient stock";
                                }
                            }
                        }
                    }
                    connection.Close();
                }
            }
        }
        
        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            salesPanel.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, salesPanel.Width, salesPanel.Height, 25, 25));
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {
            dgDBPanel.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, dgDBPanel.Width, dgDBPanel.Height, 25, 25));
        }

        private void panel1_Paint_2(object sender, PaintEventArgs e)
        {
            stockPanel.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, stockPanel.Width, stockPanel.Height, 25, 25));
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void panel_UNI000_Paint(object sender, PaintEventArgs e)
        {
            panel_UNI000.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel_UNI000.Width, panel_UNI000.Height, 16, 16));
        }

        private void panel_CWS350_Paint(object sender, PaintEventArgs e)
        {
            panel_CWS350.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel_CWS350.Width, panel_CWS350.Height, 16, 16));
        }

        private void panel_CCS420_Paint(object sender, PaintEventArgs e)
        {
            panel_CCS420.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel_CCS420.Width, panel_CCS420.Height, 16, 16));
        }

        private void panel_CAS123_Paint(object sender, PaintEventArgs e)
        {
            panel_CAS123.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel_CAS123.Width, panel_CAS123.Height, 16, 16));
        }

        private void panel_CTE023_Paint(object sender, PaintEventArgs e)
        {
            panel_CTE023.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel_CTE023.Width, panel_CTE023.Height, 16, 16));
        }

        private void panel_CIT911_Paint(object sender, PaintEventArgs e)
        {
            panel_CIT911.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel_CIT911.Width, panel_CIT911.Height, 16, 16));
        }

        private void panel_COE333_Paint(object sender, PaintEventArgs e)
        {
            panel_COE333.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel_COE333.Width, panel_COE333.Height, 16, 16));
        }
    }
}
