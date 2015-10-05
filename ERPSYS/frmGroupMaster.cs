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
    public partial class frmGroupMaster : Form
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

        public frmGroupMaster()
        {
            InitializeComponent();
            txtgroupname.Focus();
            cmbgrouptype.SelectedIndex = 0;
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (validation() == true)
            {
                save();
                clear();
                txtgroupname.Focus();
            }
            
        }
        public void save()
        {
            {
                if (txtgroupname.Text != "")
                {
                    if (btnsave.Text == "Save")
                    {
                        DialogResult result = MsgBox.Show("Do You Want to Save This Record", "BS Acount Manager", MsgBox.Buttons.YesNo, MsgBox.Icon.Info, MsgBox.AnimateStyle.FadeIn);
                        if (result == DialogResult.Yes)
                        {                            
                            string ins = "insert into Group_master (GroupName,GroupType,UnderGroup,NatureGroup) values ('" + txtgroupname.Text + "','" + cmbgrouptype.Text + "','" + txtundergroup.Text + "','" + txtnatureofgroup.Text + "') ";
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
                            string up = "update Group_master set GroupName ='" + txtgroupname.Text + "', GroupType ='" + cmbgrouptype.Text + "' , UnderGroup = '" + txtundergroup.Text + "', NatureGroup  ='" + txtnatureofgroup.Text + "' where ID= '"+txtID.Text+"' " ;
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
            txtgroupname.Text = "";
            txtnatureofgroup.Text = "";
            txtundergroup.Text = "";
            panelhelp.Visible = false;
            btnsave.Text = "Save";

            txtID.Text = clsdb.maxid("ID", "Group_Master");
            cn.Close();
        }

        public bool validation()
        {
            if (txtgroupname.Text == "")
            {   
                DialogResult result = MsgBox.Show("Enter Group Name First", "BS Acount Manager", MsgBox.Buttons.OKCancel, MsgBox.Icon.Info, MsgBox.AnimateStyle.FadeIn);
                txtgroupname.Focus();                     
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MsgBox.Show("Are You Sure You Want To Delete This Record?", "BS Acount Manager", MsgBox.Buttons.YesNo, MsgBox.Icon.Question, MsgBox.AnimateStyle.FadeIn);
            if (result == DialogResult.Yes)
            {
                string del = "delete from Group_master where  ID='" + txtID.Text + "'";
                clsdb.Ins_Up_Del(del);
                clear();
            }
            if (result == DialogResult.No)
            {
                clear();
            }           
        }
        private void txtsearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtsearch.Text == "")
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    this.GridView1.CurrentCell = this.GridView1.Rows[0].Cells[0];
                    GridView1.Focus();
                }
            }
            else
            {
                txtsearch.Text=GridView1.CurrentRow.Cells[1].Value.ToString();
                String s1 = GridView1.CurrentRow.Cells[0].Value.ToString();
                this.getdata(s1, txtsearch.Text);

            }
        }

       
        private void btnsearch_Click(object sender, EventArgs e)
        {

            panelhelp.Visible = true;
            
            //frmhelp help = new frmhelp();
            string str = "select ID,GroupName,GroupType,UnderGroup,NatureGroup from Group_Master";
            //help.qc = str;
            string c = "select column_Name = 'GroupName',column_name = 'GroupType',column_name = 'UnderGroup',column_name = 'NatureGroup' from INFORMATION_SCHEMA.COLUMNS where TABLE_NAME ='Company_Master'  ";
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
                
        private void txtgroupname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                cmbgrouptype.Focus();
            }
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
               txtnatureofgroup.Focus();
            }
        }

        private void txtnatureofgroup_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnsave.Focus();
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            clear();
            
        }

        private void frmGroupMaster_Load(object sender, EventArgs e)
        {
            clear();
            //DataTable dt11 = clsdb.selectdata(qc1); // Data Retrive For Column
            //if (dt11.Rows.Count > 0)
            //{
            //    for (int i = 0; i < dt11.Columns.Count; i++)
            //    {
            //        cmbsearch.Items.Add(dt11.Rows[0][i].ToString());
            //    }
            //    cmbsearch.SelectedIndex = 0;                // Data Retrive For Searchbox Column
            //}
            //dt = clsdb.selectdata(qc); // Data Fill in to Gride 
            //GridView1.DataSource = dt;
            //cmbsearch.Focus();
        }      

        private void GridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = GridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtgroupname.Text = GridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            cmbgrouptype.Text = GridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtundergroup.Text = GridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtnatureofgroup.Text = GridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            panelhelp.Visible = false;
            btnsave.Text = "Update";
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            string str = "select ID,GroupName,GroupType,UnderGroup,NatureGroup from Group_Master";
            String qq = str + " where " + cmbsearch.SelectedItem.ToString() + " like '%" + txtsearch.Text + "%'";
            DataTable dtqq = clsdb.selectdata(qq);
            if (dtqq.Rows.Count > 0)
            {
                GridView1.DataSource = dtqq;
            }
        }        
    }   
}
