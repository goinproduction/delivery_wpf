using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Adim
{
    internal class util
    {
        public static bool isExisted(String value, String columnName, String tableName, SqlConnection conn)
        {
            String sql = "select " + columnName + " from " + tableName + " where " + columnName + " = " +"'"+value + "'";
            DataSet ds = new DataSet();
            SqlDataAdapter data = new SqlDataAdapter(sql, conn);
            data.Fill(ds);
            if (ds.Tables[0].Rows.Count > 1)
            {
                return true;
            }
            return false;
        }

        public static void updateDependencesData(String accountName, Int16 AccountType, String preUpdateAccountName,SqlConnection conn)
        {
            String tableUpdateName = "";
            switch (AccountType)
            {
                case 2: 
                    tableUpdateName = "Driver"; 
                    break;
                case 3: 
                    tableUpdateName = "Customer";
                    break;
                case 4:
                    tableUpdateName = "Employee";
                    break;
                case 5:
                    tableUpdateName = "PParner";
                    break;
            }


            String sqlUpdate = "update " + tableUpdateName + " set Account_Name = '" + accountName + "' where Account_Name = '" +preUpdateAccountName+"'";
            SqlCommand cmd = new SqlCommand(sqlUpdate, conn);
            cmd.ExecuteNonQuery();

        }

        public static void disableConstraint(Int16 AccountType, SqlConnection conn)
        {
            String tableUpdateName = "";
            switch (AccountType)
            {
                case 2:
                    tableUpdateName = "Driver";
                    break;
                case 3:
                    tableUpdateName = "Customer";
                    break;
                case 4:
                    tableUpdateName = "Employee";
                    break;
                case 5:
                    tableUpdateName = "PParner";
                    break;
            }
            String sqlDisableConstraint = "alter table " + tableUpdateName + " NOCHECK CONSTRAINT all";
            SqlCommand disableConstraint = new SqlCommand(sqlDisableConstraint, conn);
            disableConstraint.ExecuteNonQuery();
        }
        public static void enableConstraint(Int16 AccountType, SqlConnection conn)
        {
            String tableUpdateName = "";
            switch (AccountType)
            {
                case 2:
                    tableUpdateName = "Driver";
                    break;
                case 3:
                    tableUpdateName = "Customer";
                    break;
                case 4:
                    tableUpdateName = "Employee";
                    break;
                case 5:
                    tableUpdateName = "PParner";
                    break;
            }
            String sqlEnableConstraint = "alter table " + tableUpdateName + " CHECK CONSTRAINT all";
            SqlCommand disableConstraint = new SqlCommand(sqlEnableConstraint, conn);
            disableConstraint.ExecuteNonQuery();
        }
    }
}

