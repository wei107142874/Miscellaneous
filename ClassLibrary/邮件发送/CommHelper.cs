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
    public static partial  class CommHelper
    {
        /// <summary>
        /// 邮件发送
        /// 如果大量通过邮箱发送验证码，可以借助于 SendCloud、阿里云等第三方的“触发邮件”
        ///服务，可以保证到达率。
        ///如果是公司内部发邮件，可以自己搭建邮件服务器或者购买企业邮箱服务；
        ///如果使用第三方免费的 smtp 服务器，可能有“授权码”的问题，需要用授权码（为什
        ///么）代替密码，还可能要启用 https。如果搞不定，就看课程旁边，我们会推荐当时能用的
        ///免费邮件服务。项目中不会有这个问题，因为都用自己的服务器或者购买收费的邮局服务。
        ///开发测试最好自己发给自己，否则会有垃圾邮件问题，但也别发的太多，如果被封只能
        ///换服务商。
        ///以 163 为例，注册过程自己搞。登录账号：rupengtest01@163.com 密码 rupeng123（别
        ///用老师的，自己搞）
        ///1） 首先确保开启了 Smtp 服务；
        ///2） 还需要开启、设置“客户端授权码”（有的邮箱不需要） 授权码：123rupeng
        ///3） 发邮件的代码：        /// </summary>
        public static void SendEmail()
        {
            //using (MailMessage mailMessage = new MailMessage())
            //using (SmtpClient smtpClient = new SmtpClient(Smtp 服务器))
            //{
            //    mailMessage.To.Add(接收邮箱);
            //    mailMessage.To.Add(接收邮箱 2);
            //    mailMessage.Body = "邮件正文";
            //    mailMessage.From = new MailAddress(发送邮箱);
            //    mailMessage.Subject = "邮件标题";
            //    smtpClient.Credentials = new System.Net.NetworkCredential(Smtp 发送用户名, Smtp 发
            //    送密码);//如果启用了“客户端授权码”，要用授权码代替密码
            //    smtpClient.Send(mailMessage);
            //}

            using (MailMessage mailMessage = new MailMessage())
            using (SmtpClient smtpClient = new SmtpClient("smtp.qq.com"))//QQ smtp服务器
            {
                mailMessage.To.Add("1071427874@qq.com");
                mailMessage.To.Add("1071427874@qq.com");
                //发送邮箱
                mailMessage.From = new MailAddress("1219433613@qq.com");
                mailMessage.Subject = "我是标题";//标题
                mailMessage.Body = "我是一个诗人，我向往世间所有的美好";//正文
                smtpClient.EnableSsl = true;//如果邮箱需要开启SSL访问
                //用户名和授权码      
                smtpClient.Credentials = new System.Net.NetworkCredential("1219433613@qq.com", "aykfitenbgthgifa");
                smtpClient.Send(mailMessage);
            }
        }
    }
}
