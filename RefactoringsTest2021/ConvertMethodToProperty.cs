namespace RefactoringsTest2021
{
    public class ConvertMethodToProperty
    {
        public string Faculty { get; set; }

        public string Test()
        {
            Faculty = "faculty";
            return Faculty;
        }
    }
}