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
    public partial class LongTourPackage : Form
    {
        public LongTourPackage()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-N2UG8268\SQLEXPRESS;Initial Catalog=AYUBODRIVE_CAR_RENTAL;Integrated Security=True");

        //DISPLAY DATA IN DATAGRIDVIEW//
        private void populate()
        {
            con.Open();
            string query = "SELECT * FROM LTPackageTable";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            guna2DataGridViewLongTourPackages.DataSource = ds.Tables[0];
            con.Close();
        }

        private void LongTourPackage_Load(object sender, EventArgs e)
        {
            populate();
        }
        public void loadform(object Form)
        {
            if (this.mainpanel4.Controls.Count > 0)
                this.mainpanel4.Controls.RemoveAt(0);
            Form fh = Form as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.mainpanel4.Controls.Add(fh);
            this.mainpanel4.Tag = fh;
            fh.Show();

        }
        private void clearAll()
        {
            textPackageID.Text = "";
            textPackageName.Text = "";
            textVehicleType.Text = "";
            textMaxKM.Text = "";
            textPackagePrice.Text = "";
            textExtraKMprice.Text = "";
            textDriverOvernightRate.Text = "";
            textNightParkRate.Text = "";

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearAll();
        }
        //INSERT//
        private void btnADD_Click(object sender, EventArgs e)
        {
            if (textPackageID.Text == "" || textPackageName.Text == "" || textVehicleType.Text == "" || textMaxKM.Text == "" || textPackagePrice.Text == "" || textExtraKMprice.Text == "" || textDriverOvernightRate.Text == "" || textNightParkRate.Text == "")
            {
                MessageBox.Show("Please fill all the fields");
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO LTPackageTable VALUES('" + textPackageID.Text + "','" + textPackageName.Text + "','" + textVehicleType.Text + "','" + textMaxKM.Text + "','" + textPackagePrice.Text + "','" + textExtraKMprice.Text + "','" + textDriverOvernightRate.Text + "','" + textNightParkRate.Text + "')", con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Long Tour Package Added Successfully");
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
            {
                if (textPackageID.Text == "")
                {
                    MessageBox.Show("Please Select the Package to Delete");
                }
                else
                {
                    try
                    {
                        con.Open();
                        string query = "DELETE FROM LTPackageTable WHERE PackageID = '" + textPackageID.Text + "'";
                        SqlCommand cmd = new SqlCommand(query, con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Long Tour Package Deleted Successfully");
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
        private void guna2DataGridViewLongTourPackages_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textPackageID.Text = guna2DataGridViewLongTourPackages.SelectedRows[0].Cells[0].Value.ToString();
            textPackageName.Text = guna2DataGridViewLongTourPackages.SelectedRows[0].Cells[1].Value.ToString();
            textVehicleType.Text = guna2DataGridViewLongTourPackages.SelectedRows[0].Cells[2].Value.ToString();
            textMaxKM.Text = guna2DataGridViewLongTourPackages.SelectedRows[0].Cells[3].Value.ToString();
            textPackagePrice.Text = guna2DataGridViewLongTourPackages.SelectedRows[0].Cells[4].Value.ToString();
            textExtraKMprice.Text = guna2DataGridViewLongTourPackages.SelectedRows[0].Cells[5].Value.ToString();
            textDriverOvernightRate.Text = guna2DataGridViewLongTourPackages.SelectedRows[0].Cells[6].Value.ToString();
            textNightParkRate.Text = guna2DataGridViewLongTourPackages.SelectedRows[0].Cells[7].Value.ToString();
        }
        // UPDATE//
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (textPackageID.Text == "" || textPackageName.Text == "" || textVehicleType.Text == "" || textMaxKM.Text == "" || textPackagePrice.Text == "" || textExtraKMprice.Text == "" || textDriverOvernightRate.Text == "" || textNightParkRate.Text == "")
            {
                MessageBox.Show("Please Select the Package to Update");
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE LTPackageTable SET PackageName = '" + textPackageName.Text + "',V_Type = '" + textVehicleType.Text + "',MaxKm = '" + textMaxKM.Text + "',PackagePrice = '" + textPackagePrice.Text + "',ExtraKmPrice = '" + textExtraKMprice.Text + "',DriverOvernightRate = '" + textDriverOvernightRate.Text + "',NightParkRate = '" + textNightParkRate.Text + "' WHERE PackageID = '" + textPackageID.Text + "'", con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Long Tour Package Updated Successfully");
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
            mainpanel4.Controls.Clear();

            // Load initial form into main panel
            Form initialForm = new Dashboard();
            initialForm.TopLevel = false;
            initialForm.Dock = DockStyle.Fill;
            mainpanel4.Controls.Add(initialForm);
            mainpanel4.Tag = initialForm;
            initialForm.Show();
        }

        private void guna2GradientButtonBack_Click(object sender, EventArgs e)
        {
            LoadBack();
        }

        private void guna2GradientButtonBack2_Click(object sender, EventArgs e)
        {
            LoadBack();
        }

        private void guna2GradientButtonADDNEW_Click(object sender, EventArgs e)
        {
            tabControlLongTourPackages.SelectedTab = tabPageAddPackages;
        }

        private void guna2GradientButtonEditAT_Click(object sender, EventArgs e)
        {
            tabControlLongTourPackages.SelectedTab = tabPageAddPackages;
        }
    }
}
