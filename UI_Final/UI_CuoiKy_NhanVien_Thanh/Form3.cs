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
    public partial class Form3 : Form
    {
        SqlConnection connecttion;
        string connect_string = "Data Source=DESKTOP-D1C2UFI;Initial Catalog=HQTCSDL;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            connecttion = new SqlConnection(connect_string);    //mo connection toi sql
            connecttion.Open();
            SqlCommand cmd = new SqlCommand("SELECT pn.Partner_ID AS N'Mã Đối Tác', pn.Name_Partner AS N'Tên Đối Tác', pn.Phone_Number_Partner AS N'Số Điện Thoại', pn.Email_Partner AS N'Email', pn.Adr_Business_Partner AS N'Địa Chỉ', pn.Number_Of_Branch AS N'Số Lượng Chi Nhánh', pn.Sale_Partner AS N'Doanh Thu', ct.EExpiry_Date AS N'Ngày Đáo Hạn Hợp Đồng', ct.Contract_ID AS N'Mã Hợp Đồng' FROM PPartner pn, Contractt ct where pn.Partner_ID = ct.Partner_ID", connecttion);    //cau truy van
            cmd.ExecuteNonQuery();
            connecttion.Close();        //dong connection
            adapter = new SqlDataAdapter(cmd);
            table = new DataTable();
            adapter.Fill(table);        //do data vao table
            dataGridView1.DataSource = table;       //va show len gridview
            dataGridView1.ReadOnly = true;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dataGridView1.CurrentRow.Index;
            madoitac.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            madoitac.ReadOnly = true;
            tendoitac.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            tendoitac.ReadOnly = true;
            sodt.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            sodt.ReadOnly = true;
            email.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
            email.ReadOnly = true;
            diachi.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
            diachi.ReadOnly = true;
            slchinhanh.Text = dataGridView1.Rows[i].Cells[5].Value.ToString();
            slchinhanh.ReadOnly = true;
            doanhthu.Text = dataGridView1.Rows[i].Cells[6].Value.ToString();
            doanhthu.ReadOnly = true;
            ngaydaohan.Text = dataGridView1.Rows[i].Cells[7].Value.ToString();
            ngaydaohan.ReadOnly = true;
            mahopdong.Text = dataGridView1.Rows[i].Cells[8].Value.ToString();
            mahopdong.ReadOnly = true;
        }
        public string manvgiahan;
        private void button2_Click(object sender, EventArgs e)
        {
            Form4 f = new Form4();
            f.manvgiahan = manvgiahan;
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            connecttion = new SqlConnection(connect_string);    //mo connection toi sql
            connecttion.Open();
            SqlCommand cmd = new SqlCommand("SELECT pn.Partner_ID AS N'Mã Đối Tác', pn.Name_Partner AS N'Tên Đối Tác', pn.Phone_Number_Partner AS N'Số Điện Thoại', pn.Email_Partner AS N'Email', pn.Adr_Business_Partner AS N'Địa Chỉ', pn.Number_Of_Branch AS N'Số Lượng Chi Nhánh', pn.Sale_Partner AS N'Doanh Thu', ct.EExpiry_Date AS N'Ngày Đáo Hạn Hợp Đồng', ct.Contract_ID AS N'Mã Hợp Đồng' FROM PPartner pn, Contractt ct where pn.Partner_ID = ct.Partner_ID AND Name_Partner = @tenkh", connecttion);    //cau truy van
            cmd.Parameters.AddWithValue("@tenkh", timkiem.Text);        //dung parameter de bao mat data
            cmd.ExecuteNonQuery();
            connecttion.Close();        //dong connection
            adapter = new SqlDataAdapter(cmd);
            table = new DataTable();
            adapter.Fill(table);        //do data vao table
            dataGridView1.DataSource = table;       //va show len gridview
            dataGridView1.ReadOnly = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3_Load(sender,e);
        }
    }
}
