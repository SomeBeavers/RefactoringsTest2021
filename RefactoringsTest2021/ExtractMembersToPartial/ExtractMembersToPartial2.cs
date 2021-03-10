namespace RefactoringsTest2021.ExtractMembersToPartial
{
    public class ExtractMembersToPartial2<T> where T : new()
    {
        private T privateTField;

        public ExtractMembersToPartial2()
        {
            privateTField = new T();
        }
    }
}