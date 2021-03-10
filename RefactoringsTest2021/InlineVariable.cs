using System;

namespace RefactoringsTest2021
{
    public class InlineVariable
    {
        public static string InlineVariable1(string input)
        {
            var charArrayRenamedNewCoolName = input.ToCharArray();
            Array.Reverse(charArrayRenamedNewCoolName);
            var reversed = new string(charArrayRenamedNewCoolName);
            return reversed;
        }
    }
}