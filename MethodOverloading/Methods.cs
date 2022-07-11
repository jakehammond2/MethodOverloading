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

        public static string Add(int x, int y, bool z)
        {           

           if (z == true && x + y != 1)
            {
                return ($"{x + y} dollars");
            }
            return $"{x + y} dollar";
        }

    }
}

