using System;
namespace MethodOverloading
{
    public class Methods
    {
        public Methods()
        {
        }

        public static int Add(int x, int y)
        {
            return (x + y);
        }

        public static double Add(double x, double y)
        {
            return (x + y);
        }

        public static string Add(int x, int y, bool isTrue)
        {           

           if (x + y > 1 && isTrue)
            {
                return ($"{x + y} dollars");
            }
            return $"{x + y} dollar";
        }

    }
}

