internal class Program
{
    private static void Main(string[] args)
    {
        bool gameOn = false;
        do
        {
            Console.WriteLine("Welcome to our game of Tic-Tac-Toe!");

            // Define variables. 
            int BOARD_SIZE = 9;
            char[] gameBoard = new char[BOARD_SIZE];
            Array.Fill(gameBoard, '_');

            //Create tic tac toe object.
            TicTacTools ticTacToe = new TicTacTools(gameBoard);

            // Allow the players to enter their names.
            Console.Write("Enter player one's name: ");
            string playerOne = Console.ReadLine();

            Console.Write("Enter player two's name: ");
            string playerTwo = Console.ReadLine();

            // Tell the players if they are x or o and provide "How to play" instructions
            Console.WriteLine($"{playerOne} you are x");
            Console.WriteLine($"{playerTwo} you are o");
            Console.WriteLine();

            Console.WriteLine("How to play:");
            Console.WriteLine("Each player takes turns placing their x and o\nYour goal is to get 3 in a row");
            Console.WriteLine("'_' means the spot is blank");
            Console.WriteLine("Here are the spots you can place on the board:");
            Console.WriteLine("1 | 2 | 3\n4 | 5 | 6\n7 | 8 | 9");
            Console.WriteLine();
            Console.WriteLine("Let's Play!");

            bool gamePlay = true;

            while (gamePlay)
            {
                // Print the board as the game is played. 
                Console.WriteLine("CURRENT BOARD:");
                ticTacToe.PrintBoard(gameBoard);

                Console.Write($"{playerOne}: Enter where you want to place the X: ");
                int moveOne = Console.ReadLine();
                gameBoard[moveOne - 1] = 'x';

                ticTacToe.PrintBoard(gameBoard);

                Console.Write($"{playerTwo}: Enter where you want to place the O: ");
                int moveTwo = Console.ReadLine();
                gameBoard[moveTwo - 1] = 'o';

                // Show the players the results of the game if there is a winner.
                // If there is no winner, keep the game going. 
                char winner = ticTacToe.GetResults(gameBoard);
                if (winner == 'x')
                {
                    Console.WriteLine($"{playerOne}, you won!");
                    ticTacToe.PrintBoard(gameBoard);
                    gamePlay = false;
                }
                else if (winner == 'o')
                {
                    Console.WriteLine($"{playerTwo}, you won!");
                    ticTacToe.PrintBoard(gameBoard);
                    gamePlay = false;
                }
            }

            // Let the user decide if they want to play again. 
            Console.WriteLine("Game Over. Thanks for playing!");
            Console.Write("Want to play again? (y/n): ");
            string answer = Console.ReadLine();

            if (answer == "y")
            {
                gameOn = true;
            }
            else
            {
                gameOn = false;
            }
        } while (gameOn);
    }
}
