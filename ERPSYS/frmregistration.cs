using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace ERPSYS
{
    public partial class frmregistration : Form
    
    {
        SqlConnection cn = new SqlConnection (ConfigurationManager.ConnectionStrings["conn"].ConnectionString);
        public frmregistration()
        {
            InitializeComponent();
             SqlDataAdapter da = new SqlDataAdapter("select * from User_Master", cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                frmlogin login = new frmlogin();
                login.Show();
            }
            else
            {
                //this.Close();
                frmregistration reg = new frmregistration();
                reg.ShowDialog();
            }
            //cmbusertype.SelectedIndex = 0;
        
        }
              
        
        private void frmUserMaster_Load(object sender, EventArgs e)
        {
            clear();
        }
        public void clear()
        {
            txtID.Text = "";
            txtUserName.Text = "";
            txtPassword.Text = "";
            txtConfirm.Text = "";
            txtcity.Text = "";
            txtaddress.Text = "";
            txtPhoneno.Text = "";
            txtMobileNo.Text = "";
            txtEmailId.Text = "";
        }

       
        private void btnclear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text == txtConfirm.Text)
            {
                SqlCommand cmd = new SqlCommand("Insert Into User_Master (username,password,cpassword,city,address,phone,mobile,emailid) values ('" + txtUserName.Text + "','" + txtPassword.Text + "','" + txtConfirm.Text + "','" + txtcity.Text + "','" + txtaddress.Text + "','" + txtPhoneno.Text + "','" + txtMobileNo.Text + "','" + txtEmailId.Text + "')", cn);
                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();
                MessageBox.Show("Registration Successfull", "Info");
                clear();
                this.Close();
                frmlogin login = new frmlogin();
                login.Show();

            }
            else
            {
                MessageBox.Show("Pasword Not Same:");
            }
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
