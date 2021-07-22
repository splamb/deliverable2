using System;

namespace deliverable2
{
    class Program
    {
        static void Main(string[] args)
        {
            string uInput;
            string z = "fill";
            bool x = true;
            while (x == true)
            {
                Console.WriteLine("What would you like to say to the chatbot?");
                uInput = Console.ReadLine();
                uInput = uInput.ToUpper();

                if (z == uInput)
                {
                    Console.WriteLine("I'm sorry but you have already said that");
                }
                else
                {
                    if (uInput == "HELLO")
                    {
                        Console.WriteLine("Hi good to see you");
                    }

                    else if (uInput == "SUP")
                    {
                        Console.WriteLine("I am good");
                    }

                    else if (uInput == "HELLO THERE")
                    {
                        Console.WriteLine("General Kenobi");
                    }

                    else if (uInput == "BYE")
                    {
                        Console.WriteLine("Good bye!");
                        x = false;
                    }

                    else
                    {
                        Console.WriteLine("That was not a valid input.");
                    }

                    z = uInput;
                }
            }
        }
    }
}
