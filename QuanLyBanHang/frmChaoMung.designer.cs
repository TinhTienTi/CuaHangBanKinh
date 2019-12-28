namespace QuanLyBanHang
{
    partial class frmChaoMung
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChaoMung));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pnTren = new System.Windows.Forms.Panel();
            this.lbQuenMatKhau = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.processBar = new Bunifu.Framework.UI.BunifuProgressBar();
            this.lbTenNV = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pb = new System.Windows.Forms.PictureBox();
            this.btnThuNho = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnThoat = new Bunifu.Framework.UI.BunifuImageButton();
            this.pnTren.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnThuNho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnThoat)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 15;
            this.bunifuElipse1.TargetControl = this;
            // 
            // pnTren
            // 
            this.pnTren.BackColor = System.Drawing.SystemColors.Control;
            this.pnTren.Controls.Add(this.pb);
            this.pnTren.Controls.Add(this.lbQuenMatKhau);
            this.pnTren.Controls.Add(this.btnThuNho);
            this.pnTren.Controls.Add(this.btnThoat);
            this.pnTren.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTren.Location = new System.Drawing.Point(0, 0);
            this.pnTren.Name = "pnTren";
            this.pnTren.Size = new System.Drawing.Size(440, 32);
            this.pnTren.TabIndex = 2;
            // 
            // lbQuenMatKhau
            // 
            this.lbQuenMatKhau.AutoSize = true;
            this.lbQuenMatKhau.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQuenMatKhau.Location = new System.Drawing.Point(57, 9);
            this.lbQuenMatKhau.Name = "lbQuenMatKhau";
            this.lbQuenMatKhau.Size = new System.Drawing.Size(95, 19);
            this.lbQuenMatKhau.TabIndex = 4;
            this.lbQuenMatKhau.Text = "Phone Store";
            // 
            // timer1
            // 
            this.timer1.Interval = 15;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 1;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.processBar);
            this.panel1.Controls.Add(this.lbTenNV);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(440, 164);
            this.panel1.TabIndex = 3;
            // 
            // processBar
            // 
            this.processBar.BackColor = System.Drawing.Color.Silver;
            this.processBar.BorderRadius = 5;
            this.processBar.Location = new System.Drawing.Point(21, 123);
            this.processBar.MaximumValue = 100;
            this.processBar.Name = "processBar";
            this.processBar.ProgressColor = System.Drawing.Color.Teal;
            this.processBar.Size = new System.Drawing.Size(405, 12);
            this.processBar.TabIndex = 6;
            this.processBar.Value = 0;
            // 
            // lbTenNV
            // 
            this.lbTenNV.AutoSize = true;
            this.lbTenNV.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenNV.Location = new System.Drawing.Point(94, 50);
            this.lbTenNV.Name = "lbTenNV";
            this.lbTenNV.Size = new System.Drawing.Size(258, 38);
            this.lbTenNV.TabIndex = 5;
            this.lbTenNV.Text = "Nguyễn Duy Tính";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(155, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Chào mừng";
            // 
            // pb
            // 
            this.pb.Dock = System.Windows.Forms.DockStyle.Left;
            this.pb.Image = global::QuanLyBanHang.Properties.Resources.glasses;
            this.pb.Location = new System.Drawing.Point(0, 0);
            this.pb.Name = "pb";
            this.pb.Size = new System.Drawing.Size(51, 32);
            this.pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb.TabIndex = 5;
            this.pb.TabStop = false;
            // 
            // btnThuNho
            // 
            this.btnThuNho.BackColor = System.Drawing.SystemColors.Control;
            this.btnThuNho.Image = global::QuanLyBanHang.Properties.Resources.icon_minimizar;
            this.btnThuNho.ImageActive = null;
            this.btnThuNho.Location = new System.Drawing.Point(470, 2);
            this.btnThuNho.Name = "btnThuNho";
            this.btnThuNho.Size = new System.Drawing.Size(30, 30);
            this.btnThuNho.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnThuNho.TabIndex = 1;
            this.btnThuNho.TabStop = false;
            this.btnThuNho.Zoom = 10;
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.SystemColors.Control;
            this.btnThoat.Image = global::QuanLyBanHang.Properties.Resources.icon_cerrar2;
            this.btnThoat.ImageActive = null;
            this.btnThoat.Location = new System.Drawing.Point(502, 2);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(30, 30);
            this.btnThoat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnThoat.TabIndex = 0;
            this.btnThoat.TabStop = false;
            this.btnThoat.Zoom = 10;
            // 
            // frmChaoMung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(440, 196);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnTren);
            this.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmChaoMung";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tải ứng dụng";
            this.Load += new System.EventHandler(this.frmChaoMung_Load);
            this.pnTren.ResumeLayout(false);
            this.pnTren.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnThuNho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnThoat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel pnTren;
        private System.Windows.Forms.PictureBox pb;
        private System.Windows.Forms.Label lbQuenMatKhau;
        private Bunifu.Framework.UI.BunifuImageButton btnThuNho;
        private Bunifu.Framework.UI.BunifuImageButton btnThoat;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuProgressBar processBar;
        private System.Windows.Forms.Label lbTenNV;
        private System.Windows.Forms.Label label1;
    }
}