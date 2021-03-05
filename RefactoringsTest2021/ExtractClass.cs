using System;
using System.IO;

namespace RefactoringsTest2021
{
    public class ExtractClass
    {
        private readonly int usedPrivateField;

        public string PublicProperty { get; set; }

        private void UsePrivateField()
        {
            Console.WriteLine(usedPrivateField);
        }

        public void UsePrivateField2()
        {
            Console.WriteLine(usedPrivateField);
        }

        public void UseMethod()
        {
            PublicProperty = "";
            UsePrivateField2();
        }

        public void NotUsedMethod()
        {
        }
    }

    public class ExtractClassGeneric<T>
    {
        private readonly T usedPrivateField;

        public string PublicProperty { get; set; }

        private void UsePrivateField<U>(U u)
        {
            Console.WriteLine(usedPrivateField + u?.ToString());
        }

        public void UsePrivateField2()
        {
            Console.WriteLine(usedPrivateField);
        }

        public void UseMethod()
        {
            PublicProperty = "";
            UsePrivateField2();
        }

        public void NotUsedMethod()
        {
        }
    }

    class ExtractClassWithManyMembers
    {
        /// <summary>
        /// Used in many methods.
        /// </summary>
        private readonly LastInnerClass innerClass1 = new LastInnerClass();
        private readonly LastInnerClass innerClass2 = new LastInnerClass();
        private readonly LastInnerClass innerClass3 = new LastInnerClass();
        private readonly LastInnerClass innerClass4 = new LastInnerClass();
        private readonly LastInnerClass innerClass5 = new LastInnerClass();
        private readonly LastInnerClass innerClass6 = new LastInnerClass();
        private readonly LastInnerClass innerClass7 = new LastInnerClass();
        private readonly LastInnerClass innerClass8 = new LastInnerClass();
        private readonly LastInnerClass innerClass9 = new LastInnerClass();
        private readonly LastInnerClass innerClass10 = new LastInnerClass();

        public void UseInnerClass1()
        {
            Console.WriteLine(innerClass1);
        }
        public void UseInnerClass12()
        {
            Console.WriteLine(innerClass1);
        }
        public void UseInnerClass13()
        {
            Console.WriteLine(innerClass1);
        }
        public void UseInnerClass14()
        {
            Console.WriteLine(innerClass1);
        }
        public void UseInnerClass15()
        {
            Console.WriteLine(innerClass1);
        }
        public void UseInnerClass16()
        {
            Console.WriteLine(innerClass1);
        }
        public void UseInnerClass17()
        {
            Console.WriteLine(innerClass1);
        }
        public void UseInnerClass18()
        {
            Console.WriteLine(innerClass1);
        }
        public void UseInnerClass19()
        {
            Console.WriteLine(innerClass1);
        }
        public void UseInnerClass20()
        {
            Console.WriteLine(innerClass1);
        }

        public void UseInnerClass2()
        {
            Console.WriteLine(innerClass2);
        }
        public void UseInnerClass3()
        {
            Console.WriteLine(innerClass3);
        }
        public void UseInnerClass4()
        {
            Console.WriteLine(innerClass4);
        }
        public void UseInnerClass5()
        {
            Console.WriteLine(innerClass5);
        }
        public void UseInnerClass6()
        {
            Console.WriteLine(innerClass6);
        }
        public void UseInnerClass7()
        {
            Console.WriteLine(innerClass7);
        }
        public void UseInnerClass8()
        {
            Console.WriteLine(innerClass8);
        }
        public void UseInnerClass9()
        {
            Console.WriteLine(innerClass9);
        }
        public void UseInnerClass10()
        {
            Console.WriteLine(innerClass10);
        }

        private class LastInnerClass
        {
            public void Draw()
            {
                LogError("");
            }

            public static void LogError(string e)
            {
            }
        }
    }
}