using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using PhanMen_BanHang.Class;

namespace PhanMen_BanHang.Class
{
    internal class AccessData
    {
        public static SqlConnection con;
        //Khai bao ket noi
        public static void Connect()
        {
            con = new SqlConnection();
            con.ConnectionString = Properties.Settings.Default.CSDL_BanHangConnetionString;
            if(con.State!=ConnectionState.Open )
            {
                con.Open();
            }
        }
        public void ExcuteNonQuery(string sql)
        {
            con = new SqlConnection();
            con.ConnectionString = Properties.Settings.Default.CSDL_BanHangConnetionString;
            SqlCommand cmd =  new SqlCommand(sql, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            cmd.Dispose();
        }
        public SqlDataReader ExecuteReader(string sql)
        {
            SqlConnection conn = new SqlConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            return reader;
        }
    }
}
