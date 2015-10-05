using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace ERPSYS
{
    public partial class frmlogin : Form
    {
        SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString);

        public frmlogin()
        {
            InitializeComponent();
            cmbusertype.SelectedIndex = 0;
            cmbusertype.Focus();
        }
                 
        private void frmlogin_Load(object sender, EventArgs e)
        {
          
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (cmbusertype.SelectedIndex == 0)
            {
                if (txtusername.Text == "admin" && txtpassword.Text == "admin")
                {

                    this.Hide();
                    frmcompselect cmp = new frmcompselect();
                    cmp.Show();
                }
                else
                {
                    DialogResult result = MsgBox.Show("Invalid User Name Or Password", "BS Acount Manager", MsgBox.Buttons.OKCancel, MsgBox.Icon.Info, MsgBox.AnimateStyle.FadeIn);
                }
            }
            else
            {
                if (cmbusertype.SelectedIndex == 1)
                {
                    if (txtusername.Text == "abc" && txtpassword.Text == "abc")
                    {

                        this.Hide();
                        frmcompselect cmp = new frmcompselect();
                        cmp.Show();
                    }
                    else
                    {
                        DialogResult result = MsgBox.Show("Invalid User Name Or Password", "BS Acount Manager", MsgBox.Buttons.OKCancel, MsgBox.Icon.Info, MsgBox.AnimateStyle.FadeIn);
                    }
                }
            }
        }
        private void btnexit_Click(object sender, EventArgs e)
        {
            
            this.Close();

        }

        private void cmbusertype_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtusername.Focus();
            }
        }

        private void txtusername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtpassword.Focus();
            }
        }

       
        private void txtpassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnlogin.Focus();
            }
        }

        private void txtusername_TextChanged(object sender, EventArgs e)
        {

        }                
    }
}
