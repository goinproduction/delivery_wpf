using System.Data.SqlClient;
namespace Adim
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            String connectionString = "Data Source=LAPTOP-QF22927O;Initial Catalog=HQTCSDL;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            if (conn.State != System.Data.ConnectionState.Open)
            {
                throw new Exception("Can not connect to database");
            }
            ApplicationConfiguration.Initialize();
            Application.Run(new adminHome(conn));
        }
    }
}