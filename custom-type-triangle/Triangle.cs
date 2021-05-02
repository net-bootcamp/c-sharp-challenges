using System;
namespace Session
{ //هنا استخدمنا مفهوم  (السكتم تايب ) وهو أن المستخدم هو الي ينشئ النوع الي يبي ويقدر يستخدم هالنوع مع انواع البيانات الموجوده في السي شارب او مع نفس نوعه 
    public class Triangle
    {
        public int a;
        public int ma;
        public double surface;
        public Triangle(int a, int ma)
        {
            this.a = a;
            this.ma = ma;
            this.surface = (a * ma) / 2;
        }
        public Triangle(double surface)
        { this.surface = surface; }
        public static Triangle operator +(Triangle tri1, Triangle tri2)
        {
            Triangle result = new Triangle((tri1.surface + tri2.surface));
            return result;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Triangle tri1 = new Triangle(8, 12);
            Console.WriteLine($"The first triangle: {nameof(tri1)} with surface is:{tri1.surface}");
            Triangle tri2 = new Triangle(14, 16);
            Console.WriteLine($"The second triangle: {nameof(tri2)} with surface is:{tri2.surface}");
            Triangle tri3 = tri1 + tri2;
            Console.WriteLine($"The third triangle: {nameof(tri3)} with surface is:{tri3.surface} is the product of {nameof(tri1)} and {nameof(tri2)}");
        }
    }
}
