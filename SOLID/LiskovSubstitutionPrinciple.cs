namespace CsharpPlayground.SOLID.L
{
    /*
        Objects of a superclass should be replaceable with objects of its subclass without affecting the correctness of the program. 
        We replaced the object of a superclass (Rectangle) with an object of its subclass (Square), and it affected the correctness of our program. 
        By modeling Square as a subclass of Rectangle, and allowing width and height to be independently set, we violate the LSP. 
        When setting the width and height of a Square, it should retain its squareness, but our implementation allows for inconsistency.
    */

    public abstract class Shape
    {
        public abstract double Area { get; }
    }

    public class Rectangle : Shape
    {
        public virtual double Width { get; set; }

        public virtual double Height { get; set; }

        public override double Area => Width * Height;
    }

    public class Square : Rectangle
    {
        public override double Width
        {
            get => base.Width;
            set => base.Width = base.Height = value;
        }

        public override double Height
        {
            get => base.Height;
            set => base.Height = base.Width = value;
        }
    }
}

namespace CsharpPlayground.SOLID.L.Refactored
{
    public abstract class Shape
    {
        public abstract double Area { get; }
    }

    public class Rectangle : Shape
    {
        public double Width { get; set; }

        public double Height { get; set; }

        public override double Area => Width * Height;
    }

    public class Square : Shape
    {
        private double sideLength;

        public double SideLength
        {
            get => sideLength;
            set
            {
                sideLength = value;
            }
        }

        public override double Area => sideLength * sideLength;
    }
}
