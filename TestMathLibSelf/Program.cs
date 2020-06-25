using System;

namespace TestMathLibSelf
{
   public class Program
    {
        static void Main(string[] args)
        {
            var math = new MathLibSelf.Algebra();
            var ans = math.Cubed(2);
            var ans2 = math.Inverse(2);
            var ans3 = math.Remainder(97, 2);

            //var ans4 = 37.EvalFunc();






        }
    }
}
