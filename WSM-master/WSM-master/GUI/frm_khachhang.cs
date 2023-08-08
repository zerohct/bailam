using DOAN_QLBH.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DOAN_QLBH.GUI
{
    public partial class frm_khachhang : Form
    {
        DAL.LOPDUNGCHUNG conn = new DAL.LOPDUNGCHUNG();
        LOPDUNGCHUNG lopchung = new LOPDUNGCHUNG();
        DataTable dthd; 
        BLL.BLL_khachhang bllkh;
        public frm_khachhang()
        {
            InitializeComponent();
            bllkh = new BLL.BLL_khachhang(this);
        }

        #region form load
        private void frm_khachhang_Load(object sender, EventArgs e)
        {
            bllkh.loadkh();
            bllkh.LayDSGT();
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            btnTimkiem.Enabled = false;
        }

        private void clearText()
        {
            txt_makh.Clear();
            txt_tenkh.Clear();
            txt_diachi.Clear();
            txt_email.Clear();
            txt_sdt.Clear();
            btnThem.Enabled = true;
            btnXoa.Enabled = false;
        }

        private void txt_makh_TextChanged(object sender, EventArgs e)
        {
            btnTimkiem.Enabled = true;
        }

        private void txt_sdt_TextChanged(object sender, EventArgs e)
        {

            if (int.TryParse(txt_sdt.Text, out int value))
            {
            }
            else
            {
                txt_sdt.Text = "";
            }
        }
        #endregion



        #region BTN Click

        private void DTV_khachhang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_makh.Text = DTV_khachhang.CurrentRow.Cells[0].Value.ToString();
            txt_tenkh.Text = DTV_khachhang.CurrentRow.Cells[1].Value.ToString();
            cb_gioitinh.Text = DTV_khachhang.CurrentRow.Cells[2].Value.ToString();
            txt_diachi.Text = DTV_khachhang.CurrentRow.Cells[3].Value.ToString();
            txt_sdt.Text = DTV_khachhang.CurrentRow.Cells[4].Value.ToString();
            txt_email.Text = DTV_khachhang.CurrentRow.Cells[5].Value.ToString();
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnTimkiem.Enabled = true;
            btnThem.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txt_makh.Text == "" || txt_tenkh.Text == "" || txt_email.Text == "" || txt_sdt.Text == "" || txt_diachi.Text == "")
            {
                DialogResult tb;
                tb = (MessageBox.Show("Bạn chưa chọn mục cần sửa!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning));
            }
            else if (txt_makh.TextLength > 10 || txt_tenkh.TextLength > 30 || txt_email.TextLength > 30 || txt_sdt.TextLength > 30 || txt_diachi.TextLength > 30)
            {
                DialogResult tb;
                tb = (MessageBox.Show("Bạn đã nhập sai", "Nhập lại", MessageBoxButtons.OK, MessageBoxIcon.Warning));
            }
            else
            {
                bllkh.suakh();
                bllkh.loadkh();
                clearText();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txt_makh.Text == "" || txt_tenkh.Text == "" || txt_email.Text == "" || txt_sdt.Text == "" || txt_diachi.Text == "")
            {
                DialogResult tb;
                tb = (MessageBox.Show("Bạn đã nhập thiếu thông tin!", "chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning));
            }
            else if (txt_makh.TextLength > 10 || txt_tenkh.TextLength > 30 || txt_email.TextLength > 30 || txt_sdt.TextLength > 30 || txt_diachi.TextLength > 30)
            {
                DialogResult tb;
                tb = (MessageBox.Show("Bạn đã nhập sai", "Nhập lại", MessageBoxButtons.OK, MessageBoxIcon.Warning));
            }
            else
            {
                bllkh.luukh();
                bllkh.loadkh();
                clearText();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txt_makh.Text == "" || txt_tenkh.Text == "" || txt_email.Text == "" || txt_sdt.Text == "" || txt_diachi.Text == "")
            {
                DialogResult tb;
                tb = (MessageBox.Show("Bạn chưa chọn thông tin cần xóa!", "chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning));
            }
            else if (txt_makh.TextLength > 10 || txt_tenkh.TextLength > 30 || txt_email.TextLength > 30 || txt_sdt.TextLength > 30 || txt_diachi.TextLength > 30)
            {
                DialogResult tb;
                tb = (MessageBox.Show("Bạn đã nhập sai", "Nhập lại", MessageBoxButtons.OK, MessageBoxIcon.Warning));
            }
            else
            {
                bllkh.xoakh();
                bllkh.loadkh();
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

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            string sql;
            if ((txt_makh.Text == "") && (txt_tenkh.Text == "") && (txt_email.Text == "") && (txt_sdt.Text == ""))
            {
                MessageBox.Show("Bạn hãy nhập điều kiện tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            sql = "SELECT * from KhachHang WHERE 1=1";
            if (txt_makh.Text != "")
                sql += " AND MaKH LIKE N'%" + txt_makh.Text + "%'";
            if (txt_tenkh.Text != "")
                sql += " AND TenKH LIKE N'%" + txt_tenkh.Text + "%'";
            if (txt_email.Text != "")
                sql += " AND email LIKE N'%" + txt_email.Text + "%'";
            if (txt_sdt.Text != "")
                sql += " AND SDT LIKE N'%" + txt_sdt.Text + "%'";
            dthd = lopchung.LoadDuLieu(sql);
            if (dthd.Rows.Count == 0)
                MessageBox.Show("Không có khách hàng thoả mãn điều kiện tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else MessageBox.Show("Có " + dthd.Rows.Count + " khách hàng hóa thoả mãn điều kiện!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DTV_khachhang.DataSource = dthd;
        }
        #endregion
    }
}
