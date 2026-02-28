namespace CsharpPlayground.SOLID.D
{
    /*
        High-level modules should not depend on low-level modules. Both should depend on abstractions.
        In this example:
            + The Car class directly creates an instance of the Engine class, leading to a tight coupling between Car and Engine.
            + If the Engine class changes, it may affect the Car class, violating the Dependency Inversion Principle.
    */

    public class Engine // Engine is our "low-level" module
    {
        public void Start()
        {
            Console.WriteLine("Engine started.");
        }
    }

    public class Car // Car is our "high-level" module
    {
        private Engine engine;

        public Car()
        {
            this.engine = new Engine(); // Direct dependency on concrete Engine class
        }

        public void StartCar()
        {
            engine.Start();
            Console.WriteLine("Car started.");
        }
    }
}

namespace CsharpPlayground.SOLID.D.Refactored
{
    /*
        We define an interface IEngine representing the behavior of an engine.
        The Engine class implements the IEngine interface.
        The Car class now depends on the IEngine interface instead of the concrete Engine class.
        Dependency injection is used to inject the IEngine implementation into the Car class, promoting loose coupling. 
        Now, if we want to give a car a different type of engine, for example a FastEngine, we can inject that in instead.
        Now, if the implementation of the engine changes, it won't affect the Car class as long as it adheres to the IEngine interface. 
    */

    public interface IEngine
    {
        void Start();
    }

    public class Engine : IEngine
    {
        public void Start()
        {
            System.Console.WriteLine("Engine started.");
        }
    }

    public class Car
    {
        private IEngine engine;

        public Car(IEngine engine)
        {
            this.engine = engine;
        }

        public void StartCar()
        {
            engine.Start();
            Console.WriteLine("Car started.");
        }
    }
}
