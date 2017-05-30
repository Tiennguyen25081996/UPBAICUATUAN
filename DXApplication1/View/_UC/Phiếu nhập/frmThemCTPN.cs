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
using Model;
using DXApplication1.Controller;

namespace DXApplication1.View._UC.Phiếu_nhập
{
    public partial class frmThemCTPN : DevExpress.XtraEditors.XtraForm
    {
        public frmThemCTPN()
        {
            InitializeComponent();

        }
        HangHoaController hhC = new HangHoaController();
        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                CHITIETPHIEUNHAP ct = new CHITIETPHIEUNHAP();
                ct.MaPN = lblMaPN.Text.Trim();
                ct.MaHH = cmbHangHoa.SelectedValue.ToString().Trim();
                ct.DonGia = txtDonGia.Text;
                ct.SoLuong = int.Parse(txtSoLuong.Text.Trim());
                ChiTietPhieuNhapController ct_b = new ChiTietPhieuNhapController();
                ct_b.Insert(ct);
                MessageBox.Show("Thêm thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void layMaPN(string ma)
        {
            lblMaPN.Text = ma;
        }
        private void frmThemCTPN_Load(object sender, EventArgs e)
        {
           
            cmbHangHoa.DataSource = hhC.GetAllData();
            cmbHangHoa.DisplayMember = "TenHH";
            cmbHangHoa.ValueMember = "MaHH";
        }

        private void cmbHangHoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (hhC.LayDonGia(cmbHangHoa.SelectedValue.ToString().Trim()).Rows.Count > 0)
            {
                string dg = hhC.LayDonGia(cmbHangHoa.SelectedValue.ToString().Trim()).Rows[0][0].ToString();
                txtDonGia.Text = dg.Trim();
            }
          
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}