using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Question2
    {
        static void Main(string[] args)
        {
            int[] intarray = new int[10];
            int length = 0;
            for (int i = 0; i < intarray.Length; i++)
            {
                intarray[i] = i;
                length++;
            }
            GetMax(intarray, length);
            GetMin(intarray, length);
            GetAvg(intarray, length);
        }

        static void GetMax(int[] Array,int length)
        {
            int max = 0;
            for (int i = 0; i < length; i++)
            {
                if (max < i)
                {
                    max = i;
                }
            }
            Console.WriteLine("max is " + max);
        }
        static void GetMin(int[] Array, int length)
        {
            int min = 0;
            for (int i = 0; i < length; i++)
            {
                if (min > i)
                {
                    min = i;
                }
            }
            Console.WriteLine("min is " + min);
        }
        static void GetAvg(int[] Array,int length)
        {
            int sum = 0;
            for(int i = 0; i < length; i++)
            {
                sum = sum +Array[i];
            }
            Console.WriteLine("sum is " + sum);
            Console.WriteLine("avg is " + sum / length);
        }
    }
}