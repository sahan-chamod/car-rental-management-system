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
    public partial class DriverInfo : Form
    {
        public DriverInfo()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-N2UG8268\SQLEXPRESS;Initial Catalog=AYUBODRIVE_CAR_RENTAL;Integrated Security=True");

        //DISPLAY DATA IN DATAGRIDVIEW//
        private void populate()
        {
            con.Open();
            string query = "SELECT * FROM DriverInfoTable";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            guna2DataGridViewDriverInfo.DataSource = ds.Tables[0];
            con.Close();
        }

        private void DriverInfo_Load(object sender, EventArgs e)
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
            textDriverID.Text = "";
            textDriverName.Text = "";
            textDriverAge.Text = "";
            textDriverNicNum.Text = "";
            textDriverAddress.Text = "";
            textDriverEmailAddress.Text = "";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearAll();
        }
        //INSERT//
        private void btnADD_Click(object sender, EventArgs e)
        {
            if (textDriverID.Text == "" || textDriverName.Text == "" || textDriverAge.Text == "" || textDriverNicNum.Text == "" || textDriverAddress.Text == "" || textDriverEmailAddress.Text == "")
            {
                MessageBox.Show("Please fill all the fields");
            }
            else
            {
                try
                {
                    con.Open();
                    string query = "INSERT INTO DriverInfoTable VALUES('" + textDriverID.Text + "','" + textDriverName.Text + "','" + textDriverAge.Text + "','" + textDriverNicNum.Text + "','" + textDriverAddress.Text + "','" + textDriverEmailAddress.Text + "')";
                    SqlDataAdapter sda = new SqlDataAdapter(query, con);
                    sda.SelectCommand.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Driver Added Successfully");
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
                if (textDriverID.Text == "")
                {
                    MessageBox.Show("Please Select Driver to Delete");
                }
                else
                {
                    try
                    {
                        con.Open();
                        string query = "DELETE FROM DriverInfoTable WHERE DriverID='" + textDriverID.Text + "'";
                        SqlDataAdapter sda = new SqlDataAdapter(query, con);
                        sda.SelectCommand.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Driver Deleted Successfully");
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
        private void guna2DataGridViewDriverInfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textDriverID.Text = guna2DataGridViewDriverInfo.SelectedRows[0].Cells[0].Value.ToString();
            textDriverName.Text = guna2DataGridViewDriverInfo.SelectedRows[0].Cells[1].Value.ToString();
            textDriverAge.Text = guna2DataGridViewDriverInfo.SelectedRows[0].Cells[2].Value.ToString();
            textDriverNicNum.Text = guna2DataGridViewDriverInfo.SelectedRows[0].Cells[3].Value.ToString();
            textDriverAddress.Text = guna2DataGridViewDriverInfo.SelectedRows[0].Cells[4].Value.ToString();
            textDriverEmailAddress.Text = guna2DataGridViewDriverInfo.SelectedRows[0].Cells[5].Value.ToString();
        }
        // UPDATE//
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (textDriverID.Text == "" || textDriverName.Text == "" || textDriverAge.Text == "" || textDriverNicNum.Text == "" || textDriverAddress.Text == "" || textDriverEmailAddress.Text == "")
            {
                MessageBox.Show("Please Select Driver to Update");
            }
            else
            {
                try
                {
                    con.Open();
                    string query = "UPDATE DriverInfoTable SET DriverName='" + textDriverName.Text + "',DriverAge='" + textDriverAge.Text + "',DriverNicNum='" + textDriverNicNum.Text + "',DriverAddress='" + textDriverAddress.Text + "',DriverEmailAddress='" + textDriverEmailAddress.Text + "' WHERE DriverID='" + textDriverID.Text + "'";
                    SqlDataAdapter sda = new SqlDataAdapter(query, con);
                    sda.SelectCommand.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Driver Updated Successfully");
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

        private void guna2GradientButtonBack2_Click(object sender, EventArgs e)
        {
            LoadBack();
        }

        private void guna2GradientButtonBack_Click(object sender, EventArgs e)
        {
            LoadBack();
        }

        private void guna2GradientButtonADDNEW_Click(object sender, EventArgs e)
        {
            tabControlDriverInfo.SelectedTab = tabPageAddDriver;
        }

        private void guna2GradientButtonEditAT_Click(object sender, EventArgs e)
        {
            tabControlDriverInfo.SelectedTab = tabPageAddDriver;
        }
    }
}
