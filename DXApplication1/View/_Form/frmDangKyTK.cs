using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DXApplication1.Controller;
using Model;
using System.Data.SqlClient;

namespace DXApplication1.View._Form
{
    public partial class frmDangKyTK : DevExpress.XtraEditors.XtraForm
    {
        public frmDangKyTK()
        {
            InitializeComponent();
        }

       

        private void frmDangKyTK_Load(object sender, EventArgs e)
        {
            txtMKCu.Properties.PasswordChar = '*';
            txtMKMoi.Properties.PasswordChar = '*';
            ChucVuController cvC = new ChucVuController();
            cmbQuyen.DataSource = cvC.GetAllData();
            cmbQuyen.DisplayMember = "TenCV";
            cmbQuyen.ValueMember = "MaCV";

            NhanVienController nvC = new NhanVienController();
            cmbNhanVien.DataSource = nvC.GetAllData();
            cmbNhanVien.DisplayMember = "TenNV";
            cmbNhanVien.ValueMember = "MaNV";
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            TaiKhoanCotroller tk_c = new TaiKhoanCotroller();
            if (tk_c.getDataById(txtTenDN.Text, 0).Rows.Count > 0)
            {
                lblMSG.Text = "Tên đăng nhập này đã tồn tại";
            }
            else if (txtTenDN.Text.Contains(" ") || txtTenDN.Text == "")
            {
                lblMSG.Text = "Tên đăng nhập không hợp lệ";
            }


            else if (txtMKCu.Text.Contains(" ") || txtMKCu.Text == "") 
            {
                lblMSG.Text = "Mật khẩu không hợp lệ";
                txtMKCu.Focus();
            }
            else if (txtMKMoi.Text.Contains(" ") ||txtMKMoi.Text=="") 
            {
                lblMSG.Text = "Mật khẩu nhập lại không đúng";
                txtMKMoi.Focus();
            }
            else
            {
                try
                {
                    TAIKHOAN tk = new TAIKHOAN();
                    tk.TenDangNhap = txtTenDN.Text;
                    tk.MatKhau = txtMKCu.Text;
                    tk.MaCV = int.Parse(cmbQuyen.SelectedValue.ToString().Trim());
                    TaiKhoanCotroller tkc = new TaiKhoanCotroller();
                    tkc.Insert(tk);
                    NhanVienController nvC = new NhanVienController();
                    nvC.updateTenDangNhap(cmbNhanVien.SelectedValue.ToString().Trim(), tk.TenDangNhap);
                    XtraMessageBox.Show("Đăng ký thành công");
                }
                catch(SqlException ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                this.Close();
            }
           
        }
    }
}