using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain;
namespace QuanLyBanHang
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn thật sự muốn thoát?","Thoát ứng dụng",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnThuNho_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void txtTenDangNhap_Enter(object sender, EventArgs e)
        {
            if(txtTenDangNhap.Text == "Tên đăng nhập")
            {
                txtTenDangNhap.Text = "";
                txtTenDangNhap.ForeColor = Color.White;
            }
        }

        private void txtTenDangNhap_Leave(object sender, EventArgs e)
        {
            if(txtTenDangNhap.Text == "")
            {
                txtTenDangNhap.Text = "Tên đăng nhập";
                txtTenDangNhap.ForeColor = Color.FromArgb(71,71,71);
            }
        }

        private void txtMatKhau_Enter(object sender, EventArgs e)
        {
            if(txtMatKhau.Text == "Mật khẩu")
            {
                txtMatKhau.Text = "";
                txtMatKhau.isPassword = true;
                txtMatKhau.ForeColor = Color.White;
            }
        }

        private void txtMatKhau_Leave(object sender, EventArgs e)
        {
            if(txtMatKhau.Text == "")
            {
                txtMatKhau.Text = "Mật khẩu";
                txtMatKhau.isPassword = false;
                txtMatKhau.ForeColor = Color.FromArgb(71,71,71);
            }
        }

        private void txtTenDangNhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            var regex = new Regex(@"[^a-zA-Z0-9\b\s]");
            if(regex.IsMatch(e.KeyChar.ToString()))
            {
                e.Handled = true;
            }
        }

        private void txtMatKhau_KeyPress(object sender, KeyPressEventArgs e)
        {
            var regex = new Regex(@"[^a-zA-Z0-9\b\s]");
            if (regex.IsMatch(e.KeyChar.ToString()))
            {
                e.Handled = true;
            }
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            lbError.Visible = false;
        }

        private void linkQuenMatKhau_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmQuenMatKhau f = new frmQuenMatKhau();
            f.Show();
            this.Hide();
        }
        public static string taiKhoan;
        string hash = "t47@l54";
        string pass;
        private void btnOKE_Click(object sender, EventArgs e)
        {
            if (txtTenDangNhap.Text != "Username")
            {
                if (txtMatKhau.Text != "Password")
                {
                    //// mã hoá mật khẩu
                    //byte[] data = UTF8Encoding.UTF8.GetBytes(txtMatKhau.Text);
                    //using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
                    //{
                    //    byte[] key = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));
                    //    using (TripleDESCryptoServiceProvider tripDES = new TripleDESCryptoServiceProvider() { Key = key, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                    //    {
                    //        ICryptoTransform transform = tripDES.CreateEncryptor();
                    //        byte[] results = transform.TransformFinalBlock(data, 0, data.Length);
                    //        pass = Convert.ToBase64String(results, 0, results.Length);
                    //    }

                    //}
                    //taiKhoan = txtTenDangNhap.Text;
                    UserModel user = new UserModel();
                    var validLogin = user.LoginUser(txtTenDangNhap.Text, txtMatKhau.Text);
                    if (validLogin == true)
                    {
                        this.Hide();
                        frmChaoMung welcome = new frmChaoMung();
                        welcome.ShowDialog();
                        //nkhd.Them(DateTime.Now, "Đăng nhập vào hệ thống bằng tài khoản " + taiKhoan, taiKhoan);
                        frmChinh mainMenu = new frmChinh();
                        mainMenu.Show();
                        mainMenu.FormClosed += Logout;
                    }
                    else
                    {
                        msgError(" Sai username hoặc password. Hãy thử lại.");
                        txtMatKhau.Text = "Password";
                        txtMatKhau.isPassword = false;
                        txtTenDangNhap.Focus();
                    }
                }
                else msgError("Vui lòng nhập password");
            }
            else msgError("Vui lòng nhập username");
        }
        private void msgError(string msg)
        {
            lbError.Text = "         " + msg;
            lbError.Visible = true;
            lbError.ForeColor = Color.FromArgb(255, 69, 58);
        }

        private void Logout(object sender, FormClosedEventArgs e)
        {
            txtMatKhau.Text = "Mật khẩu";
            txtMatKhau.isPassword = false;
            lbError.Visible = false;
            txtTenDangNhap.Text = "Tên đăng nhập";
            this.Show();
            txtTenDangNhap.Focus();
        }
    }
}
