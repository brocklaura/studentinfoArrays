using System;

namespace tableofpowerlab
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = 0; 
            string cont;
         
            do
            {
                Console.Write("Please enter an integer: ");
                input = int.Parse(Console.ReadLine());

                Console.WriteLine("Table of Powers!");
                Console.WriteLine("Numbers\tSquared\tCubed");
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("=======\t");
                }

                for (int i = 1; i <= input; i++)
                {
                    double inputSquared = Math.Pow(i, 2);
                    double inputCubed = Math.Pow(i, 3);
                    Console.Write($"\n{i}: ");
                    Console.Write($"\t{inputSquared}");
                    Console.Write($"\t{inputCubed}");
                }
                
                Console.WriteLine();
                    
                Console.WriteLine("Continue? (y/n)");
                cont = Console.ReadLine();

                Console.WriteLine();

                if (cont == "y") 
                {
                    Console.WriteLine("Okay, keep on keeping on friend!");
                }
            } while (cont != "n");
            Console.WriteLine("Thank you! Come again");

            Console.WriteLine();
        }
    }
}
