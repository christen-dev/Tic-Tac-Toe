
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
            
            // goes through rows and checks for 3 across
            for (int i = 0; i < 3; i++) 
            {
                int startIndex = i * 3;

                if ((boardArray[startIndex] == boardArray[startIndex + 1]) && (boardArray[startIndex] == boardArray[startIndex + 2]) && boardArray[startIndex] != '_')
                {
                    winner = boardArray[startIndex];
                }
            }

            // goes through and checks for columns
            for (int i = 0; i < 3;i++) 
            {
                if ((boardArray[i] == boardArray[i + 3]) && (boardArray[i] == boardArray[i + 6]) && (boardArray[i] != '_'))
                {
                    winner = boardArray[i];
                }
            }

            // checks diagonal values
            if (((boardArray[0] == boardArray[4]) && (boardArray[0] == boardArray[8])) || 
                ((boardArray[2] == boardArray[4]) && (boardArray[2] == boardArray[6])) && (boardArray[4] != '_'))
            {
                winner = boardArray[4];
            }

            // returns 'x' or 'o' depending on who won
            // if it returns 'n', then no one has won yet
            return winner;
        }

    }
}
