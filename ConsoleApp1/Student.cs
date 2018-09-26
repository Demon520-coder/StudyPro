using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Student : Person
    {
        public delegate void DoSomething(string outPut);

        public static string Name = "zzl";

        static Student()
        {

        }

        public Student()
        {

        }

        public static string Sex = "男";
    }
}
