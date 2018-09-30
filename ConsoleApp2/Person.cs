using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Person
    {
        //1.定义事件委托类型;
        public delegate void Run();

        //2.发布事件;
        public event Run DoRun;

        //4.事件触发
        public void FinishRun()
        {
            var k = 1000;
            for (int i = 0; i < k; i++)
            {
                if (i == k - 1)
                {
                    DoRun(); //执行事件;
                }
            }
        }


    }
}
