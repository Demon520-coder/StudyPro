using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Person person = new Person();
            //Runner runner = new Runner(person);
            //person.FinishRun(); //触发事件;

            ITest test = new Test();
            test.Print("接口测试");

            List<string> list = new List<string>();
            for (int i = 0; i < 10; i++)
            {
                list.Add(i.ToString());
            }

            

            var listEnumerator = list.GetEnumerator();
            while (listEnumerator.MoveNext())
            {
                Console.WriteLine(listEnumerator.Current);
            }

            Console.ReadKey();
        }
    }
}
