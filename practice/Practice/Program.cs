using System;
using System.Threading;
using System.Threading.Tasks;

namespace Practice
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            TaskPractice();

            Console.ReadKey();
        }

        private static void TaskPractice()
        {
            Console.WriteLine($"接需求  --  {Thread.CurrentThread.ManagedThreadId}");
            Console.WriteLine($"需求分析  --  {Thread.CurrentThread.ManagedThreadId}");
            Console.WriteLine($"架构设计  --  {Thread.CurrentThread.ManagedThreadId}");
            Console.WriteLine($"数据库设计  --  {Thread.CurrentThread.ManagedThreadId}");
            Console.WriteLine($"组建团队  --  {Thread.CurrentThread.ManagedThreadId}");
            Console.WriteLine($"提前支付50%费用  --  {Thread.CurrentThread.ManagedThreadId}");
            Console.WriteLine($"开始开发  --  {Thread.CurrentThread.ManagedThreadId}");

            var frontJob = Task.Run(() =>
            {
                Work("person1", "前端页面");
            });
            var serviceJob = Task.Run(() =>
            {
                Work("person2", "后端方法");
            });
            var apiJob = Task.Run(() =>
            {
                Work("person3", "第三方对接");
            });
            var dbJob = Task.Run(() =>
            {
                Work("person4", "数据库");
            });

            Task.WaitAll();

            Console.WriteLine($"完成开发  --  {Thread.CurrentThread.ManagedThreadId}");
            Console.WriteLine($"验收成功，交付尾款  --  {Thread.CurrentThread.ManagedThreadId}");
        }

        private static void Work(string person, string content)
        {
            Console.WriteLine($"{person} 开始工作:{content}({DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff")})  --  {Thread.CurrentThread.ManagedThreadId}");

            var sleepTime = new Random().Next(10);
            Thread.Sleep(sleepTime * 1000);

            //var sum = 0;
            //var loopCount = new Random().Next(10) * 100000000;

            //for (var i = 0; i <= loopCount; i++)
            //{
            //    sum += i;
            //}

            Console.WriteLine($"{person} 完成工作:{content}({DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff")})  --  {Thread.CurrentThread.ManagedThreadId}");
        }

        private static void DelegatePractice()
        {
            var myDelegate = new MyDelegate(
                (num1, num2) =>
                {
                    Console.Write(num1 + num2);
                },
                (num1, num2) =>
                {
                    return num1 + num2;
                }
            );

            myDelegate.Excute(3, 4);
        }
    }

    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
    }
}