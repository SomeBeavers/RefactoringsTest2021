using System;

namespace RefactoringsTest2021.ExtractMembersToPartial
{
    public partial class ExtractMembersToPartial1
    {
        // Partial method
        partial void OnSomethingHappened(String s)
        {
            Console.WriteLine("Something happened: {0}", s);
        }
    }
}