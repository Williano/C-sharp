using System;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            byte number = 3;
            int count = 10;
            float totalPrice = 20.95f;
            char character = 'A';
            string firstName = "Will";
            bool isWorking = false;
            const int PRICE = 30;

            Console.WriteLine(number);
            Console.WriteLine(count);
            Console.WriteLine(totalPrice);
            Console.WriteLine(character);
            Console.WriteLine(firstName);
            Console.WriteLine(isWorking);
            Console.WriteLine("{0} {1}", totalPrice, firstName);
            Console.WriteLine(PRICE);
        }
    }
}
