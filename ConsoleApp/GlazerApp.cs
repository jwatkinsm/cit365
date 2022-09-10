using System;

namespace ConsoleApp
{
    internal class GlazerApp
    {
        public static void RunExample()
        {
            //variable
            double width, height, woodLength, glassArea;
            string widthString, heightString;
            //user input
            Console.WriteLine("What is the width value?: ");
            widthString = Console.ReadLine();
            width = double.Parse(widthString);
            Console.WriteLine("What is the height value?: ");
            heightString = Console.ReadLine();
            height = double.Parse(heightString);
            //calculate
            woodLength = 2 * (width + height) * 3.25;
            glassArea = 2 * (width * height);
            //print
            Console.WriteLine("The length of the wood is " +
            woodLength + " feet");
            Console.WriteLine("The area of the glass is " +
            glassArea + " square metres");

        }
    }
}