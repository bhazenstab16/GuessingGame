using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessingGame
{
    class Program
    {
        public static int getInt()
        {
            int n1 = 0;
            String input = "";
            Console.WriteLine("\nPlease enter an integer:\n");
            input = Console.ReadLine();
            n1 = Convert.ToInt32(input);
            return n1;
        }
        public static void printDirections()
        {
            Console.Clear();
            Console.WriteLine("Welcome to the Guessing Game!\n");
            Console.WriteLine("In a moment, you will begin playing game 1 of 3 of the Guessing Game.\n");
            Console.WriteLine("Each game will have a more in-depth set of instructions for you.\n");
            Console.WriteLine("Once you have finished the third game, the number of guesses you gave for each game will be displayed for you.\n");
            Console.WriteLine("Enjoy!\n");
            Console.WriteLine("Press enter to continue");
            Console.ReadLine();

        }
        public static void printResults(int count1, int count2, int count3)
        {
            Console.Clear();
            Console.WriteLine("You guessed the first number in " + count1 + " guesses.\n");
            Console.WriteLine("You guessed the second number in " + count2 + " guesses.\n");
            Console.WriteLine("You guessed the third number in " + count3 + " guesses.");
        }
        public static int game3()
        {
            Random r1 = new Random();
            int num1 = 0;
            int count = 0;
            int userGuess = 0;

            num1 = r1.Next(1, 101);

            Console.Clear();
            Console.WriteLine("I have thought of a number between 1 and 100. (Inclusive) What number am I thinking of?\n");
            Console.WriteLine(num1);

            userGuess = getInt();

            while (userGuess != num1)
            {
                Console.Clear();
                Console.WriteLine("I'm sorry, that's not it. Please try again. Remember, 1 through 100. (Inclusive)\n");
                userGuess = getInt();
                count++;
            }

            Console.Clear();
            Console.WriteLine("You got it!\n");
            Console.ReadLine();

            return count;
        }
        public static int game2()
        {
            Random r1 = new Random();
            int num1 = 0;
            int count = 0;
            int userGuess = 0;

            num1 = r1.Next(1, 21);

            Console.Clear();
            Console.WriteLine("I have thought of a number between 1 and 20.(Inclusive) What number am I thinking of?\n");
            Console.WriteLine(num1);

            userGuess = getInt();

            while (userGuess != num1)
            {
                Console.Clear();
                Console.WriteLine("I'm sorry, that's not it. Please try again. Remember, 1 through 20 (Inclusive).\n");
                userGuess = getInt();
                count++;
            }

            Console.Clear();
            Console.WriteLine("You got it!\n");
            Console.ReadLine();

            return count;
    }
        public static int game1()
        {
            Random r1 = new Random();
            int num1 = 0;
            int count = 0;
            int userGuess = 0;

            num1 = r1.Next(1, 11);

            Console.Clear();
            Console.WriteLine("I have thought of a number between 1 and 10 (Inclusive). What number am I thinking of?\n");
            Console.WriteLine(num1);

            userGuess = getInt();

            while(userGuess != num1)
            {
                Console.Clear();
                Console.WriteLine("I'm sorry, that's not it. Please try again. Remember, 1 through 10.(Inclusive)\n");
                userGuess = getInt();
                count++;
            }

            Console.Clear();
            Console.WriteLine("You got it!\n");
            Console.ReadLine();

            return count;
        }
        public static void guessingGame()
        {
            int game1Count = 0;
            int game2Count = 0;
            int game3Count = 0;

            printDirections();

            game1Count = game1();
            game2Count = game2();
            game3Count = game3();

            printResults(game1Count, game2Count, game3Count);
            Console.ReadLine();
        }
        static void Main(string[] args)
        {
            guessingGame();
        }
    }
}
