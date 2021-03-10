namespace RefactoringsTest2021
{
    public class MoveToAnotherType
    {
        private static void Test()
        {
            Test2();
        }

        private static void Test2()
        {
        }

        class MoveToAnotherType1
        {
            private static string CreateMoveBug()
            {
                return string.Empty;
            }

            public static void Test2()
            {
                CreateMoveBug();
            }
        }
    }
}