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
    public partial class frm_main : Form
    {
        public frm_main()
        {
            InitializeComponent();
        }

        #region toolstrip

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void nToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frm_nhanvien"] == null)
            {
                frm_nhanvien nhanvien = new frm_nhanvien();
                nhanvien.Show();
            }
            else
            {
                Application.OpenForms["frm_nhanvien"].Activate();
            }
        }

        private void hàngHóaToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void nhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion


        #region button
        private void button1_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frm_nhanvien"] == null)
            {
                frm_nhanvien nhanvien = new frm_nhanvien();
                nhanvien.Show();
            }
            else
            {
                Application.OpenForms["frm_nhanvien"].Activate();
            }
        }

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

        private void BTN_TAOTK_Click(object sender, EventArgs e)
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
    }
}
