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
            string fullName = "Joshua Watkins";
            string location = "Stafford, Virginia";
            //print name and location
            Console.WriteLine("My name is {0}, I am from {1}.", fullName, location);
           
            //christmas countdown
            //variables
            DateTime today = DateTime.Today;
            DateTime christmas = new DateTime(2022, 12, 25);
            //print date and countdown
            Console.WriteLine("Current date "+ today.ToString("d"));
            Console.WriteLine("{0} days until Christmas.", (christmas - today).Days);

            //
            double width, height, woodLength, glassArea;
            string widthString, heightString;
            widthString = Console.ReadLine();
            width = double.Parse(widthString);
            heightString = Console.ReadLine();
            height = double.Parse(heightString);
            woodLength = 2 * (width + height) * 3.25;
            glassArea = 2 * (width * height);
            Console.WriteLine("The length of the wood is " +
            woodLength + " feet");
            Console.WriteLine("The area of the glass is " +
            glassArea + " square metres");

            Console.ReadLine();
            Console.ReadKey();
        }
    }
}
