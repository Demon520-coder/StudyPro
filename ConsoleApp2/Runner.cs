using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    /// <summary>
    /// 订阅者
    /// </summary>
    public class Runner
    {
        private Person _person;
      
        public Runner(Person person)
        {
            _person = person;
            //3.注册事件:
            _person.DoRun += () => { Console.WriteLine("我跑完了！"); };
        }   
    }
}
