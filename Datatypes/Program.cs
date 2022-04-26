using System;

namespace Ncc.ConsoleApp
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Hello, World!");
            DataTypes();
        }
        static void DataTypes()
        {
            int i = 10;
            i=20;
            
            char c = '2';
            i=c;
            long l=i;
            float f = l;
            double d = f;

            f=(float)d;
            l=(long)f;
            i=(int)l;
            c=(char)i;

            //var a="1";
            //var b = 2;
            //a=b will not work

            object o1="";
            object o2=2;
            o1=o2; //this will work


            string str = "123";
            int m = Convert.ToInt32(str);


        }
    }

}

//char => int => long => float => double

