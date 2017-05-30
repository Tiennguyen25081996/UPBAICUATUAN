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
using DXApplication1.Controller;
using Model;
using DXApplication1.View._Form;
using System.Data.SqlClient;

namespace DXApplication1.View._UC
{
    public partial class UC_NguoiDung : DevExpress.XtraEditors.XtraUserControl
    {
        private int checkButton = 0;
        NhanVienController nvC = new NhanVienController();
        public UC_NguoiDung()
        {
            InitializeComponent();
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void tabNhanVien_Click(object sender, EventArgs e)
        {

        }
        public void loadData()
        {
            
            grC.DataSource = nvC.GetAllData();
            

        }

        private void grC_Click(object sender, EventArgs e)
        {
            txtMaNV.Text = grV.GetFocusedRowCellValue(MaNV).ToString();
            txtTenNV.Text = grV.GetFocusedRowCellValue(TenNV).ToString();
            spinLuong.Text = grV.GetFocusedRowCellValue(Luong).ToString();
            txtDiaChi.Text = grV.GetFocusedRowCellValue(DiaChi).ToString();
            dateNgaySinh.Text = grV.GetFocusedRowCellValue(NgaySinh).ToString();
            if (grV.GetFocusedRowCellValue(GioiTinh).ToString().ToUpper() == "NAM")
                rdoNam.Checked = true;
            else rdoNu.Checked = true;
        }

        private void nHANVIENBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
           

        }

        private void grV_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            
        }

        private void grV_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
           
        }

        private void grC_MouseClick(object sender, MouseEventArgs e)
        {
          
        }

        private void grV_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            txtMaNV.Text = grV.GetFocusedRowCellValue(MaNV).ToString();
            txtTenNV.Text = grV.GetFocusedRowCellValue(TenNV).ToString();
            spinLuong.Text = grV.GetFocusedRowCellValue(Luong).ToString();
            txtDiaChi.Text = grV.GetFocusedRowCellValue(DiaChi).ToString();
            dateNgaySinh.Text = grV.GetFocusedRowCellValue(NgaySinh).ToString();
            if (grV.GetFocusedRowCellValue(GioiTinh).ToString().ToUpper() == "NAM")
                rdoNam.Checked = true;
            else rdoNu.Checked = true;
        }

        private void grV_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtMaNV.Text = grV.GetFocusedRowCellValue(MaNV).ToString();
            txtTenNV.Text = grV.GetFocusedRowCellValue(TenNV).ToString();
            spinLuong.Text = grV.GetFocusedRowCellValue(Luong).ToString();
            txtDiaChi.Text = grV.GetFocusedRowCellValue(DiaChi).ToString();
            dateNgaySinh.Text = grV.GetFocusedRowCellValue(NgaySinh).ToString();
            if (grV.GetFocusedRowCellValue(GioiTinh).ToString().ToUpper() == "NAM")
                rdoNam.Checked = true;
            else rdoNu.Checked = true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            checkButton = 1;
            txtMaNV.Enabled = true;
            txtTenNV.Enabled = true;
            txtLuong.Enabled = true;
            txtDiaChi.Enabled = true;
            dateNgaySinh.Enabled = true;
            rdoNam.Enabled = true;
            rdoNu.Enabled = true;

            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnHuy.Enabled = true;
            btnLuu.Enabled = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (checkButton == 1)
            {
                NHANVIEN nv = new NHANVIEN();
                bool ThanhCong = false;

                if (XtraMessageBox.Show("bạn có muốn tạo 1 tài khoản đăng nhập cho nhân viên này?", "question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    frmTaoTaiKhoan frmTaoTK = new frmTaoTaiKhoan();
                    frmTaoTK.ShowDialog();
                    nv.TenDangNhap = frmTaoTK.getTenDangNhap();
                }
                else nv.TenDangNhap = null;
                if (txtMaNV.Text == "")
                {
                    MessageBox.Show("Nhập MaNV để thêm mới nv");
                }
                else
                {
                    try
                    {
                        string gt;
                        if (rdoNam.Checked == true) gt = "NAM";
                        else gt = "NỮ";

                        nv.MaNV = txtMaNV.Text.Trim();
                        nv.TenNV = txtTenNV.Text;
                        nv.NgaySinh = dateNgaySinh.Text.Trim();
                        nv.DiaChi = txtDiaChi.Text;
                        nv.GioiTinh = gt;
                        nv.Luong = spinLuong.Text.Trim();
                        nvC.Insert(nv);
                        MessageBox.Show("Thêm mới nhân viên thành công ");
                        ThanhCong = true;
                        loadData();

                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
                if(ThanhCong==false)
                {
                    TaiKhoanCotroller tkC = new TaiKhoanCotroller();
                    tkC.Delete(nv.TenDangNhap);
                }
            }
            else if (checkButton == 2)
            {
                if (txtMaNV.Text == "")
                {
                    MessageBox.Show("click chọn 1 Nhân viên để sửa!");
                }
                else
                {
                    try
                    {
                        NHANVIEN nv = new NHANVIEN();

                        nv.MaNV = txtMaNV.Text.Trim();
                        nv.TenNV = txtTenNV.Text;
                        nv.GioiTinh = rdoNam.Checked == true ? "NAM" : "NỮ";
                        nv.DiaChi = txtDiaChi.Text;
                        nv.NgaySinh = dateNgaySinh.Text.Trim();
                        nv.Luong = spinLuong.Text;
                        nv.TenDangNhap = "ádasdasd";
                     
                        nvC.Update(nv);
                        MessageBox.Show("Sửa nhân viên thành công! ");
                        loadData();
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }

            }
            else if (checkButton == 3)
            {

                if (txtMaNV.Text == "")
                {
                    MessageBox.Show("click chọn 1 Nhân viên để xóa!");
                }
                else
                {
                    try
                    {
                       
                        if (MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                        {
                            nvC.Delete(txtMaNV.Text);
                            MessageBox.Show("Xóa nhân viên thành công ");
                            loadData();
                        }

                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }

            }
            txtMaNV.Enabled = false;
            txtTenNV.Enabled = false;
            txtLuong.Enabled = false;
            txtDiaChi.Enabled = false;
            dateNgaySinh.Enabled = false;
            rdoNam.Enabled = false;
            rdoNu.Enabled = false;

            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnHuy.Enabled = false;
            btnLuu.Enabled = false;
            checkButton = 0;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            txtMaNV.Enabled = false;
            txtTenNV.Enabled = true;
            spinLuong.Enabled = true;
            txtDiaChi.Enabled = true;
            dateNgaySinh.Enabled = true;
            rdoNam.Enabled = true;
            rdoNu.Enabled = true;

            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnHuy.Enabled = true;
            btnLuu.Enabled = true;
            checkButton = 2;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtMaNV.Enabled = false;
            txtTenNV.Enabled = false;
            spinLuong.Enabled = false;
            txtDiaChi.Enabled = false;
            dateNgaySinh.Enabled = false;
            rdoNam.Enabled = false;
            rdoNu.Enabled = false;

            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnHuy.Enabled = true;
            btnLuu.Enabled = true;
            checkButton = 3;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtMaNV.Enabled = false;
            txtTenNV.Enabled = false;
            txtLuong.Enabled = false;
            txtDiaChi.Enabled = false;
            dateNgaySinh.Enabled = false;
            rdoNam.Enabled = false;
            rdoNu.Enabled = false;

            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnHuy.Enabled = false;
            btnLuu.Enabled = false;
            checkButton = 0;
        }
    }
}
