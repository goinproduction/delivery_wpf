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
    public partial class DatHang : Form
    {
        SqlConnection connection;
        string str = "Data Source=DESKTOP-JNCQFSF;Initial Catalog=HQTCSDL;Integrated Security=True";

        void loadPartnerData()
        {
            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            command = connection.CreateCommand();
            command.CommandText = "SELECT Partner_ID, Name_Partner, City_Partner FROM PPartner";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dgv_DanhSachDoiTac.DataSource = table;
        }

        void loadDanhSachSanPham()
        {
            SqlCommand command2;
            SqlDataAdapter adapter2 = new SqlDataAdapter();
            DataTable table2 = new DataTable();
            command2 = connection.CreateCommand();
            command2.CommandText = "SELECT P.Product_ID, P.Name_Product, P.Price_Product FROM Product P JOIN Branch B ON P.Branch_ID = B.Branch_ID JOIN PPartner PN ON PN.Partner_ID = B.Partner_ID WHERE PN.Partner_ID=('" + tb_MaDoiTac.Text + "')";
            adapter2.SelectCommand = command2;
            table2.Clear();
            adapter2.Fill(table2);
            dgv_DanhSachSanPham.DataSource = table2;
        }

        void themSanPham()
        {
            SqlCommand command3;
            command3 = connection.CreateCommand();
            command3.CommandText = "INSERT INTO CartDetails(Cart_ID, Product_ID, Quantity) values ('"+tb_MaGio.Text+"','"+tb_MaSanPham.Text+"', '"+ Convert.ToInt32(tb_SoLuongMua.Text)+ "')";
            command3.ExecuteNonQuery();
            MessageBox.Show("Thêm sản phẩm thành công!");
        }
        public DatHang()
        {
            InitializeComponent();
        }

        private void btn_XemDSSanPham_Click(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            loadDanhSachSanPham();
            loadPartnerData();
        }

        private void btn_ThemVaoGio_Click(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            themSanPham();
            loadDanhSachSanPham();
            loadPartnerData();
        }

        private void DatHang_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            loadPartnerData();
        }

        private void btn_ThanhToan_Click(object sender, EventArgs e)
        {
            ThanhToan tt = new ThanhToan();
            tt.Show();
        }
    }
}
