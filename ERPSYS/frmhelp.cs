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
    
    public partial class frmhelp : Form
        
    {
        clsDatabase clsdb = new clsDatabase();
        SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString);
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();  // Record Set
        DataSet ds = new DataSet();// data fill mate ds no use thay
        DataTable dt = new DataTable(); //
        
        public String qc { get; set; }
        public String qc1 { get; set; }

        public frmhelp()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            DataTable dt11 = clsdb.selectdata(qc1); // Data Retrive For Column
            if (dt11.Rows.Count > 0)
            {
                for (int i = 0; i < dt11.Columns.Count; i++)
                {
                    cmbsearch.Items.Add(dt11.Rows[0][i].ToString());
                }
                cmbsearch.SelectedIndex = 0;                // Data Retrive For Searchbox Column
            }
            dt = clsdb.selectdata(qc); // Data Fill in to Gride 
            GridView1.DataSource = dt;
            cmbsearch.Focus();
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            String qq = qc + " where " + cmbsearch.SelectedItem.ToString() + " like '%" + txtsearch.Text + "%'";
            DataTable dtqq = clsdb.selectdata(qq);
            if (dtqq.Rows.Count > 0)
            {
                GridView1.DataSource = dtqq;
            }
        }

        private void GridView1_DoubleClick(object sender, EventArgs e)
        {
            //String s1 = GridView1.Rows[0].Cells[0].ToString();
            String s1 = GridView1.Rows[0].Cells[0].Value.ToString();

        }

        private void GridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            String s1 = GridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
           // txtsearch.Text = GridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
        }
        public void getdata(String s1, String s2)
        {
            this.Close();
            frmcompselect cs = new frmcompselect();
            cs = new frmcompselect();
            cs.id = s1;
            cs.name = s2;
            cs.Show();
        }
        private void GridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Hide();
            String s1 = GridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            String s2= GridView1.Rows[e.RowIndex].Cells[1].Value.ToString();

            this.getdata(s1, s2);
        }

        private void cmbsearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtsearch.Focus();
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

        private void txtsearch_KeyDown(object sender, KeyEventArgs e)
        {
            /*if (e.KeyCode == Keys.Down)
            {
                GridView1.CurrentRow.Selected = true;
                txtsearch.Text = GridView1.CurrentRow.Cells[1].Value.ToString();               
            }*/
        }

       private void GridView1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                this.GridView1.CurrentCell = this.GridView1.Rows[0].Cells[0];
                txtsearch.Text = GridView1.CurrentRow.Cells[1].Value.ToString();
                txtsearch.Focus();
            }
        }
    }
}
