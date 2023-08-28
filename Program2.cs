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

            Console.WriteLine(rightNow.ToString());
            
            Computer myComputer = new Computer() 
            {
                Motherboard = "Z690",
                HasWiFi = false,
                HasLTE = true,
                ReleaseDate = DateTime.Now,
                Price = 943.85m,
                VideoCard = "RTX 3070"

            };

            string sql = @"INSERT INTO TutorialAppSchema.Computer (
                Motherboard,
                HasWiFi,
                HasLTE,
                ReleaseDate,
                Price,
                VideoCard
            ) VALUES ('" + myComputer.Motherboard
                    + "','" + myComputer.HasWiFi
                    + "','" + myComputer.HasLTE
                    + "','" + myComputer.ReleaseDate
                    + "','" + myComputer.Price
                    + "','" + myComputer.VideoCard
            + "')";

            //Console.WriteLine(sql);

            //int result = dbConnection.Execute(sql);

            //Console.WriteLine(result);

            string sqlSelect = @"
            SELECT 
                Computer.Motherboard,
                Computer.HasWiFi,
                Computer.HasLTE,
                Computer.ReleaseDate,
                Computer.Price,
                Computer.VideoCard
            FROM TutorialAppSchema.Computer";

            IEnumerable<Computer> computers = dbConnection.Query<Computer>(sqlSelect);

            Console.WriteLine("'Motherboard','HasWiFi','HasLTE','ReleaseDate','Price','VideoCard'");
            foreach (Computer singleComputer in computers)
            {
                Console.WriteLine("'" + myComputer.Motherboard
                    + "','" + myComputer.HasWiFi
                    + "','" + myComputer.HasLTE
                    + "','" + myComputer.ReleaseDate
                    + "','" + myComputer.Price
                    + "','" + myComputer.VideoCard + "'");
            }

            //myComputer.HasWiFi = false;
            //Console.WriteLine(myComputer.Motherboard);
            //Console.WriteLine(myComputer.HasWiFi);
            //Console.WriteLine(myComputer.VideoCard);
            //Console.WriteLine(myComputer.ReleaseDate);

        }
    }
}
