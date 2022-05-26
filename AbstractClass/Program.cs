using System;

namespace abstractclass
{
    //cannot create the object of abstract class 
    //contains abstract methods
    //abstract methods : methods with no body
    // It can also contain non abstract methods
    //abstract methods means child class le override garnai parxa use garna
    //abstract methods define rule that yo method child class ma hunai parxa
    //cannot create the object
        public abstract class ShapeAbs
        {
            protected double area;
            protected double perimeter;

            //abstract method
            protected abstract void getInput();

            protected abstract void calculate();

            public void GetInput()
            {
                getInput();
                calculate();
            }
            //non abstract method
            public void Area()
            {
                Console.WriteLine($"Area = {area}");
            }

            public void Perimeter()
            {
                Console.WriteLine($"Perimeter = {perimeter}");
            }
        }

        public class Square : ShapeAbs
        {
            private double length;

            protected override void getInput()
            {
                Console.WriteLine("Enter the Length of Square");
                length = Convert.ToDouble(Console.ReadLine());
            }

            protected override void calculate()
            {
                area = Math.Pow(length, 2);
                perimeter = 4 * length;
            }
        }

        public class Rectangle : ShapeAbs
        {
            private double length;
            private double breadth;

            protected override void calculate()
            {
                area = length * breadth;
                perimeter = 2 * (length + breadth);
            }

            protected override void getInput()
            {
                Console.WriteLine("Enter the Length of Rectangle");
                length = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter the Breadth of Rectangle");
                breadth = Convert.ToDouble(Console.ReadLine());
            }
        }

    public class A
    {
        public static void Main()
        {
            //Square square = new Square();
            //square.GetInput();
            //square.Area();
            //square.Perimeter();

            ShapesExample();

        }
        private static void ShapesExample()
        {
            Console.WriteLine("Enter the choice\n1. for Square\n2 for Rectangle");
            var choice = Convert.ToInt32(Console.ReadLine());

            var shape = AbstractShapeFactory(choice);
            if (shape == null)
            {
                Console.WriteLine("Invalid choice");
                return;
            }
            shape.GetInput();
            shape.Area();
            shape.Perimeter();
        }

        //function to create shapes as per user input choice
        //returns object of type ShapeAbs which is abstrct class 
        private static ShapeAbs AbstractShapeFactory(int choice)
        {
            switch (choice)
            {
                case 1:
                    return new Square();

                case 2:
                    return new Rectangle();

                default:
                    return null;
            }
        }

        
    }
    }
