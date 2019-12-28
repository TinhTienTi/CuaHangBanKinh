namespace QuanLyBanHang
{
    partial class frmChinh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChinh));
            this.fluentDesignFormContainer1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer();
            this.accordionControl1 = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.ctlDanhMuc = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.ctlBanHang = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.ctlNhanVien = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.ctlKhachHang = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.ctlThongTin = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.ctlDangXuat = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.DangXuat = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.ThoatUngDung = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.fluentDesignFormControl1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // fluentDesignFormContainer1
            // 
            this.fluentDesignFormContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fluentDesignFormContainer1.Location = new System.Drawing.Point(40, 27);
            this.fluentDesignFormContainer1.Margin = new System.Windows.Forms.Padding(2);
            this.fluentDesignFormContainer1.Name = "fluentDesignFormContainer1";
            this.fluentDesignFormContainer1.Size = new System.Drawing.Size(1103, 508);
            this.fluentDesignFormContainer1.TabIndex = 0;
            // 
            // accordionControl1
            // 
            this.accordionControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.accordionControl1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.ctlDanhMuc,
            this.ctlBanHang,
            this.ctlNhanVien,
            this.ctlKhachHang,
            this.ctlThongTin,
            this.ctlDangXuat});
            this.accordionControl1.Location = new System.Drawing.Point(0, 27);
            this.accordionControl1.Margin = new System.Windows.Forms.Padding(2);
            this.accordionControl1.Name = "accordionControl1";
            this.accordionControl1.OptionsMinimizing.State = DevExpress.XtraBars.Navigation.AccordionControlState.Minimized;
            this.accordionControl1.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Touch;
            this.accordionControl1.Size = new System.Drawing.Size(40, 508);
            this.accordionControl1.TabIndex = 1;
            this.accordionControl1.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu;
            // 
            // ctlDanhMuc
            // 
            this.ctlDanhMuc.Name = "ctlDanhMuc";
            this.ctlDanhMuc.Text = "Danh Mục";
            // 
            // ctlBanHang
            // 
            this.ctlBanHang.Name = "ctlBanHang";
            this.ctlBanHang.Text = "Bán hàng";
            // 
            // ctlNhanVien
            // 
            this.ctlNhanVien.Name = "ctlNhanVien";
            this.ctlNhanVien.Text = "Nhân viên";
            // 
            // ctlKhachHang
            // 
            this.ctlKhachHang.Name = "ctlKhachHang";
            this.ctlKhachHang.Text = "Khách Hàng";
            // 
            // ctlThongTin
            // 
            this.ctlThongTin.Name = "ctlThongTin";
            this.ctlThongTin.Text = "Thông tin";
            // 
            // ctlDangXuat
            // 
            this.ctlDangXuat.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.DangXuat,
            this.ThoatUngDung});
            this.ctlDangXuat.Name = "ctlDangXuat";
            this.ctlDangXuat.Text = "Đăng xuất";
            // 
            // DangXuat
            // 
            this.DangXuat.Name = "DangXuat";
            this.DangXuat.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.DangXuat.Text = "Đăng xuất";
            this.DangXuat.Click += new System.EventHandler(this.DangXuat_Click);
            // 
            // ThoatUngDung
            // 
            this.ThoatUngDung.Name = "ThoatUngDung";
            this.ThoatUngDung.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.ThoatUngDung.Text = "Thoát ứng dụng";
            this.ThoatUngDung.Click += new System.EventHandler(this.ThoatUngDung_Click);
            // 
            // fluentDesignFormControl1
            // 
            this.fluentDesignFormControl1.FluentDesignForm = this;
            this.fluentDesignFormControl1.Location = new System.Drawing.Point(0, 0);
            this.fluentDesignFormControl1.Margin = new System.Windows.Forms.Padding(2);
            this.fluentDesignFormControl1.Name = "fluentDesignFormControl1";
            this.fluentDesignFormControl1.Size = new System.Drawing.Size(1143, 27);
            this.fluentDesignFormControl1.TabIndex = 2;
            this.fluentDesignFormControl1.TabStop = false;
            // 
            // frmChinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 535);
            this.ControlContainer = this.fluentDesignFormContainer1;
            this.Controls.Add(this.fluentDesignFormContainer1);
            this.Controls.Add(this.accordionControl1);
            this.Controls.Add(this.fluentDesignFormControl1);
            this.FluentDesignFormControl = this.fluentDesignFormControl1;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmChinh";
            this.NavigationControl = this.accordionControl1;
            this.Text = "Bán hàng";
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer fluentDesignFormContainer1;
        private DevExpress.XtraBars.Navigation.AccordionControl accordionControl1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement ctlDanhMuc;
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl fluentDesignFormControl1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement ctlBanHang;
        private DevExpress.XtraBars.Navigation.AccordionControlElement ctlNhanVien;
        private DevExpress.XtraBars.Navigation.AccordionControlElement ctlKhachHang;
        private DevExpress.XtraBars.Navigation.AccordionControlElement ctlThongTin;
        private DevExpress.XtraBars.Navigation.AccordionControlElement ctlDangXuat;
        private DevExpress.XtraBars.Navigation.AccordionControlElement DangXuat;
        private DevExpress.XtraBars.Navigation.AccordionControlElement ThoatUngDung;
    }
}

