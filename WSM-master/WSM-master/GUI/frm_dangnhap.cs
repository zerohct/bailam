using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;

namespace DOAN_QLBH.GUI
{
    public partial class frm_dangnhap : Form
    {
        DAL.LOPDUNGCHUNG lopchung = new DAL.LOPDUNGCHUNG();
        BLL.BLL_dangnhap blldn;

        public frm_dangnhap()
        {
            InitializeComponent();
            blldn = new BLL.BLL_dangnhap(this);
        }
        private void frm_dangnhap_Load(object sender, EventArgs e)
        {
            blldn.LayDSNV();
        }


        private void tbn_dangnhap_Click(object sender, EventArgs e)
        {
            SqlConnection conn = lopchung.connection();
            SqlCommand comm = new SqlCommand();
            comm.CommandText = "select * from DangNhap where TenDangNhap = '" + cb_tendn.SelectedValue.ToString() + "'and MatKhau = '" + txt_matkhau.Text + "'";
            comm.Connection = conn;
            conn.Open();

            SqlDataReader read = comm.ExecuteReader();
            if (read.Read() == true)
            {
                if (cb_tendn.SelectedValue.ToString() == "ad")
                {
                    this.Hide();
                    frm_main main = new frm_main();
                    main.Show();
                }
                else if (cb_tendn.SelectedValue.ToString() != "ad")
                {
                    this.Hide();
                    frm_mainNV main = new frm_mainNV();
                    main.Show();
                }
            }
            else
            {
                DialogResult tb;
                tb = (MessageBox.Show("Bạn đã nhập sai tài khoản hoặc mật khẩu", "chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning));
            }
            conn.Close();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void txt_taikhoan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                tbn_dangnhap.PerformClick();
                e.Handled = true;
            }
        }

        private void txt_matkhau_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                tbn_dangnhap.PerformClick();
                e.Handled = true;
            }
        }
    }
}
