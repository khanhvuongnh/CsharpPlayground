namespace CsharpPlayground.OOP.Polymorphism
{
    /*
        Polymorphism is the ability of objects from different classes to respond to the same methods. 
        This allows us to write flexible and versatile code that can work with different types of objects. 
        In this example, Shape is the base class, and Circle and Rectangle are its derived classes. 
        When the Draw() method is called on objects of different types, the corresponding method from each class will be invoked.
    */

    class Shape
    {
        public virtual void Draw()
        {
            Console.WriteLine("Drawing a shape");
        }
    }

    class Circle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing a circle");
        }
    }

    class Rectangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing a rectangle");
        }
    }
}
