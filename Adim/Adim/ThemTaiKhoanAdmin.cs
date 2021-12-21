using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Adim;

namespace Adim
{
    public partial class ThemTaiKhoanAdmin : Form
    {
        SqlConnection conn;
        String TenDangNhapString = "";
        String MatKhauString = "";
        String LoaiTaiKhoan = "";
        public ThemTaiKhoanAdmin(SqlConnection conn)
        {
            this.conn = conn;
            InitializeComponent();
        }

        private void ThemAdminButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (TenDangNhapAdminSubTextbox.Text.Length == 0) {
                    throw new Exception("Account name cannot empty");
                }

                if (MatKhauAdminSubTextBox.Text.Length == 0) {
                    throw new Exception("Password cannot null");
                }

                if (LoaTaiKhoanAdminSubTextBox.Text != "1" && LoaTaiKhoanAdminSubTextBox.Text != "2" &&
                    LoaTaiKhoanAdminSubTextBox.Text != "3" && LoaTaiKhoanAdminSubTextBox.Text != "4" &&
                    LoaTaiKhoanAdminSubTextBox.Text != "5") {
                    throw new Exception("Account type is not invalid");
                }

                this.TenDangNhapString = TenDangNhapAdminSubTextbox.Text;
                this.MatKhauString = MatKhauAdminSubTextBox.Text;
                this.LoaiTaiKhoan = LoaTaiKhoanAdminSubTextBox.Text;
                
                if ( Adim.util.isExisted(TenDangNhapString, "Account_name", "Account", conn))
                {
                    throw new Exception("Account name is existed");
                }

                String SqlAddUser = "insert into Account(Account_Name,Account_Password,Account_Type) values ( '" 
                    + TenDangNhapString + "', '" + MatKhauString + "', '" + LoaiTaiKhoan + "')";

                SqlCommand addUser = new SqlCommand(SqlAddUser, conn);
                addUser.ExecuteNonQuery();

                this.ThemTaiKhoanThanhCongAdminLabel.Visible = true;
                this.ThemTaiKhoanThanhCongAdminPictureBox.Visible = true;
                this.OkAdminButton.Visible = true;

                this.ThemTaiKhoanAdminLable.Visible = false;
                this.TenDangNhapAdminGroupBox.Visible = false;
                this.TenDangNhapAdminSubTextbox.Visible = false;
                this.MatKhauAdminGroupBox.Visible = false;
                this.MatKhauAdminSubTextBox.Visible = false;
                this.LoaiTaiKhoanAdminGroupBox.Visible = false;
                this.LoaTaiKhoanAdminSubTextBox.Visible = false;
                this.MaLoaiTaiKhoanAdminLable.Visible=false;
                this.LoaiTaiKhoanAdminAdminLabel.Visible = false;
                this.LoaiTaiKhoanDoiTacAdminLabel.Visible = false;
                this.LoaiTaiKhoanKhachHangAdminLabel.Visible = false;
                this.LoaiTaiKhoanTaiXeAdminLabel.Visible = false;
                this.LoaiTaiKhoanNhanVienAdminLable.Visible = false;

                this.ThemAdminButton.Visible = false;


            } catch (Exception ex) {

                this.ThemTaiKhoanThatBaiAdminLabel.Visible = true;
                this.ThemTaiKhoanThatBaiAdminPictureBox.Visible = true;
                this.OkAdminButton.Visible = true;

                this.ThemTaiKhoanAdminLable.Visible = false;
                this.TenDangNhapAdminGroupBox.Visible = false;
                this.TenDangNhapAdminSubTextbox.Visible = false;
                this.MatKhauAdminGroupBox.Visible = false;
                this.MatKhauAdminSubTextBox.Visible = false;
                this.LoaiTaiKhoanAdminGroupBox.Visible = false;
                this.LoaTaiKhoanAdminSubTextBox.Visible = false;
                this.MaLoaiTaiKhoanAdminLable.Visible = false;
                this.LoaiTaiKhoanAdminAdminLabel.Visible = false;
                this.LoaiTaiKhoanDoiTacAdminLabel.Visible = false;
                this.LoaiTaiKhoanKhachHangAdminLabel.Visible = false;
                this.LoaiTaiKhoanTaiXeAdminLabel.Visible = false;
                this.LoaiTaiKhoanNhanVienAdminLable.Visible = false;
                this.ThemAdminButton.Visible = false;
            }
        }

        private void OkAdminButton_Click(object sender, EventArgs e)
        {
            this.ThemTaiKhoanThatBaiAdminLabel.Visible = false;
            this.ThemTaiKhoanThatBaiAdminPictureBox.Visible = false;
            this.ThemTaiKhoanThanhCongAdminLabel.Visible = false;
            this.ThemTaiKhoanThanhCongAdminPictureBox.Visible = false;
            this.OkAdminButton.Visible = false;

            this.ThemTaiKhoanAdminLable.Visible = true;
            this.TenDangNhapAdminGroupBox.Visible = true;
            this.TenDangNhapAdminSubTextbox.Visible = true;
            this.MatKhauAdminGroupBox.Visible = true;
            this.MatKhauAdminSubTextBox.Visible = true;
            this.LoaiTaiKhoanAdminGroupBox.Visible = true;
            this.LoaTaiKhoanAdminSubTextBox.Visible = true;
            this.MaLoaiTaiKhoanAdminLable.Visible = true;
            this.LoaiTaiKhoanAdminAdminLabel.Visible = true;
            this.LoaiTaiKhoanDoiTacAdminLabel.Visible = true;
            this.LoaiTaiKhoanKhachHangAdminLabel.Visible = true;
            this.LoaiTaiKhoanTaiXeAdminLabel.Visible = true;
            this.LoaiTaiKhoanNhanVienAdminLable.Visible = true;
            this.ThemAdminButton.Visible = true;
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Form adminHome = new adminHome(conn);
            adminHome.Show();
            this.Hide();
        }
    }
}
