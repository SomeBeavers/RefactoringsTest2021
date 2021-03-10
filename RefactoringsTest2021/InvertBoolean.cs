using System;

namespace RefactoringsTest2021
{
    public class InvertBoolean
    {
        // IsEven
        public bool IsEven(int input)
        {
            return input % 2 == 0;
        }

        public void Test(int value)
        {
            if (IsEven(value))
                Console.WriteLine("\n the number is even");
        }
    }
}