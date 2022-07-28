using System.Collections.Specialized;
using Newtonsoft.Json;

namespace GlobalUsingsProject;

public class ExtractGlobalUsings
{
    public void Test()
    {
        
        var listDictionary = new ListDictionary();
        var json = new JsonConverterAttribute(typeof(A));

        Console.WriteLine(json);
    }
}

public class A
{
}