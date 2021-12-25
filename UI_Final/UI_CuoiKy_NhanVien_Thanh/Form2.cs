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

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        SqlConnection connecttion;
        string connect_string = "Data Source=DESKTOP-D1C2UFI;Initial Catalog=HQTCSDL;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            connecttion = new SqlConnection(connect_string);    //mo connection toi sql
            connecttion.Open();
            SqlCommand cmd = new SqlCommand("SELECT Contract_ID AS N'Mã Hợp Đồng', Repre_ID AS N'Mã Người Đại Diện', Partner_ID AS N'Mã Đối Tác', Tax_Number_Partner AS N'Mã Số Thuế', Register_Branch_Count AS N'Số Lượng Chi Nhánh Đăng Ký', EExpiry_Date AS N'Ngày Đáo Hạn Hợp Đồng', Commission AS N'Hoa Hồng', Activate_Fee AS N'Phí Kích Hoạt', Max_Order AS N'Số Lượng Đơn Hàng Tối Đa' FROM Contractt ct", connecttion);    //cau truy van
            connecttion.Close();        //dong connection
            adapter = new SqlDataAdapter(cmd);
            table = new DataTable();
            adapter.Fill(table);        //do data vao table
            dataGridView1.DataSource = table;       //va show len gridview
            dataGridView1.ReadOnly = true;

            connecttion = new SqlConnection(connect_string);    //mo connection toi sql
            connecttion.Open();
            cmd = new SqlCommand("SELECT Contract_ID AS N'Mã Hợp Đồng', Repre_ID AS N'Mã Người Đại Diện', Partner_ID AS N'Mã Đối Tác', Tax_Number_Partner AS N'Mã Số Thuế', Register_Branch_Count AS N'Số Lượng Chi Nhánh Đăng Ký', EExpiry_Date AS N'Ngày Đáo Hạn Hợp Đồng', Commission AS N'Hoa Hồng', Activate_Fee AS N'Phí Kích Hoạt', Max_Order AS N'Số Lượng Đơn Hàng Tối Đa' FROM Contractt WHERE DATEDIFF(day, GETDATE(), EExpiry_Date) < 31", connecttion);    //cau truy van
            connecttion.Close();        //dong connection
            adapter = new SqlDataAdapter(cmd);
            table = new DataTable();
            adapter.Fill(table);        //do data vao table
            dataGridView2.DataSource = table;       //va show len gridview
            dataGridView2.ReadOnly = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2_Load(sender, e);  
        }
    }
}
