using ClassLibrary.缩略图;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTest.weiyong
{
    internal static class Ts
    {
        public static void Test()
        {
            string a= @"C:\Users\wy\Pictures\Screenshots\屏幕截图(1).png";
            string b = @"C:\Users\wy\Pictures\Screenshots\屏幕截图(2).bmp";
            Thumbnail.GetThumbnail(a, b, 100, 100);
            Console.WriteLine("成功");
        }
    }
}
