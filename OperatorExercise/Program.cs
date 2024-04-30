namespace OperatorExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            int a = 17;

            int b = 4;

            int sum = a + b;
            int diff = a - b;
            int mult = a * b;

            int c = 8;

            int d = 6;

            int quotient = c / d;
            int remainder = c % d;

            Console.WriteLine($"{a} + {b} is {sum}");

            Console.WriteLine($"{a} - {b} is {diff}");

            Console.WriteLine($"{a} * {b} is {mult}");

            Console.WriteLine($"{c} / {d} is {quotient} with a remainder of {remainder}");


            Console.WriteLine("What is the radius of your circle?");

            var radius = double.Parse(Console.ReadLine());
            
            var area2= AreaOfCircle(radius);

            Console.WriteLine($"The area of your circle with a radius of {radius} is {area2}");
            
        }
        public static double AreaOfCircle(double radius)
        {
            return Math.PI * (radius * radius);
            
        }

    }
}

