using System;

namespace RoomCalculator
{
    class Program
    {
        static void Main(string[] args)
        {

            string userContinue;
            double length, width, area, perimeter;
            Console.WriteLine("Welcome to Grand Circus Room Detail Generator!");

            do
            {
                Console.Write("Enter Length: ");
                length = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter Width: ");
                width = Convert.ToDouble(Console.ReadLine());

                area = length * width;
                perimeter = 2 * (length + width);
                Console.WriteLine("Area: " + area);
                Console.WriteLine("Perimeter: " + perimeter);

                if (area >= 650)
                {
                    Console.WriteLine("This is a large-sized room");
                }
                else if (area > 250 && area < 650)
                {
                    Console.WriteLine("This is a medium-sized room");
                }
                else
                {
                    Console.WriteLine("This is a small-sized room");
                }

                Console.WriteLine("Continue? (y/n) ");
                userContinue = Console.ReadLine();

            } while (userContinue.ToLower() == "y");

            Console.WriteLine("See ya!");
        }
    }
}