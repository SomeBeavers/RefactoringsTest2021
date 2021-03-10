using System;

namespace RefactoringsTest2021
{
    public class InlineParameter
    {
        private void PerformAction(Action action, string s = "")
        {
            action();
        }

        private void VeryVeryVeryVeryVeryVeryVeryVeryVeryVeryVeryLongLongLongLongLongLongLongLongNameNameNameName(
            string s, string ss, string sss)
        {
            Console.WriteLine(s);
            Console.WriteLine(ss);
            Console.WriteLine(sss);
        }

        #region Helpers

        private void Test(string key, string value)
        {
            PerformAction(() =>
                Console.WriteLine("{0} : {1}", key, value));
        }

        private void Test2(string key, string value, string s, string s2, string s1, string s3, string s4, string s5,
            string s6)
        {
            PerformAction(() =>
                Console.WriteLine(
                    $"{key} : " +
                    $"{value}" +
                    $"{s}{s1}{s2}{s3}{s4}{s5}"));
        }

        private void Test6(string key, string value, string s, string s2, string s1, string s3, string s4, string s5,
            string s6)
        {
            PerformAction(() =>
                Console.WriteLine(
                    $"{key} !!!!!!!!! " +
                    $"{value}" +
                    $"{value}" +
                    $"{s}{s1}{s2}{s3}{s4}{s5}"));
        }

        private void Test3(string key, string value, string s, string s2, string s1, string s3, string s4, string s5,
            string s6)
        {
            PerformAction(() =>
                Console.WriteLine($"{key} : {value}{s}{s1}{s2}{s3}{s4}{s5}"));
        }

        private void Test4(string key, string value, string s, string s2, string s1, string s3, string s4, string s5,
            string s6)
        {
            PerformAction(() =>
                Console.WriteLine($"{key} : {value}{s}{s1}{s2}{s3}{s4}{s5}"));
        }

        private void UseTest1(string parameter)
        {
            VeryVeryVeryVeryVeryVeryVeryVeryVeryVeryVeryLongLongLongLongLongLongLongLongNameNameNameName("1", "2",
                parameter);
        }

        private void UseTest()
        {
            VeryVeryVeryVeryVeryVeryVeryVeryVeryVeryVeryLongLongLongLongLongLongLongLongNameNameNameName("", "1",
                "test");
        }

        #endregion
    }
}