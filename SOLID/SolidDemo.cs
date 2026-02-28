using CsharpPlayground.SOLID.D.Refactored;
using CsharpPlayground.SOLID.I;
using CsharpPlayground.SOLID.L;

namespace CsharpPlayground.SOLID
{
    public class SolidDemo
    {
        public static void Main()
        {
            Console.WriteLine("# Liskov Substitution Principle violation example");
            var rect = new Rectangle
            {
                Height = 10,
                Width = 5
            };
            Console.WriteLine("Expected area = 10 * 5 = 50.");
            Console.WriteLine("Calculated area = " + rect.Area);
            var squr = new Square
            {
                Height = 10,
                Width = 5
            };
            Console.WriteLine("Expected area = 10 * 5 = 50.");
            Console.WriteLine("Calculated area = " + squr.Area);

            Console.WriteLine("# Interface Segregation Principle violation example");
            var circle = new Circle
            {
                Radius = 10
            };
            Console.WriteLine(circle.Area());
            Console.WriteLine(circle.Volume());

            var sphere = new Sphere
            {
                Radius = 10
            };
            Console.WriteLine(sphere.Area());
            Console.WriteLine(sphere.Volume());

            Console.WriteLine("# Dependency Inversion Principle violation example");
            var engine = new Engine(); // concrete implementation to be "injected" into the car
            var car = new Car(engine);
            car.StartCar();
        }
    }
}
