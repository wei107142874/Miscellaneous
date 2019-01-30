using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTest.weiyong
{
    internal static class Ts
    {
        public static int sl = 0;

        public static void Test()
        {
            //CommHelper.UseQuartz2();
            Console.WriteLine(shuliang(0));
            Console.WriteLine("成功");
        }

       
        public static int shuliang(int n)
        {
            if (n == 6)
            {
                sl=5;
            }
            else
            {
                sl = (shuliang(n + 1) + 1) * 2;
                Console.WriteLine(sl);
            }
            return sl;
        }
    }
}
