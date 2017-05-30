using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DXApplication1.Controller;
using Model;
using DXApplication1.View._Form;
using System.Data.SqlClient;
using DevExpress.XtraCharts;

namespace DXApplication1.View._UC
{
    public partial class chartHangNhap : DevExpress.XtraEditors.XtraUserControl
    {
        
        BaoCaoController nvC = new BaoCaoController();
        Series sr1;
        Series sr2;
        public chartHangNhap()
        {
            InitializeComponent();
        }
       

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void tabNhanVien_Click(object sender, EventArgs e)
        {

        }
        public void TopSP_Soluong(string date1, string date2)
        {
            
            DataTable dt = nvC.BieuDoSPBanChay(date1,date2);
           
            chart1.DataSource = dt;
             sr1 = new Series("Số lượng sản phẩm nhập", ViewType.Bar);
            int dem = 0;
            
            foreach(DataRow dr in dt.Rows)
            {
                dem++;
                sr1.Points.Add(new SeriesPoint(dr[0].ToString(), dr[1].ToString()));
                if (dem == 10)
                {
                   // sr1.Points.Add(new SeriesPoint("Khác", 12.00));
                    break;
                }
            }
            chart1.Series.Clear();
            chart1.Series.Add(sr1);
            pnlChart.Controls.Add(chart1);

            

        }
        public void TopSPDoanhThu(string date1, string date2)
        {
            DataTable dt = nvC.BieuDoSPDoanhThu(date1, date2);

            chart1.DataSource = dt;
             sr2 = new Series("Tổng tiền nhập(VNĐ)", ViewType.Bar);
            int dem = 0;

            foreach (DataRow dr in dt.Rows)
            {
                dem++;
                sr2.Points.Add(new SeriesPoint(dr[0].ToString(), dr[1].ToString()));
                if (dem == 10)
                {
                    // sr1.Points.Add(new SeriesPoint("Khác", 12.00));
                    break;
                }
            }
            chart1.Series.Clear();
            chart1.Series.Add(sr2);
        
            pnlChart.Controls.Add(chart1);
        }

        private void grC_Click(object sender, EventArgs e)
        {
           
        }

        private void nHANVIENBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
           

        }

