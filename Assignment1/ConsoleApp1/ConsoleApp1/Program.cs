using System;

namespace examlpe1
{
    class program
    {
        static void Main(string[] args)
        {
            int n = 0;
            int m = 0;
            string s = "";
            Console.Write("Please input first integer number:");
            s = Console.ReadLine();
            n = Int32.Parse(s);
            Console.Write("Please input second integer number:");
            s = Console.ReadLine();
            m = Int32.Parse(s);
            Console.Write("Please input operator:");
            s = Console.ReadLine();
            switch (s)
            {
                case "+":
                    Console.WriteLine($"n+m="+(n+m));
                    break;  
                case "-":
                    Console.WriteLine($"n-m=" + (n - m));
                    break;
                case "*":
                    Console.WriteLine($"n*m=" + (n * m));
                    break;
                case "/":
                    Console.WriteLine($"n/m=" + (n / m));
                    break;
                case "%":
                    Console.WriteLine($"n%m=" + (n % m));
                    break;
            }
        }
    }
}