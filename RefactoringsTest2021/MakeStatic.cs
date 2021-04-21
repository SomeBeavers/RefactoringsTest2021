using System;

namespace RefactoringsTest2021
{
    public class MakeStatic
    {
        public string Name { get; set; }

        public void MakeStatic1(Logger logger)
        {
            var msg = $"The new shape is drawn at {pivot}, {pivot}";
            logger.Log(msg);

            Console.WriteLine(Name);
        }

        private void Test()
        {
            MakeStatic1(new Logger());
        }

        #region Helpers

        private int pivot;

        public class Logger
        {
            public void Log(string msg)
            {
            }
        }

        #endregion
    }
}