using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using HelloWorld.Data;
using HelloWorld.Models;
using Microsoft.Data.SqlClient;

namespace HelloWorld
{
    internal class Program2
    {
        static void Main(string[] args)
        {
            DataContextDapper dapper = new DataContextDapper();
            DataContextEF entityFramework = new DataContextEF();


            DateTime rightNow = dapper.LoadDataSingle<DateTime>("SELECT GETDATE()");

           // Console.WriteLine(rightNow.ToString());
            
            Computer myComputer = new Computer() 
            {
                Motherboard = "Z690",
                HasWiFi = false,
                HasLTE = true,
                ReleaseDate = DateTime.Now,
                Price = 943.85m,
                VideoCard = "RTX 3070"

            };

            entityFramework.Add(myComputer);
            entityFramework.SaveChanges();



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

            //int result = dapper.ExecuteSqlWithRowCount(sql);
            bool result = dapper.ExecuteSql(sql);

            //Console.WriteLine(result);

            string sqlSelect = @"
            SELECT 
                Computer.ComputerId,
                Computer.Motherboard,
                Computer.HasWiFi,
                Computer.HasLTE,
                Computer.ReleaseDate,
                Computer.Price,
                Computer.VideoCard
            FROM TutorialAppSchema.Computer";

            IEnumerable<Computer> computers = dapper.LoadData<Computer>(sqlSelect);


            Console.WriteLine("'ComputerId','Motherboard','HasWiFi','HasLTE','ReleaseDate','Price','VideoCard'");
            foreach (Computer singleComputer in computers)
            {
                Console.WriteLine("'" + singleComputer.ComputerId
                    + "'" + singleComputer.Motherboard
                    + "','" + singleComputer.HasWiFi
                    + "','" + singleComputer.HasLTE
                    + "','" + singleComputer.ReleaseDate
                    + "','" + singleComputer.Price
                    + "','" + singleComputer.VideoCard + "'");
            }

            IEnumerable<Computer>? computersEf = entityFramework.Computer?.ToList<Computer>();

            if (computersEf != null)
            {
                Console.WriteLine("'ComputerId','Motherboard','HasWiFi','HasLTE','ReleaseDate','Price','VideoCard'");
                foreach (Computer singleComputer in computersEf)
                {
                    Console.WriteLine("'" + singleComputer.ComputerId
                        + "'" + singleComputer.Motherboard
                        + "','" + singleComputer.HasWiFi
                        + "','" + singleComputer.HasLTE
                        + "','" + singleComputer.ReleaseDate
                        + "','" + singleComputer.Price
                        + "','" + singleComputer.VideoCard + "'");
                }
            }

            //myComputer.HasWiFi = false;
            //Console.WriteLine(myComputer.Motherboard);
            //Console.WriteLine(myComputer.HasWiFi);
            //Console.WriteLine(myComputer.VideoCard);
            //Console.WriteLine(myComputer.ReleaseDate);

        }
    }
}
