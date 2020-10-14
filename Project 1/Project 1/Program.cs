using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Number 1
            Console.WriteLine("Hello");
            Console.WriteLine("Hossen, Md. Sayem");
            Console.WriteLine();
            //Number 2
            int t = 30, r = 5;
            int sum = t + r;
            Console.WriteLine("Sum= " + sum);
            Console.WriteLine();
            //Number 3
            int div = t / r;
            Console.WriteLine("Result = " + div);
            Console.WriteLine();
            //Number 4
            int result = 8 * 6 - 5;
            Console.WriteLine("Result 1= " + result);
            result = (55 + 9) % 9;
            Console.WriteLine("Result 2= " + result);
            result = 20 + (-3 * 5 / 8);
            Console.WriteLine("Result 3= " + result);
            result = 5 + 15 / 3 * 2 - 8 % 3;
            Console.WriteLine("Result 4= " + result);
            Console.WriteLine();
            //Number 5
            int  mul, sub,  rem;
            int a = 6, b = 2;
            sum = a + b;
            mul = a * b;
            sub = a - b;
            div = a / b;
            rem = a % b;
            Console.WriteLine("Sum = " + sum);
            Console.WriteLine("Subtract = " + sub);
            Console.WriteLine("multiply = " + mul);
            Console.WriteLine("Div = " + div);
            Console.WriteLine("Remainder = " + rem);
            Console.WriteLine();
            //Number 6
            double expression = ((25.5 * 3.5) - (3.5 * 3.5) / 40.5 - 4.5);
                Console.WriteLine("result= " + expression);
            Console.WriteLine();
            //Number 7
            double w = 5.5, h = 8.5;
            double Area = 5.6 * 8.5;
            double p = 2 * (5.6 * 8.5);
            Console.WriteLine("Area is " +w+ "*" +h+" = " + Area);
            Console.WriteLine("Perimeter is 2 * ("+w+"+" +h+") = "+ p);
            Console.WriteLine();
            //Number 8
            int x = 25, y = 39;
            if(x!=y)
                Console.WriteLine(x +" != "+ y);
            else
                Console.WriteLine(x+" == "+y);
            if (x<y)
                Console.WriteLine(x + " < " + y);
            else
                Console.WriteLine(x + " > " + y);
            if(x<=y)
                Console.WriteLine(x + " <= " + y);
            else
                Console.WriteLine(x + " > " + y);

        }
    }
}
