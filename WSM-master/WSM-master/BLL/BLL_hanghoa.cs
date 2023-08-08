using DOAN_QLBH.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DOAN_QLBH.BLL
{
    class BLL_hanghoa
    {
        DAL.DAL_hanghoa dAL_hh = new DAL.DAL_hanghoa();
        GUI.frm_hanghoa frm_hh;
        GUI.frm_hoadon frm_hoadon;
        GUI.frm_nhacungcap frm_ncc;
        public BLL_hanghoa(GUI.frm_hanghoa f)
        {
            frm_hh = f;
        }
        public BLL_hanghoa(GUI.frm_hoadon f)
        {
            frm_hoadon = f;
        }
        public BLL_hanghoa(GUI.frm_nhacungcap f)
        {
            frm_ncc = f;
        }
        public void themhh()
        {
            int ketqua = dAL_hh.themhang(frm_hh.txtMaLK.Text, frm_hh.txtTenLK.Text, frm_hh.txtThongSo.Text, frm_hh.txtGiaban.Text, frm_hh.txtGiaMua.Text, frm_hh.txtNgayNhap.Text, frm_hh.cb_llk.SelectedValue.ToString(), frm_hh.cb_mk.SelectedValue.ToString(), frm_hh.cb_ncc.SelectedValue.ToString());
            if (ketqua >= 1) MessageBox.Show("Thêm thành công");
            else MessageBox.Show("Thêm thất bại");

        }
        public void suahh()
        {
            int ketqua = dAL_hh.suahang(frm_hh.txtMaLK.Text, frm_hh.txtTenLK.Text, frm_hh.txtThongSo.Text, frm_hh.txtGiaban.Text, frm_hh.txtGiaMua.Text, frm_hh.txtNgayNhap.Text, frm_hh.cb_llk.SelectedValue.ToString(), frm_hh.cb_mk.SelectedValue.ToString(), frm_hh.cb_ncc.SelectedValue.ToString());
            if (ketqua >= 1) MessageBox.Show("Sửa thành công");
            else MessageBox.Show("Sửa thất bại");
        }
        public void xoahh()
        {
            int ketqua = dAL_hh.xoahang(frm_hh.txtMaLK.Text);
            if (ketqua >= 1) MessageBox.Show("Xóa thành công");
            else MessageBox.Show("Xóa thất bại");
        }
        public void loadhh()
        {
            frm_hh.DTV_hh.DataSource = dAL_hh.loadhh();
        }

        public void LayDSLLK()
        {
            frm_hh.cb_llk.DataSource = dAL_hh.loadllk();
            frm_hh.cb_llk.DisplayMember = "TenLoai";
            frm_hh.cb_llk.ValueMember = "MaLoai";
        }

        public void LayDSKho()
        {
            frm_hh.cb_mk.DataSource = dAL_hh.loadkho();
            frm_hh.cb_mk.DisplayMember = "MaKho";
            frm_hh.cb_mk.ValueMember = "MaKho";
        }
        //     public void LayDSHH()
        //     { 
        //             frm_hoadon.cb_mahang.DataSource = dAL_hh.loadhh();
        //             frm_hoadon.cb_mahang.DisplayMember = "MaLK";
        //            frm_hoadon.cb_mahang.ValueMember = "MaLK";
        //    }


    }
}

