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
        String nameAdmin = "ST123";
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

                this.deleteAccountName = this.TenDangNhapMuonXoaAdminSubTextbox.Text;
                this.passWordAdmin = this.MatKhauQuanTriAdminSubTextBox.Text;

                //Check correct account
                if(!Adim.util.checkAccount(nameAdmin, passWordAdmin, 1, conn)) 
                {
                    throw new Exception("Admin password is not correct");
                }

                String sqlDisableConstraintAccount = "alter table Account NOCHECK CONSTRAINT all";
                SqlCommand disableConstaintAccount = new SqlCommand(sqlDisableConstraintAccount, conn);
                disableConstaintAccount.ExecuteNonQuery();
                Adim.util.disableConstraint(2, conn);
                Adim.util.disableConstraint(3, conn);
                Adim.util.disableConstraint(4, conn);
                Adim.util.disableConstraint(5, conn);

                String sqlDeleteOnTableAccount = "delete Account where Account_Name = '" + deleteAccountName + "'";
                SqlCommand deleteOnTableAccount = new SqlCommand(sqlDeleteOnTableAccount, conn);
                deleteOnTableAccount.ExecuteNonQuery();

                String sqlDeleteOnTableCustomer = "delete Customer where Account_Name = '" + deleteAccountName + "'";
                SqlCommand deleteOnTableCustomer = new SqlCommand(sqlDeleteOnTableCustomer, conn);
                deleteOnTableCustomer.ExecuteNonQuery();

                String sqlDeleteOnTablePPartner = "delete PPartner where Account_Name = '" + deleteAccountName + "'";
                SqlCommand deleteOnTablePPartner = new SqlCommand(sqlDeleteOnTablePPartner, conn);
                deleteOnTableCustomer.ExecuteNonQuery();

                String sqlDeleteOnTableDriver = "delete Driver where Account_Name = '" + deleteAccountName + "'";
                SqlCommand deleteOnTableDriver = new SqlCommand(sqlDeleteOnTableDriver, conn);
                deleteOnTableCustomer.ExecuteNonQuery();

                String sqlDeleteOnTableEmployee = "delete Employee where Account_Name = '" + deleteAccountName + "'";
                SqlCommand deleteOnTableEmployee = new SqlCommand(sqlDeleteOnTableEmployee, conn);
                deleteOnTableCustomer.ExecuteNonQuery();

                String sqlEnableConstraintAccount = "alter table Account CHECK CONSTRAINT all";
                SqlCommand enableConstraintAccount = new SqlCommand(sqlEnableConstraintAccount, conn);
                enableConstraintAccount.ExecuteNonQuery();
                Adim.util.enableConstraint(2, conn);
                Adim.util.enableConstraint(3, conn);
                Adim.util.enableConstraint(4, conn);
                Adim.util.enableConstraint(5, conn);

                // Show ok 
                this.OkButtonXoaTaiKhoanAmin.Visible = true;
                this.XoaTaiKhoanThanhCongAdminPictureBox.Visible = true;
                this.XoaTaiKhoanThanhCongAdminLabel.Visible = true;

                this.XoaTaiKhoanAdminLable.Visible = false;
                this.TenDangNhapMuonXoaAdminSubTextbox.Visible = false;
                this.TenDangNhapAdminGroupBox.Visible = false;
                this.MatKhauQuanTriAdminGroupBox.Visible = false;
                this.MatKhauQuanTriAdminSubTextBox.Visible = false;
                this.NoteAdminLabel01.Visible = false;
                this.NoteAdminLabel02.Visible = false;
                this.XoaAdminButton.Visible = false;


            } catch (Exception ex)
            {
                this.OkButtonXoaTaiKhoanAmin.Visible = true;
                this.XoaTaiKhoanThatBaiAdminPictureBox.Visible = true;
                this.XoaTaiKhoanThatBaiAdminLabel.Visible = true;

                this.XoaTaiKhoanAdminLable.Visible = false;
                this.TenDangNhapMuonXoaAdminSubTextbox.Visible = false;
                this.TenDangNhapAdminGroupBox.Visible = false;
                this.MatKhauQuanTriAdminGroupBox.Visible = false;
                this.MatKhauQuanTriAdminSubTextBox.Visible = false;
                this.NoteAdminLabel01.Visible = false;
                this.NoteAdminLabel02.Visible = false;
                this.XoaAdminButton.Visible = false;
            }
        }

        private void OkButtonXoaTaiKhoanAmin_Click(object sender, EventArgs e)
        {
            this.OkButtonXoaTaiKhoanAmin.Visible = false;
            this.XoaTaiKhoanThatBaiAdminPictureBox.Visible = false;
            this.XoaTaiKhoanThatBaiAdminLabel.Visible = false;
            this.XoaTaiKhoanThanhCongAdminPictureBox.Visible = false;
            this.XoaTaiKhoanThanhCongAdminLabel.Visible = false;

            this.XoaTaiKhoanAdminLable.Visible = true;
            this.TenDangNhapMuonXoaAdminSubTextbox.Visible = true;
            this.TenDangNhapAdminGroupBox.Visible = true;
            this.MatKhauQuanTriAdminGroupBox.Visible = true;
            this.MatKhauQuanTriAdminSubTextBox.Visible = true;
            this.NoteAdminLabel01.Visible = true;
            this.NoteAdminLabel02.Visible = true;
            this.XoaAdminButton.Visible = true;
        }

        private void XoaTaiKhoanBackAdminButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form adminHome = new adminHome(conn);
            adminHome.Show();
        }
    }
}
