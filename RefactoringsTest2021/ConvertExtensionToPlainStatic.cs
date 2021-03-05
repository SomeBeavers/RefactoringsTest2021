namespace RefactoringsTest2021
{
    public static class ConvertExtensionToPlainStatic
    {
        public static void DoSomething(this string s, string s2)
        {
        }

        private static void Test(string str)
        {
            str.DoSomething(null);
        }
    }
}