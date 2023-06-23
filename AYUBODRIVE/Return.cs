using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Globalization;

namespace AYUBODRIVE
{
    public partial class Return : Form
    {
        public Return()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-N2UG8268\SQLEXPRESS;Initial Catalog=AYUBODRIVE_CAR_RENTAL;Integrated Security=True");

        //DISPLAY DATA IN DATAGRIDVIEW//
        private void populateRent()
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
        private void populateReturn()
        {
            con.Open();
            string query = "SELECT * FROM ReturnTable";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            guna2DataGridViewReturn.DataSource = ds.Tables[0];
            con.Close();
        }
        private void populateDayTour()
        {
            con.Open();
            string query = "SELECT * FROM DayTourTable";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            guna2DataGridViewDayTour.DataSource = ds.Tables[0];
            con.Close();
        }
        private void populateLongTour()
        {
            con.Open();
            string query = "SELECT * FROM LongTourTable";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            guna2DataGridViewLongTour.DataSource = ds.Tables[0];
            con.Close();
        }
        private void UpdateVehicleStatus()
        {
            con.Open();
            string query = "UPDATE VehicleTable SET Availability = 'YES' WHERE RegNum = '" + cmbVehicleREGNO.Text + "'";
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
        private void Return_Load(object sender, EventArgs e)
        {
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
                string query = "SELECT RegNum FROM VehicleTable WHERE Availability = 'NO'";
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
            populateRent();
            populateReturn();
            populateDayTour();
            populateLongTour();
            cmbCustomerID.SelectedIndexChanged += CmbCustomerID_SelectedIndexChanged;
        }
        private void clearAll()
        {
            textReturnID.Text = "";
            cmbCustomerID.SelectedIndex = -1;
            textBoxCustomerName.Text = "";
            cmbVehicleREGNO.SelectedIndex = -1;
            txtDelay.Text = "";
            txtFine.Text = "";
            dtpReturnDate.Value = DateTime.Now;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearAll();
        }

        //INSERT//
        private void btnADD_Click(object sender, EventArgs e)
        {
            if (textReturnID.Text == "" || cmbCustomerID.Text == "" || textBoxCustomerName.Text == "" || cmbVehicleREGNO.Text == "" || txtDelay.Text == "" || txtFine.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    con.Open();
                    string query = "INSERT INTO ReturnTable VALUES('" + textReturnID.Text + "','" + cmbVehicleREGNO.Text + "','" + cmbCustomerID.Text + "','" + textBoxCustomerName.Text + "','" + dtpReturnDate.Value + "','" + txtDelay.Text + "','" + txtFine.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Return Added Successfully");
                    con.Close();
                    UpdateVehicleStatus();
                    populateReturn();
                    clearAll();
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
        }
        
        //DELETE//
        private void Delete()
        {
            {
                if (textReturnID.Text == "")
                {
                    MessageBox.Show("Enter the Return ID to Delete");
                }
                else
                {
                    try
                    {
                        con.Open();
                        string query = "DELETE FROM ReturnTable WHERE ReturnID = '" + textReturnID.Text + "'";
                        SqlCommand cmd = new SqlCommand(query, con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Return Deleted Successfully");
                        con.Close();
                        populateReturn();
                        clearAll();
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
        private void guna2DataGridViewReturn_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textReturnID.Text = guna2DataGridViewReturn.SelectedRows[0].Cells[0].Value.ToString();
            cmbVehicleREGNO.Text = guna2DataGridViewReturn.SelectedRows[0].Cells[1].Value.ToString();
            cmbCustomerID.Text = guna2DataGridViewReturn.SelectedRows[0].Cells[2].Value.ToString();
            textBoxCustomerName.Text = guna2DataGridViewReturn.SelectedRows[0].Cells[3].Value.ToString();
            dtpReturnDate.Text = guna2DataGridViewReturn.SelectedRows[0].Cells[4].Value.ToString();
            txtDelay.Text = guna2DataGridViewReturn.SelectedRows[0].Cells[5].Value.ToString();
            txtFine.Text = guna2DataGridViewReturn.SelectedRows[0].Cells[6].Value.ToString();
        }

        //UPDATE//
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (textReturnID.Text == "" || cmbCustomerID.Text == "" || textBoxCustomerName.Text == "" || cmbVehicleREGNO.Text == "" || txtDelay.Text == "" || txtFine.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    con.Open();
                    string query = "UPDATE ReturnTable SET V_RegNum = '" + cmbVehicleREGNO.Text + "', CustomerID = '" + cmbCustomerID.Text + "', CustomerName = '" + textBoxCustomerName.Text + "', ReturnDate = '" + dtpReturnDate.Value + "', Delay = '" + txtDelay.Text + "', Fine = '" + txtFine.Text + "' WHERE ReturnID = '" + textReturnID.Text + "'";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Return Updated Successfully");
                    con.Close();
                    UpdateVehicleStatus();
                    populateReturn();
                    clearAll();
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
        }

        private void guna2GradientButtonADDNEW_Click(object sender, EventArgs e)
        {
            tabControlReturn.SelectedTab = tabPageAddReturn;
        }

        private void guna2GradientButtonEditAT_Click(object sender, EventArgs e)
        {
            tabControlReturn.SelectedTab = tabPageAddReturn;
        }

        private void guna2DataGridViewRental_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            cmbVehicleREGNO.Text = guna2DataGridViewRental.SelectedRows[0].Cells[1].Value.ToString();
            cmbCustomerID.Text = guna2DataGridViewRental.SelectedRows[0].Cells[2].Value.ToString();
            textBoxCustomerName.Text = guna2DataGridViewRental.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void guna2DataGridViewDayTour_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            cmbVehicleREGNO.Text = guna2DataGridViewDayTour.SelectedRows[0].Cells[1].Value.ToString();
            cmbCustomerID.Text = guna2DataGridViewDayTour.SelectedRows[0].Cells[2].Value.ToString();
            textBoxCustomerName.Text = guna2DataGridViewDayTour.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void guna2DataGridViewLongTour_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            cmbVehicleREGNO.Text = guna2DataGridViewLongTour.SelectedRows[0].Cells[1].Value.ToString();
            cmbCustomerID.Text = guna2DataGridViewLongTour.SelectedRows[0].Cells[2].Value.ToString();
            textBoxCustomerName.Text = guna2DataGridViewLongTour.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            tabControlReturn.SelectedTab = tabPageAddReturn;
        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            tabControlReturn.SelectedTab = tabPageAddReturn;
        }

        private void guna2GradientButton3_Click(object sender, EventArgs e)
        {
            tabControlReturn.SelectedTab = tabPageAddReturn;
        }
    }
}
