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
                double length = 0;
                double width = 0;
                double height = 0;

                try
                {
                    string inputLength = GetUserInput("Enter the length of the room:");
                    length = double.Parse(inputLength);
                    if(length <= 0)
                    {
                        throw new Exception("Only positive values are accepted. Please try again.");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("That was not a valid number. Please try again.");
                    continue;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    continue;
                }

                try
                {
                    string inputWidth = GetUserInput("Enter the width of the room:");
                    width = double.Parse(inputWidth);
                    if (width <= 0)
                    {
                        throw new Exception("Only positive values are accepted. Please try again.");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("That was not a valid number. Please try again.");
                    continue;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    continue;
                }

                try 
                { 
                string inputHeight = GetUserInput("Enter the height of the room:");
                    height = double.Parse(inputHeight);
                    if (height <= 0)
                    {
                        throw new Exception("Only positive values are accepted. Please try again.");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("That was not a valid number. Please try again.");
                    continue;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    continue;
                }

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