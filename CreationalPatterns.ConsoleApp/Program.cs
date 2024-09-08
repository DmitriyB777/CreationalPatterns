using CreationalPatterns.Library.Classes;

namespace CreationalPatterns.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle(5);
            Circle circleClone = (Circle)circle.Clone();
            Console.WriteLine($"Circle: Radius = {circle.Radius}, Clone: Radius = {circleClone.Radius}");

            Rectangle rectangle = new Rectangle(4, 5);
            Rectangle rectangleClone = (Rectangle)rectangle.Clone();
            Console.WriteLine($"Rectangle: Width = {rectangle.Width}, Height = {rectangle.Height}, Clone: Width = {rectangleClone.Width}, Height = {rectangleClone.Height}");

            Square square = new Square(3);
            Square squareClone = (Square)square.Clone();
            Console.WriteLine($"Square: Side = {square.Width}, Clone: Side = {squareClone.Width}");

            Console.ReadKey();
        }
    }
}
