using System;

class Program
{
    static void Main(string[] args)
    {
        // 练习1：分数等级
        Console.Write("请输入分数（0-100）：");
        if (!int.TryParse(Console.ReadLine(), out int score))
        {
            Console.WriteLine("分数输入无效！");
        }
        else
        {
            if (score >= 90)       Console.WriteLine("等级：优秀");
            else if (score >= 80)  Console.WriteLine("等级：良好");
            else if (score >= 60)  Console.WriteLine("等级：及格");
            else                   Console.WriteLine("等级：不及格");
        }

        Console.WriteLine();

        // 练习2：switch 输出星期
        Console.Write("请输入 1~7 的数字：");
        if (!int.TryParse(Console.ReadLine(), out int day))
        {
            Console.WriteLine("输入无效！");
        }
        else
        {
            switch (day)
            {
                case 1: Console.WriteLine("星期一"); break;
                case 2: Console.WriteLine("星期二"); break;
                case 3: Console.WriteLine("星期三"); break;
                case 4: Console.WriteLine("星期四"); break;
                case 5: Console.WriteLine("星期五"); break;
                case 6: Console.WriteLine("星期六"); break;
                case 7: Console.WriteLine("星期日"); break;
                default: Console.WriteLine("超出范围！"); break;
            }
        }

        Console.WriteLine();

        // 练习3：奇偶数判断
        Console.Write("请输入一个整数：");
        if (!int.TryParse(Console.ReadLine(), out int number))
        {
            Console.WriteLine("输入无效！");
        }
        else
        {
            Console.WriteLine(number % 2 == 0 ? "偶数" : "奇数");
        }
    }
}
