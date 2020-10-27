using System;

namespace classBoxData
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var length = double.Parse(Console.ReadLine());
            var width = double.Parse(Console.ReadLine());
            var height = double.Parse(Console.ReadLine());

            var rectangle = new Box(length, width, height);

            Console.WriteLine($"Surface Area - {rectangle.SurfaceArea():F2}");
            Console.WriteLine($"Lateral Surface Area - {rectangle.LateralSurfaceArea():F2}");
            Console.WriteLine($"Volume - {rectangle.Volume():F2}");
            
        }
    }
}
