/**
* 命名空间: HelloWorld
*
* 功 能： N/A
* 类 名： ExplicitConversion
* 创建人：landy
* 创建时间：2017/7/4 8:16:46
* CLR VERSION: 4.0.30319.42000
* Ver 变更日期 负责人 变更内容
* ───────────────────────────────────
* V0.01 2017/7/4 8:16:46 landy 初版
*
* Copyright (c) 2017 Lir Corporation. All rights reserved.
*┌──────────────────────────────────┐
*│　此技术信息为本公司机密信息，未经本公司书面同意禁止向第三方披露．　│
*│　版权所有：厦门卫生检疫技术研究所 　　　　　　　　　　　　　　     │
*└──────────────────────────────────┘
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class ExplicitConversion
    {
        //static void Main(string[] args)
        //{
        //    double d = 5673.74;
        //    int i;
        //    int j; // modify by pengyou 2017/7/5

        //    // 强制转换 double 为 int
        //    i = (int)d;
        //    Console.WriteLine(i);
        //    Console.ReadKey();

        //}

        public int convertDouble2Int(double d)
        {
            int i;

            // 强制转换 double 为 int
            i = (int)d;
            return i;
        }

    }

    class StringConversion
    {
        public void toString()
        {
            int i = 75;
            float f = 53.005f;
            double d = 2345.7652;
            bool b = true;

            Console.WriteLine(i.ToString());
            Console.WriteLine(f.ToString());
            Console.WriteLine(d.ToString());
            Console.WriteLine(b.ToString());
        }
        public void convert()
        {
            string locstr = 123.ToString();

            //如果要将"locstr"转成整型数

            //方法一: 用 Convert 
            int i = Convert.ToInt16(locstr);
            Console.WriteLine("使用Convert转换：{0}", i.ToString());
            //方法二: 用 Parse
            int ii = int.Parse(locstr);
            Console.WriteLine("使用Parse转换：{0}", ii.ToString());
            //方法三：int.TryParse(string s,out int i)
            //该方式也是将数字内容的字符串转换为int类型，但是该方式比int.Parse(string s) 好一些，
            //它不会出现异常，最后一个参数result是输出值，如果转换成功则输出相应的值，转换失败则输出0。
            string s1 = "abcd";
            string s2 = "1234";
            int a, b;
            bool bo1 = int.TryParse(s1, out a);
            Console.WriteLine(s1 + "通过TryParse转换： " + bo1 + " " + a);
            bool bo2 = int.TryParse(s2, out b);
            Console.WriteLine(s2 + "通过TryParse转换： " + bo2 + " " + b);


        }
    }

    class ObjectConvert
    {

        public void convertObject()
        {
            int inum = 100;
            long lnum = inum; // 进行了隐式转换，将 int 型（数据范围小）数据转换为了 long 型（数据范围大）的数据
            Class1 c1 = new Class2(); // 这里也是隐式转换，将一个新建的 Class2 实例转换为了其基类 Class1 类型的实例 C1

            double dnum = 100.1;
            int ifromd = (int)dnum; //double类型显式转换转为int类型


            Class1 c11 = new Class1();
            Class2 c22 = c11 as Class2; //使用as进行显式转换
            Console.WriteLine("对象类型转换：c22 is Class1 {0}", c22 is Class1);
            Console.WriteLine("对象类型转换：c22 is Class2 {0}", c22 is Class2);
            Console.WriteLine("对象类型转换：c11 is Class1 {0}", c11 is Class1);
        }

        
    }

    class Class1
    {
        
    }

    class Class2 : Class1 //类Class2是类Class1的子类
    {

    }

}
