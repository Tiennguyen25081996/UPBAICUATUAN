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
    public partial class frmCTHDB : DevExpress.XtraEditors.XtraForm
    {
        public frmCTHDB()
        {
            InitializeComponent();
        }
        private string mahh;
        ChiTietHoaDonBanController ctc = new ChiTietHoaDonBanController();
        public void loadData(HOADONBAN HDB,string ten )
        {
            lblHDB.Text = HDB.MaHDB;
            cmbNhanVien.Text = ten;
            dtpNgayBan.Text = HDB.NgayBan;
            lblTongTienNhap.Text = HDB.TongTien.ToString();
            grC.DataSource = ctc.XemCTHDB(HDB.MaHDB);
        }
        public void loadGR()
        {
           
            grC.DataSource = ctc.XemCTHDB(lblHDB.Text);
        }
        public void loadTongTien()
        {
            HoaDonBanController HDBc = new HoaDonBanController();
            lblTongTienNhap.Text=HDBc.getDataById(lblHDB.Text.Trim(),0).Rows[0][4].ToString();
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
                            CHITIETHOADONBAN ct1 = new CHITIETHOADONBAN();
                            ct1.MaHDB = lblHDB.Text.Trim();
                            ct1.MaHH = dr["MaHH"].ToString().Trim();
                            ct1.SoLuong = int.Parse(dr["SoLuong"].ToString().Trim());
                            ct1.DonGia = dr["DonGia"].ToString().Trim();

                            ctc.Update(ct1);
                         

                        }
                        catch (Exception exx)
                        {
                            MessageBox.Show(exx.ToString());
                        }
                    }
                    




                }
                loadGR();
                loadTongTien();
                MessageBox.Show("Sửa thành công");
            }
            

        }

        private void btnXoa_Click(object sender, EventArgs e)

        {

            if (XtraMessageBox.Show("Bạn có chắc chắn muốn xóa hàng hóa "+mahh+" ?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                try
                {
                    //ChiTietHoaDonBanBanModel ct2 = new ChiTietPhieuBanModel();
                
                    ctc.XoaCTHDB(lblHDB.Text.Trim(),mahh);
                    XtraMessageBox.Show("Xóa thành công");
                    loadGR();
                    loadTongTien();
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
            frmThemCTHDB frmThem = new frmThemCTHDB();
            frmThem.layMaHDB(lblHDB.Text.Trim());
            frmThem.ShowDialog();
            loadGR();
            loadTongTien();

        }
    }
}