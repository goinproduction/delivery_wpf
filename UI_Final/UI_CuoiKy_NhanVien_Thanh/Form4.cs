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
    public partial class Form4 : Form
    {
        SqlConnection connecttion;
        string connect_string = "Data Source=DESKTOP-D1C2UFI;Initial Catalog=HQTCSDL;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        public Form4()
        {
            InitializeComponent();
        }
        public string manvgiahan;
        private void Form4_Load(object sender, EventArgs e)
        {
            connecttion = new SqlConnection(connect_string);    //mo connection toi sql
            connecttion.Open();
            SqlCommand cmd = new SqlCommand("SELECT a.Employee_ID FROM Employee a WHERE a.Account_Name = @manvgiahan", connecttion);    //cau truy van
            cmd.Parameters.AddWithValue("@manvgiahan", manvgiahan);
            cmd.ExecuteNonQuery();
            connecttion.Close();
            adapter = new SqlDataAdapter(cmd);
            table = new DataTable();
            adapter.Fill(table);        //do data vao table
            dataGridView1.DataSource = table;
            int i;
            i = dataGridView1.CurrentRow.Index;
            manhanvien.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            manhanvien.ReadOnly = true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
                connecttion = new SqlConnection(connect_string);    //mo connection toi sql
                connecttion.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO ContractExtension(Contract_ID, Employee_ID, New_Expiry_Date, Price_Extension) VALUES ('" + madoitac.Text + "', '" + manhanvien.Text + "', '" + ngayhethan.Text + "', 1000000)", connecttion);    //cau truy van
                cmd.ExecuteNonQuery();
                connecttion.Close();        //dong connection
                Form5 f = new Form5();
                f.Show();
        }
     }
}
