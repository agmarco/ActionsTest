using System;

public class TestClass
{    
    private string ConnectionString = "#{connectionString}#";
    private string EpicorUrl = "#{epicorUrl}";

    public string TestMethod(string value)
    {
        var inmethodValue = "#{someVariable}";
    }

    public string DummyMethod(string anotherMethod)
    {
        var anotherMethodVariable = "#{anotherVariable}";
    }
}