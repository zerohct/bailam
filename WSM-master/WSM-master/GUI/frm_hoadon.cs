using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DOAN_QLBH.DAL;
using System.Data.SqlClient;

namespace DOAN_QLBH.GUI
{
    public partial class frm_hoadon : Form
    {
      DAL.LOPDUNGCHUNG conn = new DAL.LOPDUNGCHUNG();
        LOPDUNGCHUNG lopchung = new LOPDUNGCHUNG();
        DataTable dthd;
        SqlConnection con;
        SqlCommand comm;


        BLL.BLL_khachhang bllkh;
        BLL.BLL_nhanvien bllnv;
        BLL.BLL_hanghoa bllhh;
        BLL.bll_hoadon bllhd;
        public frm_hoadon()
        {
            InitializeComponent();
            bllkh = new BLL.BLL_khachhang(this);
            bllnv = new BLL.BLL_nhanvien(this);
            bllhh = new BLL.BLL_hanghoa(this);
            bllhd = new BLL.bll_hoadon(this);
        }

        private void frm_hoadon_Load(object sender, EventArgs e)
        {
            bllkh.LayDSKH();
            bllnv.LayDSNV();
            bllhd.LayDSHH();
            bllhd.loadhd();
            btnXoa.Enabled = false;
            btn_sua.Enabled = false;
            btnTimKiem.Enabled = false;
        }

        private void clearText()
        {
            txt_mahd.Clear();
            txtSoLuong.Clear();
            txt_giaban.Clear();
            txt_thanhtien.Clear();
            btnThemmoi.Enabled = true;
            btnXoa.Enabled = false;
        }

        private void txt_soluong_TextChanged(object sender, EventArgs e)
        {
            double sl, gn, tt;
            if (txt_giaban.Text == "")
                gn = 0;
            else
                gn = Convert.ToDouble(txt_giaban.Text);
            if (txtSoLuong.Text == "")
                sl = 0;
            else
                sl = Convert.ToDouble(txtSoLuong.Text);

            tt = gn * sl;
            txt_thanhtien.Text = tt.ToString();
        }

        private void txt_mahd_TextChanged(object sender, EventArgs e)
        {
            btnTimKiem.Enabled = true;
        }

        #region Combo box
        private void cboMakhach_SelectedIndexChanged(object sender, EventArgs e)
        {
            con = conn.connection();
            con.Open();
            comm = new SqlCommand("select * from KHACHHANG where MaKH = '" + cb_mkh.SelectedValue.ToString() + "'", con);
            SqlDataReader reader = comm.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();              
                txtTenkhach.Text = reader.GetString(1).ToString();
                txtDiachi.Text = reader.GetString(4).ToString();
                txtDienthoai.Text = reader.GetString(5).ToString();
            }
        }

