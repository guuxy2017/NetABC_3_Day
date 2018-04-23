using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _08__while循环的3个练习
{
    class Program
    {
        static void Main(string[] args)
        {
            //练习1---->要求用户输入用户名和密码，只要不是admin、888888,  就一直提示用户,,请重新输入。
            //循环体： 提示用户重新输入用户名和密码
            //循环条件：admin、888888, 有一个错误
            #region  写法一
            //Console.WriteLine("请输入用户名");
            //string userName = Console.ReadLine();
            //Console.WriteLine("请输入密码");
            //string password = Console.ReadLine();

            //while (userName != "admin" || password != "888888")
            //{
            //    Console.WriteLine("请重新输入用户名");
            //   userName = Console.ReadLine();
            //    Console.WriteLine("请重新输入密码");
            //    password = Console.ReadLine();

            //}
            //Console.WriteLine("登陆成功！！");
            //Console.ReadKey();
            #endregion

            #region  写法二
            //string userName = " ";
            //string userPwd = " ";
            //while (true)
            //{
            //    Console.WriteLine("请输入用户名");
            //    userName = Console.ReadLine(); 
            //    Console.WriteLine("请输入密码");
            //    userPwd = Console.ReadLine();
            //    if (userName =="admin" && userPwd =="888888")
            //    {
            //         Console.WriteLine("登陆成功");
            //         break;
            //    }
            //}
            //Console.ReadKey();

            #endregion

            //练习2----->提示用户输入用户名和密码 admin 888888 最多让用户输入3次，如果3次都不会，则退出登录程序
            //string userName = "";
            //string userPwd = "";
            //int i = 0;
            //while (true)
            //{
            //    Console.WriteLine("请输入用户名");
            //    userName = Console.ReadLine();
            //    Console.WriteLine("请输入密码");
            //    userPwd = Console.ReadLine();
            //    if (userName == "admin" && userPwd == "888888")
            //    {
            //        Console.WriteLine("登陆成功");
            //        break;
            //    }
            //    else
            //    {
            //        i++;
            //    }
            //    if (i >= 3)
            //    {
            //        Console.WriteLine("输入次数已到，程序退出");
            //        break;
            //    }
            //}
            //Console.ReadKey();


            //练习3----->要求用户A输入用户名  要求不能为空 “”   只要为空  就提示一直重新输入，  要求B输入用户名， 第一  不能为空，第二 不能跟用户A的用户名相同



        }
    }
}
