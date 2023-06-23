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
    public partial class LongTour : Form
    {
        public LongTour()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-N2UG8268\SQLEXPRESS;Initial Catalog=AYUBODRIVE_CAR_RENTAL;Integrated Security=True");

        //DISPLAY DATA IN DATAGRIDVIEW//
        private void populate()
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

        private void LongTour_Load(object sender, EventArgs e)
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

            try
            {
                string query = "SELECT DISTINCT PackageName FROM LTPackageTable";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    cmbPackageType.Items.Add(sdr["PackageName"].ToString());
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

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            {
                float maxkm = 0;
                float packagePrice = 0;
                float extrakmPrice = 0;
                float driverOvernightRate = 0;
                float nightParkRate = 0;

                string query = "SELECT * FROM LTPackageTable WHERE V_Type  = '" + cmbVehicleType.Text + " ' AND PackageName = '" + cmbPackageType.Text + " '";
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    maxkm = float.Parse(sdr[3].ToString());
                    packagePrice = float.Parse(sdr[4].ToString());
                    extrakmPrice = float.Parse(sdr[5].ToString());
                    driverOvernightRate = float.Parse(sdr[6].ToString());
                    nightParkRate = float.Parse(sdr[7].ToString());
                }
                con.Close();

                txtBaseHireCharge.Text = packagePrice.ToString();

                TimeSpan ts = dtpEndDate.Value - dtpStartDate.Value;
                int daysTravelled = ts.Days + 1;

                float totalHire = packagePrice;

                //extra km charge//
                if ((float.Parse(txtEndKM.Text) - float.Parse(txtStartKM.Text)) > maxkm)
                {
                    txtExtraKMcharge.Text = (((float.Parse(txtEndKM.Text) - float.Parse(txtStartKM.Text)) - maxkm) * extrakmPrice).ToString();
                    totalHire += float.Parse(txtExtraKMcharge.Text);
                }

                //overnight charge//
                DateTime startDate = dtpStartDate.Value.Date;
                DateTime endDate = dtpEndDate.Value.Date;
                int numberOfNights = (int)(endDate - startDate).TotalDays;

                float overnightStayCharge = (driverOvernightRate * numberOfNights) + (nightParkRate * numberOfNights);
                txtOverNightStayCharge.Text = overnightStayCharge.ToString();
                totalHire += overnightStayCharge;

                txtTotalHire.Text = totalHire.ToString();
            }
        }
        private void clearAll()
        {
            textLongTourID.Clear();
            cmbVehicleREGNO.SelectedIndex = -1;
            cmbCustomerID.SelectedIndex = -1;
            textBoxCustomerName.Clear();
            cmbVehicleType.SelectedIndex = -1;
            cmbPackageType.SelectedIndex = -1;
            dtpStartDate.Value = DateTime.Now;
            dtpEndDate.Value = DateTime.Now;
            txtStartKM.Text = "";
            txtEndKM.Text = "";
            txtBaseHireCharge.Clear();
            txtOverNightStayCharge.Clear();
            txtExtraKMcharge.Clear();
            txtTotalHire.Clear();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearAll();
        }

        //INSERT//
        private void btnADD_Click(object sender, EventArgs e)
        {
            if (textLongTourID.Text == "" || cmbVehicleREGNO.Text == "" || cmbCustomerID.Text == "" || textBoxCustomerName.Text == "" || cmbVehicleType.Text == "" || cmbPackageType.Text == "" || txtStartKM.Text == "" || txtEndKM.Text == "")
            {
                MessageBox.Show("Please fill all the fields");
            }
            else
            {
                try
                {
                    con.Open();
                    string query = "INSERT INTO LongTourTable VALUES('" + textLongTourID.Text + "','" + cmbVehicleREGNO.Text + "','" + cmbCustomerID.Text + "','" + textBoxCustomerName.Text + "','" + cmbVehicleType.Text + "','" + cmbPackageType.Text + "','" + txtStartKM.Text + "','" + txtEndKM.Text + "','" + dtpStartDate.Value + "','" + dtpEndDate.Value + "','" + txtBaseHireCharge.Text + "','" + txtOverNightStayCharge.Text + "','" + txtExtraKMcharge.Text + "','" + txtTotalHire.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Long Tour Added Successfully!");
                    con.Close();
                    UpdateVehicleStatus();
                    populate();
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
            try
            {
                con.Open();
                string query = "DELETE FROM LongTourTable WHERE LongTourID = '" + textLongTourID.Text + "'";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Long Tour Deleted Successfully!");
                con.Close();
                populate();
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Delete();
        }

        //DISPLAY DATA IN TEXTBOX//
        private void guna2DataGridViewLongTour_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textLongTourID.Text = guna2DataGridViewLongTour.SelectedRows[0].Cells[0].Value.ToString();
            cmbVehicleREGNO.Text = guna2DataGridViewLongTour.SelectedRows[0].Cells[1].Value.ToString();
            cmbCustomerID.Text = guna2DataGridViewLongTour.SelectedRows[0].Cells[2].Value.ToString();
            textBoxCustomerName.Text = guna2DataGridViewLongTour.SelectedRows[0].Cells[3].Value.ToString();
            cmbVehicleType.Text = guna2DataGridViewLongTour.SelectedRows[0].Cells[4].Value.ToString();
            cmbPackageType.Text = guna2DataGridViewLongTour.SelectedRows[0].Cells[5].Value.ToString();
            txtStartKM.Text = guna2DataGridViewLongTour.SelectedRows[0].Cells[6].Value.ToString();
            txtEndKM.Text = guna2DataGridViewLongTour.SelectedRows[0].Cells[7].Value.ToString();
            dtpStartDate.Text = guna2DataGridViewLongTour.SelectedRows[0].Cells[8].Value.ToString();
            dtpEndDate.Text = guna2DataGridViewLongTour.SelectedRows[0].Cells[9].Value.ToString();
            txtBaseHireCharge.Text = guna2DataGridViewLongTour.SelectedRows[0].Cells[10].Value.ToString();
            txtOverNightStayCharge.Text = guna2DataGridViewLongTour.SelectedRows[0].Cells[11].Value.ToString();
            txtExtraKMcharge.Text = guna2DataGridViewLongTour.SelectedRows[0].Cells[12].Value.ToString();
            txtTotalHire.Text = guna2DataGridViewLongTour.SelectedRows[0].Cells[13].Value.ToString();
        }

        //UPDATE//
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (textLongTourID.Text == "" || cmbVehicleREGNO.Text == "" || cmbCustomerID.Text == "" || textBoxCustomerName.Text == "" || cmbVehicleType.Text == "" || cmbPackageType.Text == "" || txtStartKM.Text == "" || txtEndKM.Text == "")
            {
                MessageBox.Show("Please fill all the fields");
            }
            else
            {
                try
                {
                    con.Open();
                    string query = "UPDATE LongTourTable SET V_RegNum = '" + cmbVehicleREGNO.Text + "',Cus_ID = '" + cmbCustomerID.Text + "',CusName = '" + textBoxCustomerName.Text + "',V_Type = '" + cmbVehicleType.Text + "',P_Type = '" + cmbPackageType.Text + "',StartKM = '" + txtStartKM.Text + "',EndKM = '" + txtEndKM.Text + "',StartDate = '" + dtpStartDate.Value + "',EndDate = '" + dtpEndDate.Value + "',BHC = '" + txtBaseHireCharge.Text + "',OC = '" + txtOverNightStayCharge.Text + "',EKC = '" + txtExtraKMcharge.Text + "',TotalHire = '" + txtTotalHire.Text + "' WHERE LongTourID = '" + textLongTourID.Text + "'";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Long Tour Updated Successfully!");
                    con.Close();
                    UpdateVehicleStatus();
                    populate();
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

        private void guna2GradientButtonDeleteList_Click(object sender, EventArgs e)
        {
            Delete();
        }

        private void guna2GradientButtonADDNEW_Click(object sender, EventArgs e)
        {
            tabControlLongTour.SelectedTab = tabPageAddTour;
        }

        private void guna2GradientButtonEditAT_Click(object sender, EventArgs e)
        {
            tabControlLongTour.SelectedTab = tabPageAddTour;
        }
    }
}
