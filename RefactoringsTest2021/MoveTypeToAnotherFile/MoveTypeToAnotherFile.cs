using System;
using System.IO;

namespace RefactoringsTest2021.MoveTypeToAnotherFile
{
    public class MoveTypeToAnotherFile
    {
        public void Draw()
        {
            try
            {
            }
            catch (Exception e)
            {
                LogError(e);
            }
        }

        public void Draw2()
        {
            try
            {
            }
            catch (Exception e)
            {
                LogError(e);
            }
        }

        private static void LogError(Exception e)
        {
            File.WriteAllText(@"c:\Errors\Exception.txt", e.ToString());
        }
    }
}