using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.IO;
using System.Windows;

namespace ERPSYS
{
    class clsDatabase
    {
        SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString);
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();  // record set
        DataSet ds = new DataSet();// data fill mate ds no use thay
                
        public String maxid(string strfield, string strtable)
        {
            //cn.Open();
            string str = "select max(" + strfield + ") from " + strtable + " ";
            cmd = new SqlCommand(str, cn);
            da = new SqlDataAdapter(cmd);
            ds = new DataSet();
            da.Fill(ds);

            String dst = ds.Tables[0].Rows[0].ItemArray[0].ToString();

            if (dst == "")
            {
                return "1";
            }
            else
            {
                int i = Convert.ToInt32(dst) + 1;
                return i.ToString();

            }
            // cn.Close();
        }    

        public void Ins_Up_Del(String str)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(str, cn);
                cn.Open();
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                cn.Close();
            }
            catch (Exception ex) { throw ex; }
        }

        public DataTable selectdata(String str)
        {
            SqlDataAdapter ad = new SqlDataAdapter(str, cn);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            return dt;
        }               

    }
}