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
using DXApplication1.DAL;

namespace DXApplication1.View._Form
{
    public partial class frmDoiMK : DevExpress.XtraEditors.XtraForm
    {
        public frmDoiMK()
        {
            InitializeComponent();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            TaiKhoanCotroller tk_c = new TaiKhoanCotroller();
            DataTable dt = tk_c.getDataById(txtTenDN.Text, 0);
            if(dt.Rows.Count <= 0)
            {
                lblMsg.Text = "Sai tên đăng nhập ";
            }
            else if (dt.Rows[0][0].ToString() != Singleton.getInstance().taiKhoan.TenDangNhap)
            {
                lblMsg.Text = "Sai tên đăng nhập ";
            }
            else if (txtTenDN.Text.Contains(" ")||txtTenDN.Text=="")
            {
                lblMsg.Text = "Tên đăng nhập không hợp lệ";
            }
            else if (txtMKCu.Text != Singleton.getInstance().taiKhoan.MatKhau)
            {
                lblMsg.Text = "Mật khẩu cũ không chính xác";
            }
            else if (txtMkMoi.Text.Contains(" ") || txtMkMoi.Text == "")
            {
                lblMsg.Text = "Mật khẩu mới không hợp lệ";
            }
            else
            {
                lblMsg.Text = "";
                Singleton.getInstance().taiKhoan.TenDangNhap = txtTenDN.Text.Trim();
                Singleton.getInstance().taiKhoan.MatKhau = txtMkMoi.Text.Trim();
                tk_c.Update(Singleton.getInstance().taiKhoan);
                XtraMessageBox.Show("Sửa thành công");
                this.Close();
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmDoiMK_Load(object sender, EventArgs e)
        {
            txtMKCu.Properties.PasswordChar = '*';
            txtMkMoi.Properties.PasswordChar = '*';
        }
    }
}