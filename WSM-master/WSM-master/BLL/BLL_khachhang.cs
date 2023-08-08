using DOAN_QLBH.GUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DOAN_QLBH.BLL
{
    class BLL_khachhang
    {
        DAL.DAL_khachhang dal_khachhang = new DAL.DAL_khachhang();
        GUI.frm_khachhang frm_khachhang;
        GUI.frm_hoadon frm_hoadon;

        public BLL_khachhang(GUI.frm_khachhang f)
        {
            frm_khachhang = f;
        }
        public BLL_khachhang(GUI.frm_hoadon f)
        {
            frm_hoadon = f;
        }
        public void luukh()
        {
            int ketqua = dal_khachhang.ThemKH(frm_khachhang.txt_makh.Text, frm_khachhang.txt_tenkh.Text, frm_khachhang.cb_gioitinh.SelectedValue.ToString(), frm_khachhang.txt_diachi.Text, frm_khachhang.txt_sdt.Text, frm_khachhang.txt_email.Text);
            if (ketqua >= 1) MessageBox.Show("Thêm thành công");
            else MessageBox.Show("Thêm thất bai");

        }
        public void suakh()
        {
            int ketqua = dal_khachhang.suakh(frm_khachhang.txt_makh.Text, frm_khachhang.txt_tenkh.Text, frm_khachhang.cb_gioitinh.SelectedValue.ToString(), frm_khachhang.txt_diachi.Text, frm_khachhang.txt_sdt.Text, frm_khachhang.txt_email.Text);
            if (ketqua >= 1) MessageBox.Show("Sửa thành công");
            else MessageBox.Show("Sửa thất bai");
        }
        public void xoakh()
        {
            int ketqua = dal_khachhang.xoakh(frm_khachhang.txt_makh.Text);
            if (ketqua >= 1) MessageBox.Show("Xóa thành công");
            else MessageBox.Show("Xóa thất bai");
        }
        public void loadkh()
        {
            frm_khachhang.DTV_khachhang.DataSource = dal_khachhang.loadkh();
        }
        public void LayDSKH()
        {
            frm_hoadon.cb_mkh.DataSource = dal_khachhang.loadkh();
            frm_hoadon.cb_mkh.DisplayMember = "TenKH";
            frm_hoadon.cb_mkh.ValueMember = "MaKH";
        }

        public void LayDSGT()
        {
            List<string> list = new List<string>();
            list.Add("Nam");
            list.Add("Nữ");
            list.Add("Khác");

            frm_khachhang.cb_gioitinh.DataSource = list;
        }
    }
}
