using System;

namespace DecisionMaker
{
    class Program
    {
        static void Main(string[] args)
        {
            bool option = true;

            // Get user name
            Console.WriteLine("Please enter your name");
            string name = Console.ReadLine();

            // Begin continuous input
            while (option)
            {      
                // Get input from user
                Console.WriteLine("Please enter a number between 1 to 100");
                int num = int.Parse(Console.ReadLine());

                // Validate user input to be b/n 1 and 100
                if (1<=num && num <= 100)
                {
                    // Check if integer is odd ( this will cover the condition of >60 too for odd number)
                    if ((num % 2) != 0)
                        Console.WriteLine(num + " and Odd");
                    else
                    {
                        if (num > 60)
                        {
                            Console.WriteLine(num + " Even");
                        }//end if 
                        else
                        {                            
                            if (2 <= num && num <= 25)
                                Console.WriteLine("Even and less than 25");
                            else
                                Console.WriteLine("Even");
                        }// end else
                    }// end else
                }
                else
                {
                    Console.WriteLine("Invalid Input. Number should be between 1 and 100");
                }

                // Check for continuation
                Console.WriteLine("Do you want to continue " + name + "? y/n");
                string strContinue = Console.ReadLine();
                strContinue = strContinue.ToLower();
                if (strContinue[0] == 'n')
                {
                    option = false;
                    Console.WriteLine("Bye " + name);
                }
            } // end while  
        }
    }
}
