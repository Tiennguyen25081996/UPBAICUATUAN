namespace DXApplication1.View._UC
{
    partial class chartHangNhap
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
            DevExpress.XtraCharts.HatchFillOptions hatchFillOptions1 = new DevExpress.XtraCharts.HatchFillOptions();
            this.tabNhanVien = new DevExpress.XtraBars.Navigation.TabPane();
            this.tabNV = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.pnlChart = new System.Windows.Forms.Panel();
            this.chart1 = new DevExpress.XtraCharts.ChartControl();
            this.btnXem = new System.Windows.Forms.Button();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.layoutControl2 = new DevExpress.XtraLayout.LayoutControl();
            this.rdo2 = new System.Windows.Forms.RadioButton();
            this.rdo1 = new System.Windows.Forms.RadioButton();
            this.cmbXemTheo = new System.Windows.Forms.ComboBox();
            this.cmbThang = new System.Windows.Forms.ComboBox();
            this.cmbQuy = new System.Windows.Forms.ComboBox();
            this.cmbNam = new System.Windows.Forms.ComboBox();
            this.dtpBatDau = new System.Windows.Forms.DateTimePicker();
            this.dtpKetThuc = new System.Windows.Forms.DateTimePicker();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lblThang = new DevExpress.XtraLayout.LayoutControlItem();
            this.lblNBD = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem10 = new DevExpress.XtraLayout.LayoutControlItem();
            this.lblQuy = new DevExpress.XtraLayout.LayoutControlItem();
            this.lblNam = new DevExpress.XtraLayout.LayoutControlItem();
            this.lblNKT = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.bar1 = new DevExpress.XtraBars.Bar();
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
            ((System.ComponentModel.ISupportInitialize)(this.lblThang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblNBD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblQuy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblNam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblNKT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
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
            this.tabNV.Controls.Add(this.pnlChart);
            this.tabNV.Controls.Add(this.btnXem);
            this.tabNV.Controls.Add(this.groupControl2);
            this.tabNV.Name = "tabNV";
            this.tabNV.Size = new System.Drawing.Size(1057, 525);
            // 
            // pnlChart
            // 
            this.pnlChart.Controls.Add(this.chart1);
            this.pnlChart.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlChart.Location = new System.Drawing.Point(0, 202);
            this.pnlChart.Name = "pnlChart";
            this.pnlChart.Size = new System.Drawing.Size(1057, 323);
            this.pnlChart.TabIndex = 11;
            // 
            // chart1
            // 
            this.chart1.BorderOptions.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.chart1.DataBindings = null;
            this.chart1.Dock = System.Windows.Forms.DockStyle.Left;
            this.chart1.FillStyle.FillMode = DevExpress.XtraCharts.FillMode.Hatch;
            hatchFillOptions1.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            hatchFillOptions1.HatchStyle = System.Drawing.Drawing2D.HatchStyle.Divot;
            hatchFillOptions1.Tag = "Bểu đồ a";
            this.chart1.FillStyle.Options = hatchFillOptions1;
            this.chart1.FillStyle.Tag = "Bểu đồ a";
            this.chart1.IndicatorsPaletteName = "Northern Lights";
            this.chart1.Legend.Name = "Default Legend";
            this.chart1.Location = new System.Drawing.Point(0, 0);
            this.chart1.Name = "chart1";
            this.chart1.PaletteName = "Chameleon";
            this.chart1.SeriesSerializable = new DevExpress.XtraCharts.Series[0];
            this.chart1.Size = new System.Drawing.Size(1040, 323);
            this.chart1.TabIndex = 0;
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // btnXem
            // 
            this.btnXem.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnXem.Location = new System.Drawing.Point(94, 174);
            this.btnXem.Name = "btnXem";
            this.btnXem.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnXem.Size = new System.Drawing.Size(76, 27);
            this.btnXem.TabIndex = 1;
            this.btnXem.Text = "Xem";
            this.btnXem.UseVisualStyleBackColor = false;
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.layoutControl2);
            this.groupControl2.Location = new System.Drawing.Point(3, 0);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(1051, 176);
            this.groupControl2.TabIndex = 10;
            this.groupControl2.Text = "Thời gian";
            // 
            // layoutControl2
            // 
            this.layoutControl2.Controls.Add(this.rdo2);
            this.layoutControl2.Controls.Add(this.rdo1);
            this.layoutControl2.Controls.Add(this.cmbXemTheo);
            this.layoutControl2.Controls.Add(this.cmbThang);
            this.layoutControl2.Controls.Add(this.cmbQuy);
            this.layoutControl2.Controls.Add(this.cmbNam);
            this.layoutControl2.Controls.Add(this.dtpBatDau);
            this.layoutControl2.Controls.Add(this.dtpKetThuc);
            this.layoutControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl2.Location = new System.Drawing.Point(2, 20);
            this.layoutControl2.Name = "layoutControl2";
            this.layoutControl2.Root = this.layoutControlGroup2;
            this.layoutControl2.Size = new System.Drawing.Size(1047, 154);
            this.layoutControl2.TabIndex = 0;
            this.layoutControl2.Text = "layoutControl2";
            // 
            // rdo2
            // 
            this.rdo2.Location = new System.Drawing.Point(12, 115);
            this.rdo2.Name = "rdo2";
            this.rdo2.Padding = new System.Windows.Forms.Padding(80, 0, 0, 0);
            this.rdo2.Size = new System.Drawing.Size(1023, 25);
            this.rdo2.TabIndex = 44;
            this.rdo2.TabStop = true;
            this.rdo2.Text = "Top sản phẩm nhập có giá trị lớn nhất";
            this.rdo2.UseVisualStyleBackColor = true;
            // 
            // rdo1
            // 
            this.rdo1.Location = new System.Drawing.Point(12, 86);
            this.rdo1.Name = "rdo1";
            this.rdo1.Padding = new System.Windows.Forms.Padding(80, 0, 0, 0);
            this.rdo1.Size = new System.Drawing.Size(1023, 25);
            this.rdo1.TabIndex = 43;
            this.rdo1.TabStop = true;
            this.rdo1.Text = "Top sản phẩm nhập nhiều nhất";
            this.rdo1.UseVisualStyleBackColor = true;
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
            this.dtpBatDau.Size = new System.Drawing.Size(433, 21);
            this.dtpBatDau.TabIndex = 35;
            // 
            // dtpKetThuc
            // 
            this.dtpKetThuc.Enabled = false;
            this.dtpKetThuc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpKetThuc.Location = new System.Drawing.Point(603, 62);
            this.dtpKetThuc.Name = "dtpKetThuc";
            this.dtpKetThuc.Size = new System.Drawing.Size(432, 21);
            this.dtpKetThuc.TabIndex = 33;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup2.GroupBordersVisible = false;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lblThang,
            this.lblNBD,
            this.layoutControlItem10,
            this.lblQuy,
            this.lblNam,
            this.lblNKT,
            this.layoutControlItem3,
            this.layoutControlItem1});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "Root";
            this.layoutControlGroup2.Size = new System.Drawing.Size(1047, 154);
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
            this.lblNBD.Size = new System.Drawing.Size(514, 24);
            this.lblNBD.Text = "Ngày băt đầu :";
            this.lblNBD.TextSize = new System.Drawing.Size(74, 13);
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
            // lblNKT
            // 
            this.lblNKT.Control = this.dtpKetThuc;
            this.lblNKT.Location = new System.Drawing.Point(514, 50);
            this.lblNKT.Name = "lblNKT";
            this.lblNKT.Size = new System.Drawing.Size(513, 24);
            this.lblNKT.Text = "Ngày kết thúc :";
            this.lblNKT.TextSize = new System.Drawing.Size(74, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.rdo1;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 74);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(1027, 29);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.rdo2;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 103);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(1027, 31);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
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
            // chartHangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabNhanVien);
            this.Name = "chartHangNhap";
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
            ((System.ComponentModel.ISupportInitialize)(this.lblThang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblNBD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblQuy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblNam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblNKT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraBars.Navigation.TabPane tabNhanVien;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNV;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.Bar bar1;
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
        private System.Windows.Forms.Panel pnlChart;
        private DevExpress.XtraCharts.ChartControl chart1;
        private System.Windows.Forms.RadioButton rdo2;
        private System.Windows.Forms.RadioButton rdo1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
    }
}
