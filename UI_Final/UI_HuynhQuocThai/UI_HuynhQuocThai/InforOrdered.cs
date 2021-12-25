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
    public partial class InforOrdered : Form
    {
        public InforOrdered()
        {
            InitializeComponent();
        }
        DataSet LayThongTinHoaDonDaNhan()
        {
            DataSet data = new DataSet();
            string temp2 = inputDriverID.Text;
            string temp1 = "select DO.Order_ID, District.District_Name as District_Start,District_E.District_Name as Disctrict_End, DO.Delivery_Fee from((DeliveryOrder as DO inner join District on DO.District_Start = District.District_ID)inner join District_E on DO.District_End = District_E.District_ID) where DO.Driver_ID ='";
            string count = "select count(*) from((DeliveryOrder as DO inner join District on DO.District_Start = District.District_ID) inner join District_E on DO.District_End = District_E.District_ID) where DO.Driver_ID ='";

            using (SqlConnection connection = new SqlConnection(ConnectString.ConnectString1))
            {
                connection.Open();

                SqlCommand com1 = new SqlCommand(count + temp2 + "'", connection);
                var dem = com1.ExecuteScalar();
                int biendem = (int)dem;
                if (biendem != 0)
                {
                    SqlDataAdapter adapter1 = new SqlDataAdapter(temp1 + temp2 + "'", connection);
                    adapter1.Fill(data);
                }
                else
                {
                    SqlDataAdapter adapter1 = new SqlDataAdapter(temp1 + temp2 + "'", connection);
                    adapter1.Fill(data);
                    MessageBox.Show("Không tìm thấy hóa đơn");
                    return data;
                }
                connection.Close();

            }
            return data;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (inputDriverID.Text.Trim().Length != 0)
            {
                dataGridView1.DataSource = LayThongTinHoaDonDaNhan().Tables[0];
            }
            else
            {
                MessageBox.Show("Bạn chưa nhập mã tài xế");
                return;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (inputDriverID.Text.Trim().Length != 0)
            {
                SqlConnection conn = new SqlConnection(ConnectString.ConnectString1);
                conn.Open();
                string temp3 = inputDriverID.Text;
                string querysum = "select sum(DO.Delivery_Fee) from DeliveryOrder as DO where DO.Driver_ID='";
                SqlCommand cmd3 = new SqlCommand(querysum + temp3 + "'", conn);
                var doanhthu = cmd3.ExecuteScalar();
                string kq = doanhthu.ToString();
                tongdoanhthu.Text = kq;

            }
            else
            {
                MessageBox.Show("Bạn chưa nhập mã tài xế");
                return;
            }
        }
    }
}
