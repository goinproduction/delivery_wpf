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
    public partial class UpdateDriverInfor : Form
    {
        public UpdateDriverInfor()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if((inputDriID.Text.Trim().Length==0)||(inputDriverName.Text.Trim().Length==0)
                ||(inputDriverAdd.Text.Trim().Length==0)||(inputDriverEmail.Text.Trim().Length==0)
                ||(inputDriverPhone.Text.Trim().Length==0)||(inputGPLX.Text.Trim().Length==0)
                ||(inputCMND.Text.Trim().Length==0)||(inputTKNH.Text.Trim().Length==0))
            {
                MessageBox.Show("Bạn nhập thiếu giá trị");
                return;
            }
            else
            {
                string select = "select count(*) from Driver where Driver_ID='";
                SqlConnection conn = new SqlConnection(ConnectString.ConnectString1);
                conn.Open();
                SqlCommand cmd1 = new SqlCommand(select+inputDriID.Text+"'", conn);
                var dem = cmd1.ExecuteScalar();
                int biendem = (int)dem;
                if(biendem!=0)
                {
                    string upd = "update Driver set Name_Driver=@Name_Driver,Phone_number_Driver=@Phone_number_Driver, Adr_Driver=@Adr_Driver,Email_Driver=@Email_Driver, License_Plates=@License_Plates,Bank_Account_Driver=@Bank_Account_Driver, Identity_Code_Driver=@Identity_Code_Driver where Driver_ID='"+inputDriID.Text+"'";
                    SqlCommand cmd2 = new SqlCommand(upd, conn);
                    cmd2.Parameters.AddWithValue("Name_Driver", inputDriverName.Text);
                    cmd2.Parameters.AddWithValue("Phone_number_Driver", inputDriverPhone.Text);
                    cmd2.Parameters.AddWithValue("Adr_Driver", inputDriverAdd.Text);
                    cmd2.Parameters.AddWithValue("Email_Driver", inputDriverEmail.Text);
                    cmd2.Parameters.AddWithValue("Identity_Code_Driver", inputCMND.Text);
                    cmd2.Parameters.AddWithValue("License_Plates", inputGPLX.Text);
                    cmd2.Parameters.AddWithValue("Bank_Account_Driver", inputTKNH.Text);
                    _=cmd2.ExecuteNonQuery();
                    MessageBox.Show("Cập nhật thành công");
                }
                else
                {
                    MessageBox.Show("Bạn nhập sai mã tài xế");
                    return;
                }
                conn.Close();
            }
        }
    }
}
