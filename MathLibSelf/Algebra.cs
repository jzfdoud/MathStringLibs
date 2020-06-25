using System;

namespace MathLibSelf
{
    public class Algebra
    {
        public double Inverse(double a)
        {
           
            if(a == 0) {
                Console.WriteLine("error");
                return 0;
            }
            
            return 1 / a;
        }

        public int Remainder(int a, int b) 
        {
            return a - (a/b*b);
            //actual formula for %-modulo
        }

        public long Cubed(int a)
        {
            return a * a * a;
        }


    }
}
