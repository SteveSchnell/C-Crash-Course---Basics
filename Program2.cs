using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using AutoMapper;
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


            string ComputersJson = File.ReadAllText("ComputersSnake.json");

            /*
            Mapper mapper = new Mapper(new MapperConfiguration((cfg) =>
            {
                cfg.CreateMap<ComputerSnake, Computer>()
                .ForMember(destination => destination.ComputerId, options => options.MapFrom(source => source.computer_id))
                .ForMember(destination => destination.CPUCores, options => options.MapFrom(source => source.cpu_cores))
                .ForMember(destination => destination.HasLTE, options => options.MapFrom(source => source.has_lte))
                .ForMember(destination => destination.HasWiFi, options => options.MapFrom(source => source.has_wifi))
                .ForMember(destination => destination.Motherboard, options => options.MapFrom(source => source.motherboard))
                .ForMember(destination => destination.VideoCard, options => options.MapFrom(source => source.video_card))
                .ForMember(destination => destination.ReleaseDate, options => options.MapFrom(source => source.release_date))
                .ForMember(destination => destination.Price, options => options.MapFrom(source => source.price));
            }));
            */

            /*
            IEnumerable<ComputerSnake>? ComputersSystem = System.Text.Json.JsonSerializer.Deserialize<IEnumerable<ComputerSnake>>(ComputersJson);

            if (ComputersSystem != null)
            {
                IEnumerable<Computer> ComputersResult  = mapper.Map<IEnumerable<Computer>>(ComputersSystem);

                foreach (Computer computer in ComputersResult)
                {
                    Console.WriteLine(computer.Motherboard);
                }
            }
            */

            IEnumerable<Computer>? ComputersSystem = System.Text.Json.JsonSerializer.Deserialize<IEnumerable<Computer>>(ComputersJson);

            if (ComputersSystem != null)
            {         
                foreach (Computer computer in ComputersSystem)
                {
                    Console.WriteLine(computer.Motherboard);
                }
            }

            /*

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
            */
        }

        static string EsceprSingleQuote(string input)
        { 
            string output = input.Replace("'", "''");
        
            return output;
        }

    }
}
