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
    public partial class frm_nhacungcap : Form
    {
        DAL.LOPDUNGCHUNG conn = new DAL.LOPDUNGCHUNG();
        LOPDUNGCHUNG lopchung = new LOPDUNGCHUNG();
        DataTable dthd;
        BLL.BLL_nhacungcap bllncc;
        BLL.BLL_hanghoa bllhh;
        
        public frm_nhacungcap()
        {
            InitializeComponent();
            bllncc = new BLL.BLL_nhacungcap(this);
            bllhh = new BLL.BLL_hanghoa(this);
        }

        #region form load
        private void clearText()
        {
            txt_mancc.Clear();
            txt_tenncc.Clear();
            txt_diachi.Clear();
            txt_email.Clear();
            txt_sdt.Clear();
            btnThem.Enabled = true;
            btnXoa.Enabled = false;
        }

        private void frm_nhacungcap_Load(object sender, EventArgs e)
        {
            bllncc.loadncc();
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            btnTimkiem.Enabled = false;
        }

        private void txt_mancc_TextChanged(object sender, EventArgs e)
        {
            btnTimkiem.Enabled = false;
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

        private void DTV_nhacungcap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_mancc.Text = DTV_nhacungcap.CurrentRow.Cells[0].Value.ToString();
            txt_tenncc.Text = DTV_nhacungcap.CurrentRow.Cells[1].Value.ToString();
            txt_diachi.Text = DTV_nhacungcap.CurrentRow.Cells[2].Value.ToString();
            txt_sdt.Text = DTV_nhacungcap.CurrentRow.Cells[3].Value.ToString();
            txt_email.Text = DTV_nhacungcap.CurrentRow.Cells[4].Value.ToString();
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnTimkiem.Enabled = true;
            btnThem.Enabled = false;
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txt_mancc.Text == "" || txt_tenncc.Text == "" || txt_diachi.Text == "" || txt_email.Text == "" || txt_sdt.Text == "")
            {
                DialogResult tb;
                tb = (MessageBox.Show("Bạn chưa chọn mục cần xóa!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning));
            }
            else if (txt_mancc.TextLength > 10 || txt_tenncc.TextLength > 30 || txt_email.TextLength > 30 || txt_sdt.TextLength > 30 || txt_diachi.TextLength > 30)
            {
                DialogResult tb;
                tb = (MessageBox.Show("Bạn đã nhập sai", "Nhập lại", MessageBoxButtons.OK, MessageBoxIcon.Warning));
            }
            else
            {
                bllncc.xoancc();
                bllncc.loadncc();
                clearText();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txt_mancc.Text == "" || txt_tenncc.Text == "" || txt_diachi.Text == "" || txt_email.Text == "" || txt_sdt.Text == "")
            {
                DialogResult tb;
                tb = (MessageBox.Show("Bạn đã nhập thiếu thông tin!", "chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning));
            }
            else if (txt_mancc.TextLength > 10 || txt_tenncc.TextLength > 30 || txt_email.TextLength > 30 || txt_sdt.TextLength > 30 || txt_diachi.TextLength > 30)
            {
                DialogResult tb;
                tb = (MessageBox.Show("Bạn đã nhập sai", "Nhập lại", MessageBoxButtons.OK, MessageBoxIcon.Warning));
            }
            else
            {
                bllncc.suancc();
                bllncc.loadncc();
                clearText();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txt_mancc.Text == "" || txt_tenncc.Text == "" || txt_diachi.Text == "" || txt_email.Text == "" || txt_sdt.Text == "")
            {
                DialogResult tb;
                tb = (MessageBox.Show("Bạn đã nhập thiếu thông tin!", "chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning));
            }
            else if (txt_mancc.TextLength > 10 || txt_tenncc.TextLength > 30 || txt_email.TextLength > 30 || txt_sdt.TextLength > 30 || txt_diachi.TextLength > 30)
            {
                DialogResult tb;
                tb = (MessageBox.Show("Bạn đã nhập sai", "Nhập lại", MessageBoxButtons.OK, MessageBoxIcon.Warning));
            }
            else
            {
                bllncc.themncc();
                bllncc.loadncc();
                clearText();
            }
        }

        private void btn_find_Click(object sender, EventArgs e)
        {
            string sql;
            if ((txt_mancc.Text == "") && (txt_tenncc.Text == "") && (txt_email.Text == "") && (txt_sdt.Text == ""))
            {
                MessageBox.Show("Bạn hãy nhập điều kiện tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            sql = "SELECT * from NhaCungCap WHERE 1=1";
            if (txt_mancc.Text != "")
                sql += " AND MaNCC LIKE N'%" + txt_mancc.Text + "%'";
            if (txt_tenncc.Text != "")
                sql += " AND TenNCC LIKE N'%" + txt_tenncc.Text + "%'";
            if (txt_email.Text != "")
                sql += " AND email LIKE N'%" + txt_email.Text + "%'";
            if (txt_sdt.Text != "")
                sql += " AND SDT LIKE N'%" + txt_sdt.Text + "%'";
            dthd = lopchung.LoadDuLieu(sql);
            if (dthd.Rows.Count == 0)
                MessageBox.Show("Không có nhà cung cấp thoả mãn điều kiện tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else MessageBox.Show("Có " + dthd.Rows.Count + " nhà cung cấp hóa thoả mãn điều kiện!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DTV_nhacungcap.DataSource = dthd;
        }
        #endregion
    }
}
