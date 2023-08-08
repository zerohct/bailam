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
using DOAN_QLBH;
using DOAN_QLBH.DAL;


namespace DOAN_QLBH.GUI
{   
    
    public partial class frm_hanghoa : Form
    {
        DataTable tblH;
        DAL.LOPDUNGCHUNG lopchung = new DAL.LOPDUNGCHUNG();
        
        BLL.BLL_hanghoa bllhh;
        BLL.BLL_nhacungcap bllncc1;

        public frm_hanghoa()
        {
            InitializeComponent();
            bllncc1 = new BLL.BLL_nhacungcap(this);
            bllhh = new BLL.BLL_hanghoa(this);
        }

        #region form load
        private void clearText()
        {
            txtMaLK.Clear();
            txtTenLK.Clear();
            txtThongSo.Clear();
            txtNgayNhap.Clear();
            txtGiaMua.Clear();
            txtGiaban.Clear();
            btnThem.Enabled = true;
            btnXoa.Enabled = false;
        }

        private void frm_hanghoa_Load(object sender, EventArgs e)
        {
            bllhh.loadhh();
            bllncc1.LayDSNCC();
            bllhh.LayDSLLK();
            bllhh.LayDSKho();
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            btnTimkiem.Enabled = false;
        }

        private void txtDongianhap_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(txtGiaMua.Text, out int value))
            {
            }
            else
            {
                txtGiaMua.Text = "";
            }

            double gn, gb;
            if (txtGiaMua.Text == "")
                gn = 0;
            else
                gn = Convert.ToDouble(txtGiaMua.Text);
            gb = gn + (gn * 20 / 100);
            txtGiaban.Text = gb.ToString();
        }

        private void txtMaLK_TextChanged(object sender, EventArgs e)
        {
            btnTimkiem.Enabled = true;
        }

        private void txtThongSo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        #endregion


        #region BTN Click

        private void DTV_hh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaLK.Text = DTV_hh.CurrentRow.Cells[0].Value.ToString();
            txtTenLK.Text = DTV_hh.CurrentRow.Cells[1].Value.ToString();
            txtThongSo.Text = DTV_hh.CurrentRow.Cells[2].Value.ToString();
            txtGiaMua.Text = DTV_hh.CurrentRow.Cells[3].Value.ToString();
            txtGiaban.Text = DTV_hh.CurrentRow.Cells[4].Value.ToString();
            txtNgayNhap.Text = DTV_hh.CurrentRow.Cells[5].Value.ToString();
            cb_llk.Text = DTV_hh.CurrentRow.Cells[6].Value.ToString();
            cb_mk.Text = DTV_hh.CurrentRow.Cells[7].Value.ToString();
            cb_ncc.Text = DTV_hh.CurrentRow.Cells[8].Value.ToString();
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnTimkiem.Enabled = true;
            btnThem.Enabled = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaLK.Text == "" || txtTenLK.Text == "" || cb_ncc.Text == "" || cb_llk.Text == "" || cb_mk.Text == "" || txtThongSo.Text == "" || txtGiaMua.Text == "" || txtGiaban.Text == "" || txtNgayNhap.Text == "")
            {
                DialogResult tb;
                tb = (MessageBox.Show("Bạn đã nhập thiếu thông tin!", "chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning));
            }
            else if (txtMaLK.TextLength > 10 || txtTenLK.TextLength > 30 || DateTime.TryParse(txtNgayNhap.Text, out DateTime NgayNhap) == false || NgayNhap > DateTime.Now)
            {
                DialogResult tb;
                tb = (MessageBox.Show("Bạn đã nhập sai", "Nhập lại", MessageBoxButtons.OK, MessageBoxIcon.Warning));
            }
            else
            {
                bllhh.themhh();
                bllhh.loadhh();
                clearText();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaLK.Text == "" || txtTenLK.Text == "" || cb_ncc.Text == "" || cb_llk.Text == "" || cb_mk.Text == "" || txtThongSo.Text == "" || txtGiaMua.Text == "" || txtGiaban.Text == "" || txtNgayNhap.Text == "")
            {
                DialogResult tb;
                tb = (MessageBox.Show("Bạn chưa chọn thông tin cần sửa!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning));
            }
            else if (txtMaLK.TextLength > 10 || txtTenLK.TextLength > 30 || DateTime.TryParse(txtNgayNhap.Text, out DateTime NgayNhap) == false || NgayNhap > DateTime.Now)
            {
                DialogResult tb;
                tb = (MessageBox.Show("Bạn đã nhập sai", "Nhập lại", MessageBoxButtons.OK, MessageBoxIcon.Warning));
            }
            else
            {
                bllhh.suahh();
                bllhh.loadhh();
                clearText();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaLK.Text == "" || txtTenLK.Text == "" || cb_ncc.Text == "" || cb_llk.Text == "" || cb_mk.Text == "" || txtThongSo.Text == "" || txtGiaMua.Text == "" || txtGiaban.Text == "" || txtNgayNhap.Text == "")
            {
                DialogResult tb;
                tb = (MessageBox.Show("Bạn chưa chọn thông tin cần xóa!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning));
            }
            else if (txtMaLK.TextLength > 10 || txtTenLK.TextLength > 30 || DateTime.TryParse(txtNgayNhap.Text, out DateTime NgayNhap) == false || NgayNhap > DateTime.Now)
            {
                DialogResult tb;
                tb = (MessageBox.Show("Bạn đã nhập sai", "Nhập lại", MessageBoxButtons.OK, MessageBoxIcon.Warning));
            }
            else
            {

                bllhh.xoahh();
                bllhh.loadhh();
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
            if ((txtMaLK.Text == "") && (txtTenLK.Text == "") && (cb_ncc.Text == ""))
            {
                MessageBox.Show("Bạn hãy nhập điều kiện tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            sql = "SELECT * from LinhKien WHERE 1=1";
            if (txtMaLK.Text != "")
                sql += " AND MALK LIKE N'%" + txtMaLK.Text + "%'";
            if (txtTenLK.Text != "")
                sql += " AND TenLK LIKE N'%" + txtTenLK.Text + "%'";
            if (cb_ncc.Text != "")
                sql += " AND MaNCC LIKE N'%" + cb_ncc.SelectedValue + "%'";
            tblH =lopchung.LoadDuLieu(sql);
            if (tblH.Rows.Count == 0)
                MessageBox.Show("Không có linh kiện thoả mãn điều kiện tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else MessageBox.Show("Có " + tblH.Rows.Count + "  linh kiện thoả mãn điều kiện!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DTV_hh.DataSource = tblH;
        }
        #endregion
    }
}
