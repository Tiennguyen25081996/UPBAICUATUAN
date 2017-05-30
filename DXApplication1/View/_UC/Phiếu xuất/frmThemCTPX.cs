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
using DXApplication1.Model;

namespace DXApplication1.View._UC.Phiếu_nhập
{
    public partial class frmThemCTPX : DevExpress.XtraEditors.XtraForm
    {
        public frmThemCTPX()
        {
            InitializeComponent();

        }
        HangHoaController hhC = new HangHoaController();
        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                CHITIETPHIEUXUAT ct = new CHITIETPHIEUXUAT();
                ct.MaPX = lblMaPX.Text.Trim();
                ct.MaHH = cmbHangHoa.SelectedValue.ToString().Trim();           
                ct.SoLuong = int.Parse(txtSoLuong.Text.Trim());
                ChiTietPhieuXuatController ct_b = new ChiTietPhieuXuatController();
                ct_b.Insert(ct);
                MessageBox.Show("Thêm thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void layMaPX(string ma)
        {
            lblMaPX.Text = ma;
        }
        private void frmThemCTPN_Load(object sender, EventArgs e)
        {
           
            cmbHangHoa.DataSource = hhC.GetAllData();
            cmbHangHoa.DisplayMember = "TenHH";
            cmbHangHoa.ValueMember = "MaHH";
        }

        private void cmbHangHoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            
          
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}