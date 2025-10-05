using System;

class Program
{
    static void Main(string[] args)
    {
        // 练习1：打印 1 到 100
        Console.WriteLine("练习1：打印 1 到 100");
        for (int i = 1; i <= 100; i++)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine("\n");

        // 练习2：打印 1 到 100 的偶数
        Console.WriteLine("练习2：打印 1 到 100 的偶数");
        for (int i = 2; i <= 100; i += 2)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine("\n");

        // 练习3：计算 1 到 100 的和
        Console.WriteLine("练习3：计算 1 到 100 的和");
        int sum = 0;
        for (int i = 1; i <= 100; i++)
        {
            sum += i;
        }
        Console.WriteLine("总和 = " + sum + "\n");

        // 练习4：打印九九乘法表
        Console.WriteLine("练习4：九九乘法表");
        for (int i = 1; i <= 9; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write($"{j}x{i}={i * j}\t");
            }
            Console.WriteLine();
        }
        Console.WriteLine();

        // 练习5：输入一个数，判断是否为质数
        Console.WriteLine("练习5：输入一个数，判断是否为质数");
        Console.Write("请输入一个整数：");
        if (int.TryParse(Console.ReadLine(), out int num))
        {
            bool isPrime = true;
            if (num <= 1) isPrime = false;
            else
            {
                for (int i = 2; i <= Math.Sqrt(num); i++)
                {
                    if (num % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
            }

            Console.WriteLine(isPrime ? $"{num} 是质数" : $"{num} 不是质数");
        }
        else
        {
            Console.WriteLine("输入无效！");
        }
    }
}
