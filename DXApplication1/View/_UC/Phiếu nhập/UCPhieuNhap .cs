﻿using System;
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
    public partial class UCPhieuNhap : DevExpress.XtraEditors.XtraUserControl
    {
        private int checkButton = 0;
        PhieuNhapController nvC = new PhieuNhapController();
        public UCPhieuNhap()
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
            txtMaPN.Text = grV.GetFocusedRowCellValue(MaPN).ToString();
            spinTongTien.Text = grV.GetFocusedRowCellValue(TongTien).ToString();
            cmbNhanVien.SelectedText = grV.GetFocusedRowCellValue(TenNV).ToString();
            dateNgayNhap.Text = grV.GetFocusedRowCellValue(NgayNhap).ToString();

        }

        private void grV_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            txtMaPN.Text = grV.GetFocusedRowCellValue(MaPN).ToString();
            spinTongTien.Text = grV.GetFocusedRowCellValue(TongTien).ToString();
            cmbNhanVien.SelectedText = grV.GetFocusedRowCellValue(TenNV).ToString();
            dateNgayNhap.Text = grV.GetFocusedRowCellValue(NgayNhap).ToString();

        }

        private void grV_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtMaPN.Text = grV.GetFocusedRowCellValue(MaPN).ToString();     
            spinTongTien.Text = grV.GetFocusedRowCellValue(TongTien).ToString();
            cmbNhanVien.Text = grV.GetFocusedRowCellValue(TenNV).ToString();
            dateNgayNhap.Text = grV.GetFocusedRowCellValue(NgayNhap).ToString();
            
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            checkButton = 1;
            txtMaPN.Enabled = true;
            txtMaPN.Text = "HDN";
            txtMaPN.Focus();
            spinTongTien.Enabled = false;
            cmbNhanVien.Enabled = true;
            dateNgayNhap.Enabled = true;
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
                PHIEUNHAP hh = new PHIEUNHAP();
                try
                {
                    hh.MaPN = txtMaPN.Text.Trim();
                    hh.NgayNhap = dateNgayNhap.Text;
                    hh.MaNV = cmbNhanVien.SelectedValue.ToString();
                    hh.TongTien = spinTongTien.Text.Trim();
                    nvC.ThemPN(hh);
                    loadData();
                    XtraMessageBox.Show("Thêm mới Phiếu nhập thành công!Thêm chi tiết cho phiếu nhập này!");

                    frmThemCTPN dsn = new frmThemCTPN();
                    dsn.layMaPN(hh.MaPN);
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
                if (txtMaPN.Text == "")
                {
                    MessageBox.Show("click chọn 1 Nhân viên để sửa!");
                }
                else
                {
                    PHIEUNHAP hh = new PHIEUNHAP();
                    try
                    {
                        hh.MaPN = txtMaPN.Text.Trim();
                        hh.NgayNhap = dateNgayNhap.Text;
                        hh.MaNV = cmbNhanVien.SelectedValue.ToString();
                        hh.TongTien = spinTongTien.Text.Trim();
                        nvC.SuaPN(hh);
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

                if (txtMaPN.Text == "")
                {
                    MessageBox.Show("click chọn 1 Nhân viên để xóa!");
                }
                else
                {
                    try
                    {
                       
                        if (MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                        {
                            nvC.XoaPN(txtMaPN.Text);
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
            txtMaPN.Enabled = false;
            spinTongTien.Enabled = false;
            cmbNhanVien.Enabled = false;
            dateNgayNhap.Enabled = false;

            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnHuy.Enabled = false;
            btnLuu.Enabled = false;
            checkButton = 0;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            txtMaPN.Enabled = false;
            spinTongTien.Enabled = false;
            cmbNhanVien.Enabled = true;
            dateNgayNhap.Enabled = true;

            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnHuy.Enabled = true;
            btnLuu.Enabled = true;
            checkButton = 2;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtMaPN.Enabled = false;
            spinTongTien.Enabled = false;
            cmbNhanVien.Enabled = false;
            dateNgayNhap.Enabled = false;

            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnHuy.Enabled = true;
            btnLuu.Enabled = true;
            checkButton = 3;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtMaPN.Enabled = false;
            spinTongTien.Enabled = false;
            cmbNhanVien.Enabled = false;
            dateNgayNhap.Enabled = false;

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
            if (txtMaPN.Text == "")
            {
                XtraMessageBox.Show("click chọn phiếu nhập trước khi xem chi tiết");
            }
            else
            {
                frmCTPN frm = new frmCTPN();
                PHIEUNHAP pn = new PHIEUNHAP();
                pn.MaPN = txtMaPN.Text.Trim();
                pn.NgayNhap = dateNgayNhap.Text.Trim();
                pn.MaNV = cmbNhanVien.SelectedValue.ToString().Trim();
                string tenNV = cmbNhanVien.Text.ToString();
                pn.TongTien = spinTongTien.Text.Trim();
                frm.loadData(pn, tenNV);
                frm.ShowDialog();
                loadData();
            }
        }
    }
}
