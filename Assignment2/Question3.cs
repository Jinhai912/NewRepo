using System;

namespace Test
{
    class Test
    {
        static void Main(string[] args)
        {
            Console.WriteLine("2-100之间的素数为：");
            GetPrimeNum();
        }
        static void GetPrimeNum()
        {
            for (int i = 2; i <= 100; i++)
            {
                bool pri = true;
                for (int j = 2; j < i; j++)
                {
                    if(i % j == 0 )
                    {
                        pri = false;
                        break;
                    }
                }
                if(pri)
                {
                    Console.WriteLine(i + " ");
                }
            }
        }
    }
}