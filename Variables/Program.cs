using System;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Data Types:
                byte, int, float, char, string, bool

                Note:
                    When intializing float or decimal, add
                    'f' or 'm' to them respectively.
                    Eg:
                        float price = 2.2f;
                        decimal pay = 2.4m;

                We declare constant  with the 'Const' keyword.
                Eg:
                    const float PRICE = 3.4f;
             */

            /*
             Variable Naming:
               Variable Names should be camelCase.
               Eg:
                   float totalPrice = 20.5f;

             Methods and Class names should be PascalCase.
             Eg:
                   class StudentInfo() {};
                   public int GetStudentInfo() {};
            */
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
