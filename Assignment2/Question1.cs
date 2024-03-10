using System;

namespace assignment1
{
    class Question1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input the num:");
            string s = Console.ReadLine();
            int num= Int32.Parse(s);
            Console.WriteLine("The prime nums of this num are shown as below:");
            for(int i=2; i<num; i++)
            {
                if(num % i == 0)
                {
                    Judge(i);
                }
            }
            void Judge(int a)
            {                     
                for (int j = 2; j < a; ++j)
                { 
                    if (a % j == 0)
                    {
                        break;
                    }
                }
                Console.WriteLine(a);
            }
        }
    }
}