namespace CsharpPlayground.SOLID.I
{
    /*
        Clients should not be forced to depend on interfaces they do not use.
        In this example, we have an IShape interface representing both 2D and 3D shapes. However, the Volume() method is problematic for 2D shapes, 
        like Circle and Rectangle, because they don't have volume. This violates the ISP because clients (classes using the IShape interface) 
        may be forced to depend on methods they do not need.
    */
    
    public interface IShape
    {
        double Area();
        double Volume(); // Problem: 2D shapes don't have volume!
    }

    public class Circle : IShape
    {
        public double Radius { get; set; }

        public double Area()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }

        public double Volume()
        {
            Console.Write("Volume not applicable for 2D shapes.");
            return 0; // This is a workaround, but it violates the principle.
        }
    }

    public class Sphere : IShape
    {
        public double Radius { get; set; }

        public double Area()
        {
            return 4 * Math.PI * Math.Pow(Radius, 2);
        }

        public double Volume()
        {
            return (4.0 / 3.0) * Math.PI * Math.Pow(Radius, 3);
        }
    }
}

namespace CsharpPlayground.SOLID.I.Refactored
{
    public interface IShape2D
    {
        double Area();
    }

    public interface IShape3D
    {
        double Area();
        double Volume();
    }

    public class Circle : IShape2D
    {
        public double Radius { get; set; }

        public double Area()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }

    public class Sphere : IShape3D
    {
        public double Radius { get; set; }

        public double Area()
        {
            return 4 * Math.PI * Math.Pow(Radius, 2);
        }

        public double Volume()
        {
            return (4.0 / 3.0) * Math.PI * Math.Pow(Radius, 3);
        }
    }
}