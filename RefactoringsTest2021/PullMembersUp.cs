using System;

namespace RefactoringsTest2021
{
    public class PullMembersUp : PullMembersUpBase, IPullMembersUp, IPullMembersUp1, IPullMembersUp2, IPullMembersUp3,
        IPullMembersUp4, IPullMembersUp5
    {
        public void Test()
        {
            Test2();
        }

        public void Test2()
        {
            throw new NotImplementedException();
        }

        private void PrivateMethod()
        {
            PublicProperty = 1;
        }

        public override void PublicVirtualMethod()
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

        public int PublicProperty { get; set; }

        protected int ProtectedField;
    }

    public abstract class PullMembersUpAbstract: PullMembersUpBase, IPullMembersUp
    {
        public abstract void PublicVirtualMethod();
    }

    #region Helpers

    public interface IPullMembersUpInterface
    {
    }

    public interface IPullMembersUpInterface1
    {
    }

    public interface IPullMembersUpInterface2
    {
    }

    public interface IPullMembersUpInterface3
    {
    }

    public interface IPullMembersUpInterface4
    {
    }

    public interface IPullMembersUpInterface5
    {
    }

    public interface IPullMembersUp1 : IPullMembersUpInterface, IPullMembersUpInterface1, IPullMembersUpInterface2,
        IPullMembersUpInterface3, IPullMembersUpInterface4, IPullMembersUpInterface5
    {
    }

    public interface IPullMembersUp5
    {
    }

    public interface IPullMembersUp2
    {
    }

    public interface IPullMembersUp3
    {
    }

    public interface IPullMembersUp4
    {
    }

    public interface IPullMembersUp
    {
    }

    public interface IPullMembersUpBase
    {
    }

    public interface IPullMembersUpBase1
    {
    }

    public interface IPullMembersUpBase2
    {
    }

    public interface IPullMembersUpBase3
    {
    }

    public interface IPullMembersUpBase4
    {
    }

    public interface IPullMembersUpBase5
    {
    }

    public class PullMembersUpBase : IPullMembersUpBase, IPullMembersUpBase1, IPullMembersUpBase2, IPullMembersUpBase3,
        IPullMembersUpBase4, IPullMembersUpBase5
    {
        public virtual void PublicVirtualMethod()
        {
            throw new System.NotImplementedException();
        }
    }

    #endregion
}