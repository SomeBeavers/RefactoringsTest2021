using System;

namespace RefactoringsTest2021
{
    public class IntroduceField
    {
        private protected static int t = new int();

        private void IntroduceField1(int age)
        {
            int test = 2;
            var test2 = new Exception().Data;
            var test3 = new Exception();
            var test4 = new Exception();

            age++;
            test++;
            t++;
        }
        private void IntroduceField2(int age)
        {
            int test = 2;
            var test2 = new Exception();
            var test3 = new Exception();
            var test4 = new Exception();

            age++;
            test++;
            t++;
        }
    }
}