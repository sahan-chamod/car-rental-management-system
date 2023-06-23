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
    public partial class Rental : Form
    {
        public Rental()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-N2UG8268\SQLEXPRESS;Initial Catalog=AYUBODRIVE_CAR_RENTAL;Integrated Security=True");

        //DISPLAY DATA IN DATAGRIDVIEW//
        private void populate()
        {
            con.Open();
            string query = "SELECT * FROM RentTable";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            guna2DataGridViewRental.DataSource = ds.Tables[0];
            con.Close();
        }
        private void UpdateVehicleStatus()
        {
            con.Open();
            string query = "UPDATE VehicleTable SET Availability = 'NO' WHERE RegNum = '" + cmbVehicleREGNO.Text + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            con.Close();
        }
        private void CmbCustomerID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCustomerID.SelectedIndex != -1)
            {
                string customerId = cmbCustomerID.SelectedItem.ToString();
                try
                {
                    string query = "SELECT Cus_Name FROM CustomerTable WHERE Cus_ID = @Cus_ID";
                    using (SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-N2UG8268\SQLEXPRESS;Initial Catalog=AYUBODRIVE_CAR_RENTAL;Integrated Security=True"))
                    {
                        using (SqlCommand cmd = new SqlCommand(query, con))
                        {
                            cmd.Parameters.AddWithValue("@Cus_ID", customerId);
                            con.Open();
                            SqlDataReader sdr = cmd.ExecuteReader();
                            if (sdr.Read())
                            {
                                textBoxCustomerName.Text = sdr["Cus_Name"].ToString();
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error occurred!" + ex);
                }
                finally
                {
                    con.Close();
                }
            }
        }
        private void CmbVehicleREGNO_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbVehicleREGNO.SelectedIndex != -1)
            {
                string vehicleRegNum = cmbVehicleREGNO.SelectedItem.ToString();
                try
                {
                    string query = "SELECT V_Type FROM VehicleTable WHERE RegNum = @RegNum";
                    using (SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-N2UG8268\SQLEXPRESS;Initial Catalog=AYUBODRIVE_CAR_RENTAL;Integrated Security=True"))
                    {
                        using (SqlCommand cmd = new SqlCommand(query, con))
                        {
                            cmd.Parameters.AddWithValue("@RegNum", vehicleRegNum);
                            con.Open();
                            SqlDataReader sdr = cmd.ExecuteReader();
                            if (sdr.Read())
                            {
                                cmbVehicleType.SelectedItem = sdr["V_Type"].ToString();
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error occurred!" + ex);
                }
                finally
                {
                    con.Close();
                }
            }
        }

        private void Rental_Load(object sender, EventArgs e)
        {
            try
            {
                string query = "SELECT VehicleType FROM VehicleType";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    cmbVehicleType.Items.Add(sdr["VehicleType"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occured!" + ex);
            }
            finally
            {
                con.Close();
            }

            try
            {
                string query = "SELECT Cus_ID FROM CustomerTable";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    cmbCustomerID.Items.Add(sdr["Cus_ID"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occured!" + ex);
            }
            finally
            {
                con.Close();
            }

            try
            {
                string query = "SELECT RegNum FROM VehicleTable WHERE Availability = 'YES'";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    cmbVehicleREGNO.Items.Add(sdr["RegNum"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occured!" + ex);
            }
            finally
            {
                con.Close();
            }
            populate();
            cmbCustomerID.SelectedIndexChanged += CmbCustomerID_SelectedIndexChanged;
            cmbVehicleREGNO.SelectedIndexChanged += CmbVehicleREGNO_SelectedIndexChanged;

        }
        private void clearAll()
        {
            textRentalID.Clear();
            cmbCustomerID.SelectedIndex = -1;
            textBoxCustomerName.Clear();
            cmbVehicleREGNO.SelectedIndex = -1;
            cmbVehicleType.SelectedIndex = -1;
            dtpRentedDate.Value = DateTime.Now;
            dtpReturnDate.Value = DateTime.Now;
            cmbDriver.SelectedIndex = -1;
            txtTotalDriverCost.Clear();
            txtTotalRent.Clear();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int perDayRent = 0;
            int perWeekRent = 0;
            int perMonthRent = 0;
            int driverPerDayRent = 0;
            int totalRent = 0;

            string query = "SELECT * FROM VehicleType WHERE VehicleType = '" + cmbVehicleType.Text + "'";

            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            SqlDataReader r = cmd.ExecuteReader();
            while (r.Read())
            {
                perDayRent = int.Parse(r[1].ToString());
                perWeekRent = int.Parse(r[2].ToString());
                perMonthRent = int.Parse(r[3].ToString());
                driverPerDayRent = int.Parse(r[4].ToString());
            }
            con.Close();

            TimeSpan difference = dtpReturnDate.Value - dtpRentedDate.Value;
            int days = difference.Days + 1;

            if (cmbDriver.Text == "With Driver")
            {
                int driverCost = days * driverPerDayRent;
                txtTotalDriverCost.Text = driverCost.ToString();
                totalRent = totalRent + driverCost;
            }
            else
            {
                txtTotalDriverCost.Clear();
            }

            if (days >= 30)
            {
                int Months = days / 30;
                days = days % 30;
                totalRent = totalRent + (Months * perMonthRent);
            }

            if (days >= 7)
            {
                int Weeks = days / 7;
                days = days % 7;
                totalRent = totalRent + (Weeks * perWeekRent);
            }

            if (days > 0)
            {
                totalRent = totalRent + (days * perDayRent);
            }

            txtTotalRent.Text = totalRent.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearAll();
        }

        //INSERT//
        private void btnADD_Click(object sender, EventArgs e)
        {
            try
            {
                if (textRentalID.Text == "" || cmbCustomerID.Text == "" || textBoxCustomerName.Text == "" || cmbVehicleREGNO.Text == "" || cmbVehicleType.Text == "" || cmbDriver.Text == "")
                {
                    MessageBox.Show("Please fill all the fields!");
                }
                else
                {
                    con.Open();
                    string query = "INSERT INTO RentTable VALUES('" + textRentalID.Text + "','" + cmbVehicleREGNO.Text + "','" + cmbCustomerID.Text + "','" + textBoxCustomerName.Text + "', '" + cmbVehicleType.Text + "','" + dtpRentedDate.Value + "','" + dtpReturnDate.Value + "','" + cmbDriver.Text + "','" + txtTotalDriverCost.Text + "','" + txtTotalRent.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Rental Added Successfully");
                    con.Close();
                    UpdateVehicleStatus();
                    populate();
                    clearAll();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occured!" + ex);
            }
            finally
            {
                con.Close();
            }
        }
        //DELETE//
        private void Delete()
        {
            try
            {
                if (textRentalID.Text == "")
                {
                    MessageBox.Show("Select the Rental to Delete");
                }
                else
                {
                    con.Open();
                    string query = "DELETE FROM RentTable WHERE RentalID = '" + textRentalID.Text + "'";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Rental Deleted Successfully");
                    con.Close();
                    populate();
                    clearAll();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occured!" + ex);
            }
            finally
            {
                con.Close();
            }


        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Delete();
        }

        //DISPLAY DATA IN TEXTBOX//
        private void guna2DataGridViewRental_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textRentalID.Text = guna2DataGridViewRental.SelectedRows[0].Cells[0].Value.ToString();
            cmbVehicleREGNO.Text = guna2DataGridViewRental.SelectedRows[0].Cells[1].Value.ToString();
            cmbCustomerID.Text = guna2DataGridViewRental.SelectedRows[0].Cells[2].Value.ToString();
            textBoxCustomerName.Text = guna2DataGridViewRental.SelectedRows[0].Cells[3].Value.ToString();
            cmbVehicleType.Text = guna2DataGridViewRental.SelectedRows[0].Cells[4].Value.ToString();
            dtpRentedDate.Text = guna2DataGridViewRental.SelectedRows[0].Cells[5].Value.ToString();
            dtpReturnDate.Text = guna2DataGridViewRental.SelectedRows[0].Cells[6].Value.ToString();
            cmbDriver.Text = guna2DataGridViewRental.SelectedRows[0].Cells[7].Value.ToString();
            txtTotalDriverCost.Text = guna2DataGridViewRental.SelectedRows[0].Cells[8].Value.ToString();
            txtTotalRent.Text = guna2DataGridViewRental.SelectedRows[0].Cells[9].Value.ToString();
        }

        //UPDATE//
        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (textRentalID.Text == "" || cmbCustomerID.Text == "" || textBoxCustomerName.Text == "" || cmbVehicleREGNO.Text == "" || cmbVehicleType.Text == "" || cmbDriver.Text == "")
                {
                    MessageBox.Show("Missing Information");
                }
                else
                {
                    con.Open();
                    string query = "UPDATE RentTable SET V_RegNum = '" + cmbVehicleREGNO.Text + "', Cus_ID = '" + cmbCustomerID.Text + "', CusName = '" + textBoxCustomerName.Text + "', V_Type = '" + cmbVehicleType.Text + "', RentalDate = '" + dtpRentedDate.Value + "', ReturnDate = '" + dtpReturnDate.Value + "', Driver = '" + cmbDriver.Text + "', DriverCost = '" + txtTotalDriverCost.Text + "', TotalRent = '" + txtTotalRent.Text + "' WHERE RentalID = '" + textRentalID.Text + "'";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Rental Updated Successfully");
                    con.Close();
                    UpdateVehicleStatus();
                    populate();
                    clearAll();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occured!" + ex);
            }
            finally
            {
                con.Close();
            }
        }

        private void guna2GradientButtonDeleteList_Click(object sender, EventArgs e)
        {
            Delete();
        }

        private void guna2GradientButtonADDNEW_Click(object sender, EventArgs e)
        {
            tabControlRental.SelectedTab = tabPageAddRental;
        }

        private void guna2GradientButtonEditAT_Click(object sender, EventArgs e)
        {
            tabControlRental.SelectedTab = tabPageAddRental;
        }
    }

}
