using System;

namespace ConsoleApp1
{
    public class Shape  
    {
        bool JudgeLegal() { return false; }
        void PrintArea() { }

    }
    public class Rectangle : Shape
    {
        private double width;
        private double height;
        public Rectangle(double width, double height)
        {
            this.width = width;
            this.height = height;
        }
        public bool JudgeLegal()
        {
            if(width <= 0 || height <= 0)
            {
                return false;
            }
            else
            {
                Console.WriteLine("This shape is a rectangle.");
                return true;
            };
        }
        public double PrintArea()
        {
            return width * height;
        }
    }
    public class Square : Shape
    {
        private double length;
        public Square(double length)
        {
            this.length = length;
        }
        public bool JudgeLegal()
        {
            if(length <= 0)
            {
                return false;
            }
            else
            {
                Console.WriteLine("This shape is a square.");
                return true;
            };
        }
        public double PrintArea()
        {
            return length * length;
        }
    }
    public class Triangle : Shape
    {
        private double width;
        private double height;
        public Triangle(double width, double height)
        {
            this.width = width;
            this.height = height;
        }
        public bool JudgeLegal()
        {
            if(width < 0 || height < 0)
            {
                return false;
            }
            else
            {
                Console.WriteLine("This shape is a triangle.");
                return true;
            };
        }
        public double PrintArea()
        {
            return 0.5*width*height;
        }
    }
    public static class ShapePrinter
    {
        public static void DrwaShape(Shape shape)
        {
            if(shape.GetType() == typeof(Rectangle))
            {
                Rectangle rectangle = (Rectangle)shape;
                rectangle.JudgeLegal();
                Console.WriteLine("The area is " + rectangle.PrintArea());
            }else if(shape.GetType() == typeof(Square))
            {
                Square square = (Square)shape;
                square.JudgeLegal();
                Console.WriteLine("The area is " + square.PrintArea());
            }
            else if (shape.GetType() == typeof(Triangle))
            {
                Triangle triangle = (Triangle)shape;
                triangle.JudgeLegal();
                Console.WriteLine("The area is "+triangle.PrintArea());
            }
        }
    }
    class Test
    {
        static void Main(string[] args)
        {
            Shape shape1 = new Rectangle(2.0, 1.0);
            Shape shape2 = new Square(3.0);
            Shape shape3 = new Triangle(2.0, 1.4);
            Shape shape4 = new Rectangle(1.0, 1.0);
            Shape shape5 = new Rectangle(4.0, 9.0);
            Shape shape6 = new Square(4.5);
            Shape shape7 = new Square(10.0);
            Shape shape8 = new Square(5.0);
            Shape shape9 = new Triangle(10.0, 1.0);
            Shape shape10 = new Triangle(5.0, 5.0);
            ShapePrinter.DrwaShape(shape1);
            ShapePrinter.DrwaShape(shape2);
            ShapePrinter.DrwaShape(shape3);
            ShapePrinter.DrwaShape(shape4);
            ShapePrinter.DrwaShape(shape5);
            ShapePrinter.DrwaShape(shape6);
            ShapePrinter.DrwaShape(shape7);
            ShapePrinter.DrwaShape(shape8);
            ShapePrinter.DrwaShape(shape9);
            ShapePrinter.DrwaShape(shape10);
        }
    }
}