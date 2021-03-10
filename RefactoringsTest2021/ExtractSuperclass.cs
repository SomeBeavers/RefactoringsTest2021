namespace RefactoringsTest2021
{
    public class ExtractSuperclass
    {
        protected int ProtectedField;

        public int PublicProperty { get; set; }

        private void PrivateMethod()
        {
            PublicProperty = 1;
        }

        public virtual void PublicVirtualMethod()
        {
            PublicMethod();
        }

        public void PublicMethod()
        {
            PrivateMethod();
        }
    }

    public abstract class AbstractExtractSuperclass : IAbstractExtractSuperclass
    {
        private InnerClass ic;
        public abstract InnerClass? ReturnInnerClass();

        public class InnerClass
        {
        }
    }

    public class ExtractSuperclassManyMembers
    {
        protected int ProtectedField;

        public int PublicProperty { get; set; }

        private void PrivateMethod()
        {
            PublicProperty = 1;
        }

        public virtual void PublicVirtualMethod()
        {
            PublicMethod();
        }

        public void PublicMethod()
        {
            PrivateMethod();
        }

        public void PublicMethod1()
        {
            PrivateMethod();
        }

        public void PublicMethod2()
        {
            PrivateMethod();
        }

        public void PublicMethod3()
        {
            PrivateMethod();
        }

        public void PublicMethod4()
        {
            PrivateMethod();
        }

        public void PublicMethod5()
        {
            PrivateMethod();
        }

        public void PublicMethod6()
        {
            PrivateMethod();
        }

        public void PublicMethod7()
        {
            PrivateMethod();
        }

        public void PublicMethod8()
        {
            PrivateMethod();
        }

        public void PublicMethod9()
        {
            PrivateMethod();
        }

        public void PublicMethod21()
        {
            PrivateMethod();
        }

        public void PublicMethod22()
        {
            PrivateMethod();
        }

        public void PublicMethod23()
        {
            PrivateMethod();
        }

        public void PublicMethod24()
        {
            PrivateMethod();
        }

        public void PublicMethod25()
        {
            PrivateMethod();
        }

        public void PublicMethod26()
        {
            PrivateMethod();
        }

        public void PublicMethod27()
        {
            PrivateMethod();
        }

        public void PublicMethod28()
        {
            PrivateMethod();
        }

        public void PublicMethod29()
        {
            PrivateMethod();
        }

        public void PublicMethod11()
        {
            PrivateMethod();
        }

        public void PublicMethod12()
        {
            PrivateMethod();
        }

        public void PublicMethod13()
        {
            PrivateMethod();
        }

        public void PublicMethod14()
        {
            PrivateMethod();
        }

        public void PublicMethod15()
        {
            PrivateMethod();
        }

        public void PublicMethod16()
        {
            PrivateMethod();
        }

        public void PublicMethod17()
        {
            PrivateMethod();
        }

        public void PublicMethod18()
        {
            PrivateMethod();
        }

        public void PublicMethod19()
        {
            PrivateMethod();
        }
    }

    #region Helpers

    public interface IAbstractExtractSuperclass
    {
        AbstractExtractSuperclass.InnerClass? ReturnInnerClass();
    }

    #endregion
}