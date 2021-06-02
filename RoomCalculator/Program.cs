using System;

namespace RoomCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            bool goOn = true;

            while( goOn == true)
            {
                string inputLength = GetUserInput("Enter the length of the room:");
                double length = double.Parse(inputLength);

                string inputWidth = GetUserInput("Enter the width of the room:");
                double width = double.Parse(inputWidth);

                string inputHeight = GetUserInput("Enter the height of the room:");
                double height = double.Parse(inputHeight);

                double area = length * width;
                Console.WriteLine($"The area of the room is {area} square feet.");

                double perimeter = 2 * length + 2 * width;
                Console.WriteLine($"The perimeter of the room is {perimeter} feet.");

                double volume = length * width * height;
                Console.WriteLine($"The volume of the room is {volume} cubic feet.");

                double carpetTiles = area / 5;
                Console.WriteLine($"Carpet tiles: {carpetTiles}");

                double cansPaint = perimeter / 5;
                Console.WriteLine($"Cans of paint: {cansPaint}");

                goOn = GetContinue();
            } 
           
        }
        public static string GetUserInput(string message)
        {
            Console.WriteLine(message);
            string input = Console.ReadLine();
            return input;
        }

        public static bool GetContinue()
        {
            string input = GetUserInput("Would you like to continue? Y/N");
            if(input.ToLower() == "y")
            {
                return true;
            }
            else if (input.ToLower() == "n")
            {
                return false;
            }
            else
            {
                Console.WriteLine("I don't understand that input. Please try again.");
                return GetContinue();
            }
        }
    }
}