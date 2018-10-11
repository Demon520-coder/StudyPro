using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncApp
{
    class Program
    {
        static void Main(string[] args)
        {
            NetWork work = new NetWork();
            //work.CountCharacter("http://www.baidu.com");
            Task<int> result = work.CountCharacterAsync("http://www.youku.com");
            if (result.Result > 0)
            {

            }
            Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
            work.Run();
            Console.WriteLine(result.Result);
            Console.ReadKey();
        }




    }
}
