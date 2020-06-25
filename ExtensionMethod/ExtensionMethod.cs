using System;
using System.Runtime.CompilerServices;

namespace ExtensionMethod
{
    public static class IntExtensionMethod
    {
     
            public static int EvalFunc(this int x)
            {
                return (x * x) + 3 * x + 5;
            }
        



    }

    
}
