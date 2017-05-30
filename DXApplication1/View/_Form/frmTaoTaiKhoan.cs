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
using DXApplication1.Model;
using Model;

namespace DXApplication1.View._Form
{
    public partial class frmTaoTaiKhoan : DevExpress.XtraEditors.XtraForm
    {
        public frmTaoTaiKhoan()
        {
            InitializeComponent();
        }

        private void frmTaoTaiKhoan_Load(object sender, EventArgs e)
        {
            
            ChucVuController cvC = new ChucVuController();
            cmbQuyen.DataSource = cvC.GetAllData();
            cmbQuyen.DisplayMember = "TenCV";
            cmbQuyen.ValueMember = "MaCV";
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            TAIKHOAN tk = new TAIKHOAN();
            tk.TenDangNhap = txtTenDN.Text;
            tk.MatKhau = txtMK.Text;
            tk.MaCV = int.Parse(cmbQuyen.SelectedValue.ToString().Trim());
            TaiKhoanCotroller tkc = new TaiKhoanCotroller();
            tkc.Insert(tk);
            this.Close();
        }
        public string getTenDangNhap()
        {         
            return txtTenDN.Text;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}