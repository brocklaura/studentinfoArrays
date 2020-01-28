using System;

namespace studentInfoArraysLab
{
    class Program
    {
        static void Main(string[] args)
        {
            int studentSelected;        
            int itemSelected;
            string cont;

            string[] names = { "Anthony", "Brea", "Chris", "Danny", "Emilio", "Fernando", "George", "Henry", "Issac", "Jesus" };
            string[] favCandy = { "Almond Joy", "Butterfingers", "Chocolate", "Donuts", "Eggs", "Ferrero Rocher", "Gummy Bears", "Hersheys", "IceBreakers", "Jelly Beans"};
            string[] prevTitle = { "Administrator", "Butcher", "Comedian", "Dad", "Engineer", "Firefighter", "Grill Cook", "Hair Dresser", "Igloo Maker", "Janitor" };

            do
            {
                do
                {
                    Console.Write($"Hello user, who would you like to learn more about? \n\n1:{names[0]} \n2:{names[1]} \n3:{names[2]} \n4:{names[3]} \n5:{names[4]} \n6:{names[5]} \n7:{names[6]} \n8:{names[7]} \n9:{names[8]} \n10:{names[9]} \nPlease choose a number 1 -10: ");
                    studentSelected = int.Parse(Console.ReadLine());

                    Console.WriteLine();

                    if (studentSelected > 10)
                    {
                        Console.WriteLine("The number you enter is out of range, please enter a number 1-10");
                    }

                } while (studentSelected > 10);

                Console.WriteLine();
   
                do
                {
                    Console.Write($"You have chosen {names[studentSelected - 1]}!! What would you like to know?\n\nOption 1: Favorite food \nOption 2: Previous Role\nPlease enter 1 or 2:  ");                
                     itemSelected = int.Parse(Console.ReadLine());
                    if (itemSelected > 2)
                    {
                        Console.WriteLine("The number you enter is out of range, please enter 1 or 2");
                    }

                } while (itemSelected > 2);

                Console.WriteLine();

                if (itemSelected == 1)
                    {
                        Console.Write(favCandy[studentSelected - 1]);
                    }
                else if (itemSelected == 2)
                    {
                    Console.Write(prevTitle[studentSelected - 1]);
                    }

                Console.WriteLine();
                Console.WriteLine();

                Console.WriteLine("Would you like to learn about another student (y/n)? ");
                cont = Console.ReadLine();
                Console.WriteLine();

            } while (cont == "y" || cont == "Y");


        }
    }
}
