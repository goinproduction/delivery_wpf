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
    public partial class DriverInfor : Form
    {
        public DriverInfor()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateDriverInfor updatedriverinfor = new UpdateDriverInfor();
            updatedriverinfor.Show();
        }
        DataSet LayThongTinDriver()
        {
            DataSet data = new DataSet();
            string temp1 = "select * from Driver where Driver.Driver_ID='";
            string count = "select count(*) from Driver where Driver.Driver_ID='";
            string temp2 = inputDriverID.Text;
            using (SqlConnection connection = new SqlConnection(ConnectString.ConnectString1))
            {
                connection.Open();
                SqlCommand com1 = new SqlCommand(count + "" + temp2 +"'", connection);
                var dem = com1.ExecuteScalar();
                int biendem = (int)dem;
                if (biendem != 0)
                   {
                        SqlDataAdapter adapter = new SqlDataAdapter(temp1 + "" + temp2+"'", connection);
                        adapter.Fill(data);
                   }
                   else
                   {
                        SqlDataAdapter adapter = new SqlDataAdapter(temp1 + "" + temp2 +"'", connection);
                        adapter.Fill(data);
                        MessageBox.Show("Không tìm thấy tài xế");
                        return data;
                   }
                connection.Close();

            }

            return data;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (inputDriverID.Text.Trim().Length == 0)
            {
                MessageBox.Show("Nhập mã tài xế");
                return;
            }
            else
            {
                dataGridView1.DataSource = LayThongTinDriver().Tables[0];
            }
        }
    }
}
