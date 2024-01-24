// Conditional Statements
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTutorials
{
    class Program
    {
        static void Main(string[] args)
        {

            // simple calculator

            Console.WriteLine("Enter 1st number: ");
            double n1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter 2nd number: ");
            double n2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please make your choice: \n  1 for + \n 2 for - \n 3 for * \n 4 for /");

            Console.WriteLine("Enter the number between 1 and 4: ");
            int op = Convert.ToInt32(Console.ReadLine());

            

            switch (op)
            {
                case 1:
                    Console.WriteLine(n1 + n2);
                    break;
                case 2:
                    Console.WriteLine(n1 - n2);
                    break;
                case 3:
                    Console.WriteLine(n1 * n2);
                    break;
                case 4:
                    Console.WriteLine(n1 / n2);
                    break;
                default:
                    Console.WriteLine("Bad input");
                    break;

            }




            // switch case

            int day = 4;

            switch (day)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                default:
                    Console.WriteLine("Bad input");
                    break;

            }



            if (day == 1)
            {
                Console.WriteLine("Monday");
            }
            else if (day == 2)
            {
                Console.WriteLine("Tuesday");
            }
            else
            {
                Console.WriteLine("Bad input");
            }



            // Rock Paper Scissor
            Console.WriteLine("Player 1: ");
            string p1 = Console.ReadLine();

            Console.WriteLine("Player 2: ");
            string p2 = Console.ReadLine();

            if (p1 == p2)
            {
                Console.WriteLine("draw");
            }

            else if ((p1=="R" && p2== "P") || (p1 == "P" && p2 == "R") || (p1 == "S" && p2 == "P"))
            {
                Console.WriteLine("P1 wins");
            }

            else if ((p1 == "R" && p2 == "S") || (p1 == "P" && p2 == "S") || (p1 == "S" && p2 == "R"))
            {
                Console.WriteLine("P2 wins");
            }

            else
            {
                Console.WriteLine("Bad input");
            }
         


        

            int a = 5;
            int b = 6;

            if (a > 3 )
            {
                Console.WriteLine(a);
            }

            else if (a == b)
            {
                Console.WriteLine("they are equal");
            }
            else
            {
                Console.WriteLine(b);
            }

            // short hand if..else

            int output = (a > 3) ? a : b;
            Console.WriteLine(output);

           /* if (condition)
            {
                // do something when condition is true
            }

            else
            {
                // do smth when condition is false
            }*/
        }
    }
}