using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {//variables
         //string fullName = "Joshua Watkins";
         // string location = "Stafford, Virginia";
         //print/call name and location
            GetUserNameAndLocation();
            //Console.WriteLine("My name is {0}, I am from {1}.", fullName, location);

            //christmas countdown
            //variables
            // DateTime today = DateTime.Today;
            // DateTime christmas = new DateTime(2022, 12, 25);
            //print/call date and countdown
            ChristmasCountdown();
            // Console.WriteLine("\nCurrent date "+ today.ToString("d"));
            // Console.WriteLine("{0} days until Christmas.", (christmas - today).Days);

            //window measurements 2.1.1
            GlazerApp.RunExample();
            Console.WriteLine("Press any key to exit...");
            _ = Console.ReadKey();
            //Console.ReadLine ();
        }
        private static void GetUserNameAndLocation()
        {
           //user input name Location
            Console.WriteLine("What is your name? ");
            var personName = Console.ReadLine();
            Console.WriteLine($"Hi {personName}! Where are you from? ");
            var personLocation = Console.ReadLine();
            Console.WriteLine($"I have never been to {personLocation}. I bet it is nce. \nPress  any key to continue...");
            Console.ReadKey();

            //variables
            var Person = new person
            {
                Name = personName,
                Location = personLocation
            };
        }
        private static void ChristmasCountdown() 
        {
            //variables
            DateTime today = DateTime.Today;
            DateTime christmas = new DateTime(2022, 12, 25);
            var daysLeft = (christmas - today).Days;
            //calculate
            Console.WriteLine($"Today is {today.ToString("d")}");
            Console.WriteLine($"There are {daysLeft} days until Christmas");
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
        }
    }

    
}
