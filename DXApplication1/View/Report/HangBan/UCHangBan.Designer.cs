namespace DXApplication1.View._UC
{
    partial class UCHangBan
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
            this.tabNhanVien = new DevExpress.XtraBars.Navigation.TabPane();
            this.tabNV = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.layoutControl2 = new DevExpress.XtraLayout.LayoutControl();
            this.cmbXemTheo = new System.Windows.Forms.ComboBox();
            this.cmbThang = new System.Windows.Forms.ComboBox();
            this.cmbQuy = new System.Windows.Forms.ComboBox();
            this.cmbNam = new System.Windows.Forms.ComboBox();
            this.dtpBatDau = new System.Windows.Forms.DateTimePicker();
            this.dtpKetThuc = new System.Windows.Forms.DateTimePicker();
            this.btnXem = new System.Windows.Forms.Button();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lblThang = new DevExpress.XtraLayout.LayoutControlItem();
            this.lblNBD = new DevExpress.XtraLayout.LayoutControlItem();
            this.lblNKT = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem10 = new DevExpress.XtraLayout.LayoutControlItem();
            this.lblQuy = new DevExpress.XtraLayout.LayoutControlItem();
            this.lblNam = new DevExpress.XtraLayout.LayoutControlItem();
            this.grC = new DevExpress.XtraGrid.GridControl();
            this.grV = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.TenHH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SoLuong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DonGiaBan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ThanhTien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.bar1 = new DevExpress.XtraBars.Bar();
            ((System.ComponentModel.ISupportInitialize)(this.tabNhanVien)).BeginInit();
            this.tabNhanVien.SuspendLayout();
            this.tabNV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).BeginInit();
            this.layoutControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblThang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblNBD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblNKT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblQuy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblNam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grV)).BeginInit();
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
            this.tabNhanVien.Text = "NHÂN VIÊN";
            this.tabNhanVien.Click += new System.EventHandler(this.tabNhanVien_Click);
            // 
            // tabNV
            // 
            this.tabNV.Caption = "HÀNG HÓA";
            this.tabNV.Controls.Add(this.groupControl2);
            this.tabNV.Controls.Add(this.grC);
            this.tabNV.Name = "tabNV";
            this.tabNV.Size = new System.Drawing.Size(1057, 525);
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.layoutControl2);
            this.groupControl2.Location = new System.Drawing.Point(3, 3);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(1051, 177);
            this.groupControl2.TabIndex = 10;
            this.groupControl2.Text = "Thời gian";
            // 
            // layoutControl2
            // 
            this.layoutControl2.Controls.Add(this.cmbXemTheo);
            this.layoutControl2.Controls.Add(this.cmbThang);
            this.layoutControl2.Controls.Add(this.cmbQuy);
            this.layoutControl2.Controls.Add(this.cmbNam);
            this.layoutControl2.Controls.Add(this.dtpBatDau);
            this.layoutControl2.Controls.Add(this.dtpKetThuc);
            this.layoutControl2.Controls.Add(this.btnXem);
            this.layoutControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl2.Location = new System.Drawing.Point(2, 20);
            this.layoutControl2.Name = "layoutControl2";
            this.layoutControl2.Root = this.layoutControlGroup2;
            this.layoutControl2.Size = new System.Drawing.Size(1047, 155);
            this.layoutControl2.TabIndex = 0;
            this.layoutControl2.Text = "layoutControl2";
            // 
            // cmbXemTheo
            // 
            this.cmbXemTheo.BackColor = System.Drawing.Color.White;
            this.cmbXemTheo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbXemTheo.FormattingEnabled = true;
            this.cmbXemTheo.Items.AddRange(new object[] {
            "Quý",
            "Tháng",
            "Tự do"});
            this.cmbXemTheo.Location = new System.Drawing.Point(89, 12);
            this.cmbXemTheo.Name = "cmbXemTheo";
            this.cmbXemTheo.Size = new System.Drawing.Size(433, 21);
            this.cmbXemTheo.TabIndex = 40;
            this.cmbXemTheo.SelectedValueChanged += new System.EventHandler(this.comboBox1_SelectedValueChanged);
            // 
            // cmbThang
            // 
            this.cmbThang.BackColor = System.Drawing.Color.White;
            this.cmbThang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbThang.Enabled = false;
            this.cmbThang.FormattingEnabled = true;
            this.cmbThang.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cmbThang.Location = new System.Drawing.Point(603, 37);
            this.cmbThang.Name = "cmbThang";
            this.cmbThang.Size = new System.Drawing.Size(432, 21);
            this.cmbThang.TabIndex = 39;
            // 
            // cmbQuy
            // 
            this.cmbQuy.BackColor = System.Drawing.Color.White;
            this.cmbQuy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbQuy.Enabled = false;
            this.cmbQuy.FormattingEnabled = true;
            this.cmbQuy.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cmbQuy.Location = new System.Drawing.Point(603, 12);
            this.cmbQuy.Name = "cmbQuy";
            this.cmbQuy.Size = new System.Drawing.Size(432, 21);
            this.cmbQuy.TabIndex = 37;
            // 
            // cmbNam
            // 
            this.cmbNam.BackColor = System.Drawing.Color.White;
            this.cmbNam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNam.Enabled = false;
            this.cmbNam.FormattingEnabled = true;
            this.cmbNam.Items.AddRange(new object[] {
            "2016",
            "2015",
            "2014",
            "2013"});
            this.cmbNam.Location = new System.Drawing.Point(89, 37);
            this.cmbNam.Name = "cmbNam";
            this.cmbNam.Size = new System.Drawing.Size(433, 21);
            this.cmbNam.TabIndex = 36;
            // 
            // dtpBatDau
            // 
            this.dtpBatDau.Enabled = false;
            this.dtpBatDau.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBatDau.Location = new System.Drawing.Point(89, 62);
            this.dtpBatDau.Name = "dtpBatDau";
            this.dtpBatDau.Size = new System.Drawing.Size(946, 21);
            this.dtpBatDau.TabIndex = 35;
            // 
            // dtpKetThuc
            // 
            this.dtpKetThuc.Enabled = false;
            this.dtpKetThuc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpKetThuc.Location = new System.Drawing.Point(89, 86);
            this.dtpKetThuc.Name = "dtpKetThuc";
            this.dtpKetThuc.Size = new System.Drawing.Size(946, 21);
            this.dtpKetThuc.TabIndex = 33;
            // 
            // btnXem
            // 
            this.btnXem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnXem.Location = new System.Drawing.Point(87, 112);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(90, 30);
            this.btnXem.TabIndex = 1;
            this.btnXem.Text = "Xem";
            this.btnXem.UseVisualStyleBackColor = false;
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup2.GroupBordersVisible = false;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lblThang,
            this.lblNBD,
            this.lblNKT,
            this.layoutControlItem10,
            this.lblQuy,
            this.lblNam});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "Root";
            this.layoutControlGroup2.Size = new System.Drawing.Size(1047, 155);
            this.layoutControlGroup2.TextVisible = false;
            // 
            // lblThang
            // 
            this.lblThang.Control = this.cmbThang;
            this.lblThang.Location = new System.Drawing.Point(514, 25);
            this.lblThang.Name = "lblThang";
            this.lblThang.Size = new System.Drawing.Size(513, 25);
            this.lblThang.Text = "Tháng :";
            this.lblThang.TextSize = new System.Drawing.Size(74, 13);
            // 
            // lblNBD
            // 
            this.lblNBD.Control = this.dtpBatDau;
            this.lblNBD.Location = new System.Drawing.Point(0, 50);
            this.lblNBD.Name = "lblNBD";
            this.lblNBD.Size = new System.Drawing.Size(1027, 24);
            this.lblNBD.Text = "Ngày băt đầu :";
            this.lblNBD.TextSize = new System.Drawing.Size(74, 13);
            // 
            // lblNKT
            // 
            this.lblNKT.Control = this.dtpKetThuc;
            this.lblNKT.Location = new System.Drawing.Point(0, 74);
            this.lblNKT.Name = "lblNKT";
            this.lblNKT.Size = new System.Drawing.Size(1027, 61);
            this.lblNKT.Text = "Ngày kết thúc :";
            this.lblNKT.TextSize = new System.Drawing.Size(74, 13);
            // 
            // layoutControlItem10
            // 
            this.layoutControlItem10.Control = this.cmbXemTheo;
            this.layoutControlItem10.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem10.Name = "layoutControlItem1";
            this.layoutControlItem10.Size = new System.Drawing.Size(514, 25);
            this.layoutControlItem10.Text = "Xem theo";
            this.layoutControlItem10.TextSize = new System.Drawing.Size(74, 13);
            // 
            // lblQuy
            // 
            this.lblQuy.Control = this.cmbQuy;
            this.lblQuy.Location = new System.Drawing.Point(514, 0);
            this.lblQuy.Name = "lblQuy";
            this.lblQuy.Size = new System.Drawing.Size(513, 25);
            this.lblQuy.Text = "Quý";
            this.lblQuy.TextSize = new System.Drawing.Size(74, 13);
            // 
            // lblNam
            // 
            this.lblNam.Control = this.cmbNam;
            this.lblNam.Location = new System.Drawing.Point(0, 25);
            this.lblNam.Name = "lblNam";
            this.lblNam.Size = new System.Drawing.Size(514, 25);
            this.lblNam.Text = "Năm";
            this.lblNam.TextSize = new System.Drawing.Size(74, 13);
            // 
            // grC
            // 
            this.grC.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grC.Location = new System.Drawing.Point(0, 217);
            this.grC.MainView = this.grV;
            this.grC.Name = "grC";
            this.grC.Size = new System.Drawing.Size(1057, 308);
            this.grC.TabIndex = 7;
            this.grC.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grV});
            this.grC.Click += new System.EventHandler(this.grC_Click);
            this.grC.MouseClick += new System.Windows.Forms.MouseEventHandler(this.grC_MouseClick);
            // 
            // grV
            // 
            this.grV.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.TenHH,
            this.SoLuong,
            this.DonGiaBan,
            this.ThanhTien});
            this.grV.GridControl = this.grC;
            this.grV.Name = "grV";
            this.grV.OptionsView.ShowGroupPanel = false;
            this.grV.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.grV_RowCellClick);
            this.grV.MouseLeave += new System.EventHandler(this.grC_Click);
            // 
            // TenHH
            // 
            this.TenHH.Caption = "hàng hóa";
            this.TenHH.FieldName = "TenHH";
            this.TenHH.Name = "TenHH";
            this.TenHH.Visible = true;
            this.TenHH.VisibleIndex = 0;
            this.TenHH.Width = 258;
            // 
            // SoLuong
            // 
            this.SoLuong.Caption = "Số lượng";
            this.SoLuong.FieldName = "SoLuong";
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.Visible = true;
            this.SoLuong.VisibleIndex = 1;
            this.SoLuong.Width = 243;
            // 
            // DonGiaBan
            // 
            this.DonGiaBan.Caption = "Đơn giá";
            this.DonGiaBan.FieldName = "DonGiaBan";
            this.DonGiaBan.Name = "DonGiaBan";
            this.DonGiaBan.Visible = true;
            this.DonGiaBan.VisibleIndex = 2;
            this.DonGiaBan.Width = 207;
            // 
            // ThanhTien
            // 
            this.ThanhTien.Caption = "Thành tiền";
            this.ThanhTien.FieldName = "ThanhTien";
            this.ThanhTien.Name = "ThanhTien";
            this.ThanhTien.Visible = true;
            this.ThanhTien.VisibleIndex = 3;
            this.ThanhTien.Width = 331;
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
            // UCHangBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabNhanVien);
            this.Name = "UCHangBan";
            this.Size = new System.Drawing.Size(1075, 570);
            ((System.ComponentModel.ISupportInitialize)(this.tabNhanVien)).EndInit();
            this.tabNhanVien.ResumeLayout(false);
            this.tabNV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).EndInit();
            this.layoutControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblThang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblNBD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblNKT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblQuy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblNam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraBars.Navigation.TabPane tabNhanVien;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNV;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraGrid.GridControl grC;
        private DevExpress.XtraGrid.Views.Grid.GridView grV;
        private DevExpress.XtraGrid.Columns.GridColumn TenHH;
        private DevExpress.XtraGrid.Columns.GridColumn SoLuong;
        private DevExpress.XtraGrid.Columns.GridColumn DonGiaBan;
        private DevExpress.XtraGrid.Columns.GridColumn ThanhTien;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraLayout.LayoutControl layoutControl2;
        private System.Windows.Forms.ComboBox cmbXemTheo;
        private System.Windows.Forms.ComboBox cmbThang;
        private System.Windows.Forms.ComboBox cmbQuy;
        private System.Windows.Forms.ComboBox cmbNam;
        private System.Windows.Forms.DateTimePicker dtpBatDau;
        private System.Windows.Forms.DateTimePicker dtpKetThuc;
        private System.Windows.Forms.Button btnXem;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem lblThang;
        private DevExpress.XtraLayout.LayoutControlItem lblNBD;
        private DevExpress.XtraLayout.LayoutControlItem lblNKT;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem10;
        private DevExpress.XtraLayout.LayoutControlItem lblQuy;
        private DevExpress.XtraLayout.LayoutControlItem lblNam;
    }
}
