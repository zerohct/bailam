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
    public partial class frm_mainNV : Form
    {
        public frm_mainNV()
        {
            InitializeComponent();
        }

        #region BTN Click
        private void BTN_KH_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frm_khachhang"] == null)
            {
                frm_khachhang khachhang = new frm_khachhang();
                khachhang.Show();
            }
            else
            {
                Application.OpenForms["frm_khachhang"].Activate();
            }
        }

        private void BTN_LK_Click(object sender, EventArgs e)
        {

            if (Application.OpenForms["frm_hanghoa"] == null)
            {
                frm_hanghoa hanghoa = new frm_hanghoa();
                hanghoa.Show();
            }
            else
            {
                Application.OpenForms["frm_hanghoa"].Activate();
            }
        }

        private void BTN_NCC_Click(object sender, EventArgs e)
        {

            if (Application.OpenForms["frm_nhacungcap"] == null)
            {
                frm_nhacungcap ncc = new frm_nhacungcap();
                ncc.Show();
            }
            else
            {
                Application.OpenForms["frm_nhacungcap"].Activate();
            }
        }

        private void BTN_BH_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frm_hoadon"] == null)
            {
                frm_hoadon hoadon = new frm_hoadon();
                hoadon.Show();
            }
            else
            {
                Application.OpenForms["frm_hoadon"].Activate();
            }
        }

        private void BTN_THOAT_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                frm_dangnhap main = new frm_dangnhap();
                main.Show();
            }
        }
        #endregion

        #region Tool Strip
        private void bánHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frm_hoadon"] == null)
            {
                frm_hoadon hoadon = new frm_hoadon();
                hoadon.Show();
            }
            else
            {
                Application.OpenForms["frm_hoadon"].Activate();
            }
        }

        private void tạoTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frm_taikhoan"] == null)
            {
                frm_taikhoan taikhoan = new frm_taikhoan();
                taikhoan.Show();
            }
            else
            {
                Application.OpenForms["frm_taikhoan"].Activate();
            }
        }
        #endregion
    }
}
