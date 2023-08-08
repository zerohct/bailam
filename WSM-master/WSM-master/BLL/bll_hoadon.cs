using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DOAN_QLBH.BLL
{
    class bll_hoadon
    {
        DAL.DAL_hoadon dal_hoadon = new DAL.DAL_hoadon();
        GUI.frm_hoadon frm_hoadon;
        DAL.DAL_hanghoa dal_hh = new DAL.DAL_hanghoa();
        GUI.frm_hanghoa frm_hh;
        public bll_hoadon(GUI.frm_hoadon f)
        {
            frm_hoadon = f;
        }
        public void themhd()
        {
            int ketqua = dal_hoadon.ThemHD(frm_hoadon.txt_mahd.Text, frm_hoadon.cb_mnv.SelectedValue.ToString(), frm_hoadon.dt_ngayban.Value, frm_hoadon.cb_mkh.SelectedValue.ToString(), frm_hoadon.cb_mahang.SelectedValue.ToString(), frm_hoadon.txtSoLuong.Text, frm_hoadon.txt_giaban.Text, frm_hoadon.txt_thanhtien.Text);
            if (ketqua >= 1) MessageBox.Show("Thêm thành công");
            else MessageBox.Show("Thêm thất bai");

        }
        public void suahd()
        {
            int ketqua = dal_hoadon.SuaHD(frm_hoadon.txt_mahd.Text, frm_hoadon.cb_mnv.SelectedValue.ToString(), frm_hoadon.dt_ngayban.Value, frm_hoadon.cb_mkh.SelectedValue.ToString(), frm_hoadon.cb_mahang.SelectedValue.ToString(), frm_hoadon.txtSoLuong.Text, frm_hoadon.txt_giaban.Text, frm_hoadon.txt_thanhtien.Text);
            if (ketqua >= 1) MessageBox.Show("Sửa thành công");
            else MessageBox.Show("Sửa thất bai");
        }
        public void xoahd()
        {
            int ketqua = dal_hoadon.XoaHD(frm_hoadon.txt_mahd.Text);
            if (ketqua >= 1) MessageBox.Show("Xóa thành công");
            else MessageBox.Show("Xóa thất bai");
        }
        public void loadhd()
        {
            frm_hoadon.DTV_hoadon.DataSource = dal_hoadon.LoadHD();
        }

        public void LayDSHH()
        {
            frm_hoadon.cb_mahang.DataSource = dal_hh.loadhh();
            frm_hoadon.cb_mahang.DisplayMember = "TenLK";
            frm_hoadon.cb_mahang.ValueMember = "MaLK";
        }


    }
}
