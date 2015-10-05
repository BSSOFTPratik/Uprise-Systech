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
    public partial class frmStockGroupMaster : Form
    {
        public string qc { get; set; }
        public string qc1 { get; set; }
        private void getdata(string s1, string p)
        {
            throw new NotImplementedException();
        }

        public System.Windows.Forms.DialogResult result { get; set; }
        SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString);
        clsDatabase clsdb = new clsDatabase();
        SqlDataAdapter da = new SqlDataAdapter();  // Record Set
        DataSet ds = new DataSet();// data fill mate ds no use thay
        DataTable dt = new DataTable(); //

        public frmStockGroupMaster()
        {
            InitializeComponent();
        }

        private void frmStockGroupMaster_Load(object sender, EventArgs e)
        {
           
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (validation() == true)
            {
                save();
                clear();
                txtsgroupname.Focus();
            }

        }
        public void save()
        {
            {
                if (txtsgroupname.Text != "")
                {
                    if (btnsave.Text == "Save")
                    {
                        DialogResult result = MsgBox.Show("Do You Want to Save This Record", "BS Acount Manager", MsgBox.Buttons.YesNo, MsgBox.Icon.Info, MsgBox.AnimateStyle.FadeIn);
                        if (result == DialogResult.Yes)
                        {
                            string ins = "insert into StockGroupMaster (StockGroupName,GroupType,UnderGroup) values ('" + txtsgroupname.Text + "','" + cmbgrouptype.Text + "','" + txtundergroup.Text + "') ";
                            clsdb.Ins_Up_Del(ins);
                        }
                        if (result == DialogResult.No)
                        {
                            clear();
                        }
                    }
                    else if (btnsave.Text == "Update")
                    {
                        DialogResult result = MsgBox.Show("Do You Want to Update This Record", "BS Acount Manager", MsgBox.Buttons.YesNo, MsgBox.Icon.Info, MsgBox.AnimateStyle.FadeIn);
                        if (result == DialogResult.Yes)
                        {
                            string up = "update StockGroupMaster set StockGroupName ='" + txtsgroupname.Text + "', GroupType ='" + cmbgrouptype.Text + "' , UnderGroup = '" + txtundergroup.Text + "' where ID= '" + txtID.Text + "' ";
                            clsdb.Ins_Up_Del(up);
                            clear();
                        }
                        if (result == DialogResult.No)
                        {
                            clear();
                        }
                    }

                }

            }

        }
        public void clear()
        {
            txtID.Text = "";
            txtsgroupname.Text = "";
            txtundergroup.Text = "";
            panelhelp.Visible = false;
            btnsave.Text = "Save";

            txtID.Text = clsdb.maxid("ID", "Group_Master");
            cn.Close();
        }

        public bool validation()
        {
            if (txtsgroupname.Text == "")
            {
                DialogResult result = MsgBox.Show("Enter Stock Group Name First", "BS Acount Manager", MsgBox.Buttons.OKCancel, MsgBox.Icon.Info, MsgBox.AnimateStyle.FadeIn);
                txtsgroupname.Focus();
                return false;
            }
            if (cmbgrouptype.Text == "")
            {
                DialogResult result = MsgBox.Show("Enter Group Name First", "BS Acount Manager", MsgBox.Buttons.OKCancel, MsgBox.Icon.Info, MsgBox.AnimateStyle.FadeIn);
                cmbgrouptype.Focus();
                return false;
            }
            return true;
        }


        
        private void txtsgroupname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                cmbgrouptype.Focus();
            }
        }

        private void txtsgroupname_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbgrouptype_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtundergroup.Focus();
            }
        }

        private void txtundergroup_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnsave.Focus();
            }
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            panelhelp.Visible = true;

            //frmhelp help = new frmhelp();
            string str = "select ID,StockGroupName,GroupType,UnderGroup from StockGroupMaster";
            //help.qc = str;
            string c = "select column_Name = 'GroupName',column_name = 'GroupType',column_name = 'UnderGroup'from INFORMATION_SCHEMA.COLUMNS where TABLE_NAME ='Company_Master' ";
            //help.qc1 = c;
            //help.ShowDialog();
            DataTable dt11 = clsdb.selectdata(c); // Data Retrive For Column
            if (dt11.Rows.Count > 0)
            {
                for (int i = 0; i < dt11.Columns.Count; i++)
                {
                    cmbsearch.Items.Add(dt11.Rows[0][i].ToString());
                }
                cmbsearch.SelectedIndex = 0;                // Data Retrive For Searchbox Column
            }
            dt = clsdb.selectdata(str); // Data Fill in to Gride 
            GridView1.DataSource = dt;
            cmbsearch.Focus();
        }
    }
}
