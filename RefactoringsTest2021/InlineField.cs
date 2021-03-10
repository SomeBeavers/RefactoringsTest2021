using System;

namespace RefactoringsTest2021
{
    public class InlineField
    {
        private const string ErrorMessage = "Something has failed";

        public void Draw(string s)
        {
            try
            {
            }
            catch (Exception e)
            {
                Console.WriteLine("{0} : {1}", ErrorMessage, e);
                Console.WriteLine("{0} : {1}", ErrorMessage, e);
            }
        }
    }
}