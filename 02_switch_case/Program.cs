using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02_switch_case
{
    class Program
    {
        static void Main(string[] args)
        {
            //输入几个人的名字,计算这几个人上辈都是干什么的?（老杨,老苏,老邹,老虎,老牛,老蒋,老王,老马）
            //分析：区间定值判断  使用SWITCH-CASE
            //Console.WriteLine("请输入要计算的人的姓名");
            //string name = Console.ReadLine();
            //switch (name)
            //{
            //    case "老杨": Console.WriteLine("老杨上辈子是折翼的天使");
            //        break;
            //    case "老苏": Console.WriteLine("老苏上辈子是老鸨子");
            //        break;
            //    case "老邹": Console.WriteLine("老邹上辈子是老苏的手下");
            //        break;
            //    case "老虎": Console.WriteLine("老虎上辈子被武松挂了");
            //        break;
            //    case "老牛": Console.WriteLine("上辈子是COW");
            //        break;
            //    default: Console.WriteLine("上辈子没这个人");
            //        break;
            //}
            //Console.ReadKey();

            //  成绩>=90 ：A
            //90>成绩>=80 ：B 	
            //80>成绩>=70 ：C
            //70>成绩>=60 ：D
            //         成绩<60   ：E
            //Console.WriteLine("请输入考试成绩！");
            //int score = Convert.ToInt32(Console .ReadLine ());

            //switch (score /10)            //（score/10）将一个范围转化成一个定值
            //{
            //    case 10 :    //当连续的几个case中所带的代码一样的时候，可以省略前面的，只写最后一个case中的代码
            //        break;
            //    case 9: Console.WriteLine("A");
            //        break;
            //    case 8: Console.WriteLine("B");
            //        break;
            //    case 7: Console.WriteLine("C");
            //        break;
            //    case 6: Console.WriteLine("D");
            //        break;
            //    default: Console.WriteLine("E");
            //        break;
            //}
            //Console.ReadKey();

            //请用户输年份,再输入月份,输出该月的天数.(结合之前如何判断闰年来做)

            #region  自己的做法： 错误是未分 8月以后的31天的月份发生变化
            //Console.WriteLine("请您输入一个年份");
            //int year = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("请您再输入一个月份");
            //int month = Convert.ToInt32(Console.ReadLine());
            //bool b = (year % 400 == 0) || ((year % 4 == 0) && (year % 100 != 0));   // 闰年判断算法：年份能被400整除 ||  年份能被4整除 && 年份不能被100整除

            //if (month >= 1 && month <= 12)    //  12 >= 月份 >= 1
            //{
            //    if (month % 2 != 0)   //  奇数月
            //    {
            //        Console.WriteLine("{0}月的天数是31", month);
            //    }
            //    else   //  偶数月
            //    {
            //        if (month != 2)   // 判断不是2月
            //        {
            //            Console.WriteLine("{0}月的天数是30", month);
            //        }
            //        else  //  判断是2月
            //        {
            //            if (b)   // 判断是闰年2月
            //            {
            //                Console.WriteLine("{0}月的天数是29", month);
            //            }
            //            else  // 判断不是闰年2月
            //            {
            //                Console.WriteLine("{0}月的天数是28", month);
            //            }
            //        }
            //    }
            //}
            //Console.ReadKey();
            #endregion

            #region  老赵的做法--1
            //Console.WriteLine("请您输入一个年份");
            //int year = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("请您再输入一个月份");
            //int month = Convert.ToInt32(Console.ReadLine());
            //int day = 0;//存储天数
            //switch (month )
            //{
            //    case 1: 
            //    case 3:
            //    case 5:
            //    case 7:
            //    case 8:
            //    case 10:
            //    case 12: day =31;
            //        break;
            //    case 2:    //判断2月
            //        if ((year % 400 == 0) || (year % 4 == 0  &&  year % 100 != 0))    //判断闰年
            //            {
            //                 day =29;
            //            }
            //        else 
            //            {
            //             day =28;
            //            }
            //        break ;
            //    default:  day =30;    //余下的是30天的月份
            //        break;
            //}
            //Console .WriteLine ("{0}年{1}月有{2}天",year ,month ,day);
            //Console.ReadKey();
            #endregion

            #region  老赵的做法--2  使用try catch
            Console.WriteLine("请您输入一个年份");
            try   //try年份
            {
                int year = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("请您再输入一个月份");
                try  //try月份
                {
                    int month = Convert.ToInt32(Console.ReadLine());
                    if (month >= 1 && month <= 12)  //判断月份是否在1-12区间
                    {
                        int day = 0;//存储天数
                        switch (month)
                        {
                            case 1:
                            case 3:
                            case 5:
                            case 7:
                            case 8:
                            case 10:
                            case 12: day = 31;
                                break;
                            case 2:    //判断2月
                                if ((year % 400 == 0) || (year % 4 == 0 && year % 100 != 0))    //判断闰年
                                {
                                    day = 29;
                                }
                                else
                                {
                                    day = 28;
                                }
                                break;
                            default: day = 30;    //余下的是30天的月份
                                break;
                        }  //switch
                        Console.WriteLine("{0}年{1}月有{2}天", year, month, day);
                    }   //if
                    else
                    {
                        Console.WriteLine("月份必须在1-12月之间，程序退出");
                    }
                }            //try月份
                catch     //catch月份
                {
                    Console.WriteLine("月份输入有误，程序退出");
                }
            }           //try年份
            catch   //catch年份
            {
                Console.WriteLine("年份输入有误，程序退出");
            }
            Console.ReadKey();
            #endregion

        }
    }
}
