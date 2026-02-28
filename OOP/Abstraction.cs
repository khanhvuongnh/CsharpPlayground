namespace CsharpPlayground.OOP.Abstraction
{
    /*
        Abstraction is the first and perhaps the most important principle of Object-Oriented Programming (OOP). 
        It allows us to hide the implementation details of an object and provide only the necessary interface for working with it. 
        In other words, abstraction enables us to focus on what an object does rather than how it does it. 
    */

    abstract class Bird
    {
        public abstract void MakeSound();

        public void Sleep() => Console.WriteLine("Zzz");
    }

    class Sparrow : Bird
    {
        public override void MakeSound()
        {
            Console.WriteLine("Chirp chirp!");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Sparrow sparrow = new();
            sparrow.MakeSound();
            sparrow.Sleep();
        }
    }
}
