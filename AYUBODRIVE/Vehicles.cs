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
    public partial class Vehicles : Form
    {
        public Vehicles()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-N2UG8268\SQLEXPRESS;Initial Catalog=AYUBODRIVE_CAR_RENTAL;Integrated Security=True");

        //DISPLAY DATA IN DATAGRIDVIEW//
        private void populate()
        {
            con.Open();
            string query = "SELECT * FROM VehicleTable";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            guna2DataGridViewVehicles.DataSource = ds.Tables[0];
            con.Close();
        }

        private void Vehicles_Load(object sender, EventArgs e)
        {
            populate();
        }
        //CLEAR//
        private void ClearAll()
        {
            TextBoxVehRegNum.Text = "";
            TextBoxVehBrand.Text = "";
            TextBoxVehType.Text = "";
            TextBoxVehNumPlate.Text = "";
            TextBoxVehCost.Text = "";
            cmbVehAvailability.SelectedIndex = -1;
        }

        //INSERT//
        private void btnADD_Click(object sender, EventArgs e)
        {
            if (TextBoxVehRegNum.Text == "" || TextBoxVehBrand.Text == "" || TextBoxVehType.Text == "" || TextBoxVehNumPlate.Text == "" || TextBoxVehCost.Text == "" || cmbVehAvailability.Text == "")
            {
                MessageBox.Show("Please Fill All The Fields");
            }
            else
            {
                try
                {
                    con.Open();
                    string query = "INSERT INTO VehicleTable VALUES('" + TextBoxVehRegNum.Text + "','" + TextBoxVehNumPlate.Text + "','" + TextBoxVehType.Text + "','" + TextBoxVehBrand.Text + "','" + TextBoxVehCost.Text + "','" + cmbVehAvailability.Text + "')";
                    SqlDataAdapter sda = new SqlDataAdapter(query, con);
                    sda.SelectCommand.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Vehicle Added Successfully");
                    populate();
                    ClearAll();
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
        //Delete//
        private void Delete()
        {
            {
                if (TextBoxVehRegNum.Text == "")
                {
                    MessageBox.Show("Please Select The Vehicle To Delete");
                }
                else
                {
                    try
                    {
                        con.Open();
                        string query = "DELETE FROM VehicleTable WHERE RegNum = '" + TextBoxVehRegNum.Text + "'";
                        SqlDataAdapter sda = new SqlDataAdapter(query, con);
                        sda.SelectCommand.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Vehicle Deleted Successfully");
                        populate();
                        ClearAll();
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
        private void guna2DataGridViewVehicles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            TextBoxVehRegNum.Text = guna2DataGridViewVehicles.SelectedRows[0].Cells[0].Value.ToString();
            TextBoxVehNumPlate.Text = guna2DataGridViewVehicles.SelectedRows[0].Cells[1].Value.ToString();
            TextBoxVehType.Text = guna2DataGridViewVehicles.SelectedRows[0].Cells[2].Value.ToString();
            TextBoxVehBrand.Text = guna2DataGridViewVehicles.SelectedRows[0].Cells[3].Value.ToString();
            TextBoxVehCost.Text = guna2DataGridViewVehicles.SelectedRows[0].Cells[4].Value.ToString();
            cmbVehAvailability.Text = guna2DataGridViewVehicles.SelectedRows[0].Cells[5].Value.ToString();
        }

        //UPDATE//
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (TextBoxVehRegNum.Text == "" || TextBoxVehBrand.Text == "" || TextBoxVehType.Text == "" || TextBoxVehNumPlate.Text == "" || TextBoxVehCost.Text == "" || cmbVehAvailability.Text == "")
            {
                MessageBox.Show("Please Fill All The Fields");
            }
            else
            {
                try
                {
                    con.Open();
                    string query = "UPDATE VehicleTable SET RegNum = '" + TextBoxVehRegNum.Text + "', NumPlate = '" + TextBoxVehNumPlate.Text + "', V_Type = '" + TextBoxVehType.Text + "',Brand = '" + TextBoxVehBrand.Text + "', Cost = '" + TextBoxVehCost.Text + "', Availability = '" + cmbVehAvailability.Text + "' WHERE RegNum = '" + TextBoxVehRegNum.Text + "'";
                    SqlDataAdapter sda = new SqlDataAdapter(query, con);
                    sda.SelectCommand.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Vehicle Updated Successfully");
                    populate();
                    ClearAll();
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

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void guna2GradientButtonADDNEW_Click(object sender, EventArgs e)
        {
            tabControlVehicles.SelectedTab = tabPageAddVehicle;
        }

        private void guna2GradientButtonEditAT_Click(object sender, EventArgs e)
        {
            tabControlVehicles.SelectedTab = tabPageAddVehicle;
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            populate();
            ComboBoxSearch.SelectedIndex = -1;
        }

        private void ComboBoxSearch_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string flag = "";
            if (ComboBoxSearch.SelectedItem.ToString() == "Available")
            {
                flag = "YES";
            }
            else
            {
                flag = "NO";

            }
            con.Open();
            string query = "SELECT * FROM VehicleTable WHERE Availability = '" + flag + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            guna2DataGridViewVehicles.DataSource = dt;
            con.Close();

        }

    }
}