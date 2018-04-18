using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03_while循环
{
    class Program
    {
        static void Main(string[] args)
        {
            //循环结构
            //习题：输出10遍，欢迎来到传播智客学习.NET
            //分析出循环体和循环条件，以及改变循环条件的代码
            //循环体：向控制台打印一行文本
            //循环条件：打印次数小于10
            //改变循环条件的代码：i++
            //int i = 0;  //声明一个循环变量记录循环的次数
            //while (i < 10)
            //{
            //    Console.WriteLine("欢迎来到传播智客学习.NET第{0}次", i + 1);
            //    i++;   // i= i+1, 此代码用来改变没执行一次，就改变一次循环条件
            //}
            //Console.ReadKey();

            //习题：求1-100之间的所有整数的和
            //分析循环体和循环条件
            //循环体：  1+2+3...........+99+100,  累加
            //循环条件：i <= 100 ， 记录循环次数的变量i
            //改变循环条件的代码：i++
            //int i = 1;
            //int sum = 0;
            //while (i <= 100)
            //{
            //    sum = sum + i;  //或者写成：sum += i;
            //    i++;
            //}
            //Console.WriteLine(sum);
            //Console.ReadKey();

            //习题：求1-100之间的所有奇数的和
            //分析循环体和循环条件
            //循环体：  1+3+5...........+99,  累加
            //循环条件：i <= 100 ， 记录循环次数的变量i
            //改变循环条件的代码：i=i++
            //int i = 1;
            //int sum = 0;
            //while (i <= 100)
            //{
            //    if (i % 2 != 0)
            //    {
            //        sum += i;

            //    }
            //    i++;
            //}
            //Console.WriteLine(sum);
            //Console.ReadKey();

            //习题：求1-100之间的所有偶数的和
            //分析循环体和循环条件
            //循环体：  0+2+4...........+100,  累加
            //循环条件：i <= 100 ， 记录循环次数的变量i
            //改变循环条件的代码：i=i++
            int i = 1;
            int sum = 0;
            while (i <= 100)
            {
                if (i % 2 == 0)
                {
                    sum += i;

                }
                i++;
            }
            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}
