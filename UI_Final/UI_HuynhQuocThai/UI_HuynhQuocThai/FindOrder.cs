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
    public partial class FindOrder : Form
    {
        public FindOrder()
        {
            InitializeComponent();
        }
        DataSet LayThongTinHoaDon()
        {
            DataSet data = new DataSet();
            string temp2 = areaID.Text;
            string temp1 ="select DO.Order_ID, District.District_Name as District_Start,District_E.District_Name as Disctrict_End, DO.Delivery_Fee from((DeliveryOrder as DO inner join District on DO.District_Start = District.District_ID)inner join District_E on DO.District_End = District_E.District_ID) where DO.Status_Order = N'Chưa giao' and DO.District_Start ='";
            string count ="select count(*) from((DeliveryOrder as DO inner join District on DO.District_Start = District.District_ID) inner join District_E on DO.District_End = District_E.District_ID) where DO.Status_Order = N'Chưa giao' and DO.District_Start ='";

            using (SqlConnection connection = new SqlConnection(ConnectString.ConnectString1))
            {
                connection.Open();
                
                SqlCommand com1 = new SqlCommand(count+temp2 +"'", connection);
                var dem = com1.ExecuteScalar();
                int biendem = (int)dem;
                if (biendem != 0)
                {
                    SqlDataAdapter adapter1 = new SqlDataAdapter(temp1+ temp2 +"'", connection);
                    adapter1.Fill(data);
                }
                else
                {
                    SqlDataAdapter adapter1 = new SqlDataAdapter(temp1+temp2 +"'", connection);
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
            if (areaID.Text.Trim().Length != 0)
            {
                int num = 0;
                if (Int32.TryParse(areaID.Text, out num))
                {
                    dataGridView1.DataSource = LayThongTinHoaDon().Tables[0];
                }
                else
                {
                    MessageBox.Show("Không tìm thấy mã khu vực");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa nhập mã khu vực");
                return;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if ((ord_ID.Text.Trim().Length==0)||(driverID.Text.Trim().Length==0))
            {
                MessageBox.Show("Bạn nhập thiếu giá trị");
                return;
            }
            else
            {
                string select = "select count(*) from DeliveryOrder as DO where DO.Driver_ID is null and DO.Order_ID='"+ord_ID.Text+"'";
                SqlConnection conn = new SqlConnection(ConnectString.ConnectString1);
                conn.Open();
                SqlCommand cmd1 = new SqlCommand(select , conn);
                var dem = cmd1.ExecuteScalar();
                int biendem = (int)dem;
                if (biendem != 0)
                {
                    string upd ="update DeliveryOrder set Driver_ID=@Driver_ID, Status_Order=N'Đã nhận' where Order_ID='"+ord_ID.Text+"'";
                    SqlCommand cmd2 = new SqlCommand(upd, conn);
                    cmd2.Parameters.AddWithValue("Driver_ID", driverID.Text);
                    _ = cmd2.ExecuteNonQuery();
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

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
