using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DiceRollSingle
{
    class Program
    {
        static void Main(string[] args)
        {

            // This is the main part of the program.
            // Declare and initialize variables.
            Random rnd = new Random();
            const Int32 MAX_ROLLS = 6;
            String sUserName = String.Empty;
            Int32 iDieValue = 0;

            // Here we will generate a random number between 1 and 6, inclusive.
            iDieValue = rnd.Next(1,7);
           
            //Ask the user's name and tell them how many times the die will be rolled
            Console.Write("Hello! Welcome to Dice Roll. I will roll the dice for you six times.");
            Console.Write("\n\nEr...Before I do that what is your name? ");
            sUserName = Console.ReadLine();
            Console.WriteLine();

            for (Int32 i = 0; i < MAX_ROLLS; i++)
            {
                //Make the die roll 6 times
                PauseCode("Ok, " + sUserName + ". I will now roll the die. Press enter to roll the die.");
                ShowDie(iDieValue);
                PauseCode("Here is your die.\n\nPress enter to continue.");
            }
        }

        // This method displays the die that corresponds to the random number.
        static void ShowDie(Int32 intDieValue)
        {
            switch (intDieValue)
            {
                case 1:
                    Console.WriteLine(".-------.");
                    Console.WriteLine("|       |");
                    Console.WriteLine("|   o   |");
                    Console.WriteLine("|       |");
                    Console.WriteLine("|_______|");
                    Console.WriteLine();
                    break;
                case 2:
                    Console.WriteLine(".-------.");
                    Console.WriteLine("|     o |");
                    Console.WriteLine("|       |");
                    Console.WriteLine("| o     |");
                    Console.WriteLine("|_______|");
                    Console.WriteLine();
                    break;
                case 3:
                    Console.WriteLine(".-------.");
                    Console.WriteLine("|     o |");
                    Console.WriteLine("|   o   |");
                    Console.WriteLine("| o     |");
                    Console.WriteLine("|_______|");
                    Console.WriteLine();
                    break;
                case 4:
                    Console.WriteLine(".-------.");
                    Console.WriteLine("| o   o |");
                    Console.WriteLine("|       |");
                    Console.WriteLine("| o   o |");
                    Console.WriteLine("|_______|");
                    Console.WriteLine();
                    break;
                case 5:
                    Console.WriteLine(".-------.");
                    Console.WriteLine("| o   o |");
                    Console.WriteLine("|   o   |");
                    Console.WriteLine("| o   o |");
                    Console.WriteLine("|_______|");
                    Console.WriteLine();
                    break;
                case 6:
                    Console.WriteLine(".-------.");
                    Console.WriteLine("| o   o |");
                    Console.WriteLine("| o   o |");
                    Console.WriteLine("| o   o |");
                    Console.WriteLine("|_______|");
                    Console.WriteLine();
                    break;
                default:
                    Console.WriteLine(".-------.");
                    Console.WriteLine("|       |");
                    Console.WriteLine("|       |");
                    Console.WriteLine("|       |");
                    Console.WriteLine("|_______|");
                    Console.WriteLine();
                    break;
            }
        }

        // This method executes the Pause code.
        static void PauseCode(String sMsg)
        {
            //Console.WriteLine();
            Console.WriteLine(sMsg);
            Console.ReadLine();
        }
        
    }
}
