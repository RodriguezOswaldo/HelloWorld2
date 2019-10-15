using System;

namespace HelloWorld2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("{0} {1}", byte.MinValue, byte.MaxValue);
            Console.WriteLine("{0} {1}", int.MinValue, int.MaxValue);
            Console.WriteLine("{0} {1}", float.MinValue, float.MaxValue);
            //constant
            const float Pi = 3.14f;

            //Converting types!!
            //compatible
            float f = 1.9f;
            int i = (int) f;
            //Non-compatible types
            string s = "1";
            int I = Convert.ToInt32(s);

            int j = int.Parse(s);
        }
    }
}
