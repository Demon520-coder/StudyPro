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
            Person person = new Person();
            Runner runner = new Runner(person);
            person.FinishRun(); //触发事件;
            Console.ReadKey();
        }
    }
}
