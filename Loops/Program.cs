using System;
using System.Text;

public class program
{
    public static void Main()
    {
        LoopingStatements();
    }
    private static void LoopingStatements()
    {
        //doing tasks repeatedly
        //initialization, condition, incr/decrement
        //unknown quantities
        //while loops are used for unknown quantities
        var res = "n";
        do{
            Console.WriteLine("Do u want to continue");
            res = Console.ReadLine();
        }while(res.ToUpper() == "Y");

        



        //known quantities

        //using while loop to print table of 10
        Console.WriteLine("Enter a number");
        var num = Convert.ToInt32(Console.ReadLine());
        int i =1;
        while(i<=10)
        {
            Console.WriteLine(num + "x" + i + "=" + (num)*i);
            i++;
        }

        for(i=1;i<=10;i++)
        {
            Console.WriteLine(num + "x" + i + "=" + (num)*i);
        }

        string[] days = new string[] {"Sunday", "Monday", "Tuesday", "Wednesday", "Thrusday", "Friday", "Saturday"};

        foreach (var item in days)
        {
            Console.WriteLine("Day = " + item);
        }
        for(i=0;i<days.Length;i++)
        {
            Console.WriteLine("Days = " + days[i]);
        }
    }
    private static void StringManipulation()
    {
        string s1 = "Hello";
        string s2 = "NCC";

        //string concatenation
        Console.WriteLine(s1 + " " + s2);

        //string formatiing
        string templ = "{0} {1}";
        var res1 = string.Format(templ, s1, s2);
        Console.WriteLine("{0} {1}", s1,s2);

        //string interpolation
        var res2 = $"{s1}! {s2}";
        Console.WriteLine(res2);

        //stringbuilder
        StringBuilder sb = new StringBuilder();
        sb.AppendLine("addas asd as asdas asd ");
        var res5 = sb.ToString();

    }
}
