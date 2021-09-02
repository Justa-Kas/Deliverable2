using System;

namespace Deliverable2
{
	class Program
	{
		public static void Main(string[] args)
		{
            Console.WriteLine("Hello, I am chatbot. Here we can have basic conversations. Whenever you're ready, you can type \"hello\", \"bye\", \"sup\", or \"hello there\" and I'll respond accordingly.");
            bool doesItGo = true;
            int storeValue = 0;
            while (doesItGo == true)
            {
                Console.WriteLine("Please type here: ");
              string userInput = Console.ReadLine();
                if (userInput.ToLower() == "hello")
                {
                    if (storeValue != 1)
                    {
                        Console.WriteLine("Hi, good to see you.");
                        storeValue = 1;
                    }
                    else
                    {
                        Console.WriteLine("I'm sorry but you have already said that.");
                    }

                }
                else if (userInput.ToLower() == "sup")
                {
                    if (storeValue != 2)
                    {
                        Console.WriteLine("I am good");
                        storeValue = 2;
                    }
                    else
                    {
                        Console.WriteLine("I'm sorry but you have already said that.");
                    }

                }
                else if (userInput.ToLower() == "hello there")
                {
                    if (storeValue != 3)
                    {
                        Console.WriteLine("General Kenobi");
                        storeValue = 3;
                    }
                    else
                    {
                        Console.WriteLine("I'm sorry but you have already said that.");
                    }
                }
                if (userInput.ToLower() == "bye")
                {
                    	Console.WriteLine("Good bye!");
			doesItGo = false;
                }
            }
        }
	}
}
