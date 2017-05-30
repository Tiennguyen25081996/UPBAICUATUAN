namespace DXApplication1.View._UC
{
    partial class UCPhieuNhap
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode2 = new DevExpress.XtraGrid.GridLevelNode();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCPhieuNhap));
            this.tabNhanVien = new DevExpress.XtraBars.Navigation.TabPane();
            this.tabNV = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.grC = new DevExpress.XtraGrid.GridControl();
            this.grV = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MaPN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NgayNhap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TongTien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenNV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.cmbNhanVien = new System.Windows.Forms.ComboBox();
            this.txtMaPN = new DevExpress.XtraEditors.TextEdit();
            this.spinTongTien = new DevExpress.XtraEditors.SpinEdit();
            this.dateNgayNhap = new DevExpress.XtraEditors.DateEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.txtLuong = new DevExpress.XtraLayout.LayoutControlItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnThem = new System.Windows.Forms.ToolStripButton();
            this.btnSua = new System.Windows.Forms.ToolStripButton();
            this.btnXoa = new System.Windows.Forms.ToolStripButton();
            this.btnLuu = new System.Windows.Forms.ToolStripButton();
            this.btnHuy = new System.Windows.Forms.ToolStripButton();
            this.btnXemCT = new System.Windows.Forms.ToolStripButton();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.bar1 = new DevExpress.XtraBars.Bar();
            ((System.ComponentModel.ISupportInitialize)(this.tabNhanVien)).BeginInit();
            this.tabNhanVien.SuspendLayout();
            this.tabNV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaPN.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinTongTien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgayNhap.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgayNhap.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLuong)).BeginInit();
            this.panel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabNhanVien
            // 
            this.tabNhanVien.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.tabNhanVien.Appearance.Options.UseBackColor = true;
            this.tabNhanVien.Controls.Add(this.tabNV);
            this.tabNhanVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabNhanVien.Location = new System.Drawing.Point(0, 0);
            this.tabNhanVien.Name = "tabNhanVien";
            this.tabNhanVien.PageProperties.ShowMode = DevExpress.XtraBars.Navigation.ItemShowMode.Text;
            this.tabNhanVien.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.tabNV});
            this.tabNhanVien.RegularSize = new System.Drawing.Size(1075, 570);
            this.tabNhanVien.SelectedPage = this.tabNV;
            this.tabNhanVien.Size = new System.Drawing.Size(1075, 570);
            this.tabNhanVien.TabIndex = 4;
            this.tabNhanVien.Text = "PHIẾU NHẬP";
            this.tabNhanVien.Click += new System.EventHandler(this.tabNhanVien_Click);
            // 
            // tabNV
            // 
            this.tabNV.Caption = "PHIẾU NHẬP";
            this.tabNV.Controls.Add(this.grC);
            this.tabNV.Controls.Add(this.groupControl1);
            this.tabNV.Controls.Add(this.panel1);
            this.tabNV.Name = "tabNV";
            this.tabNV.Size = new System.Drawing.Size(1057, 525);
            // 
            // grC
            // 
            this.grC.Dock = System.Windows.Forms.DockStyle.Bottom;
            gridLevelNode1.RelationName = "Level1";
            gridLevelNode2.RelationName = "Level2";
            this.grC.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1,
            gridLevelNode2});
            this.grC.Location = new System.Drawing.Point(0, 189);
            this.grC.MainView = this.grV;
            this.grC.Name = "grC";
            this.grC.Size = new System.Drawing.Size(1057, 336);
            this.grC.TabIndex = 7;
            this.grC.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grV});
            this.grC.Click += new System.EventHandler(this.grC_Click);
            this.grC.MouseClick += new System.Windows.Forms.MouseEventHandler(this.grC_MouseClick);
            // 
            // grV
            // 
            this.grV.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MaPN,
            this.NgayNhap,
            this.TongTien,
            this.TenNV});
            this.grV.GridControl = this.grC;
            this.grV.Name = "grV";
            this.grV.OptionsView.ShowGroupPanel = false;
            this.grV.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.grV_RowCellClick);
            this.grV.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.grV_FocusedRowChanged);
            this.grV.MouseLeave += new System.EventHandler(this.grC_Click);
            // 
            // MaPN
            // 
            this.MaPN.Caption = "Mã phiếu nhập";
            this.MaPN.FieldName = "MaPN";
            this.MaPN.Name = "MaPN";
            this.MaPN.Visible = true;
            this.MaPN.VisibleIndex = 0;
            this.MaPN.Width = 164;
            // 
            // NgayNhap
            // 
            this.NgayNhap.Caption = "Ngày nhập";
            this.NgayNhap.FieldName = "NgayNhap";
            this.NgayNhap.Name = "NgayNhap";
            this.NgayNhap.Visible = true;
            this.NgayNhap.VisibleIndex = 1;
            this.NgayNhap.Width = 213;
            // 
            // TongTien
            // 
            this.TongTien.Caption = "Tổng tiền";
            this.TongTien.FieldName = "TongTien";
            this.TongTien.Name = "TongTien";
            this.TongTien.Visible = true;
            this.TongTien.VisibleIndex = 3;
            this.TongTien.Width = 398;
            // 
            // TenNV
            // 
            this.TenNV.Caption = "Tên NV lập PN";
            this.TenNV.FieldName = "TenNV";
            this.TenNV.Name = "TenNV";
            this.TenNV.Visible = true;
            this.TenNV.VisibleIndex = 2;
            this.TenNV.Width = 264;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.layoutControl1);
            this.groupControl1.Location = new System.Drawing.Point(3, 42);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1051, 141);
            this.groupControl1.TabIndex = 6;
            this.groupControl1.Text = "Thông tin phiếu nhập";
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.cmbNhanVien);
            this.layoutControl1.Controls.Add(this.txtMaPN);
            this.layoutControl1.Controls.Add(this.spinTongTien);
            this.layoutControl1.Controls.Add(this.dateNgayNhap);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(2, 20);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(1047, 119);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // cmbNhanVien
            // 
            this.cmbNhanVien.FormattingEnabled = true;
            this.cmbNhanVien.Location = new System.Drawing.Point(135, 60);
            this.cmbNhanVien.Margin = new System.Windows.Forms.Padding(30);
            this.cmbNhanVien.Name = "cmbNhanVien";
            this.cmbNhanVien.Size = new System.Drawing.Size(702, 21);
            this.cmbNhanVien.TabIndex = 11;
            // 
            // txtMaPN
            // 
            this.txtMaPN.Enabled = false;
            this.txtMaPN.Location = new System.Drawing.Point(135, 12);
            this.txtMaPN.Name = "txtMaPN";
            this.txtMaPN.Size = new System.Drawing.Size(702, 20);
            this.txtMaPN.StyleController = this.layoutControl1;
            this.txtMaPN.TabIndex = 4;
            // 
            // spinTongTien
            // 
            this.spinTongTien.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinTongTien.Enabled = false;
            this.spinTongTien.Location = new System.Drawing.Point(135, 85);
            this.spinTongTien.Name = "spinTongTien";
            this.spinTongTien.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinTongTien.Size = new System.Drawing.Size(702, 20);
            this.spinTongTien.StyleController = this.layoutControl1;
            this.spinTongTien.TabIndex = 9;
            // 
            // dateNgayNhap
            // 
            this.dateNgayNhap.EditValue = null;
            this.dateNgayNhap.Location = new System.Drawing.Point(135, 36);
            this.dateNgayNhap.Name = "dateNgayNhap";
            this.dateNgayNhap.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateNgayNhap.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateNgayNhap.Size = new System.Drawing.Size(702, 20);
            this.dateNgayNhap.StyleController = this.layoutControl1;
            this.dateNgayNhap.TabIndex = 10;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem4,
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.txtLuong});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(1047, 119);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.txtMaPN;
            this.layoutControlItem4.CustomizationFormText = "Mã NV: ";
            this.layoutControlItem4.Enabled = false;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Padding = new DevExpress.XtraLayout.Utils.Padding(50, 200, 2, 2);
            this.layoutControlItem4.Size = new System.Drawing.Size(1027, 24);
            this.layoutControlItem4.Text = "Mã PN: ";
            this.layoutControlItem4.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            this.layoutControlItem4.TextSize = new System.Drawing.Size(70, 13);
            this.layoutControlItem4.TextToControlDistance = 5;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.dateNgayNhap;
            this.layoutControlItem1.Enabled = false;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Padding = new DevExpress.XtraLayout.Utils.Padding(50, 200, 2, 2);
            this.layoutControlItem1.Size = new System.Drawing.Size(1027, 24);
            this.layoutControlItem1.Text = "Ngày nhập:";
            this.layoutControlItem1.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(70, 13);
            this.layoutControlItem1.TextToControlDistance = 5;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.cmbNhanVien;
            this.layoutControlItem2.Enabled = false;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Padding = new DevExpress.XtraLayout.Utils.Padding(50, 200, 2, 2);
            this.layoutControlItem2.Size = new System.Drawing.Size(1027, 25);
            this.layoutControlItem2.Text = "Nhân viên lập:";
            this.layoutControlItem2.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(70, 13);
            this.layoutControlItem2.TextToControlDistance = 5;
            // 
            // txtLuong
            // 
            this.txtLuong.Control = this.spinTongTien;
            this.txtLuong.Enabled = false;
            this.txtLuong.Location = new System.Drawing.Point(0, 73);
            this.txtLuong.Name = "txtLuong";
            this.txtLuong.Padding = new DevExpress.XtraLayout.Utils.Padding(50, 200, 2, 2);
            this.txtLuong.Size = new System.Drawing.Size(1027, 26);
            this.txtLuong.Text = "Tổng tiền:";
            this.txtLuong.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            this.txtLuong.TextSize = new System.Drawing.Size(70, 13);
            this.txtLuong.TextToControlDistance = 5;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.toolStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1057, 36);
            this.panel1.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(25, 25);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnThem,
            this.btnSua,
            this.btnXoa,
            this.btnLuu,
            this.btnHuy,
            this.btnXemCT});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1057, 32);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnThem
            // 
            this.btnThem.Image = global::DXApplication1.Properties.Resources.Symbol_Add1;
            this.btnThem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(67, 29);
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Image = global::DXApplication1.Properties.Resources.Edit;
            this.btnSua.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(55, 29);
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Image = global::DXApplication1.Properties.Resources._1492013854_basket;
            this.btnXoa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(54, 29);
            this.btnXoa.Text = "xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.Image")));
            this.btnLuu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(56, 29);
            this.btnLuu.Text = "Lưu";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Image = global::DXApplication1.Properties.Resources.Symbol_Delete;
            this.btnHuy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(58, 29);
            this.btnHuy.Text = "Hủy";
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnXemCT
            // 
            this.btnXemCT.Image = ((System.Drawing.Image)(resources.GetObject("btnXemCT.Image")));
            this.btnXemCT.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnXemCT.Name = "btnXemCT";
            this.btnXemCT.Size = new System.Drawing.Size(94, 29);
            this.btnXemCT.Text = "Xem CTPN";
            this.btnXemCT.Click += new System.EventHandler(this.btnXemCT_Click);
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.FloatLocation = new System.Drawing.Point(60, 160);
            this.bar2.FloatSize = new System.Drawing.Size(236, 41);
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // bar3
            // 
            this.bar3.BarName = "Main menu";
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar3.FloatLocation = new System.Drawing.Point(147, 236);
            this.bar3.FloatSize = new System.Drawing.Size(128, 31);
            this.bar3.OptionsBar.MultiLine = true;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Main menu";
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.Text = "Tools";
            // 
            // UCPhieuNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabNhanVien);
            this.Name = "UCPhieuNhap";
            this.Size = new System.Drawing.Size(1075, 570);
            this.Load += new System.EventHandler(this.UC_PhieuNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabNhanVien)).EndInit();
            this.tabNhanVien.ResumeLayout(false);
            this.tabNV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtMaPN.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinTongTien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgayNhap.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgayNhap.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLuong)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraBars.Navigation.TabPane tabNhanVien;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNV;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.Bar bar1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnThem;
        private System.Windows.Forms.ToolStripButton btnSua;
        private System.Windows.Forms.ToolStripButton btnXoa;
        private System.Windows.Forms.ToolStripButton btnLuu;
        private System.Windows.Forms.ToolStripButton btnHuy;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
       
        private DevExpress.XtraEditors.TextEdit txtMaPN;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraEditors.SpinEdit spinTongTien;
        private DevExpress.XtraLayout.LayoutControlItem txtLuong;
        private DevExpress.XtraGrid.GridControl grC;
        private DevExpress.XtraGrid.Views.Grid.GridView grV;
        private DevExpress.XtraGrid.Columns.GridColumn MaPN;
        private DevExpress.XtraGrid.Columns.GridColumn NgayNhap;
        private DevExpress.XtraGrid.Columns.GridColumn TenNV;
        private DevExpress.XtraGrid.Columns.GridColumn TongTien;
        private System.Windows.Forms.ComboBox cmbNhanVien;
        private DevExpress.XtraEditors.DateEdit dateNgayNhap;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private System.Windows.Forms.ToolStripButton btnXemCT;
    }
}
