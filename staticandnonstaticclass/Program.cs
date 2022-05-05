using System;

//static class means jasko object create garna mildaina because afai ma object ho
//static class ma static member hunai parxa but non static ma huna pani sakxa
//static member in shared among objects of non static class
namespace name
{
    public class try1
    {
        public static void Main()
        {
            // StaticClass sc = new StaticClass(); not valid
            var ns = new NonStaticClass();
            NonStaticClass.istatic = 20;
            //no need to create object to access static members
            NonStaticClass.staticfn();
            ns.i = 20;
            //need to create object to access nonstatic member
            var n1 = new NonStaticClass();
            var n2 = new NonStaticClass();
            var n3 = new NonStaticClass();
            n1.functionOne();
            n2.functionOne();
            n3.functionOne();
        }
    }
    public class NonStaticClass
    {
       public int i =10;
       public void functionOne()
       {
          // staticfn(); valid
            i++;
            istatic++;
            System.Console.WriteLine($"i={i} & istatic={istatic}");
       }
       public static int istatic = 10;
       public static void staticfn()
       {
        //    functionOne(); not valid
       }
    }
    public static class StaticClass
    {   
    //    public void functionOne()
    //    {

    //    } this is wrong
        public static void functionOne()
        {

        }
    }
}




