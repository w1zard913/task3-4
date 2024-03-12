using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3_4
{
    internal static class RandomGenerator<T>
    {
        private static Random random = new Random();
        public static T RandomValue()
        {
            if (typeof(T) == typeof(int)) return (T)(object) RandomInt();
            if (typeof(T) == typeof(double)) return (T)(object)RandomDouble();
            if (typeof(T) == typeof(bool)) return (T)(object)RandomBool();
            if (typeof(T) == typeof(string)) return (T)(object)RandomString();
            return (T)(object)false;
        }

        static int RandomInt()
        {
            return random.Next(1, 1001);
        }

        static double RandomDouble()
        {
            return random.NextDouble();
        }

        static bool RandomBool()
        {
            return random.Next(2) == 1;
        }

        static string RandomString()
        {
            string s = "";
            for (int j = 0; j < 5; j++)
            {
                char a = (char)random.Next(0, 255);
                s += a;
            }
            return s;
        }
    }
}
