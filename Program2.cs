using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Dapper;
using HelloWorld.Data;
using HelloWorld.Models;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace HelloWorld
{
    internal class Program2
    {
        static void Main(string[] args)
        {
            IConfiguration config = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
            DataContextDapper dapper = new DataContextDapper(config);



            /*
            DataContextEF entityFramework = new DataContextEF(config);

            DateTime rightNow = dapper.LoadDataSingle<DateTime>("SELECT GETDATE()");
            
            Computer myComputer = new Computer() 
            {
                Motherboard = "Z690",
                HasWiFi = false,
                HasLTE = true,
                ReleaseDate = DateTime.Now,
                Price = 943.85m,
                VideoCard = "RTX 3070"

            };

            string sql =  @"INSERT INTO TutorialAppSchema.Computer (
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

            File.WriteAllText("log.txt",sql);
            using StreamWriter openFile = new("log.txt", append: true);

            openFile.WriteLine("\n" + sql + "\n");
            openFile.Close();
              


            
            //Console.WriteLine(ComputersJson);
            */
           string ComputersJson = File.ReadAllText("Computers.json");

            JsonSerializerOptions Options = new JsonSerializerOptions()
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase
            };          

            IEnumerable<Computer>? ComputersSystem = System.Text.Json.JsonSerializer.Deserialize<IEnumerable<Computer>>(ComputersJson, Options);

            IEnumerable<Computer>? Computers = JsonConvert.DeserializeObject<IEnumerable<Computer>>(ComputersJson);

            if (Computers != null)
            {
                foreach (Computer computer in Computers)
                {
                    //Console.WriteLine(computer.Motherboard);
                    string sql = @"INSERT INTO TutorialAppSchema.Computer (
                        Motherboard,
                        HasWiFi,
                        HasLTE,
                        ReleaseDate,
                        Price,
                        VideoCard
                    ) VALUES ('" + EsceprSingleQuote(computer.Motherboard)
                            + "','" + computer.HasWiFi
                            + "','" + computer.HasLTE
                            + "','" + computer.ReleaseDate
                            + "','" + computer.Price
                            + "','" + EsceprSingleQuote(computer.VideoCard)
                     + "')";

                    dapper.ExecuteSql(sql);
                }
            }

            JsonSerializerSettings settings = new JsonSerializerSettings()
            {
                ContractResolver = new CamelCasePropertyNamesContractResolver()
            };

            string computerCopyNewtonsoft = JsonConvert.SerializeObject(Computers, settings);

            File.WriteAllText("computerCopyNewtonsoft.txt", computerCopyNewtonsoft);

            string computerCopySystem = System.Text.Json.JsonSerializer.Serialize(ComputersSystem);

            File.WriteAllText("computerCopySystemt.txt", computerCopySystem);
        }

        static string EsceprSingleQuote(string input)
        { 
            string output = input.Replace("'", "''");
        
            return output;
        }

    }
}
