using System;


namespace ExponentsPowerTable
{
    class Program
    {
        
        //Not completely done yet, will get back to this by morning 
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Exponent Generator");
            Console.WriteLine("Please enter an integer: ");
            int num = int.Parse(Console.ReadLine());

            //This outputs results into a table
            //Console.WriteLine("Number \t Squared \t Cubed");
            //Console.WriteLine($"{num} \t {expo(num,2)} \t {expo(num,3)}");

            for (int i = 1; i <= num; i++)
            {
                Console.WriteLine();
            }


        }

        
        
        
        
        ////This method will square and cube user input       
        //public static int expo(int num, int exp)
        //{
        //    int result = 1;
        //    for(int i = 1; i<=exp; i++)
        //    {
        //        result = result * num;
        //    }
        //    return result;
        //}

         
       
        
        
        
    }
}