        private void cboManhanvien_SelectedIndexChanged(object sender, EventArgs e)
        {
            con = conn.connection();
            con.Open();
            comm = new SqlCommand("select * from NHANVIEN where MaNV = '" + cb_mnv.SelectedValue.ToString() + "'", con);
            SqlDataReader reader = comm.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                txt_tennv.Text = reader.GetString(1).ToString();

            }
        }
        private void cb_mahang_SelectedIndexChanged(object sender, EventArgs e)
        {
            con = conn.connection();
            con.Open();
            comm = new SqlCommand("select * from LinhKien where MaLK = '" + cb_mahang.SelectedValue.ToString() + "'", con);
            SqlDataReader reader = comm.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                txt_tenhang.Text = reader.GetString(1).ToString();
                txt_giaban.Text = reader.GetFloat(3).ToString();
            }
        }
        #endregion

        #region BTN Click
        private void DTV_hoadon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_mahd.Text = DTV_hoadon.CurrentRow.Cells[0].Value.ToString();
            cb_mahang.Text = DTV_hoadon.CurrentRow.Cells[1].Value.ToString();
            txtSoLuong.Text = DTV_hoadon.CurrentRow.Cells[2].Value.ToString();
            txt_giaban.Text = DTV_hoadon.CurrentRow.Cells[3].Value.ToString();
            txt_thanhtien.Text = DTV_hoadon.CurrentRow.Cells[4].Value.ToString();
            btn_sua.Enabled = true;
            btnXoa.Enabled = true;
            btnTimKiem.Enabled = true;
            btnThemmoi.Enabled = false;
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            string sql;
            if ((cb_mnv.Text == ""))
            {
                MessageBox.Show("Bạn hãy nhập điều kiện tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            sql = "SELECT * from HOADON WHERE 1=1";

            if (cb_mnv.Text != "")
                sql += " AND MaNV LIKE N'%" + cb_mnv.SelectedValue + "%'";
            dthd = lopchung.LoadDuLieu(sql);
            if (dthd.Rows.Count == 0)
                MessageBox.Show("Không có nhân viên thoả mãn điều kiện tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else MessageBox.Show("Có " + dthd.Rows.Count + " nhân viên thoả mãn điều kiện!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DTV_hoadon.DataSource = dthd;
        }

        private void btnThemmoi_Click(object sender, EventArgs e)
        {
            if (txt_mahd.Text == "" || cb_mnv.Text == "" || txt_tennv.Text == "" || cb_mkh.Text == "" || txtDiachi.Text == "" || txtDienthoai.Text == "" || cb_mahang.Text == "" || txtSoLuong.Text == "" || txt_tenhang.Text == "" || txt_thanhtien.Text == "" || txt_giaban.Text == "")
            {
                DialogResult tb;
                tb = (MessageBox.Show("Bạn đã nhập thiếu thông tin!", "chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning));
            }
            else
            {
                bllhd.themhd();
                bllhd.loadhd();
                clearText();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txt_mahd.Text == "" || cb_mnv.Text == "" || txt_tennv.Text == "" || cb_mkh.Text == "" || txtDiachi.Text == "" || txtDienthoai.Text == "" || cb_mahang.Text == "" || txtSoLuong.Text == "" || txt_tenhang.Text == "" || txt_thanhtien.Text == "" || txt_giaban.Text == "")
            {
                DialogResult tb;
                tb = (MessageBox.Show("Bạn đã nhập thiếu thông tin!", "chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning));
            }
            else
            {
                bllhd.xoahd();
                bllhd.loadhd();
                clearText();
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txt_mahd.Text == "" || cb_mnv.Text == "" || txt_tennv.Text == "" || cb_mkh.Text == "" || txtDiachi.Text == "" || txtDienthoai.Text == "" || cb_mahang.Text == "" || txtSoLuong.Text == "" || txt_tenhang.Text == "" || txt_thanhtien.Text == "" || txt_giaban.Text == "")
            {
                DialogResult tb;
                tb = (MessageBox.Show("Bạn chưa chọn thông tin cần sửa!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning));
            }
            else
            {
                bllhd.suahd();
                bllhd.loadhd();
                clearText();
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btn_tinhtong_Click(object sender, EventArgs e)
        {
            int sc = DTV_hoadon.Rows.Count;
            float thanhtien = 0;
            for (int i = 0; i < sc - 1; i++)
                thanhtien += float.Parse(DTV_hoadon.Rows[i].Cells["ThanhTIEN"].Value.ToString());
            txtTongtien.Text = thanhtien.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql;
            if ((cb_mkh.Text == ""))
            {
                MessageBox.Show("Bạn hãy nhập điều kiện tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            sql = "SELECT * from HOADON WHERE 1=1";

            if (cb_mkh.Text != "")
                sql += " AND MaKH LIKE N'%" + cb_mkh.SelectedValue + "%'";
            dthd = lopchung.LoadDuLieu(sql);
            if (dthd.Rows.Count == 0)
                MessageBox.Show("Không có khách hàng thoả mãn điều kiện tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else MessageBox.Show("Có " + dthd.Rows.Count + " khách thoả mãn điều kiện!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DTV_hoadon.DataSource = dthd;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            bllhd.loadhd();
        }
        #endregion
    }
  
}
    

