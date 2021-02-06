using System;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Threading;


namespace ConnectWIthDB
{
    class Program
    {
        private static string connectionString = @"Data Source=DESKTOP-BG4E31L;" +
                                            "Initial Catalog=V_DB;Integrated Security=True";
        static void Main(string[] args)
        {

            Console.WriteLine("test");
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();

                Console.WriteLine("Connection prperties:");
                Console.WriteLine("\tConnection string: {0}", connection.ConnectionString);
                Console.WriteLine("\tDataBase: {0}", connection.Database);
                Console.WriteLine("\tServer: {0}", connection.DataSource);
                Console.WriteLine("\tServer Version: {0}", connection.ServerVersion);
                Console.WriteLine("\tState: {0}", connection.State);
                Console.WriteLine("\tWorkstationld: {0}", connection.WorkstationId);
            }
        }
    }
}
