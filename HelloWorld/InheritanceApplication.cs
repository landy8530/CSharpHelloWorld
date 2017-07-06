/**
* 命名空间: HelloWorld
*
* 功 能： N/A
* 类 名： InheritanceApplication
* 创建人：landy
* 创建时间：2017/7/5 14:26:34
* CLR VERSION: 4.0.30319.42000
* Ver 变更日期 负责人 变更内容
* ───────────────────────────────────
* V0.01 2017/7/5 14:26:34 landy 初版
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
    class InheritanceApplication
    {
        public void testInheritance()
        {
            Rectangles Rect = new Rectangles();

            Rect.setWidth(5);
            Rect.setHeight(7);

            // 打印对象的面积
            Console.WriteLine("总面积： {0}", Rect.getArea());
        }

    }

    class Shape
    {
        public void setWidth(int w)
        {
            width = w;
        }
        public void setHeight(int h)
        {
            height = h;
        }

        public Shape(int h, int w)
        {
            height = h;
            width = w;
        }

        public Shape()
        {
            height = 3;
            width = 4;
        }

        protected int width;
        protected int height;
    }

    // 派生类
    class Rectangles : Shape
    {

        public Rectangles():this(3,5)
        {
        }
        public Rectangles(int h, int w) : base(h, w)
        {
            Console.WriteLine("初始化长度： {0}", h);
            Console.WriteLine("初始化宽度： {0}", w);

        }
        
        public int getArea()
        {
            return (width * height);
        }

        public void Display()
        {
            Console.WriteLine("长度： {0}", height);
            Console.WriteLine("宽度： {0}", width);
            Console.WriteLine("面积： {0}", getArea());
        }
    }

    class Tabletop : Rectangles, PaintCost
    {
        private double cost;
        public Tabletop(int l, int w) : base(l, w)
        { }
        public double GetCost()
        {
            double cost;
            cost = getArea() * 70;
            return cost;
        }



        public new void Display()
        {
            base.Display();
            Console.WriteLine("成本： {0}", GetCost());
        }

        public int getCost(int area)
        {
            return area * 70;
        }
    }

    // 基类 PaintCost
    public interface PaintCost
    {
        int getCost(int area);

    }

}
