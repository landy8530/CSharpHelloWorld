/**
* 命名空间: HelloWorld
*
* 功 能： N/A
* 类 名： FileIOApplication
* 创建人：landy
* 创建时间：2017/7/6 9:46:47
* CLR VERSION: 4.0.30319.42000
* Ver 变更日期 负责人 变更内容
* ───────────────────────────────────
* V0.01 2017/7/6 9:46:47 landy 初版
*
* Copyright (c) 2017 Lir Corporation. All rights reserved.
*┌──────────────────────────────────┐
*│　此技术信息为本公司机密信息，未经本公司书面同意禁止向第三方披露．　│
*│　版权所有：厦门卫生检疫技术研究所 　　　　　　　　　　　　　　     │
*└──────────────────────────────────┘
*/
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class FileIOApplication
    {
        public void writeFile() {
            FileStream F = new FileStream("test.txt",
            FileMode.OpenOrCreate, FileAccess.ReadWrite);

            byte[] byData;
            char[] charData;

            charData = "My pink half of the drainpipe.\n".ToCharArray();
            byData = new byte[charData.Length];
            Encoder e = Encoding.UTF8.GetEncoder();
            e.GetBytes(charData, 0, charData.Length, byData, 0, true);


            F.Seek(0, SeekOrigin.Begin);
            for (int i = 1; i <= 20; i++)
            {
                F.Write(byData, 0, byData.Length);
            }

            F.Position = 0;

            for (int i = 0; i <= 20; i++)
            {
                Console.Write(F.ReadByte() + " ");
            }
            F.Close();
        }

        public void readFile()
        {
            byte[] byData = new byte[200];
            char[] charData = new Char[200];

            try
            {
                FileStream aFile = new FileStream("D:\\projects\\visualstudio_workspace\\HelloWorld\\HelloWorld\\PolymorphismApplication.cs", FileMode.Open);
                aFile.Seek(0, SeekOrigin.Begin);
                aFile.Read(byData, 0, 200);
            }
            catch (IOException e)
            {
                Console.WriteLine("An IO exception has been thrown!");
                Console.WriteLine(e.ToString());
                Console.ReadKey();
                return;
            }

            Decoder d = Encoding.UTF8.GetDecoder();
            d.GetChars(byData, 0, byData.Length, charData, 0);

            Console.WriteLine(charData);

        }

    }
}
