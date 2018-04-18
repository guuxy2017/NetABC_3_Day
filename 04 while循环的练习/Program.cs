using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _04_while循环的练习
{
    class Program
    {
        static void Main(string[] args)
        {
            //提示用户输入yes或者no，只要不是yes或者no，就一直提示用户重新输入，用户只能能输入yes或者no
            Console.WriteLine("请你输入yes或者no");
            string input = Console.ReadLine();

            //分析循环体和循环条件
            //循环体：  控制台输出：提示用户输入yes或者no，接受输入，再判断
            //循环条件：input != "yes"  &&  input != "no"
            //改变循环条件的代码： Console.ReadLine();
            while (input != "yes" && input != "no")   // 逻辑与：一个true，一个false，则结果是false，跳出循环
            {
                Console.WriteLine("只能输入yes或者no");
                input = Console.ReadLine();
            }
            Console.ReadKey();
        }
    }
}
