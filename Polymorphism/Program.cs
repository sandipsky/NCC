using System;

//polymorphism means child class overriding parent class methods
namespace program
{
    public class LivingThings
    {   
        //virtual means afno class ko object ko lagi real
        //child ko lagi exist gardaina
        public virtual void eat()
        {
            Console.WriteLine("Living things can eat");
        }
    }
    public class Animal: LivingThings
    {
        public void eat()
        {
            Console.WriteLine("Animal can eat");
        }
    }

    public class Plant: LivingThings
    {
        //override le j gareni afnai function call garxa
        //overide harne 3 case
        //base method huna paryo
        //base method virtual huna parxa
        //based method abstract huna parxa
        public override void eat()
        {
            Console.WriteLine("Plants can eat");
        }
    }
    public class Vertibrates: Animal
    {
      
    }
    public class polymorphism
    {
        public static void Main()
        {
            LivingThings l1 = new LivingThings();
            Plant p1 = new Plant();
            //transforming plant object to living thing objects
            LivingThings p2 = new Plant();
            Animal a1 = new Animal();
            Vertibrates v1 = new Vertibrates();
            l1.eat();   
            p1.eat();
            p2.eat();
            a1.eat();
            v1.eat();

        }
    }
}
