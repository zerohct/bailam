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
    public partial class frm_nhanvien : Form
    {
        DAL.LOPDUNGCHUNG conn = new DAL.LOPDUNGCHUNG();
        LOPDUNGCHUNG lopchung = new LOPDUNGCHUNG();
        DataTable dthd;
        BLL.BLL_nhanvien bll_nv;
        public frm_nhanvien()
        {
            InitializeComponent();
            bll_nv = new BLL.BLL_nhanvien(this);
        }

        #region form load
        private void frm_nhanvien_Load(object sender, EventArgs e)
        {
            bll_nv.loadnv();
            bll_nv.LayDSCV();
            bll_nv.LayDSGT();
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            btnTimkiem.Enabled = false;
        }

        private void clearText()
        {
            txt_mnv.Clear();
            txt_tennv.Clear();
            txt_diachi.Clear();
            txt_email.Clear();
            txt_sdt.Clear();
            btnThem.Enabled = true;
            btnXoa.Enabled = false;
        }

        private void txt_mnv_TextChanged(object sender, EventArgs e)
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

        private void DTV_nhanvien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_mnv.Text = DTV_nhanvien.CurrentRow.Cells[0].Value.ToString();
            txt_tennv.Text = DTV_nhanvien.CurrentRow.Cells[1].Value.ToString();
            cb_gioitinh.Text = DTV_nhanvien.CurrentRow.Cells[2].Value.ToString();
            dt_namsinh.Text = DTV_nhanvien.CurrentRow.Cells[3].Value.ToString();
            txt_diachi.Text = DTV_nhanvien.CurrentRow.Cells[4].Value.ToString();
            txt_sdt.Text = DTV_nhanvien.CurrentRow.Cells[5].Value.ToString();
            txt_email.Text = DTV_nhanvien.CurrentRow.Cells[6].Value.ToString();
            cb_chucvu.Text = DTV_nhanvien.CurrentRow.Cells[7].Value.ToString();
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnTimkiem.Enabled = true;
            btnThem.Enabled = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (cb_chucvu.Text == "Quản trị viên")
            {
                DialogResult tb;
                tb = (MessageBox.Show("Không được thêm!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning));
            }
            if (txt_mnv.Text == "" || txt_tennv.Text == "" || txt_sdt.Text == "" || txt_email.Text == "" || txt_diachi.Text == "")
            {
                DialogResult tb;
                tb = (MessageBox.Show("Bạn đã nhập thiếu thông tin!", "chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning));
            }
            else if (txt_mnv.TextLength > 10 || txt_tennv.TextLength > 30 || txt_email.TextLength > 30 || txt_sdt.TextLength > 30 || txt_diachi.TextLength > 30 || dt_namsinh.Value > DateTime.Now)
            {
                DialogResult tb;
                tb = (MessageBox.Show("Bạn đã nhập sai", "Nhập lại", MessageBoxButtons.OK, MessageBoxIcon.Warning));
            }
            else
            {
                bll_nv.luunv();
                bll_nv.loadnv();
                clearText();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {   
            if(txt_mnv.Text == "NV1")
            {
                DialogResult tb;
                tb = (MessageBox.Show("Không được xóa!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning));
            }
            else if (txt_mnv.Text == "" || txt_tennv.Text == "" || txt_sdt.Text == "" || txt_email.Text == "" || txt_diachi.Text == "")
            {
                DialogResult tb;
                tb = (MessageBox.Show("Bạn chưa chọn ô để xóa!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning));
            }
            else if (txt_mnv.TextLength > 10 || txt_tennv.TextLength > 30 || txt_email.TextLength > 30 || txt_sdt.TextLength > 30 || txt_diachi.TextLength > 30 || dt_namsinh.Value > DateTime.Now)
            {
                DialogResult tb;
                tb = (MessageBox.Show("Bạn đã nhập sai", "Nhập lại", MessageBoxButtons.OK, MessageBoxIcon.Warning));
            }
            else
            {
                bll_nv.xoanv();
                bll_nv.loadnv();
                clearText();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txt_mnv.Text == "NV1")
            {
                DialogResult tb;
                tb = (MessageBox.Show("Không được sửa!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning));
            }
            else if (txt_mnv.Text == "" || txt_tennv.Text == "" || txt_sdt.Text == "" || txt_email.Text == "" || txt_diachi.Text == "")
            {
                DialogResult tb;
                tb = (MessageBox.Show("Bạn chưa chọn ô để sửa!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning));
            }
            else if (txt_mnv.TextLength > 10 || txt_tennv.TextLength > 30 || txt_email.TextLength > 30 || txt_sdt.TextLength > 30 || txt_diachi.TextLength > 30 || dt_namsinh.Value > DateTime.Now)
            {
                DialogResult tb;
                tb = (MessageBox.Show("Bạn đã nhập sai", "Nhập lại", MessageBoxButtons.OK, MessageBoxIcon.Warning));
            }
            else
            {
                bll_nv.suanv();
                bll_nv.loadnv();
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

        private void btn_find_Click(object sender, EventArgs e)
        {
            string sql;
            if ((txt_mnv.Text == "") && (txt_tennv.Text == "") && (txt_email.Text == "") && (txt_sdt.Text == ""))
            {
                MessageBox.Show("Bạn hãy nhập điều kiện tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            sql = "SELECT * from NhanVien WHERE 1=1";
            if (txt_mnv.Text != "")
                sql += " AND MaNV LIKE N'%" + txt_mnv.Text + "%'";
            if (txt_tennv.Text != "")
                sql += " AND HoTen LIKE N'%" + txt_tennv.Text + "%'";
            if (txt_email.Text != "")
                sql += " AND email LIKE N'%" + txt_email.Text + "%'";
            if (txt_sdt.Text != "")
                sql += " AND SDT LIKE N'%" + txt_sdt.Text + "%'";
            dthd = lopchung.LoadDuLieu(sql);
            if (dthd.Rows.Count == 0)
                MessageBox.Show("Không có nhân viên thoả mãn điều kiện tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else MessageBox.Show("Có " + dthd.Rows.Count + " nhân viên hóa thoả mãn điều kiện!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DTV_nhanvien.DataSource = dthd;
        }
        #endregion
    }
}
