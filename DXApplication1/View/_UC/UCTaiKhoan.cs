using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DXApplication1.DAL;
using DXApplication1.Controller;
using Model;
using DXApplication1.View._Form;

namespace DXApplication1.View._UC
{
    public partial class UCTaiKhoan : DevExpress.XtraEditors.XtraUserControl
    {
        public UCTaiKhoan()
        {
            InitializeComponent();
        }

        private void nHANVIENBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
           

        }
        public void loadUC()
        {
            txtTenDangNhap.Text = Singleton.getInstance().taiKhoan.TenDangNhap;
            ChucVuController cvc = new ChucVuController();
            DataTable dt=cvc.getDataById(Singleton.getInstance().taiKhoan.MaCV.ToString(),0);
            txtChucVu.Text = dt.Rows[0][1].ToString();

            NhanVienController nvc = new NhanVienController();
            DataTable dtNV = nvc.getDataById(Singleton.getInstance().taiKhoan.TenDangNhap,6);
            NHANVIEN nv = new NHANVIEN();
            nv.MaNV = dtNV.Rows[0][0].ToString();
            nv.TenNV = dtNV.Rows[0][1].ToString();
            nv.GioiTinh = dtNV.Rows[0][2].ToString();
            nv.NgaySinh = dtNV.Rows[0][3].ToString();
            nv.DiaChi = dtNV.Rows[0][4].ToString();
            nv.Luong = dtNV.Rows[0][5].ToString();
            nv.TenDangNhap = dtNV.Rows[0][6].ToString();


            txtTenNV.Text = nv.TenNV;
            txtDiaChi.Text = nv.DiaChi;
            spinLuong.Text = nv.Luong;
            dateNgaySinh.Text = nv.NgaySinh.ToString();
            if (nv.GioiTinh.ToUpper() == "NAM")
            {
                rdoNam.Checked = true;
                rdoNu.Checked = false;
            }
            else
            {
                rdoNam.Checked = false;
                rdoNu.Checked = true;
            } 
        }
        private void UCTaiKhoan_Load(object sender, EventArgs e)
        {
            loadUC();
        }

        private void btnDoiMK_Click(object sender, EventArgs e)
        {
            frmDoiMK frmdmk = new frmDoiMK();
            frmdmk.ShowDialog();
            loadUC();
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            frmDangKyTK frmdk = new frmDangKyTK();
            frmdk.ShowDialog();
        }
    }
}
