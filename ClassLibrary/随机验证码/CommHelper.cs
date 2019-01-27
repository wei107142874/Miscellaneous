using CaptchaGen;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public static partial  class CommHelper
    {
        /// <summary>
        /// 封装一个生成 n 位验证码的函数，为了避免混淆，不生成'1'、'l'、'0'、'o'等字符：        /// </summary>
        /// <param name="len"></param>
        /// <returns></returns>
        public static string GenerateCaptchaCode(int len)
        {
            char[] data = { 'a', 'c', 'd', 'e', 'f', 'g', 'k', 'm', 'p', 'r', 's', 't', 'w', 'x', 'y', '3', '4', '5', '7', '8' };
            StringBuilder sbCode = new StringBuilder();
            Random rand = new Random();
            for (int i = 0; i < len; i++)
            {
                char ch = data[rand.Next(data.Length)];
                sbCode.Append(ch);
            }
            return sbCode.ToString();
        }

        /// <summary>
        /// 图形验证码生成
        /// GenerateImage 的参数依次是：验证码文字（需要自己写代码生成，调用 Rupeng.Common
        /// 我们封装好的）；宽度；高度；字体大小；扭曲程度，数值越大扭曲越厉害；
        ///jpeg 格式的图片流        /// </summary>
        public static void GenerateImage()
        {
            using (MemoryStream ms = ImageFactory.GenerateImage("AB12", 60, 100, 20, 6))
            using (FileStream fs = File.OpenWrite(@"c:\temp\1.jpg"))
            {
                ms.CopyTo(fs);
            }
        }
    }
}
