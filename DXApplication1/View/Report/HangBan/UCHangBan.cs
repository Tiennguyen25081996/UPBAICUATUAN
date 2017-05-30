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

namespace DXApplication1.View._UC
{
    public partial class UCHangBan : DevExpress.XtraEditors.XtraUserControl
    {
        
        BaoCaoController nvC = new BaoCaoController();
        public UCHangBan()
        {
            InitializeComponent();
        }
        public void InDSDaBan(string date1,string date2 )
        {
            grC.DataSource = nvC.LayDSHangDaBan(date1, date2);
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void tabNhanVien_Click(object sender, EventArgs e)
        {

        }
        public void loadData()
        {
            
            grC.DataSource = nvC.LayDSHangDaBan(DateTime.Now.ToShortDateString(), DateTime.Now.ToShortDateString());
            

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
                MessageBox.Show("Chọn xem theo... đã!");
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
                        InDSDaBan(ngayBatDau,ngayKetThuc);
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

                     
                        InDSDaBan(ngayBatDau, ngayKetThuc);
                    }


                }

                else if (cmbXemTheo.SelectedItem == "Tự do")
                {
                    InDSDaBan(dtpBatDau.Value.ToShortDateString(), dtpKetThuc.Value.ToShortDateString());
                }


            }

        }
    }
}
