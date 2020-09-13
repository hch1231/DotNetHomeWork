using System;

namespace 整数数组求值
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = { 1, 1, 2, 3, 5, 8, 13, 21, 34 };
            int max = array1[0], min = array1[0];
            double avg = 0, sum = 0;
            foreach (int i in array1)
            {
                if (i > max)
                    max = i;
                if (i < min)
                    min = i;
                sum += i;
            }
            avg = sum / array1.Length;
            Console.WriteLine("最大值：" + max + " 最小值：" + min + " 平均值：" + avg + " 总和：" + sum);
        }
    }
}
