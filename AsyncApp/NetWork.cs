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
    public class NetWork
    {
        Stopwatch sw = null;

        public NetWork()
        {
            sw = new Stopwatch();
        }

        public async Task<int> CountCharacterAsync(string url)
        {
            sw.Start();
            WebClient client = new WebClient();
            Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
            var strResult = await client.DownloadStringTaskAsync(new Uri(url));
            Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
            Console.WriteLine($"Download Compeleted:{sw.ElapsedMilliseconds.ToString()}ms");
            return strResult.Count();
        }


        public int CountCharacter(string url)
        {
            sw.Start();
            WebClient client = new WebClient();
            var strResult = client.DownloadString(url);

            Console.WriteLine($"Download Compeleted:{sw.ElapsedMilliseconds.ToString()}ms");
            return strResult.Count();
        }

        public void Run()
        {
            for (int i = 0; i < 10000; i++)
            {

            }
            Console.WriteLine($"运行时间:{sw.ElapsedMilliseconds.ToString()}ms");
        }
    }
}
