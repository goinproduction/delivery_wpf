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

namespace UI
{
    public partial class ThanhToan : Form
    {
        SqlConnection connection;
        string str = "Data Source=DESKTOP-JNCQFSF;Initial Catalog=HQTCSDL;Integrated Security=True";

        void loadGioHang()
        {
            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            command = connection.CreateCommand();
            command.CommandText = "SELECT c.Cart_ID, c.Product_ID, c.Quantity, p.Price_Product as 'Don Gia', c.Total as 'Tong Tien' FROM CARTDETAILs c join product p ON c.Product_ID = p.Product_ID;";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dgv_GioHang.DataSource = table;
        }
        public ThanhToan()
        {
            InitializeComponent();
        }

        void XoaGioHang()
        {
            SqlCommand command3;
            command3 = connection.CreateCommand();
            command3.CommandText = "DELETE FROM CARTDETAILS";
            command3.ExecuteNonQuery();
        }

        private void btn_ThanhToan_Click(object sender, EventArgs e)
        {
            SqlCommand command2;
            command2 = connection.CreateCommand();
            command2.CommandText = "INSERT INTO DeliveryOrder(Order_ID, Customer_ID, Payment) values ('" + tb_MaDonHang.Text + "', '" + tb_MaKhachHang.Text + "', '" + tb_HinhThucThanhToan.Text + "')";
            command2.ExecuteNonQuery();
            XoaGioHang();
            MessageBox.Show("Thanh toán thành công!");
        }

        private void ThanhToan_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            loadGioHang();
        }

        private void btn_Load_Click(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            string tenEx = "SELECT C.Name_Cus FROM Customer C WHERE C.Customer_ID = '"+tb_MaKhachHang.Text+"'";
            string phoneEx = "SELECT C.Phone_Number_Cus FROM Customer C WHERE C.Customer_ID = '" + tb_MaKhachHang.Text + "'";
            string addressEx = "SELECT C.Adr_Cus FROM Customer C WHERE C.Customer_ID = '" + tb_MaKhachHang.Text + "'";
            string emailEx = "SELECT C.Email_Cus FROM Customer C WHERE C.Customer_ID = '" + tb_MaKhachHang.Text + "'";

            SqlCommand tenCmd = new SqlCommand(tenEx, connection);
            SqlCommand phoneCmd = new SqlCommand(phoneEx, connection);
            SqlCommand adrCmd = new SqlCommand(addressEx, connection);
            SqlCommand emailCmd = new SqlCommand(emailEx, connection);

            var ten = tenCmd.ExecuteScalar();
            var diaChi = adrCmd.ExecuteScalar();
            var sdt = phoneCmd.ExecuteScalar();
            var email = emailCmd.ExecuteScalar();

            tb_DiaChi.Text = diaChi.ToString();
            tb_TenKhachHang.Text = ten.ToString();
            tb_SDT.Text = sdt.ToString();
            tb_Email.Text = email.ToString();
        }
    }
}
