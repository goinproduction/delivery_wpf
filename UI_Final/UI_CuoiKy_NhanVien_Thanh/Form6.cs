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
    public partial class Form6 : Form
    {
        SqlConnection connecttion;
        string connect_string = "Data Source=DESKTOP-D1C2UFI;Initial Catalog=HQTCSDL;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        public Form6()
        {
            InitializeComponent();
        }
        public string temp1;
        private void Form6_Load(object sender, EventArgs e)
        {
            tentknv.Text = temp1;      //load ten dang nhap cua nhan vien
            tentknv.ReadOnly = true;
            connecttion = new SqlConnection(connect_string);    //mo connection toi sql
            connecttion.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Employee e where e.Account_Name = @tentk", connecttion);    //cau truy van
            cmd.Parameters.AddWithValue("@tentk", tentknv.Text);       //dung parameter de bao mat data
            cmd.ExecuteNonQuery();
            connecttion.Close();        //dong connection
            adapter = new SqlDataAdapter(cmd);
            table = new DataTable();
            adapter.Fill(table);        //do data vao table
            dataGridView1.DataSource = table;       //va show len gridview
            dataGridView1.ReadOnly = true;
            int i;
            i = dataGridView1.CurrentRow.Index;
            manhanvien.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            manhanvien.ReadOnly = true;
            tennhanvien.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            tennhanvien.ReadOnly = true;
            sodtnv.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            sodtnv.ReadOnly = true;
            diachinv.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
            diachinv.ReadOnly = true;
        }
    }
}
