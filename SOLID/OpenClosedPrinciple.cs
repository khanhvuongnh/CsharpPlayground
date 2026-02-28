namespace CsharpPlayground.SOLID.O
{
    /*
        Software entities (classes, modules, functions, etc.) should be open for extension but closed for modification.
        In this example, the Shape class has a method, CalculateArea(), that calculates the area based on the type of shape. 
        Adding a new shape, such as a triangle, would require modifying the existing Shape class, violating the OCP.
        To adhere to the Open/Closed Principle, we should design the system in a way that allows for extension without modification. 
        Let's refactor the code using inheritance and polymorphism:
    */

    public enum ShapeType
    {
        Circle,
        Rectangle
    }

    public class Shape
    {
        public ShapeType Type { get; set; }
        public double Radius { get; set; }
        public double Length { get; set; }
        public double Width { get; set; }

        public double CalculateArea()
        {
            switch (Type)
            {
                case ShapeType.Circle:
                    return Math.PI * Math.Pow(Radius, 2);
                case ShapeType.Rectangle:
                    return Length * Width;
                default:
                    throw new InvalidOperationException("Unsupported shape type.");
            }
        }
    }
}

namespace CsharpPlayground.SOLID.O.Refactored
{
    public abstract class Shape
    {
        public abstract double CalculateArea();
    }

    public class Circle : Shape
    {
        public double Radius { get; set; }

        public override double CalculateArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }

    public class Rectangle : Shape
    {
        public double Length { get; set; }
        public double Width { get; set; }

        public override double CalculateArea()
        {
            return Length * Width;
        }
    }
}