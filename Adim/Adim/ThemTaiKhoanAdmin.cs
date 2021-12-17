using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Adim
{
    public partial class ThemTaiKhoanAdmin : Form
    {
        String TenDangNhapString = "";
        public ThemTaiKhoanAdmin()
        {
            InitializeComponent();
        }

        private void TenDangNhapAdminSubTextbox_MouseClick(object sender, MouseEventArgs e)
        {
            this.TenDangNhapAdminSubTextbox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.TenDangNhapAdminSubTextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TenDangNhapAdminSubTextbox.Text = this.TenDangNhapString;

        }

        private void TenDangNhapAdminSubTextbox_MouseLeave(object sender, EventArgs e)
        {
            this.TenDangNhapString = this.TenDangNhapAdminSubTextbox.Text;
        }
    }
}
