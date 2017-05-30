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
using System.Data.SqlClient;
using DXApplication1.Model;

namespace DXApplication1.View._UC
{
    public partial class UCNHACUNGCAPS : DevExpress.XtraEditors.XtraUserControl
    {
        NhaCungCapController nhcc = new NhaCungCapController();
        public UCNHACUNGCAPS()
        {
            InitializeComponent();
        }
        private int checkButton = 0;      
        public void loadData()
        {
            dgvnhacungcap.DataSource = nhcc.GetAllData();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            checkButton = 1;
            txtMaNCC.Enabled = true;
            txtTenNCC.Enabled = true;
            txtDiaChi.Enabled = true;
            txtSDT.Enabled = true;

            txtMaNCC.Text = "";
            txtTenNCC.Text = "";
            txtDiaChi.Text = "";
            txtSDT.Text = "";

            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnHuy.Enabled = true;
            btnLuu.Enabled = true;
        }

        private void dgvnhacungcap_Click_1(object sender, EventArgs e)
        {
            txtMaNCC.DataBindings.Clear();
            txtMaNCC.DataBindings.Add("text", dgvnhacungcap.DataSource, "MaNCC");
            txtTenNCC.DataBindings.Clear();
            txtTenNCC.DataBindings.Add("text", dgvnhacungcap.DataSource, "TenNCC");
            txtDiaChi.DataBindings.Clear();
            txtDiaChi.DataBindings.Add("text", dgvnhacungcap.DataSource, "DiaChi");
            txtSDT.DataBindings.Clear();
            txtSDT.DataBindings.Add("text", dgvnhacungcap.DataSource, "SDT");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            checkButton = 2;
            txtMaNCC.Enabled = true;
            txtTenNCC.Enabled = true;
            txtDiaChi.Enabled = true;
            txtSDT.Enabled = true;

            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnHuy.Enabled = true;
            btnLuu.Enabled = true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtMaNCC.Enabled = true;
            txtTenNCC.Enabled = true;
            txtDiaChi.Enabled = true;
            txtSDT.Enabled = true;

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
                NHACUNGCAP nv = new NHACUNGCAP();
                if (txtMaNCC.Text == "")
                {
                    MessageBox.Show("Nhập MaNCC để thêm mới HH");
                }
                else
                {
                    try
                    {
                        nv.MaNCC = txtMaNCC.Text.Trim();
                        nv.TenNCC = txtTenNCC.Text.Trim();
                        nv.DiaChi = txtDiaChi.Text.Trim();
                        nv.SDT = txtSDT.Text.Trim();
                        nhcc.Insert(nv);
                        MessageBox.Show("Thêm mới NCC thành công ");
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
                if (txtMaNCC.Text == "")
                {
                    MessageBox.Show("click chọn 1 Mã NCC để sửa!");
                }
                else
                {
                    try
                    {
                        NHACUNGCAP nv = new NHACUNGCAP();

                        nv.MaNCC = txtMaNCC.Text.Trim();
                        nv.TenNCC = txtTenNCC.Text.Trim();
                        nv.DiaChi = txtDiaChi.Text.Trim();
                        nv.SDT = txtSDT.Text.Trim();

                        nhcc.Update(nv);
                        MessageBox.Show("Sửa NCC thành công! ");
                        loadData();
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }

            }
            if (checkButton == 3)
            {

                if (txtMaNCC.Text == "")
                {
                    MessageBox.Show("click chọn 1 MNCC để xóa!");
                }
                else
                {
                    try
                    {

                        if (MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                        {
                            nhcc.Delete(txtMaNCC.Text);
                            MessageBox.Show("Xóa NCC thành công ");
                            loadData();
                        }

                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtMaNCC.Enabled = true;
            txtTenNCC.Enabled = true;
            txtDiaChi.Enabled = true;
            txtSDT.Enabled = true;

            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnHuy.Enabled = false;
            btnLuu.Enabled = false;
            checkButton = 0;
        }
    }
}
