using System;

namespace MyReverseArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter 5 numbers\nFirst nr:");
            string nr1 = Console.ReadLine();

            Console.WriteLine("Second nr:");
            string nr2 = Console.ReadLine();

            Console.WriteLine("Third nr:");
            string nr3 = Console.ReadLine();

            Console.WriteLine("Fourth nr:");
            string nr4 = Console.ReadLine();

            Console.WriteLine("Fifth nr:");
            string nr5 = Console.ReadLine();

            string[] numbers = { nr1, nr2, nr3, nr4, nr5 };

            Array.Reverse(numbers);

            Console.Write("\nElements in the reversed array are: \n");

            foreach (string value in numbers)
            {
                Console.WriteLine(value);
            }
        }
    }
}
