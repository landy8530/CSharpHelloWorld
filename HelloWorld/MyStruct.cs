/**
* 命名空间: HelloWorld
*
* 功 能： N/A
* 类 名： MyStruct
* 创建人：landy
* 创建时间：2017/7/5 14:14:00
* CLR VERSION: 4.0.30319.42000
* Ver 变更日期 负责人 变更内容
* ───────────────────────────────────
* V0.01 2017/7/5 14:14:00 landy 初版
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
/// <summary>
/// 类和结构有以下几个基本的不同点：
// 类是引用类型，结构是值类型。
// 结构不支持继承。
// 结构不能声明默认的构造函数。
/// </summary>
namespace HelloWorld
{
    class MyStruct
    {
        public void printStructInfo()
        {
            Books Book1;        /* 声明 Book1，类型为 Book */
            Books Book2;        /* 声明 Book2，类型为 Book */

            /* book 1 详述 */
            Book1.title = "C Programming";
            Book1.author = "Nuha Ali";
            Book1.subject = "C Programming Tutorial";
            Book1.book_id = 6495407;

            /* book 2 详述 */
            Book2.title = "Telecom Billing";
            Book2.author = "Zara Ali";
            Book2.subject = "Telecom Billing Tutorial";
            Book2.book_id = 6495700;

            /* 打印 Book1 信息 */
            Console.WriteLine("Book 1 title : {0}", Book1.title);
            Console.WriteLine("Book 1 author : {0}", Book1.author);
            Console.WriteLine("Book 1 subject : {0}", Book1.subject);
            Console.WriteLine("Book 1 book_id :{0}", Book1.book_id);

            /* 打印 Book2 信息 */
            Console.WriteLine("Book 2 title : {0}", Book2.title);
            Console.WriteLine("Book 2 author : {0}", Book2.author);
            Console.WriteLine("Book 2 subject : {0}", Book2.subject);
            Console.WriteLine("Book 2 book_id : {0}", Book2.book_id);

//             Books Book1 = new Books(); /* 声明 Book1，类型为 Book */
//             Books Book2 = new Books(); /* 声明 Book2，类型为 Book */

            /* book 1 详述 */
            Book1.getValues("C Programming",
            "Nuha Ali", "C Programming Tutorial", 6495407);

            /* book 2 详述 */
            Book2.getValues("Telecom Billing",
            "Zara Ali", "Telecom Billing Tutorial", 6495700);

            /* 打印 Book1 信息 */
            Book1.display();

            /* 打印 Book2 信息 */
            Book2.display();


        }
    }

    struct Books
    {
        public string title;
        public string author;
        public string subject;
        public int book_id;

        public void getValues(string t, string a, string s, int id)
        {
            title = t;
            author = a;
            subject = s;
            book_id = id;
        }
        public void display()
        {
            Console.WriteLine("Title : {0}", title);
            Console.WriteLine("Author : {0}", author);
            Console.WriteLine("Subject : {0}", subject);
            Console.WriteLine("Book_id :{0}", book_id);
        }

    };
}
