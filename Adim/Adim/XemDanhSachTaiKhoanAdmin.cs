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
using Adim;


namespace Adim
{
    public partial class XemDanhSachTaiKhoanAdmin : Form
    {
        private SqlConnection conn;
        private String preUpdateAccountName;
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

        private void danhSachTaiKhoanAdminDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

            String accountName = "";
            Int16 accountType = 0;
            String accountPassword = "";
            DataGridViewRow accountDataGridViewRow = danhSachTaiKhoanAdminDataGridView.CurrentRow;
            try
            {
                if (accountDataGridViewRow != null)
                {
                    if (accountDataGridViewRow.Cells[0].Value == DBNull.Value)
                    {
                        throw new Exception("Account name cannot empty");

                    }

                    if (accountDataGridViewRow.Cells[1].Value == DBNull.Value)
                    {
                        throw new Exception("Account password cannot empty");
                    }

                    if (accountDataGridViewRow.Cells[2].Value == DBNull.Value || (((Int16)accountDataGridViewRow.Cells[2].Value < 1) && (Int16)accountDataGridViewRow.Cells[2].Value > 5))
                    {
                        throw new Exception("Account type is invalid");
                    }

                    if(Adim.util.isExisted(accountName, "Account_Name", "Account", conn))
                    {
                        throw new Exception("Account name is existed");
                    }
                    
                    accountName = accountDataGridViewRow.Cells[0].Value.ToString();
                    accountPassword = accountDataGridViewRow.Cells[1].Value.ToString();
                    accountType = (Int16)accountDataGridViewRow.Cells[2].Value;

                    String sqlDisableConstraintAccount = "alter table Account NOCHECK CONSTRAINT all";
                    SqlCommand disableConstaintAccount = new SqlCommand(sqlDisableConstraintAccount,conn);
                    disableConstaintAccount.ExecuteNonQuery();

                    Adim.util.disableConstraint(accountType,conn);

                    String sqlUpdateAccountData = "update Account set Account_Name = '" + accountName + "' , Account_Password = '" + accountPassword + "' , Account_Type = '" + accountType
                        + "' where Account_Name = '" + this.preUpdateAccountName+"'";
                    SqlCommand updateAccountData = new SqlCommand(sqlUpdateAccountData,conn);
                    updateAccountData.ExecuteNonQuery();

                    MessageBox.Show(this.preUpdateAccountName);

                    if (this.preUpdateAccountName != accountName)
                    {
                        Adim.util.updateDependencesData(accountName, accountType, preUpdateAccountName, conn);
                    }

                    String sqlEnableConstraintAccount = "alter table Account CHECK CONSTRAINT all";
                    SqlCommand enableConstraintAccount = new SqlCommand(sqlEnableConstraintAccount, conn);
                    enableConstraintAccount.ExecuteNonQuery();
                    Adim.util.enableConstraint(accountType, conn);
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void danhSachTaiKhoanAdminDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int columnIndex = e.ColumnIndex;
            if (columnIndex == 0)
            {
                this.preUpdateAccountName = danhSachTaiKhoanAdminDataGridView.CurrentCell.Value.ToString();
            }
        }
    }
}
