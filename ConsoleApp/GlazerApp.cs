using System;
namespace ConsoleApp
{

	internal class GlazerApp
	{
		public static void RunExample()
		{
            //variables
            double width, height, woodLength, glassArea;
            string widthString, heightString;
            //user input
            Console.WriteLine("\nEnter the width of the window");
            widthString = Console.ReadLine();
            width = double.Parse(widthString);
            Console.WriteLine("Enter the hieght of window");
            heightString = Console.ReadLine();
            //calculate
            height = double.Parse(heightString);
            woodLength = 2 * (width + height) * 3.25;
            glassArea = 2 * (width * height);
            //print result
            Console.WriteLine("The length of the wood is " +
            woodLength + " feet");
            Console.WriteLine("The area of the glass is " +
            glassArea + " square metres");
        }
    }
}