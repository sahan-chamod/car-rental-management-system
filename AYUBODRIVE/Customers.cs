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
    public partial class Customers : Form
    {
        public Customers()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-N2UG8268\SQLEXPRESS;Initial Catalog=AYUBODRIVE_CAR_RENTAL;Integrated Security=True");
        //DISPLAY DATA IN DATAGRIDVIEW//
        private void populate()
        {
            con.Open();
            string query = "SELECT * FROM CustomerTable";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            guna2DataGridViewCustomers.DataSource = ds.Tables[0];
            con.Close();
        }

        private void Customers_Load(object sender, EventArgs e)
        {
            populate();
        }
        //CLEAR//
        private void ClearAll()
        {
            TextBoxCusID.Text = "";
            TextBoxCusNicNum.Text = "";
            TextBoxCusName.Text = "";
            TextBoxCusAddress.Text = "";
            TextBoxCusContNum.Text = "";
            TextBoxCusEmail.Text = "";
        }
        //INSERT//
        private void btnADD_Click(object sender, EventArgs e)
        {
            if (TextBoxCusID.Text == "" || TextBoxCusNicNum.Text == "" || TextBoxCusName.Text == "" || TextBoxCusAddress.Text == "" || TextBoxCusContNum.Text == "" || TextBoxCusEmail.Text == "")
            {
                MessageBox.Show("Please Fill All The Fields");
            }
            else
            {
                try
                {
                    con.Open();
                    string query = "INSERT INTO CustomerTable VALUES('" + TextBoxCusID.Text + "','" + TextBoxCusNicNum.Text + "','" + TextBoxCusName.Text + "','" + TextBoxCusAddress.Text + "','" + TextBoxCusContNum.Text + "','" + TextBoxCusEmail.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Customer Added Successfully");
                    con.Close();
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
            if (TextBoxCusID.Text == "")
            {
                MessageBox.Show("Please Select The Customer To Delete");
            }
            else
            {
                try
                {
                    con.Open();
                    string query = "DELETE FROM CustomerTable WHERE Cus_ID = '" + TextBoxCusID.Text + "'";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Customer Deleted Successfully");
                    con.Close();
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Delete();
        }

        private void guna2GradientButtonDeleteList_Click(object sender, EventArgs e)
        {
            Delete();
        }

        //DISPLAY DATA IN TEXTBOX//
        private void guna2DataGridViewCustomers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            TextBoxCusID.Text = guna2DataGridViewCustomers.SelectedRows[0].Cells[0].Value.ToString();
            TextBoxCusNicNum.Text = guna2DataGridViewCustomers.SelectedRows[0].Cells[1].Value.ToString();
            TextBoxCusName.Text = guna2DataGridViewCustomers.SelectedRows[0].Cells[2].Value.ToString();
            TextBoxCusAddress.Text = guna2DataGridViewCustomers.SelectedRows[0].Cells[3].Value.ToString();
            TextBoxCusEmail.Text = guna2DataGridViewCustomers.SelectedRows[0].Cells[4].Value.ToString();
            TextBoxCusContNum.Text = guna2DataGridViewCustomers.SelectedRows[0].Cells[5].Value.ToString();
            
            
        }

        //UPDATE//
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (TextBoxCusID.Text == "" || TextBoxCusNicNum.Text == "" || TextBoxCusName.Text == "" || TextBoxCusAddress.Text == "" || TextBoxCusContNum.Text == "" || TextBoxCusEmail.Text == "")
            {
                MessageBox.Show("Please Fill All The Fields");
            }
            else
            {
                try
                {
                    con.Open();
                    string query = "UPDATE CustomerTable SET Cus_ID = '" + TextBoxCusID.Text + "', Cus_NicNum = '" + TextBoxCusNicNum.Text + "', Cus_Name = '" + TextBoxCusName.Text + "', Cus_Address = '" + TextBoxCusAddress.Text + "', Cus_ContactNum = '" + TextBoxCusContNum.Text + "', Cus_Email = '" + TextBoxCusEmail.Text + "' WHERE Cus_ID = '" + TextBoxCusID.Text + "'";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Customer Updated Successfully");
                    con.Close();
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
            tabControlCustomers.SelectedTab = tabPageAddCustomer;
        }

        private void guna2GradientButtonEditAT_Click(object sender, EventArgs e)
        {
            tabControlCustomers.SelectedTab = tabPageAddCustomer;
        }
    }
}
