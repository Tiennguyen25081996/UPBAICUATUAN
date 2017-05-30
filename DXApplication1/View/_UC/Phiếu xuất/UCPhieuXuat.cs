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
using DXApplication1.View._UC.Phiếu_nhập;
using DXApplication1.Model;

namespace DXApplication1.View._UC
{
    public partial class UCPhieuXuat : DevExpress.XtraEditors.XtraUserControl
    {
        private int checkButton = 0;
        PhieuXuatController nvC = new PhieuXuatController();
        public UCPhieuXuat()
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
           
        }

       

        private void grV_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            
        }

        private void grV_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
           
        }

        private void grC_MouseClick(object sender, MouseEventArgs e)
        {
            txtMaPX.Text = grV.GetFocusedRowCellValue(MaPX).ToString();
          
            cmbNhanVien.SelectedText = grV.GetFocusedRowCellValue(TenNV).ToString();
            dateNgayXuat.Text = grV.GetFocusedRowCellValue(NgayXuat).ToString();

        }

        private void grV_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            txtMaPX.Text = grV.GetFocusedRowCellValue(MaPX).ToString();
           
            cmbNhanVien.SelectedText = grV.GetFocusedRowCellValue(TenNV).ToString();
            dateNgayXuat.Text = grV.GetFocusedRowCellValue(NgayXuat).ToString();

        }

        private void grV_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtMaPX.Text = grV.GetFocusedRowCellValue(MaPX).ToString();     
           
            cmbNhanVien.Text = grV.GetFocusedRowCellValue(TenNV).ToString();
            dateNgayXuat.Text = grV.GetFocusedRowCellValue(NgayXuat).ToString();
            
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            checkButton = 1;
            txtMaPX.Enabled = true;
            txtMaPX.Text = "PX";
            txtMaPX.Focus();
          
            cmbNhanVien.Enabled = true;
            dateNgayXuat.Enabled = true;
           



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
                PHIEUXUAT hh = new PHIEUXUAT();
                try
                {
                    hh.MaPX = txtMaPX.Text.Trim();
                    hh.NgayXuat = dateNgayXuat.Text;
                    hh.MaNV = cmbNhanVien.SelectedValue.ToString();
                   
                    nvC.Insert(hh);
                    loadData();
                    XtraMessageBox.Show("Thêm mới Phiếu xuất thành công!Thêm chi tiết cho phiếu xuất này!");

                    frmThemCTPX dsn = new frmThemCTPX();
                    dsn.layMaPX(hh.MaPX);
                    dsn.ShowDialog();
                    loadData();
                }
                    catch (SqlException ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                
               
            }
            else if (checkButton == 2)
            {
                if (txtMaPX.Text == "")
                {
                    MessageBox.Show("click chọn 1 phiếu xuất để sửa!");
                }
                else
                {
                    PHIEUXUAT hh = new PHIEUXUAT();
                    try
                    {
                        hh.MaPX = txtMaPX.Text.Trim();
                        hh.NgayXuat = dateNgayXuat.Text;
                        hh.MaNV = cmbNhanVien.SelectedValue.ToString();
                     
                        nvC.Update(hh);
                        loadData();
                        XtraMessageBox.Show("Sửa Phiếu nhập thành công!");
                      
                       
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }

            }
            else if (checkButton == 3)
            {

                if (txtMaPX.Text == "")
                {
                    MessageBox.Show("click chọn 1 Nhân viên để xóa!");
                }
                else
                {
                    try
                    {
                       
                        if (MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                        {
                            nvC.Delete(txtMaPX.Text);
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
            txtMaPX.Enabled = false;
        
            cmbNhanVien.Enabled = false;
            dateNgayXuat.Enabled = false;

            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnHuy.Enabled = false;
            btnLuu.Enabled = false;
            checkButton = 0;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            txtMaPX.Enabled = false;
       
            cmbNhanVien.Enabled = true;
            dateNgayXuat.Enabled = true;

            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnHuy.Enabled = true;
            btnLuu.Enabled = true;
            checkButton = 2;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtMaPX.Enabled = false;
       
            cmbNhanVien.Enabled = false;
            dateNgayXuat.Enabled = false;

            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnHuy.Enabled = true;
            btnLuu.Enabled = true;
            checkButton = 3;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtMaPX.Enabled = false;
        
            cmbNhanVien.Enabled = false;
            dateNgayXuat.Enabled = false;

            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnHuy.Enabled = false;
            btnLuu.Enabled = false;
            checkButton = 0;
        }
        public void loadUC()
        {
            cmbNhanVien.DataSource = new NhanVienController().GetAllData();
            cmbNhanVien.DisplayMember = "TenNV";
            cmbNhanVien.ValueMember = "MaNV";
        }

        private void UC_PhieuNhap_Load(object sender, EventArgs e)
        {
            loadData();
            loadUC();
        }

        private void btnXemCT_Click(object sender, EventArgs e)
        {
            if (txtMaPX.Text == "")
            {
                XtraMessageBox.Show("click chọn phiếu nhập trước khi xem chi tiết");
            }
            else
            {
                frmCTPX frm = new frmCTPX();
                PHIEUXUAT pn = new PHIEUXUAT();
                pn.MaPX = txtMaPX.Text.Trim();
                pn.NgayXuat = dateNgayXuat.Text.Trim();
                pn.MaNV = cmbNhanVien.SelectedValue.ToString().Trim();
                string tenNV = cmbNhanVien.Text.ToString();
         
                frm.loadData(pn, tenNV);
                frm.ShowDialog();
                loadData();
            }
        }
    }
}
