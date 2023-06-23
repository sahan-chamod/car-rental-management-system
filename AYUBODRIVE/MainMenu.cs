using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AYUBODRIVE
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }
        public void loadform(object Form)
        {
            if (this.mainpanel.Controls.Count > 0)
                this.mainpanel.Controls.RemoveAt(0);
            Form fh = Form as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.mainpanel.Controls.Add(fh);
            this.mainpanel.Tag = fh;
            fh.Show();

        }

        private void iconButtonDayTour_Click(object sender, EventArgs e)
        {
            loadform(new DayTour());
        }

        private void iconButtonLongTour_Click(object sender, EventArgs e)
        {
            loadform(new LongTour());
        }

        private void iconButtonRental_Click(object sender, EventArgs e)
        {
            loadform(new Rental());
        }

        private void iconButtonUsers_Click(object sender, EventArgs e)
        {
            loadform(new Users());
        }

        private void iconButtonCustomers_Click(object sender, EventArgs e)
        {
            loadform(new Customers());
        }

        private void iconButtonVehicles_Click(object sender, EventArgs e)
        {
            loadform(new Vehicles());
        }

        private void iconButtonReturn_Click(object sender, EventArgs e)
        {
            loadform(new Return());
        }

        private void LoadMainPanel()
        {
            // Clear existing controls from main panel
            mainpanel.Controls.Clear();

            // Load initial form into main panel
            Form initialForm = new HomePage();
            initialForm.TopLevel = false;
            initialForm.Dock = DockStyle.Fill;
            mainpanel.Controls.Add(initialForm);
            mainpanel.Tag = initialForm;
            initialForm.Show();
        }
        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            LoadMainPanel();
        }

        private void iconButtonDrivers_Click(object sender, EventArgs e)
        {
            loadform(new Driver());
        }

        private void iconButtonDashboard_Click(object sender, EventArgs e)
        {
            loadform(new Dashboard());
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }
    }
}
