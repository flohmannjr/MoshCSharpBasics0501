using System;

namespace MoshCSharpBasics0501
{
    class Program
    {
        const int ValidateNumber = 1;
        const int MaximumNumber = 2;
        const int Orientation = 3;
        const int SpeedLimit = 4;

        static void Main(string[] args)
        {
            Console.Write("1 - Validate Input\n2 - Maximum Number\n3 - Orientation\n4 - Speed Limit\n\nChoose an exercise: ");

            switch (Convert.ToInt32(Console.ReadLine()))
            {
                case ValidateNumber:
                    Console.Write("Enter a number: ");
                    int number = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine((number >= 1 && number <= 10) ? "Valid" : "Invalid");
                    break;
                case MaximumNumber:
                    Console.Write("Enter two numbers:\nNumber 1: ");
                    int number1 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Number 2: ");
                    int number2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Maximum number: " + ((number1 > number2) ? number1 : number2));
                    break;
                case Orientation:
                    Console.Write("Enter image dimensions:\nWidth: ");
                    int width = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Height: ");
                    int height = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("The image orientation is " + ((width > height) ? "landscape" : "portrait") + ".");
                    break;
                case SpeedLimit:
                    Console.Write("Enter speed limit: ");
                    int speedLimit = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter car speed: ");
                    int carSpeed = Convert.ToInt32(Console.ReadLine());

                    if(carSpeed <= speedLimit)
                    {
                        Console.WriteLine("OK");
                    }
                    else
                    {
                        int speedExcess = carSpeed - speedLimit;
                        int demeritFactor = 5;
                        int demeritPoints = speedExcess / demeritFactor;

                        Console.WriteLine("Demerit points: " + demeritPoints + ((demeritPoints > 12) ? " - License Suspended." : ""));
                    }

                    break;
                default:
                    Console.WriteLine("Invalid exercise.");
                    break;
            }
        }
    }
}
