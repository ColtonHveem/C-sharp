// Time class
using System;
namespace CSC205
{
    public class Time
    {
        public int Hour, Minute;
        public double Second;
        public Time()
        {   // Default constructor
            this.Hour = 0;
            this.Minute = 0;
            this.Second = 0.0;
        }
        public Time(int hour, int minute, double second)
        {   // Parametric constructor
            this.Hour = hour;
            this.Minute = minute;
            this.Second = second;
        }
        public static void WriteTime(Time t)
        {
            Console.WriteLine(t.Hour + ":" + t.Minute + ":" + t.Second);
        }
        public void WriteTime2()
        {   // a version that uses String.Format
            Console.WriteLine(String.Format("{0:D2}:{1:D2}:{2:D2}",
            this.Hour, this.Minute, (int)this.Second));
        }
        public void WriteTime3()
        {  // a version uses this
            Console.WriteLine(this.Hour + ":" + this.Minute + ":" + this.Second);
        }
        public void WriteTime4(Time t)
        {   // a version takes an argument
            Console.WriteLine(t.Hour + ":" + t.Minute + ":" + t.Second);
        }
        // add these three methods to Time class
        public static bool IsAfter(Time time1, Time time2)
        {
            if (time1.Hour > time2.Hour) return true;
            if (time1.Hour < time2.Hour) return false;
            if (time1.Minute > time2.Minute) return true;
            if (time1.Minute < time2.Minute) return false;
            if (time1.Second > time2.Second) return true;
            return false;
        }
        public static Time AddTime(Time t1, Time t2)
        {
            Time sum = new Time();
            sum.Hour = t1.Hour + t2.Hour;
            sum.Minute = t1.Minute + t2.Minute;
            sum.Second = t1.Second + t2.Second;
            return sum;
        }
        public static Time AddTime2(Time t1, Time t2)
        {
            Time sum = new Time();
            sum.Hour = t1.Hour + t2.Hour;
            sum.Minute = t1.Minute + t2.Minute;
            sum.Second = t1.Second + t2.Second;
            if (sum.Second >= 60.0)
            {
                sum.Second -= 60.0;
                sum.Minute += 1;
            }
            if (sum.Minute >= 60)
            {
                sum.Minute -= 60;
                sum.Hour += 1;
            }
            return sum;
        }

        public static void Increment(Time time, double secs)
        {
            time.Second += secs;
            while (time.Second >= 60.0)
            {
                time.Second -= 60.0;
                time.Minute += 1;
            }
            while (time.Minute >= 60)
            {
                time.Minute -= 60;
                time.Hour += 1;
            }
        }
        public Time(double secs)
        {
            this.Hour = (int)(secs / 3600.0);
            double secsremaining = secs - this.Hour * 3600.0;
            this.Minute = (int)(secsremaining / 60.0);
            secsremaining -= this.Minute * 60;
            secs = secsremaining;
        }
        public static void Main(string[] args)
        {
            Time t1 = new Time(11, 58, 31);
            Time t2 = new Time(11, 58, 31);
            Console.WriteLine(Time.IsAfter(t2, t1));
            Time.AddTime(t1, t2).WriteTime2();
            Time.AddTime2(t1, t2).WriteTime2();
            Time.Increment(t2, 150);
            t2.WriteTime2();
            Time t3 = new Time(14588);
            t3.WriteTime2();
        }


    }
}

