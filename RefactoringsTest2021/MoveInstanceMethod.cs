namespace RefactoringsTest2021
{
    public class MoveInstanceMethod
    {
        public void SetAge(Logger value)
        {
            age = value;
        }

        #region Helpers

        private Logger age;
        private Logger age1;
        private Logger age2;
        private Logger age3;
        private Logger age4;
        private Logger age5;
        private Logger age6;
        private Logger age7;
        private Logger age8;
        private Logger age9;
        private Logger age21;
        private Logger age22;
        private Logger age23;
        private Logger age24;
        private Logger age25;
        private Logger age26;
        private Logger age27;
        private Logger age28;
        private Logger age29;
        private Logger age11;
        private Logger age12;
        private Logger age13;
        private Logger age14;
        private Logger age15;
        private Logger age16;
        private Logger age17;
        private Logger age18;
        private Logger age19;

        public class Logger
        {
            public void Log(string msg)
            {
            }
        }

        #endregion
    }
}