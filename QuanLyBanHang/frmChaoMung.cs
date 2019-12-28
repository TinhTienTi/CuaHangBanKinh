using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace QuanLyBanHang
{
    public partial class frmChaoMung : Form
    {
        public frmChaoMung()
        {
            InitializeComponent();
        }

        private void frmChaoMung_Load(object sender, EventArgs e)
        {
            
                lbQuenMatKhau.ForeColor = label1.ForeColor = lbTenNV.ForeColor = Color.White;
                panel1.BackColor = lbTenNV.BackColor = label1.BackColor = Color.FromArgb(32,32,32);
                pnTren.BackColor = lbQuenMatKhau.BackColor = pb.BackColor = Color.FromArgb(0,0,0);
            //lbTenNV.Text = UserLoginCache.FRISTNAME + " " + UserLoginCache.LASTNAME;
            timer1.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            this.Opacity -= 0.1;
            if (this.Opacity == 0)
            {
                timer2.Stop();
                this.Close();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 1) this.Opacity += 0.05;
            processBar.Value += 1;
            processBar.Text = processBar.Value.ToString();
            if (processBar.Value == 100)
            {
                timer1.Stop();
                timer2.Start();
            }
        }
    }
}
