using System;

namespace RefactoringsTest2021
{
    public class ExtractInterface
    {
        private int t;
        private string Name { get; set; }
        public string NamePublic { get; set; }

        /// <summary>
        /// Select Dependent.
        /// </summary>
        public void Test()
        {
            NamePublic = "";
            Console.WriteLine(t);
            Console.WriteLine(Name);
        }
    }

    public class ExtractInterfaceWithManyMembers
    {
        public string Name { get; set; }
        public string Name1 { get; set; }
        public string Name2 { get; set; }
        public string Name3 { get; set; }
        public string Name4 { get; set; }
        public string Name5 { get; set; }
        public string Name6 { get; set; }
        public string Name7 { get; set; }
        public string Name8 { get; set; }
        public string Name9 { get; set; }
        public string Name10 { get; set; }
        private string Name11 { get; set; }
        private string Name12 { get; set; }
        private string Name13 { get; set; }
        private string Name14 { get; set; }
        private string Name15 { get; set; }
        private string Name16 { get; set; }
        private string Name17 { get; set; }
        private string Name18 { get; set; }
        public string Name19 { get; set; }

        public void Use()
        {
            Name = "";
        }
        public void Use1()
        {
            Name1 = "";
        }
        public void Use2()
        {
            Name2 = "";
        }
        public void Use3()
        {
            Name3 = "";
        }
        public void Use4()
        {
            Name4 = "";
        }
        public void Use5()
        {
            Name5 = "";
        }
        public void Use6()
        {
            Name6 = "";
        }
        public void Use7()
        {
            Name7 = "";
        }
        public void Use8()
        {
            Name8 = "";
        }
        public void Use9()
        {
            Name9 = "";
        }
        public void Use10()
        {
            Name10 = "";
        }
        public void Use11()
        {
            Name11 = "";
        }
        public void Use12()
        {
            Name12 = "";
        }
        public void Use13()
        {
            Name13 = "";
        }
        public void Use14()
        {
            Name14 = "";
        }
        public void Use15()
        {
            Name15 = "";
        }
        public void Use16()
        {
            Name16 = "";
        }
        public void Use17()
        {
            Name17 = "";
        }
        public void Use18()
        {
            Name18 = "";
        }

        private class InnerClass
        {
        }
    }
}