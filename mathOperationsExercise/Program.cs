using System; 

namespace mathOperationExercise
{
    class program
    {
        static void Main (string [] args)
        {
            Console.WriteLine("Enter number");
           int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(num1 * num2);     
        }
    }
}