using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PietApp
{
    public class Pet
    {
        public Pet(string name)
        {
            this.name = name;
        }

        public Pet(string name, string color):this(name)
        {
            this.color = color;
        }

        private string name;

        public string Name
        {
            set
            {
                name = value;
            }
            get
            {
                return name;
            }
        }

        private string color;

        public string Color
        {
            set { color = value; }
            get { return color; }
        }

        public void Print()
        {
            Console.WriteLine($"宠物名字:{this.Name}");
        }


        public virtual void Speak()
        {
            Console.WriteLine($"宠物的叫声");
        }
    }
}
