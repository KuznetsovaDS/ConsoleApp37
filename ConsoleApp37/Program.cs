using System;
public struct Distanse
{
    class Program
    {
        static void Main(string[] args)
        {
            Distance t1 = new Distance(24, 11);
            Distance t2 = new Distance(2, 5);
            Distance t3 = t1 + t2;
            Distance t4 = t1 - t2;
            Console.WriteLine($"Первое значение:{t1}, второе значение:{t2}");
            Console.WriteLine($"Сумма:{t3}");
            Console.WriteLine($"Разность:{t4}");
            if (t1 > t2)
                Console.WriteLine("Первое значение больше второго");
            else if (t1 < t2)
                Console.WriteLine("Первое значение меньше второго");
            else
                Console.WriteLine("Значения равны");
        }
        class Distance
        {
            protected double inch;
            protected int feet;
            public Distance(int feet, double inch)
            {
                this.feet = feet;
                this.inch = inch;
            }
            public static Distance operator +(Distance d1, Distance d2)
            {
                int resultfeet = d1.feet + d2.feet;
                double resultinch = d1.inch + d2.inch;
                while (resultinch >= 12)
                {
                    resultfeet++;
                    resultinch = resultinch - 12;
                }
                return new Distance(resultfeet, resultinch);
            }
            public static Distance operator -(Distance d1, Distance d2)
            {
                int resultfeet = d1.feet - d2.feet;
                double resultinch = d1.inch - d2.inch;

                while (resultinch < 0)
                {
                    resultfeet--;
                    resultinch = resultinch + 12;
                }
                return new Distance(resultfeet, resultinch);
            }
            public override string ToString()
            {
                return $"{feet}'-{inch}\"";
            }
            public static bool operator >(Distance d1, Distance d2)
            {
                if (d1.feet > d2.feet)
                    return true;
                else if (d1.feet == d2.feet && d1.inch > d2.inch)
                    return true;
                else
                    return false;
            }
            public static bool operator <(Distance d1, Distance d2)
            {
                if (d1.feet < d2.feet)
                    return true;
                else if (d1.feet == d2.feet && d1.inch < d2.inch)
                    return true;
                else
                    return false;
            }
        }
    }
}