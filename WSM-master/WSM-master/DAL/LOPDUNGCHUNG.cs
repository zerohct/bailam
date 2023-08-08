using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace DOAN_QLBH.DAL
{
    class LOPDUNGCHUNG
    {
        SqlConnection conn = new SqlConnection();
        GUI.frm_hoadon frmhd;
        public LOPDUNGCHUNG(GUI.frm_hoadon f)
        {
            frmhd = f;
        }
       

        public LOPDUNGCHUNG()
        {
            conn.ConnectionString = @"Data Source=MSI\SQLEXPRESS;Initial Catalog=QL_LK;Integrated Security=True";
         
        }
        public SqlConnection connection()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=MSI\SQLEXPRESS;Initial Catalog=QL_LK;Integrated Security=True");

            return conn;
        }
       
        public void Mo()
        {
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }
        }
        public void Dong()
        {
            if (conn.State != ConnectionState.Closed)
            {
                conn.Close();
            }

        }
        public int ThemSuaXoa(string sql)
        {
            SqlCommand comm = new SqlCommand(sql, conn);
            Mo();
            int ketqua = comm.ExecuteNonQuery();
            Dong();
            return ketqua;
        }
        public object ExcuteScalar(string sql)
        {
            SqlCommand comm = new SqlCommand(sql, conn);
            Mo();
            object ketqua = comm.ExecuteScalar();
            Dong();
            return ketqua;

        }

        public DataTable LoadDuLieu(string sql)
        {
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
       
    }
}
