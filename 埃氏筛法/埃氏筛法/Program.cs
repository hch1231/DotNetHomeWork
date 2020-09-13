using System;

namespace 埃氏筛法
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[101];
            for (int i = 0; i <= 100; i++)
            {
                array[i] = i;
            }
            for (int i = 2; i <= 100; i++)
            {
                for (int j = 2; i * j <= 100; j++)
                    array[i * j] = 0;
            }
            for (int i = 2; i <= 100; i++)
            {
                if (array[i] != 0)
                    Console.WriteLine(array[i]);
            }
        }
    }
}
