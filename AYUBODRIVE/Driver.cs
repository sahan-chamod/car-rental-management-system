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
    public partial class Driver : Form
    {
        public Driver()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-N2UG8268\SQLEXPRESS;Initial Catalog=AYUBODRIVE_CAR_RENTAL;Integrated Security=True");

        //DISPLAY DATA IN DATAGRIDVIEW//
        private void populate()
        {
            con.Open();
            string query = "SELECT * FROM DriverTable";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            guna2DataGridViewDrivers.DataSource = ds.Tables[0];
            con.Close();
        }
        private void CmbDriverID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbDriverID.SelectedIndex != -1)
            {
                string driverID = cmbDriverID.SelectedItem.ToString();
                try
                {
                    string query = "SELECT DriverName FROM DriverInfoTable WHERE DriverID = @DriverID";
                    using (SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-N2UG8268\SQLEXPRESS;Initial Catalog=AYUBODRIVE_CAR_RENTAL;Integrated Security=True"))
                    {
                        using (SqlCommand cmd = new SqlCommand(query, con))
                        {
                            cmd.Parameters.AddWithValue("@DriverID", driverID);
                            con.Open();
                            SqlDataReader sdr = cmd.ExecuteReader();
                            if (sdr.Read())
                            {
                                textBoxDriverName.Text = sdr["DriverName"].ToString();
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
        private void CmbTripType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTripType.SelectedIndex != -1)
            {
                string selectedType = cmbTripType.SelectedItem.ToString();
                cmbRelevantID.Items.Clear();

                try
                {
                    string query = "";

                    if (selectedType == "Rental")
                    {
                        query = "SELECT RentalID FROM RentTable";
                    }
                    else if (selectedType == "Day Tour")
                    {
                        query = "SELECT DayTourID FROM DayTourTable";
                    }
                    else if (selectedType == "Long Tour")
                    {
                        query = "SELECT LongTourID FROM LongTourTable";
                    }

                    using (SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-N2UG8268\SQLEXPRESS;Initial Catalog=AYUBODRIVE_CAR_RENTAL;Integrated Security=True"))
                    {
                        using (SqlCommand cmd = new SqlCommand(query, con))
                        {
                            con.Open();
                            SqlDataReader sdr = cmd.ExecuteReader();
                            while (sdr.Read())
                            {
                                cmbRelevantID.Items.Add(sdr[0].ToString());
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error occurred!" + ex);
                }
            }
        }

        private void Driver_Load(object sender, EventArgs e)
        {
            try
            {
                string query = "SELECT DriverID FROM DriverInfoTable";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    cmbDriverID.Items.Add(sdr["DriverID"].ToString());
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
            cmbDriverID.SelectedIndexChanged += CmbDriverID_SelectedIndexChanged;
            cmbTripType.SelectedIndexChanged += CmbTripType_SelectedIndexChanged;

        }
        private void clearAll()
        {
            cmbDriverID.SelectedIndex = -1;
            textBoxDriverName.Text = "";
            cmbTripType.SelectedIndex = -1;
            cmbRelevantID.SelectedIndex = -1;
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
                if (cmbDriverID.Text == "" || textBoxDriverName.Text == "" || cmbTripType.Text == "" || cmbRelevantID.Text == "")
                {
                    MessageBox.Show("Please fill all the fields!");
                }
                else
                {
                    con.Open();
                    string query = "INSERT INTO DriverTable VALUES('" + cmbDriverID.Text + "','" + textBoxDriverName.Text + "','" + cmbTripType.Text + "','" + cmbRelevantID.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Driver Added Successfully");
                    con.Close();
                    clearAll();
                    populate();
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
                if (cmbDriverID.Text == "")
                {
                    MessageBox.Show("Select the Driver to Delete");
                }
                else
                {
                    con.Open();
                    string query = "DELETE FROM DriverTable WHERE DriverID = '" + cmbDriverID.Text + "'";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Driver Deleted Successfully");
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

        private void guna2GradientButtonDeleteList_Click(object sender, EventArgs e)
        {
            Delete();
        }

        //DISPLAY DATA IN TEXTBOX//
        private void guna2DataGridViewDrivers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            cmbDriverID.Text = guna2DataGridViewDrivers.SelectedRows[0].Cells[0].Value.ToString();
            textBoxDriverName.Text = guna2DataGridViewDrivers.SelectedRows[0].Cells[1].Value.ToString();
            cmbTripType.Text = guna2DataGridViewDrivers.SelectedRows[0].Cells[2].Value.ToString();
            cmbRelevantID.Text = guna2DataGridViewDrivers.SelectedRows[0].Cells[3].Value.ToString();
        }

        //UPDATE//
        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbDriverID.Text == "")
                {
                    MessageBox.Show("Select the Driver to Update");
                }
                else
                {
                    con.Open();
                    string query = "UPDATE DriverTable SET Name = '" + textBoxDriverName.Text + "', TravelType = '" + cmbTripType.Text + "', RelevantID = '" + cmbRelevantID.Text + "' WHERE DriverID = '" + cmbDriverID.Text + "'";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Driver Updated Successfully");
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

        private void guna2GradientButtonADDNEW_Click(object sender, EventArgs e)
        {
            tabControlDrivers.SelectedTab = tabPageAddDriver;
        }

        private void guna2GradientButtonEditAT_Click(object sender, EventArgs e)
        {
            tabControlDrivers.SelectedTab = tabPageAddDriver;
        }
    }
    
}
