using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Student stu = new Student();
            //静态变量--->静态构造函数--->构造函数
            //委托三部曲---->1.定义  2.实例化委托 3.调用委托(三种方法:a.委托实例(参数) b.委托实例.Invoke(参数) c.委托实例.BeginInvoke(参数)-->异步调用)
            Student stu2 = new Student();

            Student.DoSomething delDo = new Student.DoSomething(Do);
            //delDo("我是一个委托");
            //delDo.Invoke($"我是一个委托{nameof(delDo.Invoke)}");
            delDo.BeginInvoke($"我是一个委托{nameof(delDo.BeginInvoke)}", (Done) => { }, null);
            Console.WriteLine("1111111111111111");
            Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
            Console.ReadKey();
        }

        public static void Do(string str)
        {
            Console.WriteLine("================");
            for (int i = 0; i < 10000; i++)
            {

            }
            Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
            Thread.Sleep(5000);
            Console.WriteLine(str);
        }

        public static void Done()
        {
            Console.WriteLine("我是回调方法");
        }
    }
}
