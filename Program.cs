namespace Assignment_5_2_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Assignment 5.2.2
             * 
             * Write a program in C# Sharp to print the first 
             * n natural number using recursion.
             * 
             * Test Data :
             * How many numbers to print : 10
             * Expected Output :
             * 1 2 3 4 5 6 7 8 9 10
             */

            int iterations = 30;

            PrintNumbersRecursion(iterations);
        }

        static void PrintNumbersRecursion(int Iterations_)
        {
            if (Iterations_ > 0)
            {
                PrintNumbersRecursion(Iterations_ - 1);
                Console.Write(Iterations_ + " ");
            }
        }
    }
}
