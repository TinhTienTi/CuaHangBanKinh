namespace QuanLyBanHang
{
    partial class frmDangNhap
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDangNhap));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnThuNho = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnThoat = new Bunifu.Framework.UI.BunifuImageButton();
            this.lbDangNhap = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.txtTenDangNhap = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtMatKhau = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.linkQuenMatKhau = new System.Windows.Forms.LinkLabel();
            this.lbError = new System.Windows.Forms.Label();
            this.btnOKE = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuDragControl2 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuDragControl3 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnThuNho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnThoat)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.btnThuNho);
            this.panel1.Controls.Add(this.btnThoat);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(359, 35);
            this.panel1.TabIndex = 0;
            // 
            // btnThuNho
            // 
            this.btnThuNho.BackColor = System.Drawing.Color.Black;
            this.btnThuNho.Image = global::QuanLyBanHang.Properties.Resources.minimazar;
            this.btnThuNho.ImageActive = null;
            this.btnThuNho.Location = new System.Drawing.Point(294, 2);
            this.btnThuNho.Name = "btnThuNho";
            this.btnThuNho.Size = new System.Drawing.Size(30, 30);
            this.btnThuNho.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnThuNho.TabIndex = 2;
            this.btnThuNho.TabStop = false;
            this.btnThuNho.Zoom = 10;
            this.btnThuNho.Click += new System.EventHandler(this.btnThuNho_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.Black;
            this.btnThoat.Image = global::QuanLyBanHang.Properties.Resources.cerrar;
            this.btnThoat.ImageActive = null;
            this.btnThoat.Location = new System.Drawing.Point(327, 2);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(30, 30);
            this.btnThoat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnThoat.TabIndex = 1;
            this.btnThoat.TabStop = false;
            this.btnThoat.Zoom = 10;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // lbDangNhap
            // 
            this.lbDangNhap.AutoSize = true;
            this.lbDangNhap.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDangNhap.ForeColor = System.Drawing.Color.White;
            this.lbDangNhap.Location = new System.Drawing.Point(92, 62);
            this.lbDangNhap.Name = "lbDangNhap";
            this.lbDangNhap.Size = new System.Drawing.Size(176, 39);
            this.lbDangNhap.TabIndex = 0;
            this.lbDangNhap.Text = "Đăng Nhập";
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 10;
            this.bunifuElipse1.TargetControl = this;
            // 
            // txtTenDangNhap
            // 
            this.txtTenDangNhap.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(255)))));
            this.txtTenDangNhap.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTenDangNhap.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(122)))), ((int)(((byte)(255)))));
            this.txtTenDangNhap.BorderThickness = 3;
            this.txtTenDangNhap.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenDangNhap.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtTenDangNhap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTenDangNhap.isPassword = false;
            this.txtTenDangNhap.Location = new System.Drawing.Point(14, 146);
            this.txtTenDangNhap.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenDangNhap.Name = "txtTenDangNhap";
            this.txtTenDangNhap.Size = new System.Drawing.Size(333, 44);
            this.txtTenDangNhap.TabIndex = 1;
            this.txtTenDangNhap.Text = "Tên đăng nhập";
            this.txtTenDangNhap.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTenDangNhap.Enter += new System.EventHandler(this.txtTenDangNhap_Enter);
            this.txtTenDangNhap.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTenDangNhap_KeyPress);
            this.txtTenDangNhap.Leave += new System.EventHandler(this.txtTenDangNhap_Leave);
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(255)))));
            this.txtMatKhau.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtMatKhau.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(122)))), ((int)(((byte)(255)))));
            this.txtMatKhau.BorderThickness = 3;
            this.txtMatKhau.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMatKhau.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtMatKhau.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtMatKhau.isPassword = false;
            this.txtMatKhau.Location = new System.Drawing.Point(14, 198);
            this.txtMatKhau.Margin = new System.Windows.Forms.Padding(4);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(333, 44);
            this.txtMatKhau.TabIndex = 2;
            this.txtMatKhau.Text = "Mật khẩu";
            this.txtMatKhau.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtMatKhau.Enter += new System.EventHandler(this.txtMatKhau_Enter);
            this.txtMatKhau.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMatKhau_KeyPress);
            this.txtMatKhau.Leave += new System.EventHandler(this.txtMatKhau_Leave);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panel1;
            this.bunifuDragControl1.Vertical = true;
            // 
            // linkQuenMatKhau
            // 
            this.linkQuenMatKhau.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.linkQuenMatKhau.AutoSize = true;
            this.linkQuenMatKhau.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(122)))), ((int)(((byte)(255)))));
            this.linkQuenMatKhau.Location = new System.Drawing.Point(131, 341);
            this.linkQuenMatKhau.Name = "linkQuenMatKhau";
            this.linkQuenMatKhau.Size = new System.Drawing.Size(99, 15);
            this.linkQuenMatKhau.TabIndex = 4;
            this.linkQuenMatKhau.TabStop = true;
            this.linkQuenMatKhau.Text = "Quên mật khẩu?";
            this.linkQuenMatKhau.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.linkQuenMatKhau.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkQuenMatKhau_LinkClicked);
            // 
            // lbError
            // 
            this.lbError.AutoSize = true;
            this.lbError.ForeColor = System.Drawing.Color.Red;
            this.lbError.Location = new System.Drawing.Point(14, 250);
            this.lbError.Name = "lbError";
            this.lbError.Size = new System.Drawing.Size(41, 15);
            this.lbError.TabIndex = 5;
            this.lbError.Text = "label2";
            // 
            // btnOKE
            // 
            this.btnOKE.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(122)))), ((int)(((byte)(255)))));
            this.btnOKE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(147)))));
            this.btnOKE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOKE.BorderRadius = 0;
            this.btnOKE.ButtonText = "                                Đồng ý";
            this.btnOKE.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOKE.DisabledColor = System.Drawing.Color.Gray;
            this.btnOKE.ForeColor = System.Drawing.Color.Black;
            this.btnOKE.Iconcolor = System.Drawing.Color.Transparent;
            this.btnOKE.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnOKE.Iconimage")));
            this.btnOKE.Iconimage_right = null;
            this.btnOKE.Iconimage_right_Selected = null;
            this.btnOKE.Iconimage_Selected = null;
            this.btnOKE.IconMarginLeft = 0;
            this.btnOKE.IconMarginRight = 0;
            this.btnOKE.IconRightVisible = true;
            this.btnOKE.IconRightZoom = 0D;
            this.btnOKE.IconVisible = true;
            this.btnOKE.IconZoom = 50D;
            this.btnOKE.IsTab = true;
            this.btnOKE.Location = new System.Drawing.Point(14, 271);
            this.btnOKE.Name = "btnOKE";
            this.btnOKE.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(147)))));
            this.btnOKE.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(122)))), ((int)(((byte)(255)))));
            this.btnOKE.OnHoverTextColor = System.Drawing.Color.White;
            this.btnOKE.selected = false;
            this.btnOKE.Size = new System.Drawing.Size(333, 43);
            this.btnOKE.TabIndex = 3;
            this.btnOKE.Text = "                                Đồng ý";
            this.btnOKE.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOKE.Textcolor = System.Drawing.Color.Black;
            this.btnOKE.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOKE.Click += new System.EventHandler(this.btnOKE_Click);
            // 
            // bunifuDragControl2
            // 
            this.bunifuDragControl2.Fixed = true;
            this.bunifuDragControl2.Horizontal = true;
            this.bunifuDragControl2.TargetControl = this.lbDangNhap;
            this.bunifuDragControl2.Vertical = true;
            // 
            // bunifuDragControl3
            // 
            this.bunifuDragControl3.Fixed = true;
            this.bunifuDragControl3.Horizontal = true;
            this.bunifuDragControl3.TargetControl = this;
            this.bunifuDragControl3.Vertical = true;
            // 
            // frmDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(359, 536);
            this.Controls.Add(this.lbError);
            this.Controls.Add(this.linkQuenMatKhau);
            this.Controls.Add(this.btnOKE);
            this.Controls.Add(this.txtMatKhau);
            this.Controls.Add(this.txtTenDangNhap);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbDangNhap);
            this.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(53)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDangNhap";
            this.Load += new System.EventHandler(this.frmDangNhap_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnThuNho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnThoat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbDangNhap;
        private Bunifu.Framework.UI.BunifuImageButton btnThoat;
        private Bunifu.Framework.UI.BunifuImageButton btnThuNho;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtTenDangNhap;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtMatKhau;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuFlatButton btnOKE;
        private System.Windows.Forms.LinkLabel linkQuenMatKhau;
        private System.Windows.Forms.Label lbError;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl3;
    }
}