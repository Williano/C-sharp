using System;

namespace TypeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Explicit type conversion
            float f = 1.0f;
            int i = (int)f;
            */

            /* Non-compatible conversions like
               converting string to intger.

               You can use the 'Converse' class or the 'Parse'
               method.

               'Convert' class is part to the dotnet framework
               and is defined in the system namespace.
               It has bunch of methods for converting various types
               to other types. Some types are:
               - ToByte()
               - ToInt16()
               - ToInt32()
               - ToInt64()

             */

            /*
               1 byte == 8 bits (00000000)

               byte -> 1 byte (00000000)
               short -> 2 bytes (00000000) (00000000)
               integer -> 4 bytes (00000000) (00000000) (00000000) (00000000)
               long -> 8 bytes

             */

            /*
               In C#,
                 integer is Int32
                 short is Int16
             */

            // Using the Convert Class
            var number = "1234";
            int i = Convert.ToInt32(number);
            Console.WriteLine(i);

            // Type Casting
            float pay = 1.2f;
            int newPay = (int)pay;
            Console.WriteLine(newPay);

            // Exception Handling
            /*
             Syntax:
                    try
                    {
                      var numStr = "1234";
                      byte b = Convert.ToByte(numStr);
                      Console.WriteLine(b);

                    }
                    catch (System.Exception)
                    {

                        Console.WriteLine("The number could not be converted to a byte.");
                    }
             */
            try
            {
                var numStr = "1234";
                byte b = Convert.ToByte(numStr);
                Console.WriteLine(b);
            }
            catch (System.Exception)
            {

                Console.WriteLine("The number could not be converted to a byte.");
            }


        }
    }
}
