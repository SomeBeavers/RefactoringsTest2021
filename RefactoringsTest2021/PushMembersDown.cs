using System;

namespace RefactoringsTest2021
{
    public class PushMembersDown
    {
        protected int ProtectedField;

        public int PublicProperty { get; set; }

        public virtual void Test()
        {
        }

        public void Test2()
        {
            throw new NotImplementedException();
        }

        private void PrivateMethod()
        {
            PublicProperty = 1;
        }

        public void PublicVirtualMethod()
        {
            PublicProperty = 1;
            PrivateMethod();
        }

        public void PublicMethod()
        {
            PublicProperty = 1;
            ProtectedField = 1;
            PublicVirtualMethod();
        }
    }

    public interface IPushMembersDown
    {
        int PublicProperty { get; set; }
        void Test();
        void Test2();
        void PrivateMethod();
        void PublicVirtualMethod();
        void PublicMethod();
    }

    #region Helpers

    internal class PushMembersDown1 : PushMembersDown
    {
    }

    internal class PushMembersDown2 : PushMembersDown
    {
    }

    internal class PushMembersDown3 : PushMembersDown
    {
    }

    internal class PushMembersDown4 : PushMembersDown
    {
    }

    internal class PushMembersDown5 : PushMembersDown
    {
    }
    internal class PushMembersDown6 : PushMembersDown
    {
    }

    internal class PushMembersDown7 : PushMembersDown
    {
    }

    internal class PushMembersDown8 : PushMembersDown
    {
    }

    internal class PushMembersDown9 : PushMembersDown
    {
    }
    internal class PushMembersDown11 : PushMembersDown
    {
    }

    internal class PushMembersDown12 : PushMembersDown
    {
    }

    internal class PushMembersDown13 : PushMembersDown
    {
    }

    internal class PushMembersDown14 : PushMembersDown
    {
    }

    internal class PushMembersDown15 : PushMembersDown
    {
    }
    internal class PushMembersDown16 : PushMembersDown
    {
    }

    internal class PushMembersDown17 : PushMembersDown
    {
    }

    internal class PushMembersDown18 : PushMembersDown
    {
    }

    internal class PushMembersDown19 : PushMembersDown
    {
    }

    internal class PushMembersDown10 : PushMembersDown
    {
    }

    internal class PushMembersDown5_1 : PushMembersDown5
    {
    }

    internal interface IPushMembersDown_1 : IPushMembersDown
    {
    }

    #endregion
}