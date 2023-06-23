using FontAwesome.Sharp;
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
    public partial class Users : Form
    {
        public Users()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-N2UG8268\SQLEXPRESS;Initial Catalog=AYUBODRIVE_CAR_RENTAL;Integrated Security=True");
        //DISPLAY DATA IN DATAGRIDVIEW//
        private void populate()
        {
            con.Open();
            string query = "SELECT * FROM UserTable";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            guna2DataGridViewUsers.DataSource = ds.Tables[0];
            con.Close();
        }
        private void Users_Load(object sender, EventArgs e)
        {
            populate();
        }
        //CLEAR//
        private void ClearAll()
        {
            TextBoxUID.Text = "";
            TextBoxUName.Text = "";
            TextBoxUPassword.Text = "";
        }
        //INSERT//
        private void btnADD_Click(object sender, EventArgs e)
        {
            if (TextBoxUID.Text == "" || TextBoxUName.Text == "" || TextBoxUPassword.Text == "")
            {
                MessageBox.Show("Please Fill All The Fields");
            }
            else
            {
                try
                {
                    con.Open();
                    string query = "INSERT INTO UserTable VALUES('" + TextBoxUID.Text + "','" + TextBoxUName.Text + "','" + TextBoxUPassword.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("User Added Successfully");
                    con.Close();
                    populate();
                    ClearAll();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
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
            if (TextBoxUID.Text == "")
            {
                MessageBox.Show("Please Select The User To Delete");
            }
            else
            {
                try
                {
                    con.Open();
                    string query = "DELETE FROM UserTable WHERE User_ID = '" + TextBoxUID.Text + "'";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("User Deleted Successfully");
                    con.Close();
                    populate();
                    ClearAll();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
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
        private void guna2DataGridViewUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            TextBoxUID.Text = guna2DataGridViewUsers.SelectedRows[0].Cells[0].Value.ToString();
            TextBoxUName.Text = guna2DataGridViewUsers.SelectedRows[0].Cells[1].Value.ToString();
            TextBoxUPassword.Text = guna2DataGridViewUsers.SelectedRows[0].Cells[2].Value.ToString();
        }
        //UPDATE//
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (TextBoxUID.Text == "" || TextBoxUName.Text == "" || TextBoxUPassword.Text == "")
            {
                MessageBox.Show("Please Select The User To Update");
            }
            else
            {
                try
                {
                    con.Open();
                    string query = "UPDATE UserTable SET User_Name = '" + TextBoxUName.Text + "', User_Password = '" + TextBoxUPassword.Text + "' WHERE User_ID = '" + TextBoxUID.Text + "'";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("User Updated Successfully");
                    con.Close();
                    populate();
                    ClearAll();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
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
            tabControlUsers.SelectedTab = tabPageAddUser;
        }

        private void guna2GradientButtonEditAT_Click(object sender, EventArgs e)
        {
            tabControlUsers.SelectedTab = tabPageAddUser;
        }
    }
}
