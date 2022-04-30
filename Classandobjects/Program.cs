using System;

public class example
{
    public static void Main()
    {
        ClassAndObject c1 = new ClassAndObject();
        var c2 = new ClassAndObject(0);
        c2.Fname = "sandip";
        Console.WriteLine(c2.Fname);
    }
}
