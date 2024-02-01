
namespace Tic_Tac_Toe
{
    internal class TicTacTools
    {
        public void PrintBoard(char[] boardArray) //Method for printing the board
        {
            Console.WriteLine(" " + boardArray[0] + " | " + boardArray[1] + " | " + boardArray[2]); //First Row
            Console.WriteLine("-----------");
            Console.WriteLine(" " + boardArray[3] + " | " + boardArray[4] + " | " + boardArray[5]); //Second Row
            Console.WriteLine("-----------");
            Console.WriteLine(" " + boardArray[6] + " | " + boardArray[7] + " | " + boardArray[8]); //Third Row
            Console.WriteLine("-----------");
            Console.WriteLine();
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
