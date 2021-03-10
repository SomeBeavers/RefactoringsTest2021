using System;
using System.Collections.Generic;

namespace RefactoringsTest2021.ExtractMembersToPartial
{
    public partial class ExtractMembersToPartial1
    {
        private ExtractMembersToPartial1 extractClassPartial1;
        internal float[] internalField;
        protected bool protectedField;
        protected internal List<Action> protectedInternalField;

        public string PublicField;

        private int PrivateField_Property { get; set; }

        public string PublicField_Property
        {
            get => PublicField;
            set => PublicField = value;
        }

        protected bool ProtectedField_Property
        {
            get => protectedField;
            set => protectedField = value;
        }

        public void Test()
        {
        }
        public void Test1()
        {
        }
        public void Test2()
        {
        }
        public void Test3()
        {
        }
        public void Test4()
        {
        }
        public void Test5()
        {
        }
        public void Test6()
        {
        }
        public void Test7()
        {
        }
        public void Test8()
        {
        }
        public void Test9()
        {
        }
        public void Test11()
        {
        }
        public void Test12()
        {
        }
        public void Test13()
        {
        }
        public void Test14()
        {
        }
        public void Test15()
        {
        }
        public void Test16()
        {
        }
        public void Test17()
        {
        }
        public void Test18()
        {
        }
        public void Test19()
        {
        }

        partial void OnSomethingHappened(string s);
    }
}