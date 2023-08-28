using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using HelloWorld.Models;
using Microsoft.Data.SqlClient;

namespace HelloWorld
{
    internal class Program2
    {
        static void Main(string[] args)
        {
            string connectionString = "Server=localhost;Database=DotNetCourseDatabase;TrustServerCertificate=true;Trusted_Connection=true;";

            IDbConnection dbConnection = new SqlConnection(connectionString);

            string sqlCommand = "SELECT GETDATE()";

            DateTime rightNow = dbConnection.QuerySingle<DateTime>(sqlCommand);

            Console.WriteLine(rightNow);

            /*
            Computer myComputer = new Computer()
            {
                Motherboard = "Z690",
                HasLTE = false,
                HasWiFi = true,
                ReleaseDate = DateTime.Now,
                Price = 943.85m,
                VideoCard = "RTX 3070"

            };

            myComputer.HasWiFi = false;
            Console.WriteLine(myComputer.Motherboard);
            Console.WriteLine(myComputer.HasWiFi);
            Console.WriteLine(myComputer.VideoCard);
            Console.WriteLine(myComputer.ReleaseDate);
            */
        }
    }
}
