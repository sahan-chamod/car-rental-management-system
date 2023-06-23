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
    public partial class RentalPackage : Form
    {
        public RentalPackage()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-N2UG8268\SQLEXPRESS;Initial Catalog=AYUBODRIVE_CAR_RENTAL;Integrated Security=True");
        
        //DISPLAY DATA IN DATAGRIDVIEW//
        private void populate()
        {
            con.Open();
            string query = "SELECT * FROM VehicleType";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            guna2DataGridViewRentalPackages.DataSource = ds.Tables[0];
            con.Close();
        }

        private void RentalPackage_Load(object sender, EventArgs e)
        {
            populate();
        }
        public void loadform(object Form)
        {
            if (this.mainpanel3.Controls.Count > 0)
                this.mainpanel3.Controls.RemoveAt(0);
            Form fh = Form as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.mainpanel3.Controls.Add(fh);
            this.mainpanel3.Tag = fh;
            fh.Show();

        }
        private void clearAll()
        {
            {
                textVehicleType.Text = "";
                textPricePerDay.Text = "";
                textPricePerWeek.Text = "";
                textPricePerMonth.Text = "";
                textDriverRatePerDate.Text = "";
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearAll();
        }

        //INSERT//
        private void btnADD_Click(object sender, EventArgs e)
        {
            if (textVehicleType.Text == "" || textPricePerDay.Text == "" || textPricePerWeek.Text == "" || textPricePerMonth.Text == "" || textDriverRatePerDate.Text == "")
            {
                MessageBox.Show("Please fill all the fields");
            }
            else
            {
                try
                {
                    con.Open();
                    string query = "INSERT INTO VehicleType VALUES('" + textVehicleType.Text + "','" + textPricePerDay.Text + "','" + textPricePerWeek.Text + "','" + textPricePerMonth.Text + "','" + textDriverRatePerDate.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Rental Package Added Successfully!");
                    con.Close();
                    populate();
                    clearAll();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
                finally
                {
                    con.Close();
                }
            }
        }
        //DELETE//
        private void Delete()
        {
            if (textVehicleType.Text == "")
            {
                MessageBox.Show("Please Select the Vehicle Type to Delete");
            }
            else
            {
                try
                {
                    con.Open();
                    string query = "DELETE FROM VehicleType WHERE VehicleType='" + textVehicleType.Text + "'";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Rental Package Deleted Successfully!");
                    con.Close();
                    populate();
                    clearAll();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
                finally
                {
                    con.Close();
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Delete();
        }

        private void guna2GradientButtonDeleteList_Click(object sender, EventArgs e)
        {
            Delete();
        }

        //DISPLAY DATA IN TEXTBOX//
        private void guna2DataGridViewRentalPackages_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textVehicleType.Text = guna2DataGridViewRentalPackages.SelectedRows[0].Cells[0].Value.ToString();
            textPricePerDay.Text = guna2DataGridViewRentalPackages.SelectedRows[0].Cells[1].Value.ToString();
            textPricePerWeek.Text = guna2DataGridViewRentalPackages.SelectedRows[0].Cells[2].Value.ToString();
            textPricePerMonth.Text = guna2DataGridViewRentalPackages.SelectedRows[0].Cells[3].Value.ToString();
            textDriverRatePerDate.Text = guna2DataGridViewRentalPackages.SelectedRows[0].Cells[4].Value.ToString();
        }
        // UPDATE//
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (textVehicleType.Text == "" || textPricePerDay.Text == "" || textPricePerWeek.Text == "" || textPricePerMonth.Text == "" || textDriverRatePerDate.Text == "")
            {
                MessageBox.Show("Please Select the Vehicle Type to Update");
            }
            else
            {
                try
                {
                    con.Open();
                    string query = "UPDATE VehicleType SET VehicleType ='" + textVehicleType.Text +
                        "',PricePerDay='" + textPricePerDay.Text + "',PricePerWeek='" + textPricePerWeek.Text + "',PricePerMonth='" + textPricePerMonth.Text + "',DriverRatePerDay='" + textDriverRatePerDate.Text + "' WHERE VehicleType='" + textVehicleType.Text + "'";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Rental Package Updated Successfully!");
                    con.Close();
                    populate();
                    clearAll();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
                finally
                {
                    con.Close();
                }
            }
        }
        private void LoadBack()
        {
            // Clear existing controls from main panel
            mainpanel3.Controls.Clear();

            // Load initial form into main panel
            Form initialForm = new Dashboard();
            initialForm.TopLevel = false;
            initialForm.Dock = DockStyle.Fill;
            mainpanel3.Controls.Add(initialForm);
            mainpanel3.Tag = initialForm;
            initialForm.Show();
        }

        private void guna2GradientButtonBack_Click(object sender, EventArgs e)
        {
            LoadBack();
        }

        private void guna2GradientButtonADDNEW_Click(object sender, EventArgs e)
        {
            tabControlRentalPackages.SelectedTab = tabPageAddPackages;
        }

        private void guna2GradientButtonEditAT_Click(object sender, EventArgs e)
        {
            tabControlRentalPackages.SelectedTab = tabPageAddPackages;
        }

        private void guna2GradientButtonBack2_Click(object sender, EventArgs e)
        {
            LoadBack();
        }
    }
}