        private void grV_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            
        }

        private void grV_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
           
        }

        private void grC_MouseClick(object sender, MouseEventArgs e)
        {
          
        }

        private void grV_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
          
        }

        private void grV_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
         
        }
        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmbXemTheo.SelectedItem == "Quý")
            {
                cmbQuy.Enabled = true;
                cmbNam.Enabled = true;
                dtpBatDau.Enabled = false;
                dtpKetThuc.Enabled = false;
                cmbThang.Enabled = false;

                //lblQuy.Enabled = true;
                //lblNam.Enabled = true;
                //lblNBD.Enabled = false;
                //lblNKT.Enabled = false;
                //lblThang.Enabled = false;
            }
            else if (cmbXemTheo.SelectedItem == "Tháng")
            {
                cmbThang.Enabled = true;
                cmbNam.Enabled = true;
                dtpBatDau.Enabled = false;
                dtpKetThuc.Enabled = false;
                cmbQuy.Enabled = false;

                //lblThang.Enabled = true;
                //lblNam.Enabled = true;
                //lblNBD.Enabled = false;
                //lblNKT.Enabled = false;
                //lblQuy.Enabled = false;
            }
            else if (cmbXemTheo.SelectedItem == "Tự do")
            {
                dtpBatDau.Enabled = true;
                dtpKetThuc.Enabled = true;
                cmbQuy.Enabled = false;
                cmbNam.Enabled = false;
                cmbThang.Enabled = false;

                //lblNBD.Enabled = true;
                //lblNKT.Enabled = true;
                //lblQuy.Enabled = false;
                //lblNam.Enabled = false;
                //lblThang.Enabled = false;
            }

        }

        private void btnXem_Click(object sender, EventArgs e)

        {
            if (cmbXemTheo.Text == "")
            {
                if (rdo1.Checked == false && rdo2.Checked == false)
                {
                    MessageBox.Show("Chọn loại biểu đồ để xem!");
                }
                else if (rdo1.Checked == true)
                {
                    TopSP_Soluong("10-10-2000", DateTime.Now.ToShortDateString());
                }
                else
                {
                    TopSPDoanhThu("10-10-2000", DateTime.Now.ToShortDateString());
                }

            }
           
            else
            {
                string ngayBatDau = "";
                string ngayKetThuc = "";
                if (cmbXemTheo.SelectedItem == "Quý")
                {
                      if (cmbNam.Text == "")
                    {
                        MessageBox.Show("Chưa chọn năm");
                    }
                    else if(cmbQuy.Text == "")
                    {
                        MessageBox.Show("Chọn quý đã!");
                    }
                    else
                    {
                        if (cmbQuy.SelectedItem == "1")
                        {
                            ngayBatDau = String.Concat(cmbNam.SelectedItem + "/" + "1" + "/" + "1");
                            ngayKetThuc = String.Concat(cmbNam.SelectedItem + "/" + "3" + "/" + "31");
                           
                        }
                        else if (cmbQuy.SelectedItem == "2")
                        {
                            ngayBatDau = cmbNam.SelectedItem + "/" + "4" + "/" + "1";
                            ngayKetThuc = cmbNam.SelectedItem + "/" + "6" + "/" + "30";
                           
                        }
                        else if (cmbQuy.SelectedItem == "3")
                        {
                            ngayBatDau = cmbNam.SelectedItem + "/" + "7" + "/" + "1";
                            ngayKetThuc = cmbNam.SelectedItem + "/" + "9" + "/" + "30";
                         
                        }
                        else if (cmbQuy.SelectedItem == "4")
                        {
                            ngayBatDau = cmbNam.SelectedItem + "/" + "10" + "/" + "1";
                            ngayKetThuc = cmbNam.SelectedItem + "/" + "12" + "/" + "31";
                           
                        }
                        if (rdo1.Checked == true)
                        {
                            TopSP_Soluong(ngayBatDau, ngayKetThuc);
                        }
                        else
                        {
                            TopSPDoanhThu(ngayBatDau, ngayKetThuc);
                        }
                        //InDSDaBan(ngayBatDau,ngayKetThuc);
                    }


                }
                else if (cmbXemTheo.SelectedItem == "Tháng")
                {
                    if (cmbNam.Text == "")
                    {
                        MessageBox.Show("Chưa chọn năm");
                    }
                    else if (cmbThang.Text == "")
                    {
                        MessageBox.Show("Chọn tháng đã!");
                    }
                    else
                    {
                        int thang;
                        int.TryParse(cmbThang.SelectedItem.ToString(), out thang);
                        if (thang == 4 || thang == 6 || thang == 9 || thang == 11)
                        {
                            ngayBatDau = cmbNam.SelectedItem + "/" + cmbThang.SelectedItem + "/" + "1";
                            ngayKetThuc = cmbNam.SelectedItem + "/" + cmbThang.SelectedItem + "/" + "30";
                        }
                        else
                             if (thang == 2)
                        {
                            ngayBatDau = cmbNam.SelectedItem + "/" + "2" + "/" + "1";
                            ngayKetThuc = cmbNam.SelectedItem + "/" + "2" + "/" + "28";
                        }

                        else
                        {
                            ngayBatDau = cmbNam.SelectedItem + "/" + cmbThang.SelectedItem + "/" + "1";
                            ngayKetThuc = cmbNam.SelectedItem + "/" + cmbThang.SelectedItem + "/" + "31";
                        }


                        if (rdo1.Checked == true)
                        {
                            TopSP_Soluong(ngayBatDau, ngayKetThuc);
                        }
                        else
                        {
                            TopSPDoanhThu(ngayBatDau, ngayKetThuc);
                        }
                    }


                }

                else if (cmbXemTheo.SelectedItem == "Tự do")
                {
                    // InDSDaBan(dtpBatDau.Value.ToShortDateString(), dtpKetThuc.Value.ToShortDateString());
                    if (rdo1.Checked == true)
                    {
                        TopSP_Soluong(dtpBatDau.Value.ToShortDateString(), dtpKetThuc.Value.ToShortDateString());
                    }
                    else
                    {
                        TopSPDoanhThu(dtpBatDau.Value.ToShortDateString(), dtpKetThuc.Value.ToShortDateString());
                    }
                }


            }

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void chartHangBan_Load(object sender, EventArgs e)
        {
        
        }

        private void radioGroup1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
