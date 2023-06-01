using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// Rounded
using System.Runtime.InteropServices;

namespace StockScale___Gacer__Masilac__Gavino
{
    public partial class Form1 : Form
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

        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        public void formLoad(object Form)
        {
            if (this.panelShow.Controls.Count > 0)
                this.panelShow.Controls.RemoveAt(0);

            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.panelShow.Controls.Add(f);
            this.panelShow.Tag = f;
            f.Show();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            formLoad(new DashboardForm());
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            formLoad(new OrderHistoryForm());
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            formLoad(new StockForm());
        }

        private void btnNewOrder_Click(object sender, EventArgs e)
        {
            NewOrderForm show = new NewOrderForm();
            show.Show();
        }
        // Rounded
        private void panelButton_Paint(object sender, PaintEventArgs e)
        {
            panelButton.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panelButton.Width, panelButton.Height, 25, 25));
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            
            LoginForm shows = new LoginForm();
            shows.Show();
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panelNewOrder.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panelNewOrder.Width, panelNewOrder.Height, 50, 50));
        }
    }
}
