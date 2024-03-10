using System;

namespace assignment2
{
    class Question4
    {
        static void Main(string[] args)
        {
                int[,] array = null;
                //直接在程序里面给的任意矩阵
                array = new int[,] {{ 1, 2, 3, 2},
                                    { 5, 1, 2, 3},
                                    { 3, 5, 1, 2},
                                    { 1, 3, 5, 1}};
                //调用函数进行判断并输出
                var res = IsMatrix(array);
                Console.WriteLine(res);
                Console.ReadKey();
            }
            private static bool IsMatrix(int[,] matrix)
            //运算每一条对角线
            {
                for (int i = 0; i < matrix.GetLength(0) - 1; i++)
                {
                    for (int j = 0; j < matrix.GetLength(1) - 1; j++)
                    {
                        if (matrix[i + 1, j + 1] != matrix[i, j])
                        {
                            return false;
                        }
                    }
                }
                return true;
            }

        }
    }