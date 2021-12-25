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
    public partial class TheoDoiDonHang : Form
    {
        SqlConnection connection;
        string str = "Data Source=DESKTOP-JNCQFSF;Initial Catalog=HQTCSDL;Integrated Security=True";

        void ThongTinGiaoHang()
        {
            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            command = connection.CreateCommand();
            command.CommandText = "SELECT * FROM DELIVERYORDER D WHERE D.ORDER_ID=('"+tb_MaDonHang.Text+"')";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dgv_TTDH.DataSource = table;
        }
        public TheoDoiDonHang()
        {
            InitializeComponent();
        }

        private void tb_TheoDoi_Click(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            ThongTinGiaoHang();
        }
    }
}
