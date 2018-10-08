using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PietApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Pet dog = new Dog("Tom");        
            dog.Print();
            dog.Speak();
            Console.ReadKey();
        }
    }
}
