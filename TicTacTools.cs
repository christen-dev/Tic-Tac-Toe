using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toe
{
    internal class TicTacTools
    {
        public void PrintBoard(char[] boardArray) //Method for printing the board
        {
            for (int i = 0; i < 3; i++) //Print the first row with the values from the array
            {
                Console.WriteLine(boardArray[i] + " | ");
            }

            Console.WriteLine("---------");

            for (int i = 3; i < 6; i++)
            {
                Console.WriteLine(boardArray[i] + " | "); //Second Row
            }

            Console.WriteLine("---------");

            for (int i = 6; i < 9; i++)
            {
                Console.WriteLine(boardArray[i] + " | "); //Third Row
            }

        }


        public string GetResults(char[] boardArray) //Method for checking the results
        {
            if ()
        }

    }
}
