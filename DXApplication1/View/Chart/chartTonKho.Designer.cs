namespace DXApplication1.View._UC
{
    partial class chartTonKho
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
            DevExpress.XtraCharts.HatchFillOptions hatchFillOptions3 = new DevExpress.XtraCharts.HatchFillOptions();
            this.tabNhanVien = new DevExpress.XtraBars.Navigation.TabPane();
            this.tabNV = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.pnlChart = new System.Windows.Forms.Panel();
            this.chart1 = new DevExpress.XtraCharts.ChartControl();
            this.btnXem = new System.Windows.Forms.Button();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.layoutControl2 = new DevExpress.XtraLayout.LayoutControl();
            this.rdoXemtheonhom = new System.Windows.Forms.RadioButton();
            this.rdoXemtatca = new System.Windows.Forms.RadioButton();
            this.cmbKho = new System.Windows.Forms.ComboBox();
            this.cmbNhomHang = new System.Windows.Forms.ComboBox();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem10 = new DevExpress.XtraLayout.LayoutControlItem();
            this.lblNam = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.tabNhanVien)).BeginInit();
            this.tabNhanVien.SuspendLayout();
            this.tabNV.SuspendLayout();
            this.pnlChart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).BeginInit();
            this.layoutControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblNam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
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
            this.tabNV.Caption = "THỐNG KÊ HÀNG NHẬP";
            this.tabNV.Controls.Add(this.groupControl2);
            this.tabNV.Controls.Add(this.pnlChart);
            this.tabNV.Controls.Add(this.btnXem);
            this.tabNV.Name = "tabNV";
            this.tabNV.Size = new System.Drawing.Size(1057, 525);
            // 
            // pnlChart
            // 
            this.pnlChart.Controls.Add(this.chart1);
            this.pnlChart.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlChart.Location = new System.Drawing.Point(0, 181);
            this.pnlChart.Name = "pnlChart";
            this.pnlChart.Size = new System.Drawing.Size(1057, 344);
            this.pnlChart.TabIndex = 11;
            // 
            // chart1
            // 
            this.chart1.BorderOptions.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.chart1.DataBindings = null;
            this.chart1.Dock = System.Windows.Forms.DockStyle.Left;
            this.chart1.FillStyle.FillMode = DevExpress.XtraCharts.FillMode.Hatch;
            hatchFillOptions3.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            hatchFillOptions3.HatchStyle = System.Drawing.Drawing2D.HatchStyle.Divot;
            hatchFillOptions3.Tag = "Bểu đồ a";
            this.chart1.FillStyle.Options = hatchFillOptions3;
            this.chart1.FillStyle.Tag = "Bểu đồ a";
            this.chart1.IndicatorsPaletteName = "Northern Lights";
            this.chart1.Legend.Name = "Default Legend";
            this.chart1.Location = new System.Drawing.Point(0, 0);
            this.chart1.Name = "chart1";
            this.chart1.PaletteName = "Chameleon";
            this.chart1.SeriesSerializable = new DevExpress.XtraCharts.Series[0];
            this.chart1.Size = new System.Drawing.Size(1040, 344);
            this.chart1.TabIndex = 0;
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // btnXem
            // 
            this.btnXem.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnXem.Location = new System.Drawing.Point(94, 148);
            this.btnXem.Name = "btnXem";
            this.btnXem.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnXem.Size = new System.Drawing.Size(76, 27);
            this.btnXem.TabIndex = 1;
            this.btnXem.Text = "Xem";
            this.btnXem.UseVisualStyleBackColor = false;
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
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
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.layoutControl2);
            this.groupControl2.Location = new System.Drawing.Point(3, 3);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(1022, 139);
            this.groupControl2.TabIndex = 12;
            this.groupControl2.Text = "Thời gian";
            // 
            // layoutControl2
            // 
            this.layoutControl2.Controls.Add(this.rdoXemtheonhom);
            this.layoutControl2.Controls.Add(this.rdoXemtatca);
            this.layoutControl2.Controls.Add(this.cmbKho);
            this.layoutControl2.Controls.Add(this.cmbNhomHang);
            this.layoutControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl2.Location = new System.Drawing.Point(2, 20);
            this.layoutControl2.Name = "layoutControl2";
            this.layoutControl2.Root = this.layoutControlGroup2;
            this.layoutControl2.Size = new System.Drawing.Size(1018, 117);
            this.layoutControl2.TabIndex = 0;
            this.layoutControl2.Text = "layoutControl2";
            // 
            // rdoXemtheonhom
            // 
            this.rdoXemtheonhom.Location = new System.Drawing.Point(138, 12);
            this.rdoXemtheonhom.Name = "rdoXemtheonhom";
            this.rdoXemtheonhom.Size = new System.Drawing.Size(868, 25);
            this.rdoXemtheonhom.TabIndex = 44;
            this.rdoXemtheonhom.TabStop = true;
            this.rdoXemtheonhom.Text = "Xem theo nhóm hàng";
            this.rdoXemtheonhom.UseVisualStyleBackColor = true;
            this.rdoXemtheonhom.CheckedChanged += new System.EventHandler(this.rdoXemtheonhom_CheckedChanged);
            // 
            // rdoXemtatca
            // 
            this.rdoXemtatca.Location = new System.Drawing.Point(12, 12);
            this.rdoXemtatca.Name = "rdoXemtatca";
            this.rdoXemtatca.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.rdoXemtatca.Size = new System.Drawing.Size(122, 25);
            this.rdoXemtatca.TabIndex = 43;
            this.rdoXemtatca.TabStop = true;
            this.rdoXemtatca.Text = "Xem tất cả";
            this.rdoXemtatca.UseVisualStyleBackColor = true;
            // 
            // cmbKho
            // 
            this.cmbKho.BackColor = System.Drawing.Color.White;
            this.cmbKho.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKho.Enabled = false;
            this.cmbKho.FormattingEnabled = true;
            this.cmbKho.Location = new System.Drawing.Point(100, 45);
            this.cmbKho.Margin = new System.Windows.Forms.Padding(30, 3, 3, 3);
            this.cmbKho.Name = "cmbKho";
            this.cmbKho.Size = new System.Drawing.Size(108, 21);
            this.cmbKho.TabIndex = 40;
            this.cmbKho.SelectedIndexChanged += new System.EventHandler(this.cmbKho_SelectedIndexChanged);
            // 
            // cmbNhomHang
            // 
            this.cmbNhomHang.BackColor = System.Drawing.Color.White;
            this.cmbNhomHang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNhomHang.Enabled = false;
            this.cmbNhomHang.FormattingEnabled = true;
            this.cmbNhomHang.Location = new System.Drawing.Point(100, 70);
            this.cmbNhomHang.Name = "cmbNhomHang";
            this.cmbNhomHang.Size = new System.Drawing.Size(108, 21);
            this.cmbNhomHang.TabIndex = 36;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup2.GroupBordersVisible = false;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem3,
            this.layoutControlItem10,
            this.lblNam,
            this.layoutControlItem1});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "Root";
            this.layoutControlGroup2.Size = new System.Drawing.Size(1018, 117);
            this.layoutControlGroup2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.rdoXemtatca;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(126, 29);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem10
            // 
            this.layoutControlItem10.Control = this.cmbKho;
            this.layoutControlItem10.Location = new System.Drawing.Point(0, 29);
            this.layoutControlItem10.Name = "layoutControlItem1";
            this.layoutControlItem10.Padding = new DevExpress.XtraLayout.Utils.Padding(30, 800, 6, 2);
            this.layoutControlItem10.Size = new System.Drawing.Size(998, 29);
            this.layoutControlItem10.Text = "Kho    ";
            this.layoutControlItem10.TextSize = new System.Drawing.Size(57, 13);
            // 
            // lblNam
            // 
            this.lblNam.Control = this.cmbNhomHang;
            this.lblNam.Location = new System.Drawing.Point(0, 58);
            this.lblNam.Name = "lblNam";
            this.lblNam.Padding = new DevExpress.XtraLayout.Utils.Padding(30, 800, 2, 2);
            this.lblNam.Size = new System.Drawing.Size(998, 39);
            this.lblNam.Text = "Nhóm hàng ";
            this.lblNam.TextSize = new System.Drawing.Size(57, 13);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.rdoXemtheonhom;
            this.layoutControlItem1.Location = new System.Drawing.Point(126, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(872, 29);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // chartTonKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabNhanVien);
            this.Name = "chartTonKho";
            this.Size = new System.Drawing.Size(1075, 570);
            this.Load += new System.EventHandler(this.chartHangBan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabNhanVien)).EndInit();
            this.tabNhanVien.ResumeLayout(false);
            this.tabNV.ResumeLayout(false);
            this.pnlChart.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).EndInit();
            this.layoutControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblNam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraBars.Navigation.TabPane tabNhanVien;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNV;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.Bar bar1;
        private System.Windows.Forms.Button btnXem;
        private System.Windows.Forms.Panel pnlChart;
        private DevExpress.XtraCharts.ChartControl chart1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraLayout.LayoutControl layoutControl2;
        private System.Windows.Forms.RadioButton rdoXemtheonhom;
        private System.Windows.Forms.RadioButton rdoXemtatca;
        private System.Windows.Forms.ComboBox cmbKho;
        private System.Windows.Forms.ComboBox cmbNhomHang;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem10;
        private DevExpress.XtraLayout.LayoutControlItem lblNam;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
    }
}
