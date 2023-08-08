using DOAN_QLBH.GUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DOAN_QLBH.BLL
{
    class BLL_taikhoan
    {
        DAL.DAL_taikhoan DAL_tk = new DAL.DAL_taikhoan();
        DAL.DAL_nhanvien DAL_nv = new DAL.DAL_nhanvien();
        GUI.frm_taikhoan frm_tk;
        GUI.frm_dangnhap frm_dn;
        GUI.frm_nhanvien frm_nv;

        public BLL_taikhoan(GUI.frm_taikhoan f)
        {
            frm_tk = f;
        }
        public BLL_taikhoan(GUI.frm_nhanvien f)
        {
            frm_nv = f;
        }

        public void themtk()
        {
            int ketqua = DAL_tk.themtk(frm_tk.TXB_TENDN.Text, frm_tk.TXB_MK.Text, frm_tk.CB_MANV.SelectedValue.ToString());
            if (ketqua >= 1) MessageBox.Show("Thêm thành công");
            else MessageBox.Show("Thêm thất bại");
        }

        public void suatk()
        {
            int ketqua = DAL_tk.suatk(frm_tk.TXB_TENDN.Text, frm_tk.TXB_MK.Text, frm_tk.CB_MANV.SelectedValue.ToString());
            if (ketqua >= 1) MessageBox.Show("Sửa thành công");
            else MessageBox.Show("Sửa thất bại");
        }
        public void xoatk()
        {
            int ketqua = DAL_tk.xoatk(frm_tk.TXB_TENDN.Text);
            if (ketqua >= 1) MessageBox.Show("Xóa thành công");
            else MessageBox.Show("Xóa thất bại");
        }
        public void loadtk()
        {
            frm_tk.DTV_TK.DataSource = DAL_tk.loadtk();
        }

        public void LayDSTK()
        {
            frm_tk.CB_MANV.DataSource = DAL_nv.loadnv();
            frm_tk.CB_MANV.DisplayMember = "MaNV";
            frm_tk.CB_MANV.ValueMember = "MaNV";
        }

        public void LayDSNV()
        {
            frm_dn.cb_tendn.DataSource = DAL_tk.loadtk();
            frm_dn.cb_tendn.DisplayMember = "TenDangNhap";
            frm_dn.cb_tendn.ValueMember = "TenDangNhap";
        }
    }
}
