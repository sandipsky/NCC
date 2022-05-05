using System;

public class oop
{
    public static void Main()
    {
        MarksInfo mi = new MarksInfo();
        mi.MathMarks = 200;
        mi.ScienceMarks = -200;
        System.Console.WriteLine(mi.Total);
        System.Console.WriteLine(mi.Percentage);
    }
}
