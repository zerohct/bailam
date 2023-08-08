using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DOAN_QLBH.BLL
{
    class BLL_nhanvien
    {
        DAL.DAL_nhanvien dal_nhanvien = new DAL.DAL_nhanvien();
        GUI.frm_nhanvien frm_nhanvien;
        GUI.frm_hoadon frm_hoadon;
        public BLL_nhanvien(GUI.frm_nhanvien f)
        {
            frm_nhanvien = f;
        }
        public BLL_nhanvien(GUI.frm_hoadon f)
        {
            frm_hoadon = f;
        }

        public void luunv()
        {
            int ketqua = dal_nhanvien.ThemNV(frm_nhanvien.txt_mnv.Text, frm_nhanvien.txt_tennv.Text, frm_nhanvien.cb_gioitinh.SelectedValue.ToString(), frm_nhanvien.dt_namsinh.Value, frm_nhanvien.txt_diachi.Text, frm_nhanvien.txt_sdt.Text, frm_nhanvien.txt_email.Text, frm_nhanvien.cb_chucvu.SelectedValue.ToString());
            if (ketqua >= 1) MessageBox.Show("Thêm thành công");
            else MessageBox.Show("Thêm thất bai");

        }
        public void suanv()
        {
            int ketqua = dal_nhanvien.suanv(frm_nhanvien.txt_mnv.Text, frm_nhanvien.txt_tennv.Text, frm_nhanvien.cb_gioitinh.SelectedValue.ToString(), frm_nhanvien.dt_namsinh.Value, frm_nhanvien.txt_diachi.Text, frm_nhanvien.txt_sdt.Text, frm_nhanvien.txt_email.Text, frm_nhanvien.cb_chucvu.SelectedValue.ToString());
            if (ketqua >= 1) MessageBox.Show("Sửa thành công");
            else MessageBox.Show("Sửa thất bai");
        }
        public void xoanv()
        {
            int ketqua = dal_nhanvien.xoanv(frm_nhanvien.txt_mnv.Text);
            if (ketqua >= 1) MessageBox.Show("Xóa thành công");
            else MessageBox.Show("Xóa thất bai");
        }
        public void loadnv()
        {
            frm_nhanvien.DTV_nhanvien.DataSource = dal_nhanvien.loadnv();
        }
        public void LayDSNV()
        {
            frm_hoadon.cb_mnv.DataSource = dal_nhanvien.loadnv();
            frm_hoadon.cb_mnv.DisplayMember = "TenNV";
            frm_hoadon.cb_mnv.ValueMember = "MaNV";
        }
        public void LayDSCV()
        {
            List<string> list = new List<string>();
            list.Add("Quản trị viên");
            list.Add("Tiếp tân");
            list.Add("Thu ngân");
            list.Add("Kiểm kho");
            list.Add("Kế toán");

            frm_nhanvien.cb_chucvu.DataSource = list;
        }

        public void LayDSGT()
        {
            List<string> list = new List<string>();
            list.Add("Nam");
            list.Add("Nữ");
            list.Add("Khác");

            frm_nhanvien.cb_gioitinh.DataSource = list;
        }
    }
}

