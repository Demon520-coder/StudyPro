using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PietApp
{
    public class Dog : Pet
    {

        public Dog(string name) : base(name)
        {

        }
        new public void Print()
        {
            Console.WriteLine($"我是{nameof(Dog)}的方法");
        }

        public override void Speak()
        {
            Console.WriteLine($"我是{nameof(Dog)}叫声");
        }
    }
}
