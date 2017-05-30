using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Model;
//using COMExcel = Microsoft.Office.Interop.Excel;
using DXApplication1.Controller;

namespace DXApplication1.View._UC.Phiếu_nhập
{
    public partial class frmCTPN : DevExpress.XtraEditors.XtraForm
    {
        public frmCTPN()
        {
            InitializeComponent();
        }
        private string mahh;
        ChiTietPhieuNhapController ctc = new ChiTietPhieuNhapController();
        public void loadData(PHIEUNHAP pn,string ten )
        {
            lblPN.Text = pn.MaPN;
            cmbNhanVien.Text = ten;
            dtpNgayNhap.Text = pn.NgayNhap;
            lblTongTienNhap.Text = pn.TongTien.ToString();
            grC.DataSource = ctc.XemCTPN(pn.MaPN);
        }
        public void loadGR()
        {
           
            grC.DataSource = ctc.XemCTPN(lblPN.Text);
        }
        public void loadTongTien()
        {
            PhieuNhapController pnc = new PhieuNhapController();
            lblTongTienNhap.Text=pnc.getDataById(lblPN.Text.Trim(),0).Rows[0][4].ToString();
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
                            CHITIETPHIEUNHAP ct1 = new CHITIETPHIEUNHAP();
                            ct1.MaPN = lblPN.Text.Trim();
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
                    //    ChiTietPhieuBanModel ct2 = new ChiTietPhieuBanModel();

                    ctc.XoaCTPN(lblPN.Text.Trim(),mahh);
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
            frmThemCTPN frmThem = new frmThemCTPN();
            frmThem.layMaPN(lblPN.Text.Trim());
            frmThem.ShowDialog();
            loadGR();
            loadTongTien();

        }

        private void button2_Click(object sender, EventArgs e)
       {

        //    {
        //        //khởi tạo excel
        //        COMExcel._Application app = new Microsoft.Office.Interop.Excel.Application();
        //        //Khởi tạo workbook
        //        COMExcel._Workbook workBook = app.Workbooks.Add(Type.Missing);
        //        //Khoiwr tao worksheet
        //        COMExcel._Worksheet workSheet = null;
        //        workSheet = workBook.Sheets["Sheet1"];
        //        workSheet = workBook.ActiveSheet;
        //        //Do du lieu vao sheet
        //        workSheet.Cells[1, 1] = "CHI TIẾT HÓA ĐƠN NHẬP";
        //        workSheet.Cells[3, 2] = "HDN : " + lblHDN.Text;
        //        workSheet.Cells[4, 2] = "Nhân viên nhập : " + cmbNhanVien.Text;
        //        workSheet.Cells[5, 2] = "Ngày nhập : " + dtpNgayNhap.Value.ToShortDateString();
        //        workSheet.Cells[7, 1] = "MaHH";
        //        workSheet.Cells[7, 2] = "Tên HH";
        //        workSheet.Cells[7, 3] = "Số lượng";
        //        workSheet.Cells[7, 4] = "Đơn giá";
        //        workSheet.Cells[7, 5] = "Thành tiền";

        //        for (int i = 0; i < dgvCTPN.Rows.Count - 1; i++)
        //        {
        //            for (int j = 0; j < 5; j++)
        //            {
        //                workSheet.Cells[i + 8, j + 1] = dgvCTPN.Rows[i].Cells[j].Value;
        //            }
        //        }
        //        workSheet.Cells[dgvCTPN.Rows.Count - 1 + 9, 4] = "Tổng tiền: " + lblTongTienNhap.Text + " VNĐ";
        //        string[] str = dtpNgayNhap.Value.ToShortDateString().Split('/');
        //        workSheet.Cells[dgvCTPN.Rows.Count - 1 + 11, 4] = "Ngày " + str[0] + ", tháng " + str[1] + ", năm" + str[2];
        //        workSheet.Cells[dgvCTPN.Rows.Count - 1 + 12, 4] = "Nhân viên ( Chữ ký )";
        //        //Định dạng trang
        //        workSheet.PageSetup.Orientation = COMExcel.XlPageOrientation.xlPortrait;
        //        workSheet.PageSetup.PaperSize = COMExcel.XlPaperSize.xlPaperA4;
        //        workSheet.PageSetup.LeftMargin = 0;
        //        workSheet.PageSetup.RightMargin = 0;
        //        workSheet.PageSetup.TopMargin = 0;
        //        workSheet.PageSetup.BottomMargin = 0;

        //        //Din dang cot
        //        workSheet.Range["A1"].ColumnWidth = 14;
        //        workSheet.Range["B1"].ColumnWidth = 34;
        //        workSheet.Range["C1"].ColumnWidth = 15;
        //        workSheet.Range["D1"].ColumnWidth = 15;
        //        workSheet.Range["E1"].ColumnWidth = 15;
        //        //dinh dang font
        //        workSheet.Range["A1", "E100"].Font.Name = "Times New Roman";
        //        workSheet.Range["A1", "E1"].Font.Size = 18;
        //        workSheet.Range["A2", "E100"].Font.Size = 14;
        //        workSheet.Range["A1", "E1"].MergeCells = true;
        //        workSheet.Range["A1", "E1"].Font.Color = Color.Red;
        //        workSheet.Range["A1", "E1"].Font.Bold = true;
        //        workSheet.Range["A7", "E7"].Font.Bold = true;
        //        workSheet.Range["C" + (dgvCTPN.Rows.Count - 1 + 11), "E" + (dgvCTPN.Rows.Count - 1 + 12)].Font.Italic = true;
        //        //workSheet.Range[dgvCTPB.Rows.Count - 1 + 12, 4].Font.Italic = true;
        //        //ke bang
        //        workSheet.Range["A7", "E" + ((dgvCTPN.Rows.Count - 1) + 7)].Borders.LineStyle = 1;
        //        //dinh dang center
        //        workSheet.Range["A1", "E1"].HorizontalAlignment = 3;
        //        workSheet.Range["A7", "E7"].HorizontalAlignment = 3;

        //        workSheet.Range["A8", "A" + (dgvCTPN.Rows.Count - 1) + 6].HorizontalAlignment = 3;

        //        workSheet.Range["C8", "C" + (dgvCTPN.Rows.Count - 1) + 6].HorizontalAlignment = 3;
        //        workSheet.Range["D8", "D" + (dgvCTPN.Rows.Count - 1) + 6].HorizontalAlignment = 3;
        //        workSheet.Range["E8", "E" + (dgvCTPN.Rows.Count - 1) + 6].HorizontalAlignment = 3;
        //        app.Visible = true;
        //    }
        }
    }
}