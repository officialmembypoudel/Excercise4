namespace Excercise4;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Running, Program!");

        Circle cir = new Circle(5);

        double area = cir.CalculateArea();

        Console.WriteLine($"The area of given circle is {area}");

        Console.ReadKey();
    }
}

