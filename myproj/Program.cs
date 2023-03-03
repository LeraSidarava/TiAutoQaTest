using System;

namespace TriangleProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input coordinates of 3 points
            Console.Write("Enter coordinate x of dot A: ");
            double ax = double.Parse(Console.ReadLine());
            Console.Write("Enter coordinate y of dot A: ");
            double ay = double.Parse(Console.ReadLine());
            Console.Write("Enter coordinate x of dot B: ");
            double bx = double.Parse(Console.ReadLine());
            Console.Write("Enter coordinate y of dot B: ");
            double by = double.Parse(Console.ReadLine());
            Console.Write("Enter coordinate x of dot C: ");
            double cx = double.Parse(Console.ReadLine());
            Console.Write("Enter coordinate y of dot C: ");
            double cy = double.Parse(Console.ReadLine());

            // Calculate length of sides using distance formula
            double ab = Math.Sqrt(Math.Pow(bx - ax, 2) + Math.Pow(by - ay, 2));
            double ac = Math.Sqrt(Math.Pow(cx - ax, 2) + Math.Pow(cy - ay, 2));
            double bc = Math.Sqrt(Math.Pow(cx - bx, 2) + Math.Pow(cy - by, 2));
            
            // Calculate perimeter of triangle
            double perimeter = ab + ac + bc;

            // Output length of sides and perimeter
            Console.WriteLine($"Length of AB: {ab}");
            Console.WriteLine($"Length of AC: {ac}");
            Console.WriteLine($"Length of BC: {bc}");
            Console.WriteLine($"Perimeter: {perimeter}");

            // Check if it's an isosceles triangle
            if (ab == ac || ab == bc || ac == bc)
            {
                Console.WriteLine("The triangle is isosceles.");
            }
            else
            {
                Console.WriteLine("The triangle is not isosceles.");
            }

            // Check if it's an equilateral triangle
            if (ab == ac && ac == bc)
            {
                Console.WriteLine("The triangle is equilateral.");
            }
            else
            {
                Console.WriteLine("The triangle is not equilateral.");
            }

            // Check if it's a right-angled triangle
            double delta = 1e-6;
            if (Math.Abs(Math.Pow(bc, 2) - (Math.Pow(ab, 2) + Math.Pow(ac, 2))) <= delta)
            {
                Console.WriteLine("The triangle is right-angled.");
            }
            else
            {
                Console.WriteLine("The triangle is not right-angled.");
            }
           

            // Output all even numbers from 0 to the value of the perimeter
            Console.Write("Even numbers from 0 to the perimeter: ");
            for (int i = 0; i <= perimeter; i += 2)
            {
                Console.Write(i + " ");
            }
        }
    }
}
