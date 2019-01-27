using CodeCarvings.Piczard;
using CodeCarvings.Piczard.Filters.Watermarks;
using log4net;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public static partial class CommHelper
    {
        public static void UseLog4net()
        {
            //启动日志，放在程序启动时
            log4net.Config.XmlConfigurator.Configure();

            //使用日志
            ILog log= LogManager.GetLogger(typeof(CommHelper));
            log.Debug("调试信息");
            log.Warn("警告信息");
            log.Error("错误信息");
        }
    }
}
