using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsApp1
{
    class Math
    {
        public static int max(int a, int b)
        {
            int result;
            if (a < b)
                result = b;
            else
                result = a;

            return result;
        }
    }
}
