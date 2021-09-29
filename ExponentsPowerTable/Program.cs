using System;

namespace ExponentsPowerTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Exponent Generator");
            Console.WriteLine("Please enter an integer: ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine(expo(num,2));
            Console.WriteLine(expo(num,3));
            
        }

        //This method will square and cube user input       
        public static int expo(int num, int exp)
        {
            int result = 1;
            for(int i = 1; i<=exp; i++)
            {
                result = result * num;
            }
            return result;
        }
        
        
    }
}
