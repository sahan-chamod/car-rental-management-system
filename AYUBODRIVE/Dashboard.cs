using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AYUBODRIVE
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-N2UG8268\SQLEXPRESS;Initial Catalog=AYUBODRIVE_CAR_RENTAL;Integrated Security=True");

        public void loadform(object Form)
        {
            if (this.mainpanel2.Controls.Count > 0)
                this.mainpanel2.Controls.RemoveAt(0);
            Form fh = Form as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.mainpanel2.Controls.Add(fh);
            this.mainpanel2.Tag = fh;
            fh.Show();

        }
        private void Dashboard_Load(object sender, EventArgs e)
        {
            string queryVehicles = "SELECT COUNT(*) FROM VehicleTable";
            string queryCustomers = "SELECT COUNT(*) FROM CustomerTable";
            string queryUsers = "SELECT COUNT(*) FROM UserTable";
            string queryDayTour = "SELECT COUNT(*) FROM DayTourTable";
            string queryLongTour = "SELECT COUNT(*) FROM LongTourTable";
            string queryRental = "SELECT COUNT(*) FROM RentTable";
            con.Open();
            SqlCommand cmdVehicles = new SqlCommand(queryVehicles, con);
            SqlCommand cmdCustomers = new SqlCommand(queryCustomers, con);
            SqlCommand cmdUsers = new SqlCommand(queryUsers, con);
            SqlCommand cmdDayTour = new SqlCommand(queryDayTour, con);
            SqlCommand cmdLongTour = new SqlCommand(queryLongTour, con);
            SqlCommand cmdRental = new SqlCommand(queryRental, con);
            int countVehicles = (int)cmdVehicles.ExecuteScalar();
            int countCustomers = (int)cmdCustomers.ExecuteScalar();
            int countUsers = (int)cmdUsers.ExecuteScalar();
            int countDayTour = (int)cmdDayTour.ExecuteScalar();
            int countLongTour = (int)cmdLongTour.ExecuteScalar();
            int countRental = (int)cmdRental.ExecuteScalar();
            con.Close();
            labelVehicles.Text = countVehicles.ToString();
            labelCustomers.Text = countCustomers.ToString();
            labelUsers.Text = countUsers.ToString();
            labelDayTour.Text = countDayTour.ToString();
            labelLongTour.Text = countLongTour.ToString();
            labelRental.Text = countRental.ToString();
        }

        private void LoadRentalPackage()
        {
            // Clear existing controls from main panel
            mainpanel2.Controls.Clear();

            // Load initial form into main panel
            Form initialForm = new RentalPackage();
            initialForm.TopLevel = false;
            initialForm.Dock = DockStyle.Fill;
            mainpanel2.Controls.Add(initialForm);
            mainpanel2.Tag = initialForm;
            initialForm.Show();
        }
        private void LoadRentalPack()
        {
            // Clear existing controls from main panel
            mainpanel2.Controls.Clear();

            // Load initial form into main panel
            Form initialForm = new RentalPackage();
            initialForm.TopLevel = false;
            initialForm.Dock = DockStyle.Fill;
            mainpanel2.Controls.Add(initialForm);
            mainpanel2.Tag = initialForm;
            initialForm.Show();
        }
        private void LoadLongTourPack()
        {
            // Clear existing controls from main panel
            mainpanel2.Controls.Clear();

            // Load initial form into main panel
            Form initialForm = new LongTourPackage();
            initialForm.TopLevel = false;
            initialForm.Dock = DockStyle.Fill;
            mainpanel2.Controls.Add(initialForm);
            mainpanel2.Tag = initialForm;
            initialForm.Show();
        }
        private void LoadDayTourPack()
        {
            // Clear existing controls from main panel
            mainpanel2.Controls.Clear();

            // Load initial form into main panel
            Form initialForm = new DayTourPackage();
            initialForm.TopLevel = false;
            initialForm.Dock = DockStyle.Fill;
            mainpanel2.Controls.Add(initialForm);
            mainpanel2.Tag = initialForm;
            initialForm.Show();
        }
        private void LoadDriverInfo()
        {
            // Clear existing controls from main panel
            mainpanel2.Controls.Clear();

            // Load initial form into main panel
            Form initialForm = new DriverInfo();
            initialForm.TopLevel = false;
            initialForm.Dock = DockStyle.Fill;
            mainpanel2.Controls.Add(initialForm);
            mainpanel2.Tag = initialForm;
            initialForm.Show();
        }
        private void iconButtonRentalPackages_Click(object sender, EventArgs e)
        {
            LoadRentalPack();
        }

        private void iconButtonLongTourPackages_Click(object sender, EventArgs e)
        {
            LoadLongTourPack();
        }

        private void iconButtonDayTourPackages_Click(object sender, EventArgs e)
        {
            LoadDayTourPack();
        }

        private void iconButtonDriverInfo_Click(object sender, EventArgs e)
        {
            LoadDriverInfo();
        }
    }
}
