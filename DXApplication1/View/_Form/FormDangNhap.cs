using DXApplication1.Controller;
using DXApplication1.DAL;
using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DXApplication1.View._Form
{
    
    public partial class FormDangNhap : Form
    {
        TaiKhoanCotroller tk_b = new TaiKhoanCotroller();
        TAIKHOAN tk=new TAIKHOAN();
        public string name { get; set; }
        public FormDangNhap()
        {
            InitializeComponent();
            lblQLSV.BackColor = Color.Transparent;
            lblTenTruyCap.BackColor = Color.Transparent;
            lblMatKhau.BackColor = Color.Transparent;
           
            Name = "";


        }
        public TAIKHOAN LayTTDN()
        {
            //TaiKhoanModel tk = new TaiKhoanModel();
            //tk.Name = txtTenTruyCap.Text;
            //tk.Pass = txtMatKhau.Text;
            //string[] lst = tk_b.LayDSTK(tk);
            //tk.HoTen = lst[2];
            //tk.Email = lst[5];
            //tk.DiaChi = lst[3];
            //try { tk.NgaySinh = Convert.ToDateTime(lst[4]); }
            //catch { tk.NgaySinh = Convert.ToDateTime("1996/2/2"); }
            //tk.SDT = lst[6];

            return tk;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (txtTenTruyCap.Text.Length == 0 && txtMatKhau.Text.Length == 0)
            {
                timer1.Enabled = false;
                MessageBox.Show("nhập nhanh!");
            }

        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
           
           Singleton.getInstance().taiKhoan= new TAIKHOAN();


            Singleton.getInstance().taiKhoan.TenDangNhap = txtTenTruyCap.Text;
            Singleton.getInstance().taiKhoan.MatKhau = txtMatKhau.Text;
           


            dt = tk_b.LayTK(Singleton.getInstance().taiKhoan);
            //lấy dữ liệu bảng NhanVien


            if (dt.Rows.Count <= 0)
            {
                MessageBox.Show("Sai thông tin đăng nhập!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            }
            else
            {
                Singleton.getInstance().taiKhoan.MaCV = int.Parse(dt.Rows[0][2].ToString());
                name = txtTenTruyCap.Text;
                this.Hide();

            }

        }

        private void txtMatKhau_TextChanged(object sender, EventArgs e)
        {
            if (txtMatKhau.Text.Length < 6)
            {
                erp1.SetError(txtMatKhau, "Mật khẩu ít nhất 6 ký tự");
            }
            else erp1.Dispose();
        }

        private void FormDangNhap_Load(object sender, EventArgs e)
        {

        }

        private void FormDangNhap_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void FormDangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
