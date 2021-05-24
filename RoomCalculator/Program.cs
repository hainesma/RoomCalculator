using System;

namespace RoomCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string tryAgain = "Y";

            do
            {
                Console.WriteLine("Enter the length of the room:");
                string inputLength = Console.ReadLine();
                double length = double.Parse(inputLength);

                Console.WriteLine("Enter the width of the room:");
                string inputWidth = Console.ReadLine();
                double width = double.Parse(inputWidth);

                Console.WriteLine("Enter the height of the room:");
                string inputHeight = Console.ReadLine();
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

                Console.WriteLine("Would you like to continue? (Y/N)");
                tryAgain = Console.ReadLine();
                Console.WriteLine();
            } while (tryAgain == "Y" || tryAgain == "y");
            
        }
    }
}