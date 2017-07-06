/**
* 命名空间: HelloWorld
*
* 功 能： N/A
* 类 名： EnumProgram
* 创建人：landy
* 创建时间：2017/7/5 14:21:51
* CLR VERSION: 4.0.30319.42000
* Ver 变更日期 负责人 变更内容
* ───────────────────────────────────
* V0.01 2017/7/5 14:21:51 landy 初版
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
    class EnumProgram
    {
        enum Days { Sun, Mon, tue, Wed, thu, Fri, Sat };

        public void printEnumInfo()
        {
            int WeekdayStart = (int)Days.Mon;
            int WeekdayEnd = (int)Days.Fri;
            Console.WriteLine("Monday: {0}", WeekdayStart);
            Console.WriteLine("Friday: {0}", WeekdayEnd);
        }
    }


}
