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
using DXApplication1.Model;
using System.Data.SqlClient;

namespace DXApplication1.View._UC
{
    public partial class UCNhomHang : DevExpress.XtraEditors.XtraUserControl
    {
        private int checkButton = 0;
        NhomHangController nhc = new NhomHangController();
        public UCNhomHang()
        {
            InitializeComponent();
        }
        public void loadData()
        {
            dgvNhomHang.DataSource = nhc.GetAllData();
        }
        private void TabNVnhomhang_Click(object sender, EventArgs e)
        {

        }

        private void dgvNhomHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void loadUC()
        {
            cmbMaKho.DataSource = new KhoController().GetAllData();
            cmbMaKho.DisplayMember = "MaKho";
            cmbMaKho.ValueMember = "TenKho";
        }
        private void dgvNhomHang_Click(object sender, EventArgs e)
        {
            txtMaNH.DataBindings.Clear();
            txtMaNH.DataBindings.Add("text", dgvNhomHang.DataSource, "MaNhom");
            txtTenNH.DataBindings.Clear();
            txtTenNH.DataBindings.Add("text", dgvNhomHang.DataSource, "TenNhom");
            cmbMaKho.DataBindings.Clear();
            cmbMaKho.DataBindings.Add("text", dgvNhomHang.DataSource, "MaKho");          
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            checkButton = 1;
            txtMaNH.Enabled = true;
            txtTenNH.Enabled = true;
            cmbMaKho.Enabled = true;
            txtMaNH.Text = "";
            txtTenNH.Text = "";
            cmbMaKho.Text = "";

            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnHuy.Enabled = true;
            btnLuu.Enabled = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            txtMaNH.Enabled = true;
            txtTenNH.Enabled = true;
            cmbMaKho.Enabled = true;

            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnHuy.Enabled = true;
            btnLuu.Enabled = true;
            checkButton = 2;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtMaNH.Enabled = true;
            txtTenNH.Enabled = true;
            cmbMaKho.Enabled = true;

            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnHuy.Enabled = true;
            btnLuu.Enabled = true;
            checkButton = 3;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (checkButton == 1)
            {
                NHOMHANG nv = new NHOMHANG();
                if (txtMaNH.Text == "")
                {
                    MessageBox.Show("Nhập MaHH để thêm mới HH");
                }
                else
                {
                    try
                    {
                        nv.MaNhom = txtMaNH.Text.Trim();
                        nv.TenNhom = txtTenNH.Text.Trim();
                        nv.MaKho = cmbMaKho.Text.Trim();
                        nhc.Insert(nv);
                        MessageBox.Show("Thêm mới nhóm hàng thành công ");
                        loadData();

                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
            }
            else if (checkButton == 2)
            {
                if (txtMaNH.Text == "")
                {
                    MessageBox.Show("click chọn 1 Mã HH để sửa!");
                }
                else
                {
                    try
                    {
                        NHOMHANG nv = new NHOMHANG();

                        nv.MaNhom = txtMaNH.Text.Trim();
                        nv.TenNhom = txtTenNH.Text.Trim();
                        nv.MaKho = cmbMaKho.Text.Trim();

                        nhc.Update(nv);
                        MessageBox.Show("Sửa HH thành công! ");
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

                if (txtMaNH.Text == "")
                {
                    MessageBox.Show("click chọn 1 MHH để xóa!");
                }
                else
                {
                    try
                    {

                        if (MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                        {
                            nhc.Delete(txtMaNH.Text);
                            MessageBox.Show("Xóa MHH thành công ");
                            loadData();
                        }

                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }

            }
            txtMaNH.Enabled = false;
            txtTenNH.Enabled = false;
            cmbMaKho.Enabled = false;

            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnHuy.Enabled = false;
            btnLuu.Enabled = false;
            checkButton = 0;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtMaNH.Enabled = true;
            txtTenNH.Enabled = true;
            cmbMaKho.Enabled = true;

            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnHuy.Enabled = false;
            btnLuu.Enabled = false;
            checkButton = 0;
        }

        private void UCNhomHang_Load(object sender, EventArgs e)
        {
            loadUC();
        }
    }
}
