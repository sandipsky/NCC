using System;
// sharing and code usablity
// child class ko obj bannu agadi parent obj hunu parxa
//meaning goes to parent constructer first
//sealed keyword prevents from inheritning that class
namespace inheritance
{
    public class LivingThings
    {
        public int publicvariable;
        //public outside of class
        private int _privatevariable;
        //private inside the class only
        protected int protectedvariable;
        // protected can be called by child class
        public LivingThings()
        {

        }
        public LivingThings(int i)
        {
            
        }

    }
    public class Animal: LivingThings
    {
        //goes to base first 
        //depending on parameter
        public Animal() : base()
        {

        }
        public Animal(int i)
        {

        }
    }

    public class Plants: LivingThings
    {
        public Plants() : base(16)
        {

        }
        public Plants(int i)
        {
            
        }
    }
    public class Vertibrate: Animal
    {
        //if no constructor specified goes to default 

    }
    //public sealed Vertibrate : Man
    //not possible because sealed prevents from inheriting from that class


    public static void Main()
    {
        LivingThings l1 = new LivingThings();
        LivingThings l2 = new LivingThings(20);
        Animal a1 = new Animal();
        Animal a2 = new Animal(20);
        Plants p1 = new Plants();
        Plants p2 = new Plants(2);
        Vertibrate v1 = new Vertibrate();
        
    }

}
