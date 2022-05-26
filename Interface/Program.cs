using System;

namespace InterfaceProgram
{   
    //can only contain abstract methods
    //doesnt contain non abstract methods unlike abstract class
    //use keyword interface to delcare interface and Start classname with I to distinguish
    //cannot create objects 
    //must be inherited to use 
    //its use is to have child class manditory methods in interface parent class
    public interface IShape
    {
        void GetInput();

        void Area();

        void Perimeter();
    }

    public class Square : IShape
    {
        private double length;

        public double Length
        {
            get
            {
                return length;
            }
        }

        public void GetInput()
        {
            Console.WriteLine("Enter the Length of Square");
            length = Convert.ToDouble(Console.ReadLine());
        }

        public void Area()
        {
            Console.WriteLine($"Area of Square = {Math.Pow(length, 2)}");
        }

        public void Perimeter()
        {
            Console.WriteLine($"Perimeter of Square = {4 * length}");
        }
    }

    public class Rectangle : IShape
    {
        private double length;
        private double breadth;

        public void GetInput()
        {
            Console.WriteLine("Enter the Length of Rectangle");
            length = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the Breadth of Rectangle");
            breadth = Convert.ToDouble(Console.ReadLine());
        }

        public void Area()
        {
            Console.WriteLine($"Area of Rectangle = {length * breadth}");
        }

        public void Perimeter()
        {
            Console.WriteLine($"Perimeter of Rectangle = {2 * (length + breadth)}");
        }
    }

    public class Circle : IShape
    {
        private double radius;

        public void GetInput()
        {
            Console.WriteLine("Enter the radius of circle");
            radius = Convert.ToDouble(Console.ReadLine());
        }

        public void Area()
        {
            Console.WriteLine($"Area of Circle = {Math.PI * Math.Pow(radius, 2)}");
        }

        public void Perimeter()
        {
            Console.WriteLine($"Circumference of circle = {2 * radius}");
        }

    }
    public class A
    {
        private static void ShapesExample()
        {
            Console.WriteLine("Enter the choice\n1. for Square\n2 for Rectangle\n3 for Circle");
            var choice = Convert.ToInt32(Console.ReadLine());

            var shape = ShapeFactory(choice);
            if (shape == null)
            {
                Console.WriteLine("Invalid choice");
                return;
            }
            shape.GetInput();
            shape.Area();
            shape.Perimeter();
        }

        private static IShape ShapeFactory(int choice)
        {
            switch (choice)
            {
                case 1:
                    return new Square();

                case 2:
                    return new Rectangle();

                case 3:
                    return new Circle();


                default:
                    return null;
            }
        }
        public static void Main()
        {
            ShapesExample();
        }
    }
}