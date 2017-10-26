using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3table
{
    class Program
    {
        static void Main(string[] args)
        {
            bool next = true;
            
            while (next == true)
            {
                Console.WriteLine("Enter an integer between 1 and 12: ");
                string input = Console.ReadLine();
                int i = 0;
                if (!int.TryParse(input, out i))
                {
                    Console.WriteLine("Your input {0} is NOT an integer", i);
                    continue;
                }

                else if(i <= 0 || i >12)
                {
                    Console.WriteLine("Your number {0} is not within the range of 1 - 12 ", i);
                    continue;
                }


                Console.WriteLine("The results of the number you entered are: \n");

                Console.WriteLine("Number       Squared          Cubed");
                Console.WriteLine("========     ========        ========");
                for (i = 1; i <= 12; i++)
                {
                    Console.WriteLine(" {0}         \t{1}          \t{2}", i, (i * i), (i * i * i));
                }
                next = Option();
            }

        }

        private static bool Option()
        {
            Console.WriteLine("Would you like to run the application again? (yes or no): ");
            string yesno = Console.ReadLine();
            yesno = yesno.ToLower();
            bool repeat;

            if (yesno == "yes" || yesno == "Yes" || yesno == "y" || yesno == "Y")
            {
                repeat = true;
            }

            else if (yesno == "no" || yesno == "No" || yesno == "n" || yesno == "N")
            {
                repeat = false;
            }

            else
            {
                Console.WriteLine("It isn't rocket science. You have to enter a yes or no. Try again genius: ");
                repeat = Option();
            }
            return repeat;



        }


    }
}
