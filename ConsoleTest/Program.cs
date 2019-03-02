using ConsoleTest.weiyong;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTest
{
    /// <summary>
    /// Update-Package -reinstall
    /// </summary>
    class Program
    {
        /// <summary>
        /// 调用代码单独写在自己的文件夹中
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            string sql = "Insert Into t_wm (DJBH,RQ) Values ('123','2017/8/6 10:24')";
            MysqlHelper.ExecuteReader(System.Data.CommandType.Text, sql);
            //测试签入
            Console.ReadKey();
        }
    }
}
