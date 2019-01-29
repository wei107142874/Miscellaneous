using Quartz;
using Quartz.Impl;
using Quartz.Spi;
using System;

namespace ClassLibrary
{
    public static partial class CommHelper
    {
        /// <summary>
        /// Install-Package Quartz -Version 2.5.0
        /// Quartz.Net 中的概念：计划者（IScheduler）、工作（IJob）、触发器（Trigger）。给计划者
        /// 一个工作(Job)，让他在 Trigger（什么条件下做这件事）触发的条件下执行这个工作(Job)
        /// 将要定时执行的任务的代码写到实现 IJob 接口的 Execute 方法中即可，时间到来的时候
        /// Execute 方法会被调用。
        /// </summary>
        public static void UseQuartz1()
        {
            //每 周 固 定 时 间 ： CronScheduleBuilder.AtHourAndMinuteOnGivenDaysOfWeek(13, 55,
            //DayOfWeek.Friday, DayOfWeek.Sunday) 每周五、周日的 13:55 执行；
            //每周固定时间：CronScheduleBuilder.WeeklyOnDayAndHourAndMinute()
            //每月固定时间：CronScheduleBuilder.MonthlyOnDayAndHourAndMinute()

            IScheduler sched = new StdSchedulerFactory().GetScheduler();
            JobDetailImpl jdBossReport = new JobDetailImpl("jdTest", typeof(Job));
            IMutableTrigger triggerBossReport = CronScheduleBuilder.DailyAtHourAndMinute(20,
            52).Build();//每天 23:45 执行一次
            triggerBossReport.Key = new TriggerKey("triggerTest");
            sched.ScheduleJob(jdBossReport, triggerBossReport);
            sched.Start();
        }


        /// <summary>
        /// 每隔三秒执行一次
        /// </summary>
        public static void UseQuartz2()
        {
            IScheduler sched = new StdSchedulerFactory().GetScheduler();
            JobDetailImpl jdBossReport = new JobDetailImpl("jdTest", typeof(Job));
            CalendarIntervalScheduleBuilder builder = CalendarIntervalScheduleBuilder.Create();
            builder.WithInterval(3, IntervalUnit.Second);//每 3 秒钟执行一次 
            IMutableTrigger triggerBossReport = builder.Build();
            triggerBossReport.Key = new TriggerKey("triggerTest");//多个任务Key不能重复
            sched.ScheduleJob(jdBossReport, triggerBossReport);
            sched.Start();
        }

    }

    public class Job : IJob
    {
        public void Execute(IJobExecutionContext context)
        {
            try
            {
                string a = "123FF ";
                int b = int.Parse(a);
            }
            catch (Exception ex)
            {
                Console.WriteLine("出错"+ex);
            }
           
        }
    }
}
