/**
* 命名空间: HelloWorld
*
* 功 能： N/A
* 类 名： PolymorphismApplication
* 创建人：landy
* 创建时间：2017/7/6 9:00:34
* CLR VERSION: 4.0.30319.42000
* Ver 变更日期 负责人 变更内容
* ───────────────────────────────────
* V0.01 2017/7/6 9:00:34 landy 初版
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
    /// <summary>
    // 静态多态性
    // 在编译时，函数和对象的连接机制被称为早期绑定，也被称为静态绑定。C# 提供了两种技术来实现静态多态性。分别为：
    // 函数重载
    // 运算符重载
//     动态多态性
//     C# 允许您使用关键字 abstract 创建抽象类，用于提供接口的部分类的实现。当一个派生类继承自该抽象类时，实现即完成。抽象类包含抽象方法，抽象方法可被派生类实现。派生类具有更专业的功能。
//     请注意，下面是有关抽象类的一些规则：
//     您不能创建一个抽象类的实例。
//     您不能在一个抽象类外部声明一个抽象方法。
//     通过在类定义前面放置关键字 sealed，可以将类声明为密封类。当一个类被声明为 sealed 时，它不能被继承。抽象类不能被声明为 sealed。
    /// </summary>
    class PolymorphismApplication
    {
        public void print(int i)
        {
            Console.WriteLine("Printing int: {0}", i);
        }

        public void print(double f)
        {
            Console.WriteLine("Printing float: {0}", f);
        }

        public void print(string s)
        {
            Console.WriteLine("Printing string: {0}", s);
        }
    }

    abstract class Shapes
    {
        public abstract int area();
    }
    class Rect : Shapes
    {
        private int length;
        private int width;
        public Rect(int a = 0, int b = 0)
        {
            length = a;
            width = b;
        }
        public override int area()
        {
            Console.WriteLine("Rectangle 类的面积：");
            return (width * length);
        }
    }

    /// <summary>
    /// 当有一个定义在类中的函数需要在继承类中实现时，可以使用虚方法。虚方法是使用关键字 virtual 声明的。虚方法可以在不同的继承类中有不同的实现。对虚方法的调用是在运行时发生的。
//     动态多态性是通过 抽象类 和 虚方法 实现的。
    /// </summary>
    class Shapev
    {
        protected int width, height;
        public Shapev(int a = 0, int b = 0)
        {
            width = a;
            height = b;
        }
        public virtual int area()
        {
            Console.WriteLine("父类的面积：");
            return 0;
        }
    }
    class Rectanglev : Shapev
    {
        public Rectanglev(int a = 0, int b = 0) : base(a, b)
        {

        }
        public override int area()
        {
            Console.WriteLine("Rectangle 类的面积：");
            return (width * height);
        }
    }
    class Trianglev : Shapev
    {
        public Trianglev(int a = 0, int b = 0) : base(a, b)
        {

        }
        public override int area()
        {
            Console.WriteLine("Triangle 类的面积：");
            return (width * height / 2);
        }
    }
    class Caller
    {
        public void CallArea(Shapev sh)
        {
            int a;
            a = sh.area();
            Console.WriteLine("面积： {0}", a);
        }
    }



}
