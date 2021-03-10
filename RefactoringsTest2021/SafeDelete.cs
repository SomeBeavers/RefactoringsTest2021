namespace RefactoringsTest2021
{
    public class SafeDelete : SafeDeleteBase
    {
        public SafeDelete(string name)
        {
        }

        public SafeDelete(string name, int age) : this(name)
        {
        }

        public override void SafeDeleteMethod()
        {
        }

        public override void SafeDeleteMethod(string s)
        {
            SafeDeleteMethod();
        }
    }

    public class UseSafeDelete
    {
        private void UseSafeDelete1()
        {
            var safeDelete = new SafeDelete("Jane Doe");
        }
    }

    public class TestLongNameTestLongNameTestLongNameTestLongNameTestLongNameTestLongNameTestLongName
    {
    }

    #region Helpers

    public abstract class SafeDeleteBase
    {
        public abstract void SafeDeleteMethod();
        public abstract void SafeDeleteMethod(string s);
    }

    public class BC : TestLongNameTestLongNameTestLongNameTestLongNameTestLongNameTestLongNameTestLongName
    {
    }

    #endregion
}