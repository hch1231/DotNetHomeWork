using System;

namespace dotnetzy1._3
{
    class Program
    {
        static int readnum()
        {
            int num;
            Console.WriteLine("请输入数据：");
            num = int.Parse(Console.ReadLine());
            return num;
        }
        static bool primenum(int num)
        {
            for(int i = 2; i < num; i++)
            {
                if (num % i == 0)
                    return false; 
            }
            return true;
        }
        static void Main(string[] args)
        {
            int num;
            num = readnum();
            for(int i = 2; i < num; i++)
            {
                if((num%i==0)&&primenum(i))
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
