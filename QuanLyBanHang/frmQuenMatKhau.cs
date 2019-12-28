using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain;
namespace QuanLyBanHang
{
    public partial class frmQuenMatKhau : Form
    {
        public frmQuenMatKhau()
        {
            InitializeComponent();
        }

        private void mauSang()
        {
            btnThoat.BackColor = btnThuNho.BackColor= pnTren.BackColor = lbQuenMatKhau.BackColor = Color.FromArgb(240,240,240);
            txtEmail.ForeColor = lbQuenMatKhau.ForeColor = Color.Black;
            lbResult.ForeColor = Color.Red;
            pnGiua.BackColor = lbResult.BackColor = Color.White;
           
        }
        private void mauToi()
        {
            btnThoat.BackColor = btnThuNho.BackColor = pnTren.BackColor = lbQuenMatKhau.BackColor = Color.FromArgb(0,0,0);
            txtEmail.ForeColor = lbQuenMatKhau.ForeColor = Color.White;
            lbResult.ForeColor = Color.Red;
            pnGiua.BackColor = lbResult.BackColor = Color.FromArgb(32,32,32);
        }
        private void fmQuenMatKhau_Load(object sender, EventArgs e)
        {
            lbResult.Visible = false;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            frmDangNhap f = new frmDangNhap();
            f.Show();
            this.Hide();
        }

        private void btnThuNho_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void txtTenDangNhap_Enter(object sender, EventArgs e)
        {
            if(txtEmail.Text == "Nhập email của bạn tại đây")
            {
                txtEmail.Text = "";
            }
        }

        private void txtTenDangNhap_Leave(object sender, EventArgs e)
        {
            if (txtEmail.Text == "")
                txtEmail.Text = "Nhập email của bạn tại đây";
        }

        private void btnDongY_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text == "")
            {
                MessageBox.Show("Bạn cần nhập email của mình để lấy lại mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                var user = new UserModel();
                var result = user.recoverPassword(txtEmail.Text);
                lbResult.Visible = true;
                lbResult.Text = result;
            }
        }
    }
}
