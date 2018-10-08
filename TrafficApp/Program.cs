using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TrafficApp
{
    class Program
    {
        delegate int LightTimeDel(LightColor light);

        static void Main(string[] args)
        {
            LightTimeDel del = new LightTimeDel(GetLightTime);
            LightColor[] lights = { LightColor.Green, LightColor.Yellow, LightColor.Red };
            Dictionary<LightColor, int> dic = new Dictionary<LightColor, int>();
            foreach (var item in lights)
            {
                dic.Add(item, del(item));
            }
            //倒计时:
            foreach (KeyValuePair<LightColor, int> pair in dic)
            {
                for (int i = pair.Value; i >= 1; i--)
                {
                    Console.WriteLine($"{pair.Key.GetEnumDes()}倒计时:{i}");
                    Thread.Sleep(1000);
                }

            }

            Console.ReadKey();

        }

        private static int GetLightTime(LightColor light)
        {
            string lightTime = string.Empty;
            do
            {
                Console.ForegroundColor = (ConsoleColor)light;
                Console.WriteLine($"请输入{light.GetEnumDes()}时间:");
                Console.ForegroundColor = (ConsoleColor)light;
                lightTime = Console.ReadLine();

            } while (lightTime.TryToInt() == 0);

            return lightTime.TryToInt();
        }
    }
}
