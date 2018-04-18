using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _05_while循环的3个练习题
{
    class Program
    {
        static void Main(string[] args)
        {
            ///输入班级人数，然后依次输入学员成绩，计算班级学员的平均成绩和总成绩
            ///分析循环体和循环条件
            ///循环体：  提示输入学员成绩，并接收，转成int类型，累加总成绩中
            ///循环条件：循环的次数，小于等于班级的人数
            ///改变循环条件的代码： i ++
            #region   不带try catch
            //Console.WriteLine("请输入班级人数");
            //int count = Convert.ToInt32(Console.ReadLine());
            //int i = 0;  //声明一个变量，记录循环的次数
            //int sum = 0;  //声明一个变量，记录总成绩

            //while (i < count)   //当 int i = 1时，条件可以写成：i <= count 
            //{
            //    Console.WriteLine("请输入第{0}个学员的成绩。", i + 1);
            //    int score = Convert.ToInt32(Console.ReadLine());
            //    sum += score;
            //    i++;
            //}
            //Console.WriteLine("学员总成绩是{0}，平均分是{1:0.00}", sum, sum / count);
            //Console.ReadKey();
            #endregion

            #region  使用try  catch
            //Console.WriteLine("请输入班级人数");
            //int count = Convert.ToInt32(Console.ReadLine());
            //int i = 0;  //声明一个变量，记录循环的次数
            //int sum = 0;  //声明一个变量，记录总成绩

            //while (i < count)   //当 int i = 1时，条件可以写成：i <= count 
            //{
            //    Console.WriteLine("请输入第{0}个学员的成绩。", i + 1);
            //    try
            //    {
            //        int score = Convert.ToInt32(Console.ReadLine());
            //        sum += score;
            //        i++;
            //    }
            //    catch
            //    {
            //        Console.WriteLine("输入有误！请重新输入.");
            //    }
            //}
            //Console.WriteLine("学员总成绩是{0}，平均分是{1:0.00}", sum, sum / count);
            //Console.ReadKey();
            #endregion


            //老师问学生,这道题你会做了吗?如果学生答"会了(y)",则可以放学.
            //如果学生不会做(n),则老师再讲一遍,再问学生是否会做了......
            //直到学生会为止,才可以放学.
            //直到老师给他讲了10遍还不会,都要放学
            // ↑↑循环体：老师问，学生答，老师讲
            // ↑↑循环条件：1、学生答不会，2、老师讲10遍

            int i = 0;                //声明一个变量，记录循环次数，表示老师讲的次数
            string answer = " ";  //声明一个变量，记录学生回答，
            while (answer != "yes" && i < 10)
            {
                Console.WriteLine("这是我第{0}遍给你讲，你会做了吗？", i + 1);
                answer = Console.ReadLine();

                //限制学生回答在yes和no两个答案中
                while (answer != "yes" && answer != "no")  
                {
                    Console.WriteLine("学生只能输入yes或者no  ！！");
                    answer = Console.ReadLine();
                }

                i++;   //老师讲的次数加一遍
            }
            Console.ReadKey();

        }
    }
}
