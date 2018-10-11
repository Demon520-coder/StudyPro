using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{

    delegate int GetNum(int n);

    class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>()
            {
                new Product("c"),
                new Product("b"),
                new Product("d")
            };


            products.Sort((Product x, Product y) => { return x.Name.CompareTo(y.Name); });
            products.ForEach((s) => { Console.WriteLine(s.Name); });

            //ConsoleApp3.GetNum get = new GetNum(Program.GetNum);

            //for (int i = 1; i <= 30; i++)
            //{
            //    Console.Write(get(i) + "\t");
            //}


            var nums = GetNoRepeatArray(100, new Random(), 101);
            var orderNums = nums.OrderByDescending(s => { return s; });
            var list = nums.ToList().OrderByDescending(s => { return s; });
            Array.Sort(nums, new SortArray());

            //var enumerator = nums.GetEnumerator();
            //while (enumerator.MoveNext())
            //{
            //    Console.Write(enumerator.Current + "\t");
            //}

            foreach (var item in nums)
            {
                Console.Write(item + "\t");
            }

            Console.ReadKey();
        }


        public static int GetNum(int n)
        {
            //1 1 2 3 5 8 13---->
            //n=1 1
            //n=2 1
            //n=3 1+1
            //n=4 1+2
            //n=5 2+3
            if (n == 0)
            {
                return 0;
            }
            else if (n == 1 || n <= 2)
            {
                return 1;
            }

            return GetNum(n - 2) + GetNum(n - 1);
        }


        public static int[] GetNoRepeatArray(int arrayLength, Random random, int maxVal)
        {
            //产生一个int数组，长度为100，并向其中随机插入1-100，并且不能重复。
            int[] nums = new int[arrayLength];
            for (int i = 0; i < nums.Length; i++)
            {
                //产生随机数;
                int rdNum = random.Next(maxVal);
                //判断随机数是否已经存在于数组中;
                if (!nums.Contains(rdNum))
                {
                    nums[i] = rdNum;
                }
                else
                {
                    //重新开始循环;
                    i--;
                }
            }

            return nums;
        }
    }


    public class SortArray : IComparer<int>
    {
        public int Compare(int x, int y)
        {
            return y.CompareTo(x);
        }
    }
}
