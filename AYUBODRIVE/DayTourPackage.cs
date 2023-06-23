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
    public partial class DayTourPackage : Form
    {
        public DayTourPackage()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-N2UG8268\SQLEXPRESS;Initial Catalog=AYUBODRIVE_CAR_RENTAL;Integrated Security=True");

        //DISPLAY DATA IN DATAGRIDVIEW//
        private void populate()
        {
            con.Open();
            string query = "SELECT * FROM DTPackageTable";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            guna2DataGridViewDayTourPackages.DataSource = ds.Tables[0];
            con.Close();
        }

        private void DayTourPackage_Load(object sender, EventArgs e)
        {
            populate();
        }
        public void loadform(object Form)
        {
            if (this.mainpanel5.Controls.Count > 0)
                this.mainpanel5.Controls.RemoveAt(0);
            Form fh = Form as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.mainpanel5.Controls.Add(fh);
            this.mainpanel5.Tag = fh;
            fh.Show();

        }
        private void clearAll()
        {
            textPackageID.Text = "";
            textPackageName.Text = "";
            textVehicleType.Text = "";
            textMaxKM.Text = "";
            textMaxHrs.Text = "";
            textPackagePrice.Text = "";
            textExtraKMprice.Text = "";
            textExtraHrsPrice.Text = "";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearAll();
        }

        //INSERT//
        private void btnADD_Click(object sender, EventArgs e)
        {
            if (textPackageID.Text == "" || textPackageName.Text == "" || textVehicleType.Text == "" || textMaxKM.Text == "" || textMaxHrs.Text == "" || textPackagePrice.Text == "" || textExtraKMprice.Text == "" || textExtraHrsPrice.Text == "")
            {
                MessageBox.Show("Please fill all the fields");
            }
            else
            {
                try
                {
                    con.Open();
                    string query = "INSERT INTO DTPackageTable VALUES('" + textPackageID.Text + "','" + textPackageName.Text + "','" + textVehicleType.Text + "','" + textMaxKM.Text + "','" + textMaxHrs.Text + "','" + textPackagePrice.Text + "','" + textExtraKMprice.Text + "','" + textExtraHrsPrice.Text + "')";
                    SqlDataAdapter sda = new SqlDataAdapter(query, con);
                    sda.SelectCommand.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Package Added Successfully");
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
                    MessageBox.Show("Please Select a Package to Delete");
                }
                else
                {
                    try
                    {
                        con.Open();
                        string query = "DELETE FROM DTPackageTable WHERE PackageID = '" + textPackageID.Text + "'";
                        SqlDataAdapter sda = new SqlDataAdapter(query, con);
                        sda.SelectCommand.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Package Deleted Successfully");
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

        private void guna2GradientButtonDeleteList_Click(object sender, EventArgs e)
        {
            Delete();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Delete();
        }

        //DISPLAY DATA IN TEXTBOX//
        private void guna2DataGridViewDayTourPackages_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textPackageID.Text = guna2DataGridViewDayTourPackages.SelectedRows[0].Cells[0].Value.ToString();
            textPackageName.Text = guna2DataGridViewDayTourPackages.SelectedRows[0].Cells[1].Value.ToString();
            textVehicleType.Text = guna2DataGridViewDayTourPackages.SelectedRows[0].Cells[2].Value.ToString();
            textMaxKM.Text = guna2DataGridViewDayTourPackages.SelectedRows[0].Cells[3].Value.ToString();
            textMaxHrs.Text = guna2DataGridViewDayTourPackages.SelectedRows[0].Cells[4].Value.ToString();
            textPackagePrice.Text = guna2DataGridViewDayTourPackages.SelectedRows[0].Cells[5].Value.ToString();
            textExtraKMprice.Text = guna2DataGridViewDayTourPackages.SelectedRows[0].Cells[6].Value.ToString();
            textExtraHrsPrice.Text = guna2DataGridViewDayTourPackages.SelectedRows[0].Cells[7].Value.ToString();
        }

        // UPDATE//
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (textPackageID.Text == "" || textPackageName.Text == "" || textVehicleType.Text == "" || textMaxKM.Text == "" || textMaxHrs.Text == "" || textPackagePrice.Text == "" || textExtraKMprice.Text == "" || textExtraHrsPrice.Text == "")
            {
                MessageBox.Show("Please Select a Package to Update");
            }
            else
            {
                try
                {
                    con.Open();
                    string query = "UPDATE DTPackageTable SET PackageName = '" + textPackageName.Text + "',V_Type = '" + textVehicleType.Text + "',MaxKm = '" + textMaxKM.Text + "',MaxHrs = '" + textMaxHrs.Text + "',PackagePrice = '" + textPackagePrice.Text + "',ExtraKmPrice = '" + textExtraKMprice.Text + "',ExtraHrsPrice = '" + textExtraHrsPrice.Text + "' WHERE PackageID = '" + textPackageID.Text + "'";
                    SqlDataAdapter sda = new SqlDataAdapter(query, con);
                    sda.SelectCommand.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Package Updated Successfully");
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
            mainpanel5.Controls.Clear();

            // Load initial form into main panel
            Form initialForm = new Dashboard();
            initialForm.TopLevel = false;
            initialForm.Dock = DockStyle.Fill;
            mainpanel5.Controls.Add(initialForm);
            mainpanel5.Tag = initialForm;
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
            tabControlDayTourPackages.SelectedTab = tabPageAddPackages;
        }

        private void guna2GradientButtonEditAT_Click(object sender, EventArgs e)
        {
            tabControlDayTourPackages.SelectedTab = tabPageAddPackages;
        }
    }
}
