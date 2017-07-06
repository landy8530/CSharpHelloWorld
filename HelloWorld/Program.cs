/**
* 命名空间: HelloWorld
*
* 功 能： N/A
* 类 名： Program
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

// #define PI

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello world");
            //Console.ReadKey();
            //Rectangle rect = new Rectangle();
            //rect.Acceptdetails();
            //rect.Display();

            //ExplicitConversion ec = new ExplicitConversion();

            //double d = 223.23;

            //int i = ec.convertDouble2Int(d);

            //Console.WriteLine("类型强制转换：由double类型，值为{0}，转化为int类型，值为{1}", d,i);

            //转为字符串
            //StringConversion sc = new StringConversion();
            //Console.WriteLine("基本类型转为字符串事例：");
            //sc.toString();
            ////基本类型转换
            //sc.convert();

            //对象类型转换
            //ObjectConvert oc = new ObjectConvert();
            //oc.convertObject();

            ////常量定义
            //DeclaringConstants dc = new DeclaringConstants();
            //dc.Constants();

            //运算符
            //             OperatorsAppl oa = new OperatorsAppl();
            //             oa.operators();
            // 
            //             //算术运算符
            //             oa.operators2();
            //             //关系运算符
            //             oa.operators3();
            //             //逻辑运算符
            //             oa.operators4();
            // 
            //             //位运算符
            //             oa.operators5();
            //             //其他运算符
            //             oa.operators6();

            /* 局部变量定义 */
            //             int a = 100;
            //             int b = 200;
            //             int ret;
            //             NumberManipulator n = new NumberManipulator();
            // 
            //             //调用 FindMax 方法
            //             ret = n.FindMax(a, b);
            //             Console.WriteLine("最大值是： {0}", ret);
            // 
            //             //调用 factorial 方法
            //             Console.WriteLine("6 的阶乘是： {0}", n.factorial(6));
            //             Console.WriteLine("7 的阶乘是： {0}", n.factorial(7));
            //             Console.WriteLine("8 的阶乘是： {0}", n.factorial(8));

            //值传递方式
            /* 局部变量定义 */
            //             int a = 100;
            //             int b = 200;

            //             Console.WriteLine("在交换之前，a 的值： {0}", a);
            //             Console.WriteLine("在交换之前，b 的值： {0}", b);
            // 
            //             /* 调用函数来交换值 */
            //             n.swap(a, b);
            // 
            //             Console.WriteLine("在交换之后，a 的值： {0}", a);
            //             Console.WriteLine("在交换之后，b 的值： {0}", b);

            //             Console.WriteLine("引用传递在交换之前，a 的值： {0}", a);
            //             Console.WriteLine("引用传递在交换之前，b 的值： {0}", b);
            // 
            //             /* 调用函数来交换值 */
            //             n.swapByRef(ref a, ref b);
            // 
            //             Console.WriteLine("引用传递在交换之后，a 的值： {0}", a);
            //             Console.WriteLine("引用传递在交换之后，b 的值： {0}", b);

            /* 局部变量定义 */

            //             Console.WriteLine("在方法调用之前，a 的值： {0}", a);
            // 
            //             /* 调用函数来获取值 */
            //             n.getValue(out a);
            // 
            //             Console.WriteLine("在方法调用之后，a 的值： {0}", a);

            /* 调用函数来获取值 */
            //             n.getValues(out a, out b);
            // 
            //             Console.WriteLine("在方法调用之后，a 的值： {0}", a);
            //             Console.WriteLine("在方法调用之后，b 的值： {0}", b);

            //             NullablesAtShow nas = new NullablesAtShow();
            //             nas.NullableDemo();
            //             nas.NullableDemo2();

            //             MyArray ma = new MyArray();
            //             ma.myArrayDemo();
            //             ma.myArrayDemoByForEach();

            //             MyString ms = new MyString();
            //             ms.StringDemo();

            //建造者模式
            //             User user = new User.UserBuilder("liu", "landy")
            //                 .setAge(30)
            //                 .setAddr("湖里")
            //                 .setPhone("13333321312")
            //                 .build();

            //             MyStruct myStruct = new MyStruct();
            //             myStruct.printStructInfo();

            //继承
            //             InheritanceApplication ia = new InheritanceApplication();
            //             ia.testInheritance();
            //             Tabletop tt = new Tabletop(10,50);
            //             int area = tt.getArea();
            //             tt.Display();
            // 
            //             Console.WriteLine("油漆总成本： ${0}", tt.getCost(area));
            //多态
            //             PolymorphismApplication pa = new PolymorphismApplication();
            // 调用 print 来打印整数
            //             pa.print(5);
            //             // 调用 print 来打印浮点数
            //             pa.print(500.263);
            //             // 调用 print 来打印字符串
            //             pa.print("Hello C++");

            //             Rect r = new Rect(10, 7);
            //             double a = r.area();
            //             Console.WriteLine("面积： {0}", a);

            //             Caller c = new Caller();
            //             Rectanglev r = new Rectanglev(10, 7);
            //             Trianglev t = new Trianglev(10, 5);
            //             c.CallArea(r);
            //             c.CallArea(t);
            //命名空间
            //             first_space.namespace_cl fc = new first_space.namespace_cl();
            //             second_space.namespace_cl sc = new second_space.namespace_cl();
            //             fc.func();
            //             sc.func();

            //             #if (PI)
            //                  Console.WriteLine("PI is defined");
            //             #else
            //                  Console.WriteLine("PI is not defined");
            //             #endif

            FileIOApplication fi = new FileIOApplication();
            //fi.writeFile();
            fi.readFile();

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }

}


namespace first_space
{
    class namespace_cl
    {
        public void func()
        {
            Console.WriteLine("Inside first_space");
        }
    }
}
namespace second_space
{
    class namespace_cl
    {
        public void func()
        {
            Console.WriteLine("Inside second_space");
        }
    }
}
