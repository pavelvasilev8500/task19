using System;
using System.Diagnostics;

namespace Test
{
    class TestClass
    {
        Stopwatch stopWatch = new Stopwatch();
        GCD gcd = new GCD();
        int result;

        public void TestGCD()
        {
            TestFirsGCD();
            TestSecondGCD();
        }

        private void TestFirsGCD()
        {
            stopWatch.Restart();
            stopWatch.Start();
            //result = gcd.FirstMethod(gcd.FirstMethod(0, 36), gcd.FirstMethod(585, 360));
            result = gcd.FirstMethod(gcd.SecondMethod(10, 6), gcd.SecondMethod(44, -18));
            stopWatch.Stop();
            Console.WriteLine(result);
            Console.WriteLine("RunTime " + stopWatch.Elapsed);
        }

        private void TestSecondGCD()
        {
            stopWatch.Restart();
            stopWatch.Start();
            //result = gcd.SecondMethod(gcd.FirstMethod(0, 36), gcd.FirstMethod(585, 360));
            result = gcd.SecondMethod(gcd.SecondMethod(10, 6), gcd.SecondMethod(44, -18));
            stopWatch.Stop();
            Console.WriteLine(result);
            Console.WriteLine("RunTime " + stopWatch.Elapsed);
        }
    }
}
