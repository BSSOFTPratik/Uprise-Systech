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
    public partial class frmcompanyMaster : Form
    {
        SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString);
        clsDatabase clsdb = new clsDatabase();
        SqlCommand cmd = new SqlCommand();
        DataSet ds = new DataSet();// data fill mate ds no use thay
        DataTable dt = new DataTable(); //

        public frmcompanyMaster()
        {
            InitializeComponent();
        }

        private void frmcompanyMaster_Load(object sender, EventArgs e)
        {
            clear();
        }
               
        private void btnsave_Click(object sender, EventArgs e)
        {
            if (txtCompanyName.Text=="")
            {
                DialogResult result = MsgBox.Show("Please Enter Company Name", "BS Acount Manager", MsgBox.Buttons.OKCancel, MsgBox.Icon.Info, MsgBox.AnimateStyle.FadeIn);
            }
            else 
            {
                DialogResult result = MsgBox.Show("Do You Want to Save This Record", "BS Acount Manager", MsgBox.Buttons.YesNo, MsgBox.Icon.Info, MsgBox.AnimateStyle.FadeIn);
                if (result == DialogResult.Yes)
                {
                    String str = "insert into Company_Master (aliasname,cname,address,City,Pincode,State,Email,incomtax,cstno,tinno,Password,retypepass) Values ( '" + txtAliasName.Text + "','" + txtCompanyName.Text + "','" + txtAddress.Text + "','" + txtCity.Text + "','" + txtPincode.Text + "','" + txtState.Text + "','" + txtEmail.Text + "','" + txtincometaxno.Text + "','" + txtcstno.Text + "','" + txttinno.Text + "','" + txtpass.Text + "','" + txtretypepass.Text + "')";
                    SqlCommand cmd = new SqlCommand(str, cn);
                    cn.Open();
                    cmd.ExecuteNonQuery();                  
                }
                if (result == DialogResult.No)
                {                   
                    clear();
                }              
            
            } this.Close();
        }
        public void clear()
        {
            txtCode.Text = "";
            txtCompanyName.Text = "";
            txtAliasName.Text = "";
            txtAddress.Text = "";
            txtCity.Text = "";
            txtPincode.Text = "";
            txtState.Text = "";
            txtEmail.Text = "";
            txtincometaxno.Text = "";
            txtcstno.Text = "";
            txttinno.Text = "";
            txtpass.Text = "";
            txtretypepass.Text = "";
            txtCompanyName.Focus();

            txtCode.Text = clsdb.maxid("ccode","Company_Master");
            cn.Close();
            
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            panelhelp.Visible = true;
                        
            string str = "select * from Company_Master";
            string c = "select column_Name = 'GroupName',column_name = 'GroupType',column_name = 'UnderGroup',column_name = 'NatureGroup' from INFORMATION_SCHEMA.COLUMNS where TABLE_NAME ='Company_Master'  ";
            
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
        private void GridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCode.Text = GridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtAliasName.Text = GridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtCompanyName.Text = GridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtAddress.Text = GridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtCity.Text = GridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtPincode.Text = GridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtState.Text = GridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            txtEmail.Text = GridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            txtincometaxno.Text = GridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
            txtcstno.Text = GridView1.Rows[e.RowIndex].Cells[9].Value.ToString();
            txttinno.Text = GridView1.Rows[e.RowIndex].Cells[10].Value.ToString();
            txtpass.Text = GridView1.Rows[e.RowIndex].Cells[11].Value.ToString();
            txtretypepass.Text = GridView1.Rows[e.RowIndex].Cells[12].Value.ToString();
        }      
    }
}
