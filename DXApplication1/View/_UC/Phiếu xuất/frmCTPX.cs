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
    public partial class frmCTPX : DevExpress.XtraEditors.XtraForm
    {
        public frmCTPX()
        {
            InitializeComponent();
        }
        private string mahh;
        ChiTietPhieuXuatController ctc = new ChiTietPhieuXuatController();
        public void loadData(PHIEUXUAT pn,string ten )
        {
            lblPX.Text = pn.MaPX;
            cmbNhanVien.Text = ten;
            dtpNgayXuat.Text = pn.NgayXuat;
           
            grC.DataSource = ctc.XemCTPX(pn.MaPX);
        }
        public void loadGR()
        {
           
            grC.DataSource = ctc.XemCTPX(lblPX.Text);
        }
      
        private void btnSua_Click(object sender, EventArgs e)

        {
            if (XtraMessageBox.Show("Bạn có chắc chắn muốn sửa?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                DataRow dr;
                
                for (int i = 0; i <= grV.RowCount - 1; i++)
                {
                    dr = grV.GetDataRow(i);
                    if(dr.RowState==DataRowState.Modified)
                    {
                        try
                        {
                            CHITIETPHIEUXUAT ct1 = new CHITIETPHIEUXUAT();
                            ct1.MaPX = lblPX.Text.Trim();
                            ct1.MaHH = dr["MaHH"].ToString().Trim();
                            ct1.SoLuong = int.Parse(dr["SoLuong"].ToString().Trim());
                           ctc.Update(ct1);
                        }
                        catch (Exception exx)
                        {
                            MessageBox.Show(exx.ToString());
                        }
                    }
                    




                }
                loadGR();
                MessageBox.Show("Sửa thành công");
            }
            

        }

        private void btnXoa_Click(object sender, EventArgs e)

        {

            if (XtraMessageBox.Show("Bạn có chắc chắn muốn xóa hàng hóa "+mahh+" ?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                try
                {
                    //    ChiTietPhieuBanModel ct2 = new ChiTietPhieuBanModel();

                    ctc.XoaCTPX(lblPX.Text.Trim(),mahh);
                    XtraMessageBox.Show("Xóa thành công");
                    loadGR();
                 
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }


        }

        private void grV_Click(object sender, EventArgs e)
        {
              mahh = grV.GetFocusedRowCellValue(MaHH).ToString().Trim();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            frmThemCTPX frmThem = new frmThemCTPX();
            frmThem.layMaPX(lblPX.Text.Trim());
            frmThem.ShowDialog();
            loadGR();
         

        }
    }
}