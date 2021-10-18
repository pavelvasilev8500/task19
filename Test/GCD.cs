using System;

namespace Test
{
    class GCD
    {
        public int FirstMethod(int a, int b) 
        {
            while (b != 0)
            {
                var t = b;
                b = a % b;
                a = t;
            }
            return a;
        }

        public int SecondMethod(int a, int b)
        {
            if (a == 0)
            {
                return b;
            }
            else
            {
                while (b != 0)
                {
                    if(b > 0)
                    {
                        if (a > b)
                        {
                            a -= b;
                        }
                        else
                        {
                            b -= a;
                        }
                    }
                    else
                    {
                        if (a < b)
                        {
                            a -= b;
                        }
                        else
                        {
                            b -= a;
                        }
                    }
                }
                return a;
            }
        }
    }
}
