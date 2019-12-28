namespace QuanLyBanHang
{
    partial class frmQuenMatKhau
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuenMatKhau));
            this.pnTren = new System.Windows.Forms.Panel();
            this.lbQuenMatKhau = new System.Windows.Forms.Label();
            this.btnThuNho = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnThoat = new Bunifu.Framework.UI.BunifuImageButton();
            this.pnGiua = new System.Windows.Forms.Panel();
            this.lbResult = new System.Windows.Forms.Label();
            this.btnDongY = new System.Windows.Forms.Button();
            this.txtEmail = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuDragControl2 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuDragControl3 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pnTren.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnThuNho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnThoat)).BeginInit();
            this.pnGiua.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnTren
            // 
            this.pnTren.BackColor = System.Drawing.Color.Black;
            this.pnTren.Controls.Add(this.lbQuenMatKhau);
            this.pnTren.Controls.Add(this.btnThuNho);
            this.pnTren.Controls.Add(this.btnThoat);
            this.pnTren.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTren.ForeColor = System.Drawing.Color.White;
            this.pnTren.Location = new System.Drawing.Point(0, 0);
            this.pnTren.Name = "pnTren";
            this.pnTren.Size = new System.Drawing.Size(537, 35);
            this.pnTren.TabIndex = 1;
            // 
            // lbQuenMatKhau
            // 
            this.lbQuenMatKhau.AutoSize = true;
            this.lbQuenMatKhau.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQuenMatKhau.Location = new System.Drawing.Point(3, 9);
            this.lbQuenMatKhau.Name = "lbQuenMatKhau";
            this.lbQuenMatKhau.Size = new System.Drawing.Size(127, 19);
            this.lbQuenMatKhau.TabIndex = 4;
            this.lbQuenMatKhau.Text = "Lấy lại mật khẩu";
            // 
            // btnThuNho
            // 
            this.btnThuNho.BackColor = System.Drawing.Color.Black;
            this.btnThuNho.Image = global::QuanLyBanHang.Properties.Resources.minimazar;
            this.btnThuNho.ImageActive = null;
            this.btnThuNho.Location = new System.Drawing.Point(470, 2);
            this.btnThuNho.Name = "btnThuNho";
            this.btnThuNho.Size = new System.Drawing.Size(30, 30);
            this.btnThuNho.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnThuNho.TabIndex = 1;
            this.btnThuNho.TabStop = false;
            this.btnThuNho.Zoom = 10;
            this.btnThuNho.Click += new System.EventHandler(this.btnThuNho_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.Black;
            this.btnThoat.Image = global::QuanLyBanHang.Properties.Resources.cerrar;
            this.btnThoat.ImageActive = null;
            this.btnThoat.Location = new System.Drawing.Point(502, 2);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(30, 30);
            this.btnThoat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnThoat.TabIndex = 0;
            this.btnThoat.TabStop = false;
            this.btnThoat.Zoom = 10;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // pnGiua
            // 
            this.pnGiua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.pnGiua.Controls.Add(this.lbResult);
            this.pnGiua.Controls.Add(this.btnDongY);
            this.pnGiua.Controls.Add(this.txtEmail);
            this.pnGiua.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnGiua.ForeColor = System.Drawing.Color.White;
            this.pnGiua.Location = new System.Drawing.Point(0, 35);
            this.pnGiua.Name = "pnGiua";
            this.pnGiua.Size = new System.Drawing.Size(537, 171);
            this.pnGiua.TabIndex = 6;
            // 
            // lbResult
            // 
            this.lbResult.AutoSize = true;
            this.lbResult.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbResult.Location = new System.Drawing.Point(14, 90);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(43, 15);
            this.lbResult.TabIndex = 8;
            this.lbResult.Text = "Result";
            // 
            // btnDongY
            // 
            this.btnDongY.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnDongY.FlatAppearance.BorderSize = 0;
            this.btnDongY.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDongY.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDongY.Location = new System.Drawing.Point(408, 34);
            this.btnDongY.Name = "btnDongY";
            this.btnDongY.Size = new System.Drawing.Size(122, 48);
            this.btnDongY.TabIndex = 7;
            this.btnDongY.Text = "Đồng ý";
            this.btnDongY.UseVisualStyleBackColor = false;
            this.btnDongY.Click += new System.EventHandler(this.btnDongY_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(255)))));
            this.txtEmail.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtEmail.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(122)))), ((int)(((byte)(255)))));
            this.txtEmail.BorderThickness = 1;
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.Color.White;
            this.txtEmail.isPassword = false;
            this.txtEmail.Location = new System.Drawing.Point(13, 34);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(388, 48);
            this.txtEmail.TabIndex = 6;
            this.txtEmail.Text = "Nhập email của bạn tại đây";
            this.txtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtEmail.Enter += new System.EventHandler(this.txtTenDangNhap_Enter);
            this.txtEmail.Leave += new System.EventHandler(this.txtTenDangNhap_Leave);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.pnTren;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuDragControl2
            // 
            this.bunifuDragControl2.Fixed = true;
            this.bunifuDragControl2.Horizontal = true;
            this.bunifuDragControl2.TargetControl = this.pnGiua;
            this.bunifuDragControl2.Vertical = true;
            // 
            // bunifuDragControl3
            // 
            this.bunifuDragControl3.Fixed = true;
            this.bunifuDragControl3.Horizontal = true;
            this.bunifuDragControl3.TargetControl = this.lbQuenMatKhau;
            this.bunifuDragControl3.Vertical = true;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 10;
            this.bunifuElipse1.TargetControl = this;
            // 
            // frmQuenMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(537, 206);
            this.Controls.Add(this.pnGiua);
            this.Controls.Add(this.pnTren);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmQuenMatKhau";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quên Mật Khẩu";
            this.Load += new System.EventHandler(this.fmQuenMatKhau_Load);
            this.pnTren.ResumeLayout(false);
            this.pnTren.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnThuNho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnThoat)).EndInit();
            this.pnGiua.ResumeLayout(false);
            this.pnGiua.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnTren;
        private Bunifu.Framework.UI.BunifuImageButton btnThuNho;
        private Bunifu.Framework.UI.BunifuImageButton btnThoat;
        private System.Windows.Forms.Label lbQuenMatKhau;
        private System.Windows.Forms.Panel pnGiua;
        private System.Windows.Forms.Label lbResult;
        private System.Windows.Forms.Button btnDongY;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtEmail;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl3;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
    }
}