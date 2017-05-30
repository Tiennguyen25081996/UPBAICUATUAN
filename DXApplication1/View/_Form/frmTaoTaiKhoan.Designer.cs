namespace DXApplication1.View._Form
{
    partial class frmTaoTaiKhoan
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.txtTenDN = new DevExpress.XtraEditors.TextEdit();
            this.txtTenDangNhap = new DevExpress.XtraLayout.LayoutControlItem();
            this.txtMK = new DevExpress.XtraEditors.TextEdit();
            this.txtMatKhau = new DevExpress.XtraLayout.LayoutControlItem();
            this.txtMK2 = new DevExpress.XtraEditors.TextEdit();
            this.txtNhapLai = new DevExpress.XtraLayout.LayoutControlItem();
            this.btnDangKy = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.cmbQuyen = new System.Windows.Forms.ComboBox();
            this.layoutQuyen = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenDN.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenDangNhap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMK.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMatKhau)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMK2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNhapLai)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutQuyen)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.cmbQuyen);
            this.layoutControl1.Controls.Add(this.txtTenDN);
            this.layoutControl1.Controls.Add(this.txtMK);
            this.layoutControl1.Controls.Add(this.txtMK2);
            this.layoutControl1.Location = new System.Drawing.Point(51, 47);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(317, 120);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.txtTenDangNhap,
            this.txtMatKhau,
            this.txtNhapLai,
            this.layoutQuyen});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(317, 120);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // txtTenDN
            // 
            this.txtTenDN.Location = new System.Drawing.Point(105, 12);
            this.txtTenDN.Name = "txtTenDN";
            this.txtTenDN.Size = new System.Drawing.Size(200, 20);
            this.txtTenDN.StyleController = this.layoutControl1;
            this.txtTenDN.TabIndex = 4;
            // 
            // txtTenDangNhap
            // 
            this.txtTenDangNhap.Control = this.txtTenDN;
            this.txtTenDangNhap.Location = new System.Drawing.Point(0, 0);
            this.txtTenDangNhap.Name = "txtTenDangNhap";
            this.txtTenDangNhap.Size = new System.Drawing.Size(297, 24);
            this.txtTenDangNhap.Text = "Tên đăng nhập:";
            this.txtTenDangNhap.TextSize = new System.Drawing.Size(89, 13);
            // 
            // txtMK
            // 
            this.txtMK.Location = new System.Drawing.Point(105, 36);
            this.txtMK.Name = "txtMK";
            this.txtMK.Size = new System.Drawing.Size(200, 20);
            this.txtMK.StyleController = this.layoutControl1;
            this.txtMK.TabIndex = 5;
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Control = this.txtMK;
            this.txtMatKhau.Location = new System.Drawing.Point(0, 24);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(297, 24);
            this.txtMatKhau.Text = "Mặt khẩu:";
            this.txtMatKhau.TextSize = new System.Drawing.Size(89, 13);
            // 
            // txtMK2
            // 
            this.txtMK2.Location = new System.Drawing.Point(105, 60);
            this.txtMK2.Name = "txtMK2";
            this.txtMK2.Size = new System.Drawing.Size(200, 20);
            this.txtMK2.StyleController = this.layoutControl1;
            this.txtMK2.TabIndex = 6;
            // 
            // txtNhapLai
            // 
            this.txtNhapLai.Control = this.txtMK2;
            this.txtNhapLai.Location = new System.Drawing.Point(0, 48);
            this.txtNhapLai.Name = "txtNhapLai";
            this.txtNhapLai.Size = new System.Drawing.Size(297, 24);
            this.txtNhapLai.Text = "Nhập lại mật khẩu:";
            this.txtNhapLai.TextSize = new System.Drawing.Size(89, 13);
            // 
            // btnDangKy
            // 
            this.btnDangKy.Location = new System.Drawing.Point(111, 174);
            this.btnDangKy.Name = "btnDangKy";
            this.btnDangKy.Size = new System.Drawing.Size(75, 23);
            this.btnDangKy.TabIndex = 1;
            this.btnDangKy.Text = "Đăng ký";
            this.btnDangKy.UseVisualStyleBackColor = true;
            this.btnDangKy.Click += new System.EventHandler(this.btnDangKy_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(215, 173);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 23);
            this.btnHuy.TabIndex = 2;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // cmbQuyen
            // 
            this.cmbQuyen.FormattingEnabled = true;
            this.cmbQuyen.Location = new System.Drawing.Point(105, 84);
            this.cmbQuyen.Name = "cmbQuyen";
            this.cmbQuyen.Size = new System.Drawing.Size(200, 21);
            this.cmbQuyen.TabIndex = 7;
            // 
            // layoutQuyen
            // 
            this.layoutQuyen.Control = this.cmbQuyen;
            this.layoutQuyen.Location = new System.Drawing.Point(0, 72);
            this.layoutQuyen.Name = "layoutQuyen";
            this.layoutQuyen.Size = new System.Drawing.Size(297, 28);
            this.layoutQuyen.Text = "Quyền:";
            this.layoutQuyen.TextSize = new System.Drawing.Size(89, 13);
            // 
            // frmTaoTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 226);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnDangKy);
            this.Controls.Add(this.layoutControl1);
            this.Name = "frmTaoTaiKhoan";
            this.Text = "Tạo tài khoản mới";
            this.Load += new System.EventHandler(this.frmTaoTaiKhoan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenDN.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenDangNhap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMK.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMatKhau)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMK2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNhapLai)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutQuyen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.TextEdit txtTenDN;
        private DevExpress.XtraEditors.TextEdit txtMK;
        private DevExpress.XtraEditors.TextEdit txtMK2;
        private DevExpress.XtraLayout.LayoutControlItem txtTenDangNhap;
        private DevExpress.XtraLayout.LayoutControlItem txtMatKhau;
        private DevExpress.XtraLayout.LayoutControlItem txtNhapLai;
        private System.Windows.Forms.Button btnDangKy;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.ComboBox cmbQuyen;
        private DevExpress.XtraLayout.LayoutControlItem layoutQuyen;
    }
}