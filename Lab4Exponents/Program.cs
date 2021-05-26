using System;

namespace Lab4Exponents
{
    class Program
    {
        static void Main(string[] args)
        {
            
            bool goOn = true;
            while (goOn == true)
            {

              //ask to enter a integer 
               Console.WriteLine("Enter a Integer");
                int input = int.Parse(Console.ReadLine());

                
                square(input);
                
                cube(input);
                


                goOn = chooseAgain();
            }
        }

        //Ask if the user wants to do another number

        public static bool chooseAgain()
        {
            Console.WriteLine("Would you like to enter another number?");
            string answer = Console.ReadLine().ToLower();

            if (answer == "yes")
            {
                Console.Clear();
                return true;

            }
            else 
            {
                Console.WriteLine("Goodbye.");
                return false;
            }
           
        }

        //display

        static void DisplayTable(int userInput) 
        {
            Console.WriteLine( "Number", "Squared", "Cubed");
            Console.WriteLine("=======", "=======", "======");
            
        }

        //square

        public static void square(double num)
        {
            Console.WriteLine("Squared");
            Console.WriteLine("===");
            for (int i = 1; i <= num; i++)
            {
                double square = i * i;
                Console.WriteLine(square);
            }
        }

        //cube

        public static void cube(double num)
        {
            Console.WriteLine("Cubed");
            Console.WriteLine("===");
            for (int i = 1; i <= num; i++)
            {
                double cube = i * i * i;
                Console.WriteLine(cube);
            }

        }
    }
}
