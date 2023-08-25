using System;
using System.Drawing;

namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            //----------------------------------------------------------------------------  Console.WriteLine  ------------------------------------------------------------------------------------
             
            Console.WriteLine("Hello C# Programmers");
            Console.WriteLine("Hello C# Programmers");
            Console.Write("First \n");
            Console.Write("Second");
            Console.WriteLine("Hello C# Programmers");
            Console.WriteLine("Hello \n\n\n");

            //----------------------------------------------------------------------------  Variables  ------------------------------------------------------------------------------------

            //// 1 byte is made up of 8 bits 00000000 - these bits can be used to store a number as follows
            // //// Each bit can be worth 0 or 1 of the value it is placed in
            // ////// From the right we start with a value of 1 and double for each digit to the left
            // //// 00000000 = 0
            // //// 00000001 = 1
            // //// 00000010 = 2
            // //// 00000011 = 3
            // //// 00000100 = 4
            // //// 00000101 = 5
            // //// 00000110 = 6
            // //// 00000111 = 7
            // //// 00001000 = 8

            // 1 byte (8 bit) unsigned, where signed means it can be negative
            byte myByte = 255;
            byte mySecondByte = 0;

            // 1 byte (8 bit) signed, where signed means it can be negative
            sbyte mySbyte = 127;
            sbyte mySecondSbyte = -128;


            // 2 byte (16 bit) unsigned, where signed means it can be negative
            ushort myUshort = 65535;

            // 2 byte (16 bit) signed, where signed means it can be negative
            short myShort = -32768;

            // 4 byte (32 bit) signed, where signed means it can be negative
            int myInt = 2147483647;
            int mySecondInt = -2147483648;

            // 8 byte (64 bit) signed, where signed means it can be negative
            long myLong = -9223372036854775808;


            // 4 byte (32 bit) floating point number
            float myFloat = 0.751f;
            float mySecondFloat = 0.75f;

            // 8 byte (64 bit) floating point number
            double myDouble = 0.751;
            double mySecondDouble = 0.75d;

            // 16 byte (128 bit) floating point number
            decimal myDecimal = 0.751m;
            decimal mySecondDecimal = 0.75m;

            Console.WriteLine(myFloat - mySecondFloat);
            Console.WriteLine(myDouble - mySecondDouble);
            Console.WriteLine(myDecimal - mySecondDecimal);


            Console.WriteLine("\n\n");


            string myString = "Hello World";
            Console.WriteLine(myString);
            string myStringWithSymbols = "!@#$@^$%%^&(&%^*__)+%^@##$!@%123589071340698ughedfaoig137";
            Console.WriteLine(myStringWithSymbols);

            bool myBool = true;

            Console.WriteLine("\n\n");

            //----------------------------------------------------------------------------  Data Structures  ------------------------------------------------------------------------------------

            string[] myGroceryArray = new string[2];

            myGroceryArray[0] = "Guacamole";
            myGroceryArray[1] = "Ice Cream";

            Console.WriteLine(myGroceryArray[0]);
            Console.WriteLine(myGroceryArray[1] + "\n\n");
            //Console.WriteLine(myGroceryArray[2]);

            string[] mySecondGroceryArray = { "Apples", "Eggs" };

            mySecondGroceryArray[0] = "";

            //mySecondGroceryArray[2] = "";

            Console.WriteLine(mySecondGroceryArray[0]);
            Console.WriteLine(mySecondGroceryArray[1]);

            Console.WriteLine("\n\n");

            List<string> myGroceryList = new List<string>() { "Milk", "Cheese" };

            Console.WriteLine(myGroceryList[0]);
            Console.WriteLine(myGroceryList[1]);

            //Console.WriteLine(mySecondGroceryArray[2]);

            myGroceryList.Add("Oranges");

            Console.WriteLine(myGroceryList[2]);

            Console.WriteLine("\n\n");

            IEnumerable<string> myGroceryIEnumerable = myGroceryList;

            Console.WriteLine(myGroceryIEnumerable.First());

            Console.WriteLine("\n\n");


            string[,] myTwoDimensionalArry = new string[,] {
                { "Apples", "Eggs" },
                { "Milk", "Cheese" }
            };

            Console.WriteLine(myTwoDimensionalArry[1,1]);

            Console.WriteLine("\n\n");

            Dictionary<string, string[]> myGroceryDictionary = new Dictionary<string, string[]>()
            {
                {"Dairy", new string[]{"Cheese", "Milk", "Eggs"}}
            };

            Console.WriteLine(myGroceryDictionary["Dairy"][2]);

            Dictionary<string, decimal> itemPrices = new Dictionary<string, decimal>()
            {
                {"cheese", 5.99m},
                {"carrots", 2.99m}
            };


            //Write You Code Above This Line
            Console.WriteLine(itemPrices["cheese"].GetType());
            Console.WriteLine(itemPrices["cheese"]);
            Console.WriteLine(itemPrices["carrots"]);

            Console.WriteLine("\n\n");

            */

            //----------------------------------------------------------------------------  Operators and Conditionals  ------------------------------------------------------------------------------------
            /*
             
            int myInt = 5;
            int mySecondInt = 10;
            Console.WriteLine(myInt);

            myInt++;

            Console.WriteLine(myInt);

            myInt += 7;

            Console.WriteLine(myInt);

            myInt -= 9;

            Console.WriteLine(myInt);

            Console.WriteLine(myInt * mySecondInt);

            Console.WriteLine(mySecondInt / myInt);

            Console.WriteLine(mySecondInt + myInt);

            Console.WriteLine(myInt - mySecondInt);

            Console.WriteLine(5 + 5 * 10);

            Console.WriteLine((5 + 5) * 10);

            Console.WriteLine("\n\n");

            Console.WriteLine(Math.Pow(5,4));

            Console.WriteLine(Math.Sqrt(25));

            Console.WriteLine("\n\n");

            string myString = "test";

            Console.WriteLine(myString);

            myString += ". second part.";

            Console.WriteLine(myString);

            myString = myString + " \"third\\ part.";

            Console.WriteLine(myString);

            string[] mystringArr = myString.Split(". ");

            Console.WriteLine(mystringArr[0]);
            Console.WriteLine(mystringArr[1]);
            Console.WriteLine(mystringArr[2] + "\n\n");

            myInt = 5;
            mySecondInt = 10;

            Console.WriteLine(myInt.Equals(mySecondInt));
            Console.WriteLine(myInt.Equals(mySecondInt / 2) + "\n\n");

            Console.WriteLine(myInt != mySecondInt);
            Console.WriteLine(myInt != mySecondInt / 2);
            Console.WriteLine(myInt != mySecondInt / 3);

            Console.WriteLine("\n" + (myInt >= mySecondInt));
            Console.WriteLine(myInt >= mySecondInt / 2);
            Console.WriteLine(myInt > mySecondInt);
            Console.WriteLine(myInt > mySecondInt - 2);
            Console.WriteLine(myInt <= mySecondInt);
            Console.WriteLine(myInt < mySecondInt);

            Console.WriteLine("");
            Console.WriteLine(5 < 10 && 5 > 10);
            Console.WriteLine(5 < 10 || 5 > 10);

            */

            //----------------------------------------------------------------------------  Conditional Statements  ------------------------------------------------------------------------------------
            /*
            int myInt = 5;
            int mySecondInt = 10;

            if(myInt < mySecondInt)
            {
                myInt += 10;
            }

            Console.WriteLine(myInt + "\n");

            string myCow = "cow";
            string myCapitaizedCow = "Cow";

            if(myCow == myCapitaizedCow)
            {
                Console.WriteLine("Equal");
            }
            else if(myCow == myCapitaizedCow.ToLower()) 
            {
                Console.WriteLine("Equal wthout case sensitivity");
            }
            else
            {
                Console.WriteLine("Not Equal");
            }

            Console.WriteLine("");

            switch (myCow)
            {
                case "cow":
                    Console.WriteLine("Lowercase");
                    break;
                case "Cow":
                    Console.WriteLine("Capitaized");
                    break;
                default:
                    break;
            }
            */

            //----------------------------------------------------------------------------  Loops  ------------------------------------------------------------------------------------

            /*
            int[] intsToCompress = new int[] {10, 15, 20, 25, 30, 12, 34};
            DateTime startTime = DateTime.Now;

            int totalValue = intsToCompress[0] + intsToCompress[1] + intsToCompress[2] + intsToCompress[3] + intsToCompress[4] + intsToCompress[5] + intsToCompress[6];

            Console.WriteLine("\nno loop :" + (DateTime.Now - startTime).TotalSeconds);
            Console.WriteLine(totalValue); //146

            totalValue = 0;
            startTime = DateTime.Now;

            for (int i = 0; i < intsToCompress.Length; i++)
            {
                totalValue += intsToCompress[i];
            }

            Console.WriteLine("\nfor loop :" + (DateTime.Now - startTime).TotalSeconds);
            Console.WriteLine(totalValue);

            totalValue = 0;
            startTime = DateTime.Now;

            foreach (var intsForCompress in intsToCompress)
            {
                totalValue += intsForCompress;
            }

            Console.WriteLine("\nforeach loop :" + (DateTime.Now - startTime).TotalSeconds);
            Console.WriteLine(totalValue);


            int index = 0;
            totalValue = 0;
            startTime = DateTime.Now;

            while (index < intsToCompress.Length)
            {
                totalValue += intsToCompress[index];
                index++;
            }

            Console.WriteLine("\nwhile loop :" + (DateTime.Now - startTime).TotalSeconds);
            Console.WriteLine(totalValue);


            index = 0;
            totalValue = 0;
            startTime = DateTime.Now;

            do
            {
                totalValue += intsToCompress[index];
                index++;
            }
            while (index < intsToCompress.Length);

            Console.WriteLine("\ndo while loop :" + (DateTime.Now - startTime).TotalSeconds);
            Console.WriteLine(totalValue);

            totalValue = 0;
            startTime = DateTime.Now;

            totalValue = intsToCompress.Sum();

            Console.WriteLine("\nSum() :" + (DateTime.Now - startTime).TotalSeconds);
            Console.WriteLine(totalValue);


            totalValue = 0;

            foreach (var intsForCompress in intsToCompress)
            {
                if (intsForCompress > 20)
                {
                    totalValue += intsForCompress;
                }
            }

            Console.WriteLine("\n\n" + totalValue);
            */

            //----------------------------------------------------------------------------  Methods  ------------------------------------------------------------------------------------

            int[] intsToCompress = new int[] { 10, 15, 20, 25, 30, 12, 34 };
            int totalValue = 0;

            DateTime startTime = DateTime.Now;

            totalValue = intsToCompress.Sum();

            Console.WriteLine("\nSum() :" + (DateTime.Now - startTime).TotalSeconds);
            Console.WriteLine(totalValue);

            startTime = DateTime.Now;

            totalValue = GetSum(intsToCompress);

            Console.WriteLine("\nGetSum() :" + (DateTime.Now - startTime).TotalSeconds);
            Console.WriteLine(totalValue);


            int[] intsToCompress2 = new int[] { 23, 23, 53, 56, 83, 92};

            totalValue = GetSum(intsToCompress2);
            Console.WriteLine("\n" + totalValue);


            //----------------------------------------------------------------------------  Scope  ------------------------------------------------------------------------------------
        }

        private static int GetSum(int[] intsToCompress) //
        {
            int totalValue = 0;
            foreach (var intsForCompress in intsToCompress)
            {
                totalValue += intsForCompress;
            }

            return totalValue;
        }

    }
}