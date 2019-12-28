using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuanLyBanHang
{
    public partial class frmChinh : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public frmChinh()
        {
            InitializeComponent();
        }

        private void DangXuat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Hãy chắc rằng bạn đã lưu lại toàn bộ dữ liệu", "Thoát ứng dụng", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void ThoatUngDung_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Hãy chắc rằng bạn đã lưu lại toàn bộ dữ liệu", "Thoát ứng dụng", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
