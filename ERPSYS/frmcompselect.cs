using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ERPSYS
{
    public partial class frmcompselect : Form
    {
        clsDatabase clsdb = new clsDatabase();
        public String id { get; set; }
        public String name { get; set; }
        //public String s1 { get; set; }

        public frmcompselect()
        {
            InitializeComponent();
            txtccode.Focus();
        }

        private void btnok_Click(object sender, EventArgs e)
        {
            if (txtccode.Text == "")
            {
                DialogResult result = MsgBox.Show("Select Company Name", "BS Acount Manager", MsgBox.Buttons.OKCancel, MsgBox.Icon.Info, MsgBox.AnimateStyle.FadeIn);
            }
            else
            {
                selectcomp.Hide();
                pass.Show();
                txtpass.Focus();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btncreate_Click(object sender, EventArgs e)
        {
            frmcompanyMaster cmpmas = new frmcompanyMaster();
            cmpmas.Show();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            frmhelp help = new frmhelp();
            help.ShowDialog();
        }

        private void txtccode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                frmcompselect cs = new frmcompselect();
                this.Close();
                frmhelp help = new frmhelp();
                string str = "select ccode,cname from Company_Master";
                help.qc = str;
                string c = "select column_Name = 'ccode',column_name = 'cname' from INFORMATION_SCHEMA.COLUMNS where TABLE_NAME ='Company_Master'  ";
                help.qc1 = c;
                help.ShowDialog();
            }
        }

        private void frmcompselect_Load(object sender, EventArgs e)
        {
            pass.Hide();
            txtccode.Focus();
            if (id != "" && name != "")
            {
                txtccode.Text = id;
                txtcname.Text = name;
            }
        }

        private void btnverify_Click(object sender, EventArgs e)
        {
            clsDatabase clsdb = new clsDatabase();
            String s1 = "select password from Company_Master where ccode = " + txtccode.Text + " and password = '" + txtpass.Text + "' ";
            DataTable dt = clsdb.selectdata(s1);
            if (dt.Rows.Count > 0)
            {
                this.Close();
                ERPMaster erp = new ERPMaster();
                erp.Show();

            }
            else
            {
                DialogResult result = MsgBox.Show("Enter Valid Password", "BS Acount Manager", MsgBox.Buttons.OKCancel, MsgBox.Icon.Info, MsgBox.AnimateStyle.FadeIn);
                txtpass.Focus();
                txtpass.Text = "";
            }
        }

        private void txtccode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                
                txtcname.Focus();
            }
        }

        private void txtcname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnok.Focus();
            }
        }

        private void txtpass_KeyPress(object sender, KeyPressEventArgs e)
        {            
            if (e.KeyChar == (char)Keys.Enter)

            {
                btnverify.Focus();
                e.Handled = true;
            }
        }

        private void txtccode_TextChanged(object sender, EventArgs e)
        {

        }           
    }
}

