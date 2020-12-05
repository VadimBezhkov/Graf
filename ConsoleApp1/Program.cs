using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
   
       public class Timer
        {
            public int Hours { get; set; }
            public int Minuts { get; set; }
            public int Seconds { get; set; }
        }
        static void Main(string[] args)
        {
            Time mytime = new Time { Seconds = 103 };
            int x = mytime;
            Time mytime1 = (Time)x;
            Timer timer1 = mytime;
            Time mytime2 = timer1;
            Console.WriteLine($"{timer1.Hours}:{timer1.Minuts}:{timer1.Seconds}");
            Console.WriteLine(mytime2.Seconds);
            Console.ReadKey();
        }
        class Time
        {
            public int Seconds { get; set; }
            public static explicit operator Time(int x)
            {
                return new Time { Seconds = x };
            }
            public static implicit operator int(Time time)
            {
                return time.Seconds;
            }
            public static implicit operator Time(Timer timer)
            {
                int h = timer.Hours*3600;
                int m = timer.Minuts * 60;
                return new Time { Seconds = h + m + timer.Seconds };
            }
            public static implicit operator Timer(Time time)
            {
                int h = time.Seconds / 3600;
                int m = (time.Seconds-h*3600) / 60;
                int s = time.Seconds - h * 3600 - m * 60;
                return new Timer {Hours=h , Minuts = m, Seconds= s};
            }
        }
    }
}
