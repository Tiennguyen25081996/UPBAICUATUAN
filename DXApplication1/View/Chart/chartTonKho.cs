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
    public partial class chartTonKho : DevExpress.XtraEditors.XtraUserControl
    {
        
        BaoCao_TonkhoController nvC = new BaoCao_TonkhoController();
        Series sr1;
        Series sr2;
        private string makho;
        public chartTonKho()
        {
            InitializeComponent();
            TonkhoTatCa();
            loadData();
        }
        public void loadData()
        {

            cmbKho.DataSource = nvC.LayDSKho();
            cmbKho.DisplayMember = "TenKho";
            cmbKho.ValueMember = "MaKho";
          

        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void tabNhanVien_Click(object sender, EventArgs e)
        {

        }
        public void TonkhoTatCa()
        {
            
            DataTable dt = nvC.LayBDTonKhoTatCa(DateTime.Now.ToShortDateString());
           
            chart1.DataSource = dt;
             sr1 = new Series("Số lượng sản phẩm còn", ViewType.Point);
          
            
            foreach(DataRow dr in dt.Rows)
            {
                
                sr1.Points.Add(new SeriesPoint(dr[2].ToString(), dr[3].ToString()));
             
            }
            chart1.Series.Clear();
            chart1.Series.Add(sr1);
            pnlChart.Controls.Add(chart1);

            

        }
        public void TonKho(string date1, string makho, string manhom)
        {
            DataTable dt = nvC.LayBDTonKho(DateTime.Now.ToShortDateString(), makho, manhom);

            chart1.DataSource = dt;
            sr2 = new Series("Số lượng sản phẩm còn", ViewType.Point);
            int dem = 0;

            foreach (DataRow dr in dt.Rows)
            {
                dem++;
                sr2.Points.Add(new SeriesPoint(dr[0].ToString(), dr[1].ToString()));
              
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

        private void cmbKho_SelectedIndexChanged(object sender, EventArgs e)
        {
            makho = cmbKho.SelectedValue.ToString().Trim();
            cmbNhomHang.DataSource = nvC.LayDSNhom(makho);
            cmbNhomHang.DisplayMember = "TenNhom";
            cmbNhomHang.ValueMember = "MaNhom";
        }

        private void rdoXemtheonhom_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoXemtheonhom.Checked == true)
            {
                cmbKho.Enabled = true;

                cmbNhomHang.Enabled = true;

            }
            else if (rdoXemtheonhom.Checked == false)
            {
                cmbKho.Enabled = false;

                cmbNhomHang.Enabled = false;

            }
        }
        private void btnXem_Click(object sender, EventArgs e) {
            if (rdoXemtatca.Checked == true)
            {

                TonkhoTatCa();
            }
            else if (rdoXemtheonhom.Checked == true)
            {

                if (cmbNhomHang.Text == "" || cmbKho.Text == "")
                {
                    MessageBox.Show("Chọn nhóm hàng với kho trước đã");
                }
                else
                {

                    
                    TonKho(DateTime.Now.ToString().Trim(), cmbKho.SelectedValue.ToString(), cmbNhomHang.SelectedValue.ToString());
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
