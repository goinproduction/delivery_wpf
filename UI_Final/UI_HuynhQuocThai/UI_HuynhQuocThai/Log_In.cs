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


namespace UI_HuynhQuocThai
{
    public partial class Log_In : Form
    {
        public Log_In()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void inputPW_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            
            Sign_Up signup = new Sign_Up();
            signup.ShowDialog();
        }

        private void inputAcc_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(ConnectString.ConnectString1))
            {
                connection.Open();
                string tk = inputAcc.Text;
                string mk = inputPW.Text;
                string sqlrole = "select Account_Type from Account where Account_Name='" + tk + "' and Account_Password='" + mk + "'";
                string sql = "select count(*) from Account where Account_Name='" + tk + "' and Account_Password='" + mk + "'";
                
                SqlCommand cmdlog = new SqlCommand(sql, connection);
                var dta = cmdlog.ExecuteScalar();
                int dem = (int)dta;
                
          
                if (dem==1)
                {
                    SqlCommand cmdrole = new SqlCommand(sqlrole, connection);
                    var dta2 = cmdrole.ExecuteScalar();
                    int biendem = (int)dta2;
                    //MessageBox.Show("Tài khoản mật khẩu đúng");
                    if (biendem==2)
                    {
                        Home_Driver driver = new Home_Driver();
                        driver.ShowDialog();
                    }else if(biendem==5)
                    {
                        _1712733_UI.Home PN_Home = new _1712733_UI.Home();
                        PN_Home.Show();
                    }else if(biendem==4)
                    {
                        WindowsFormsApp1.Form1 Emp_Home= new WindowsFormsApp1.Form1();
                        Emp_Home.Show();
                    }
                    else if (biendem == 3)
                    {
                        UI.KhachHang_Main Cus_Home = new UI.KhachHang_Main();
                        Cus_Home.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Tài khoản mật khẩu không đúng");
                }
               
                
                connection.Close();

            }
            /*_1712733_UI.Home PN_Home = new _1712733_UI.Home();
            PN_Home.Show();*/

        }
    }
}
