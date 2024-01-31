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


        public char GetResults(char[] boardArray) //Method for checking the results
        {
            char winner = 'n';
            
            for (int i = 0; i < 3;i++) 
            {
                int startIndex = i * 3;

                if ((boardArray[startIndex] == boardArray[startIndex + 1]) && (boardArray[startIndex] == boardArray[startIndex + 2]))
                {
                    winner = boardArray[startIndex];
                }
            }

            for (int i = 0; i < 3;i++) 
            {
                if ((boardArray[i] == boardArray[i + 3]) && (boardArray[i] == boardArray[i + 6]))
                {
                    winner = boardArray[i];
                }
            }

            if (((boardArray[0] == boardArray[4]) && (boardArray[0] == boardArray[8])) || 
                ((boardArray[2] == boardArray[4]) && (boardArray[2] == boardArray[6])))
            {
                winner = boardArray[4];
            }

            return winner;
        }

    }
}
