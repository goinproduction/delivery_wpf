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


namespace Adim
{
    public partial class XemDanhSachTaiKhoanAdmin : Form
    {
        private SqlConnection conn;
        public XemDanhSachTaiKhoanAdmin(SqlConnection conn)
        {
            this.conn = conn;
            InitializeComponent();
            String selectAllFromAccount = "Select * from Account";
            DataSet accountDataSet = new DataSet();
            SqlDataAdapter accountDataAdapter = new SqlDataAdapter(selectAllFromAccount, conn);
            accountDataAdapter.Fill(accountDataSet);
            this.danhSachTaiKhoanAdminDataGridView.DataSource = accountDataSet.Tables[0];
            this.danhSachTaiKhoanAdminDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.danhSachTaiKhoanAdminDataGridView.Refresh();

        }
        private void DanhSachTaiKhoanAdminBackButton_Click(object sender, EventArgs e)
        {
            Form homeAdmin = new adminHome(conn);
            homeAdmin.Show();
            this.Dispose();

        }
    }
}
