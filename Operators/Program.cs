using System;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 10;
            var b = 3;
            var c = 4;

            // Addition
            var add = a + b;

            // Division
            var div = a / b;

            // Not operator
            var notOp = !(a != b);

            // Equal to
            var equal = (a == b);

            // And operator
            var andOp = c > b && a > c;

            // Or operator
            var orOp = c > b || a > c;

            Console.WriteLine(add);
            Console.WriteLine(div);
            Console.WriteLine(notOp);
            Console.WriteLine(equal);
            Console.WriteLine(andOp);
            Console.WriteLine(orOp);
        }
    }
}
