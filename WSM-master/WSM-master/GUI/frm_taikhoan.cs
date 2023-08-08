using DOAN_QLBH.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DOAN_QLBH.GUI
{
    public partial class frm_taikhoan : Form
    {
        DataTable tblH;
        DAL.LOPDUNGCHUNG lopchung = new DAL.LOPDUNGCHUNG();
        DAL.LOPDUNGCHUNG conn = new DAL.LOPDUNGCHUNG();
        SqlConnection con;
        SqlCommand comm;

        BLL.BLL_taikhoan blltk;
        BLL.BLL_nhanvien bllnv;

        public frm_taikhoan()
        {
            InitializeComponent();
            blltk = new BLL.BLL_taikhoan(this);
        }

        #region form load

        private void frm_taikhoan_Load(object sender, EventArgs e)
        {
            blltk.loadtk();
            blltk.LayDSTK();
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            btn_timkiem.Enabled = false;
        }

        private void clearText()
        {
            TXB_TENDN.Clear();
            TXB_MK.Clear();
            txb_tennv.Clear();
            txb_chucvu.Clear();
            btnThem.Enabled = true;
            btnXoa.Enabled = false;
        }

        private void DTV_TK_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            TXB_TENDN.Text = DTV_TK.CurrentRow.Cells[0].Value.ToString();
            TXB_MK.Text = DTV_TK.CurrentRow.Cells[1].Value.ToString();
            CB_MANV.Text = DTV_TK.CurrentRow.Cells[2].Value.ToString();
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btn_timkiem.Enabled = true;
            btnThem.Enabled = false;
        }

        private void CB_MANV_SelectedIndexChanged(object sender, EventArgs e)
        {
            con = conn.connection();
            con.Open();
            comm = new SqlCommand("select * from NhanVien where MaNV = '" + CB_MANV.SelectedValue.ToString() + "'", con);
            SqlDataReader reader = comm.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                txb_tennv.Text = reader.GetString(1).ToString();
                txb_chucvu.Text = reader.GetString(7).ToString();
            }
        }
        #endregion


        #region Button Click

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (TXB_TENDN.Text == "" || TXB_MK.Text == "")
            {
                DialogResult tb;
                tb = (MessageBox.Show("Bạn đã nhập thiếu thông tin!", "chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning));
            }
            else if (TXB_TENDN.TextLength > 10 || TXB_MK.TextLength > 20 || TXB_MK.TextLength < 4)
            {
                DialogResult tb;
                tb = (MessageBox.Show("Bạn đã nhập sai", "Nhập lại", MessageBoxButtons.OK, MessageBoxIcon.Warning));
            }
            else
            {
                blltk.themtk();
                blltk.loadtk();
                clearText();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (CB_MANV.Text == "NV1")
            {
                DialogResult tb;
                tb = (MessageBox.Show("Không được xóa!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning));
            }
            else if (CB_MANV.Text == "" || TXB_TENDN.Text == "" || TXB_MK.Text == "")
            {
                DialogResult tb;
                tb = (MessageBox.Show("Bạn chưa chọn mục để xóa!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning));
            }
            else if (TXB_TENDN.TextLength > 10 || TXB_MK.TextLength > 20 || TXB_MK.TextLength < 4)
            {
                DialogResult tb;
                tb = (MessageBox.Show("Bạn đã nhập sai", "Nhập lại", MessageBoxButtons.OK, MessageBoxIcon.Warning));
            }
            else
            {
                blltk.xoatk();
                blltk.loadtk();
                clearText();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (CB_MANV.Text == "NV1")
            {
                DialogResult tb;
                tb = (MessageBox.Show("Không được sửa!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning));
            }
            else if (CB_MANV.Text == "" || TXB_TENDN.Text == "" || TXB_MK.Text == "")
            {
                DialogResult tb;
                tb = (MessageBox.Show("Bạn chưa chọn mục để sửa!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning));
            }
            else if (TXB_TENDN.TextLength > 10 || TXB_MK.TextLength > 20 || TXB_MK.TextLength < 4)
            {
                DialogResult tb;
                tb = (MessageBox.Show("Bạn đã nhập sai", "Nhập lại", MessageBoxButtons.OK, MessageBoxIcon.Warning));
            }
            else
            {
                blltk.suatk();
                blltk.loadtk();
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
            if ((CB_MANV.Text == ""))
            {
                MessageBox.Show("Bạn hãy nhập điều kiện tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            sql = "SELECT * from DangNhap WHERE 1=1";

            if (CB_MANV.Text != "")
                sql += " AND MaNV LIKE N'%" + CB_MANV.SelectedValue + "%'";
            tblH = lopchung.LoadDuLieu(sql);
            if (tblH.Rows.Count == 0)
                MessageBox.Show("Không có nhân viên thoả mãn điều kiện tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else MessageBox.Show("Có " + tblH.Rows.Count + " nhân viên thoả mãn điều kiện!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DTV_TK.DataSource = tblH;
        }

        #endregion
    }
}
