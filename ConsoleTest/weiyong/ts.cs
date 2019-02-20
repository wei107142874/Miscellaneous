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
            var list = Person.pList();
            foreach (var item in list.Where(p => p.PId != 0))
            {
                Console.WriteLine(Tj(list, item.Id));
            }
            Console.WriteLine("成功");
        }

        private static int Tj(List<Person> list,int PId)
        {
            var person = list.Where(w => w.Id == PId);
            if (person.Count()==0)
            {
                return 0;
            }
            else
            {
               
                return Tj(list, );
            }
        }

        public static int shuliang(int n)
        {
            if (n == 6)
            {
                sl = 5;
            }
            else
            {
                sl = (shuliang(n + 1) + 1) * 2;
                Console.WriteLine(sl);
            }
            return sl;
        }

        private class Person
        {
            public int Id { get; set; }

            public int PId { get; set; }

            public string Name { get; set; }

            public int Number { get; set; }

            public static List<Person> pList()
            {
                List<Person> pList = new List<Person>();
                pList.Add(new Person { Id = 1, PId = 0, Name = "发达" });
                pList.Add(new Person { Id = 2, PId = 0, Name = "阿萨德" });
                pList.Add(new Person { Id = 3, PId = 0, Name = "安抚" });
                pList.Add(new Person { Id = 4, PId = 0, Name = "撒旦法" });
                pList.Add(new Person { Id = 5, PId = 1, Name = "阿达" });
                pList.Add(new Person { Id = 6, PId = 2, Name = "啊实打实" });
                pList.Add(new Person { Id = 7, PId = 3, Name = "按时发放" });
                pList.Add(new Person { Id = 8, PId = 2, Name = "发送到" });
                pList.Add(new Person { Id = 9, PId = 3, Name = "阿萨管道德" });
                pList.Add(new Person { Id = 10, PId = 2, Name = "怪怪的" });
                pList.Add(new Person { Id = 11, PId = 2, Name = "等等" });
                pList.Add(new Person { Id = 12, PId = 12, Name = "试试" });
                pList.Add(new Person { Id = 13, PId = 2, Name = "好好" });
                pList.Add(new Person { Id = 14, PId = 4, Name = "解决" });
                pList.Add(new Person { Id = 15, PId = 2, Name = "存储" });
                pList.Add(new Person { Id = 16, PId = 2, Name = "正在" });
                pList.Add(new Person { Id = 17, PId = 2, Name = "存储信息" });
                pList.Add(new Person { Id = 18, PId = 2, Name = "查询" });
                pList.Add(new Person { Id = 19, PId = 2, Name = "小熊熊" });
                pList.Add(new Person { Id = 20, PId = 2, Name = "休息休息" });
                pList.Add(new Person { Id = 21, PId = 2, Name = "是是是" });
                pList.Add(new Person { Id = 22, PId = 2, Name = "发发发" });
                pList.Add(new Person { Id = 23, PId = 2, Name = "多大事" });
                pList.Add(new Person { Id = 24, PId = 21, Name = "搞得" });
                pList.Add(new Person { Id = 25, PId = 4, Name = "阿达" });
                pList.Add(new Person { Id = 26, PId = 1, Name = "阿萨德" });
                pList.Add(new Person { Id = 27, PId = 1, Name = "阿萨德的" });
                return pList;
            }
        }
    }
}
