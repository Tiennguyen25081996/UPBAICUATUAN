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

namespace DXApplication1.View._UC
{
    public partial class UC_HDB : DevExpress.XtraEditors.XtraUserControl
    {
        private int checkButton = 0;
        HoaDonBanController nvC = new HoaDonBanController();
        public UC_HDB()
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
            txtMaHDB.Text = grV.GetFocusedRowCellValue(MaHDB).ToString();
            spinTongTien.Text = grV.GetFocusedRowCellValue(TongTien).ToString();
            cmbNhanVien.SelectedText = grV.GetFocusedRowCellValue(TenNV).ToString();
            dateNgayBan.Text = grV.GetFocusedRowCellValue(NgayBan).ToString();

        }

        private void grV_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            txtMaHDB.Text = grV.GetFocusedRowCellValue(MaHDB).ToString();
            spinTongTien.Text = grV.GetFocusedRowCellValue(TongTien).ToString();
            cmbNhanVien.SelectedText = grV.GetFocusedRowCellValue(TenNV).ToString();
            dateNgayBan.Text = grV.GetFocusedRowCellValue(NgayBan).ToString();

        }

        private void grV_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtMaHDB.Text = grV.GetFocusedRowCellValue(MaHDB).ToString();     
            spinTongTien.Text = grV.GetFocusedRowCellValue(TongTien).ToString();
            cmbNhanVien.Text = grV.GetFocusedRowCellValue(TenNV).ToString();
            dateNgayBan.Text = grV.GetFocusedRowCellValue(NgayBan).ToString();
            
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtMaHDB.Text = "HDB" + (int.Parse(grV.GetDataRow(grV.RowCount -1)["MaHDB"].ToString().Trim().Split('B')[1]) + 1).ToString().Trim();
            checkButton = 1;
            txtMaHDB.Enabled = false;
            
            txtMaHDB.Focus();
            spinTongTien.Enabled = false;
            cmbNhanVien.Enabled = true;
            dateNgayBan.Enabled = true;
            spinTongTien.Text = "0";



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
                HOADONBAN hh = new HOADONBAN();
                try
                {
                    hh.MaHDB = txtMaHDB.Text.Trim();
                    hh.NgayBan = dateNgayBan.Text;
                    hh.MaNV = cmbNhanVien.SelectedValue.ToString();
                    hh.TongTien = spinTongTien.Text.Trim();
                    nvC.ThemHDB(hh);
                    loadData();
                    XtraMessageBox.Show("Thêm mới Phiếu nhập thành công!Thêm chi tiết cho phiếu nhập này!");

                    frmThemCTHDB dsn = new frmThemCTHDB();
                    dsn.layMaHDB(hh.MaHDB);
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
                if (txtMaHDB.Text == "")
                {
                    MessageBox.Show("click chọn 1 Nhân viên để sửa!");
                }
                else
                {
                    HOADONBAN hh = new HOADONBAN();
                    try
                    {
                        hh.MaHDB = txtMaHDB.Text.Trim();
                        hh.NgayBan = dateNgayBan.Text;
                        hh.MaNV = cmbNhanVien.SelectedValue.ToString();
                        hh.TongTien = spinTongTien.Text.Trim();
                        nvC.SuaHDB(hh);
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

                if (txtMaHDB.Text == "")
                {
                    MessageBox.Show("click chọn 1 Nhân viên để xóa!");
                }
                else
                {
                    try
                    {
                       
                        if (MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                        {
                            nvC.XoaHDB(txtMaHDB.Text);
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
            txtMaHDB.Enabled = false;
            spinTongTien.Enabled = false;
            cmbNhanVien.Enabled = false;
            dateNgayBan.Enabled = false;

            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnHuy.Enabled = false;
            btnLuu.Enabled = false;
            checkButton = 0;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            txtMaHDB.Enabled = false;
            spinTongTien.Enabled = false;
            cmbNhanVien.Enabled = true;
            dateNgayBan.Enabled = true;

            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnHuy.Enabled = true;
            btnLuu.Enabled = true;
            checkButton = 2;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtMaHDB.Enabled = false;
            spinTongTien.Enabled = false;
            cmbNhanVien.Enabled = false;
            dateNgayBan.Enabled = false;

            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnHuy.Enabled = true;
            btnLuu.Enabled = true;
            checkButton = 3;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtMaHDB.Enabled = false;
            spinTongTien.Enabled = false;
            cmbNhanVien.Enabled = false;
            dateNgayBan.Enabled = false;

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

        private void UC_HOADONBAN_Load(object sender, EventArgs e)
        {
            loadData();
            loadUC();
        }

        private void btnXemCT_Click(object sender, EventArgs e)
        {
            if (txtMaHDB.Text == "")
            {
                XtraMessageBox.Show("click chọn phiếu nhập trước khi xem chi tiết");
            }
            else
            {
                frmCTHDB frm = new frmCTHDB();
                HOADONBAN HDB = new HOADONBAN();
                HDB.MaHDB = txtMaHDB.Text.Trim();
                HDB.NgayBan = dateNgayBan.Text.Trim();
                HDB.MaNV = cmbNhanVien.SelectedValue.ToString().Trim();
                string tenNV = cmbNhanVien.Text.ToString();
                HDB.TongTien = spinTongTien.Text.Trim();
                frm.loadData(HDB, tenNV);
                frm.ShowDialog();
                loadData();
            }
        }
    }
}
