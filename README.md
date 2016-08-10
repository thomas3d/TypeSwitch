# TypeSwitch

I got the idea here:
http://stackoverflow.com/questions/7252186/switch-case-on-type-c-sharp/7301514#7301514

public static void TestTypeSwitch()
{
    var ts = new TypeSwitch()
        .Case((int x) => Console.WriteLine("int"))
        .Case((bool x) => Console.WriteLine("bool"))
        .Case((string x) => Console.WriteLine("string"));

    ts.Switch(42);     
    ts.Switch(false);  
    ts.Switch("hello"); 
}

public class TypeSwitch
{
    Dictionary<Type, Action<object>> matches = new Dictionary<Type, Action<object>>();
    public TypeSwitch Case<T>(Action<T> action) { matches.Add(typeof(T), (x) => action((T)x)); return this; } 
    public void Switch(object x) { matches[x.GetType()](x); }
}

Thanks to Christopher from Autodesk (http://stackoverflow.com/users/184528/cdiggins)
Thanks to Stackoverflow
Thanks to Google
