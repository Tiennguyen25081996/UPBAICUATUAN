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
    public partial class UCTonKho : DevExpress.XtraEditors.XtraUserControl
    {
        
        BaoCao_TonkhoController nvC = new BaoCao_TonkhoController();
        private string makho;
        public UCTonKho()
        {
            InitializeComponent();
            loadData();
        }
        public void InDSTonKho(string Ngay,string MaKho,string MaNhom )
        {
            grC.DataSource = nvC.LayDSTonKho(Ngay, MaKho, MaNhom);
        }
        public void InDSTonKhoTatCa(string Ngay)
        {
            grC.DataSource = nvC.LayDSTonKhoTatCa(Ngay);
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void tabNhanVien_Click(object sender, EventArgs e)
        {

        }
        public void loadData()
        {
           
            cmbKho.DataSource = nvC.LayDSKho();
            cmbKho.DisplayMember = "TenKho";
            cmbKho.ValueMember = "MaKho";
            InDSTonKhoTatCa(DateTime.Now.ToString().Trim());

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
     

     

        private void btnXem_Click_1(object sender, EventArgs e)
        {

           
                if (rdoXemtatca.Checked == true)
                {
                   
                    InDSTonKhoTatCa(DateTime.Now.ToString().Trim());
                }
                else if (rdoXemtheonhom.Checked == true)
                {

                    if (cmbNhomHang.Text == "" || cmbKho.Text == "")
                    {
                        MessageBox.Show("Chọn nhóm hàng với kho trước đã");
                    }
                    else
                    {
           
                    grV.Columns.Clear();
                        InDSTonKho(DateTime.Now.ToString().Trim(),cmbKho.SelectedValue.ToString(), cmbNhomHang.SelectedValue.ToString());
                    }

                }


            
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
    }
}
