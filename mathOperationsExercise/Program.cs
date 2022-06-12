using System;

namespace mathOperationExercise

{
    class Program
    {
        static void Main (string [] args)
        {
            int D = 17;

            int V = 4;

            int module = Module (D, V);

            int quotient = Quotient (D,V);
            Console.WriteLine($"{17}/{4}={quotient} R {module}");

            double pi = 3.141592;

            Console.WriteLine("Enter Raduis");
            double R = double.Parse (Console.ReadLine());

            double A = Area(pi, R);

            Console.WriteLine($" pi x {R}^2 = {A}");
        }

        public static int Quotient (int D, int V)
        {
            return D / V;
        }

        public static int Module (int D, int V)
        {
            return D % V;
        }

        public static double Area (double pi, double R)
        {
            return pi * (R *R);
        }
    }
}