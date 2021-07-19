using System.Collections.Generic;

namespace RefactoringsTest2021
{
    #nullable enable
    public class MakeNullable
    {
        private Person personField;

        IEnumerable<Person> VarIsChanged(Person person/*caret*/)
        {
            var list = new List<Person>();
            var person2 = person;
            list.Add(person2);
            list.Add(personField);
            return list;
        }

        private A2 a/*caret*/ = new A2();

        private void Test()
        {
            string? s = AName(a.Name);
        }

        private string? AName(string? aa)
        {
            return aa;
        }

        public A_1 A { get; set; }
        private void Test3()
        {
            A_1 s/*caret*/ = A;
            A_1 a2 = s;
        }

        private string /*caret*/Test2()
        {
            Use(Test2());
            Use(GenerateInv());
            return "";
        }

        private string Use(string s)
        {
            return Test2();
        }

        private string GenerateInv()
        {
            return "";
        }

        #region Helpers

        internal class Person
        {
        }

        internal class A2
        {
            public string Name { get; set; }
        }

        public class A_1
        {
        }

        #endregion
    }
}