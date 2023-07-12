using System;
namespace UnitTest;
public class program
    {
        public static int fibonaci(int n)
        {
            if (n == 1 || n == 2) return 1;
            return fibonaci(n) + fibonaci(n - 1);
        }
    }