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
    public partial class frmThemCTHDB : DevExpress.XtraEditors.XtraForm
    {
        public frmThemCTHDB()
        {
            InitializeComponent();

        }
        HangHoaController hhC = new HangHoaController();
        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                CHITIETHOADONBAN ct = new CHITIETHOADONBAN();
                ct.MaHDB = lblMaHDB.Text.Trim();
                ct.MaHH = cmbHangHoa.SelectedValue.ToString().Trim();
                ct.DonGia = txtDonGia.Text;
                ct.SoLuong = int.Parse(txtSoLuong.Text.Trim());
                ChiTietHoaDonBanController ct_b = new ChiTietHoaDonBanController();
                ct_b.Insert(ct);
                MessageBox.Show("Thêm thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void layMaHDB(string ma)
        {
            lblMaHDB.Text = ma;
        }
        private void frmThemCTPN_Load(object sender, EventArgs e)
        {
           
            cmbHangHoa.DataSource = hhC.GetAllData();
            cmbHangHoa.DisplayMember = "TenHH";
            cmbHangHoa.ValueMember = "MaHH";
        }

        private void cmbHangHoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (hhC.LayDonGiaBan(cmbHangHoa.SelectedValue.ToString().Trim()).Rows.Count > 0)
            {
                string dg = hhC.LayDonGiaBan(cmbHangHoa.SelectedValue.ToString().Trim()).Rows[0][0].ToString();
                txtDonGia.Text = dg.Trim();
            }
          
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}