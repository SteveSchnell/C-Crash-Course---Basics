using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HelloWorld.Models;

namespace HelloWorld
{
    internal class Program2
    {
        static void Main(string[] args)
        {
            Computer myComputer = new Computer()
            {
                Motherboard = "Z690",
                HasLTE = false,
                HasWiFi = true,
                ReleaseDate = DateTime.Now,
                Price = 943.85m,
                VideoCard = "RTX 370"

            };

            myComputer.HasWiFi = false;
            Console.WriteLine(myComputer.Motherboard);
            Console.WriteLine(myComputer.HasWiFi);
            Console.WriteLine(myComputer.VideoCard);
            Console.WriteLine(myComputer.ReleaseDate);
        }
    }
}
