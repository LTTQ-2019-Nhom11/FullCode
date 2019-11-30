using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace PhanMemQuanLyNhaHang.Views
{
    
    class myDataBases
    {
        string conStr = @"Data Source=DESKTOP-Q22EOS8\SQLEXPRESS;Initial Catalog=QuanLyNhaHang;Integrated Security=True";
        SqlConnection myConnection;
        public myDataBases()
        {
            myConnection = new SqlConnection(conStr);
            myConnection.Open();
        }
        public DataTable getData(string sql)
        {
            SqlDataAdapter myDa = new SqlDataAdapter(sql, myConnection);
            DataTable myDt = new DataTable();
            myDa.Fill(myDt);
            return myDt;
        }
        public void executeQuery(string sql)
        {
            SqlCommand cmd = new SqlCommand(sql, myConnection);
            cmd.ExecuteNonQuery();
        }
    }
}
