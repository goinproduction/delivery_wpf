using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Adim;
using System.Data.SqlClient;

namespace Adim
{
    public partial class XoaTaiKhoanAdmin : Form
    {
        SqlConnection conn;
        String deleteAccountName;
        String passWordAdmin;
        public XoaTaiKhoanAdmin(SqlConnection conn)
        {
            this.conn = conn;
            InitializeComponent();
        }

        private void XoaAdminButton_Click(object sender, EventArgs e)
        {
            try
            {
                if(this.TenDangNhapMuonXoaAdminSubTextbox.Text.Length == 0)
                {
                    throw new Exception("Delete account name is not empty");
                }

                if (this.MatKhauQuanTriAdminSubTextBox.Text.Length == 0)
                {
                    throw new Exception("Admin password is not empty");
                }

                String sqlDeleteOnTableAccount = "delete account where Account_Name = '" + deleteAccountName + "'";
                

            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
