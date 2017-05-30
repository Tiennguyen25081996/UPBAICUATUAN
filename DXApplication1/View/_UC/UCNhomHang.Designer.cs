namespace DXApplication1.View._UC
{
    partial class UCNhomHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCNhomHang));
            this.Tabnhomhang = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.dgvNhomHang = new System.Windows.Forms.DataGridView();
            this.MaNhom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNhom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaKho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.txtMaNH = new DevExpress.XtraEditors.TextEdit();
            this.txtTenNH = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnThem = new System.Windows.Forms.ToolStripButton();
            this.btnSua = new System.Windows.Forms.ToolStripButton();
            this.btnXoa = new System.Windows.Forms.ToolStripButton();
            this.btnLuu = new System.Windows.Forms.ToolStripButton();
            this.btnHuy = new System.Windows.Forms.ToolStripButton();
            this.TabNVnhomhang = new DevExpress.XtraBars.Navigation.TabPane();
            this.cmbMaKho = new System.Windows.Forms.ComboBox();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.Tabnhomhang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhomHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaNH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenNH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TabNVnhomhang)).BeginInit();
            this.TabNVnhomhang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // Tabnhomhang
            // 
            this.Tabnhomhang.Caption = "NHÓM HÀNG";
            this.Tabnhomhang.Controls.Add(this.dgvNhomHang);
            this.Tabnhomhang.Controls.Add(this.groupControl1);
            this.Tabnhomhang.Controls.Add(this.toolStrip1);
            this.Tabnhomhang.Name = "Tabnhomhang";
            this.Tabnhomhang.Size = new System.Drawing.Size(1057, 525);
            // 
            // dgvNhomHang
            // 
            this.dgvNhomHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNhomHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhomHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNhom,
            this.TenNhom,
            this.MaKho});
            this.dgvNhomHang.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvNhomHang.Location = new System.Drawing.Point(0, 167);
            this.dgvNhomHang.Name = "dgvNhomHang";
            this.dgvNhomHang.Size = new System.Drawing.Size(1057, 358);
            this.dgvNhomHang.TabIndex = 8;
            this.dgvNhomHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNhomHang_CellClick);
            this.dgvNhomHang.Click += new System.EventHandler(this.dgvNhomHang_Click);
            // 
            // MaNhom
            // 
            this.MaNhom.DataPropertyName = "MaNhom";
            this.MaNhom.HeaderText = "Mã Nhóm";
            this.MaNhom.Name = "MaNhom";
            // 
            // TenNhom
            // 
            this.TenNhom.DataPropertyName = "TenNhom";
            this.TenNhom.HeaderText = "Tên Nhóm";
            this.TenNhom.Name = "TenNhom";
            // 
            // MaKho
            // 
            this.MaKho.DataPropertyName = "MaKho";
            this.MaKho.HeaderText = "Mã Kho";
            this.MaKho.Name = "MaKho";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.layoutControl1);
            this.groupControl1.Location = new System.Drawing.Point(3, 35);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1051, 128);
            this.groupControl1.TabIndex = 7;
            this.groupControl1.Text = "Thông tin nhóm hàng";
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.cmbMaKho);
            this.layoutControl1.Controls.Add(this.txtMaNH);
            this.layoutControl1.Controls.Add(this.txtTenNH);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(2, 20);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(1047, 106);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // txtMaNH
            // 
            this.txtMaNH.Enabled = false;
            this.txtMaNH.Location = new System.Drawing.Point(95, 12);
            this.txtMaNH.Name = "txtMaNH";
            this.txtMaNH.Size = new System.Drawing.Size(940, 20);
            this.txtMaNH.StyleController = this.layoutControl1;
            this.txtMaNH.TabIndex = 4;
            // 
            // txtTenNH
            // 
            this.txtTenNH.Enabled = false;
            this.txtTenNH.Location = new System.Drawing.Point(95, 36);
            this.txtTenNH.Name = "txtTenNH";
            this.txtTenNH.Size = new System.Drawing.Size(940, 20);
            this.txtTenNH.StyleController = this.layoutControl1;
            this.txtTenNH.TabIndex = 5;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem4,
            this.layoutControlItem1,
            this.layoutControlItem2});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(1047, 106);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.txtMaNH;
            this.layoutControlItem4.CustomizationFormText = "Mã NV: ";
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(1027, 24);
            this.layoutControlItem4.Text = "Mã NH: ";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(80, 13);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.txtTenNH;
            this.layoutControlItem1.CustomizationFormText = "Tên nhân viên:";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.OptionsTableLayoutItem.RowIndex = 1;
            this.layoutControlItem1.Size = new System.Drawing.Size(1027, 24);
            this.layoutControlItem1.Text = "Tên Nhóm Hàng:";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(80, 13);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(25, 25);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnThem,
            this.btnSua,
            this.btnXoa,
            this.btnLuu,
            this.btnHuy});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1057, 32);
            this.toolStrip1.TabIndex = 1;
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
            // TabNVnhomhang
            // 
            this.TabNVnhomhang.Controls.Add(this.Tabnhomhang);
            this.TabNVnhomhang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabNVnhomhang.Location = new System.Drawing.Point(0, 0);
            this.TabNVnhomhang.Name = "TabNVnhomhang";
            this.TabNVnhomhang.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.Tabnhomhang});
            this.TabNVnhomhang.RegularSize = new System.Drawing.Size(1075, 570);
            this.TabNVnhomhang.SelectedPage = this.Tabnhomhang;
            this.TabNVnhomhang.Size = new System.Drawing.Size(1075, 570);
            this.TabNVnhomhang.TabIndex = 0;
            this.TabNVnhomhang.Text = "Nhóm Hàng";
            this.TabNVnhomhang.Click += new System.EventHandler(this.TabNVnhomhang_Click);
            // 
            // cmbMaKho
            // 
            this.cmbMaKho.FormattingEnabled = true;
            this.cmbMaKho.Location = new System.Drawing.Point(95, 60);
            this.cmbMaKho.Name = "cmbMaKho";
            this.cmbMaKho.Size = new System.Drawing.Size(940, 21);
            this.cmbMaKho.TabIndex = 6;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.cmbMaKho;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(1027, 38);
            this.layoutControlItem2.Text = "Mã Kho";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(80, 13);
            // 
            // UCNhomHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TabNVnhomhang);
            this.Name = "UCNhomHang";
            this.Size = new System.Drawing.Size(1075, 570);
            this.Load += new System.EventHandler(this.UCNhomHang_Load);
            this.Tabnhomhang.ResumeLayout(false);
            this.Tabnhomhang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhomHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtMaNH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenNH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TabNVnhomhang)).EndInit();
            this.TabNVnhomhang.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Navigation.TabNavigationPage Tabnhomhang;
        private DevExpress.XtraBars.Navigation.TabPane TabNVnhomhang;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnThem;
        private System.Windows.Forms.ToolStripButton btnSua;
        private System.Windows.Forms.ToolStripButton btnXoa;
        private System.Windows.Forms.ToolStripButton btnLuu;
        private System.Windows.Forms.ToolStripButton btnHuy;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.TextEdit txtMaNH;
        private DevExpress.XtraEditors.TextEdit txtTenNH;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private System.Windows.Forms.DataGridView dgvNhomHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNhom;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNhom;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKho;
        private System.Windows.Forms.ComboBox cmbMaKho;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
    }
}
