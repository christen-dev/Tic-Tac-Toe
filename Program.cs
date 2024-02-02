using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tic_Tac_Toe;

internal class Program
{
    private static void Main(string[] args)
    {
        bool gameOn = false;
        //Loop allows user to play multiple times
        do
        {
            Console.WriteLine("Welcome to our game of Tic-Tac-Toe!");

            // Define variables 
            int BOARD_SIZE = 9;
            char[] gameBoard = new char[BOARD_SIZE];
            Array.Fill(gameBoard, '_');
            Console.WriteLine("game board array:", gameBoard);

            //Create tic tac toe object
            TicTacTools ticTacToe = new TicTacTools();

            // Allow the players to enter their names
            Console.Write("Enter player one's name: ");
            string playerOne = Console.ReadLine();

            Console.Write("Enter player two's name: ");
            string playerTwo = Console.ReadLine();

            //Game instructions
            Console.WriteLine();
            Console.WriteLine("How to play:");
            Console.WriteLine("Each player takes a turn placing their x and o\nYour goal is to get 3 in a row");
            Console.WriteLine("'_' means the spot is blank");
            Console.WriteLine("Here are the spots you can place on the board:");
            Console.WriteLine("1 | 2 | 3\n4 | 5 | 6\n7 | 8 | 9");
            Console.WriteLine();

            // Tell the players if they are x or o
            Console.WriteLine($"{playerOne}, you are x");
            Console.WriteLine($"{playerTwo}, you are o");
            Console.WriteLine();
            Console.WriteLine("Let's Play!");

            int turns = 0;

            //Loop to allow user to enter inpur
            while (true)
            {
                // Print the board as the game is played. 
                Console.WriteLine("CURRENT BOARD:");
                ticTacToe.PrintBoard(gameBoard);

                while (true)
                {
                    Console.Write($"{playerOne}, enter where you want to place the X: ");
                    string moveStr1 = Console.ReadLine();
                    int moveOne;
                    // Check if user input is a valid number
                    if (int.TryParse(moveStr1, out moveOne))
                    {
                        // Check if moveOne is within the valid range (1-9)
                        if (moveOne >= 1 && moveOne <= 9)
                        {
                            // Check for an empty cell
                            if (gameBoard[moveOne - 1] == '_')
                            {
                                gameBoard[moveOne - 1] = 'x';
                                turns++;
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Please enter a number with an empty spot");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Please enter a valid integer between 1 and 9");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Please enter a valid integer between 1 and 9");
                    }
                }

                // reprint board after player 1 plays
                Console.WriteLine("CURRENT BOARD:");
                ticTacToe.PrintBoard(gameBoard);

                // check if player 1 won
                char winner = ticTacToe.GetResults(gameBoard);
                
                if (winner == 'x')
                {
                    Console.WriteLine("FINAL BOARD:");
                    ticTacToe.PrintBoard(gameBoard);
                    Console.WriteLine($"{playerOne}, you won!");
                    break;
                }
                else if ((winner == 'n') && (turns == 9)) {
                    Console.WriteLine("FINAL BOARD:");
                    ticTacToe.PrintBoard(gameBoard);
                    Console.WriteLine("It was a tie!");
                    break;
                }

                //print turns
                Console.WriteLine("turns: " + turns);

                // allow player 2 to enter input
                while (true)
                {
                    Console.Write($"{playerTwo}, enter where you want to place the O: ");
                    string moveStr2 = Console.ReadLine();
                    int moveTwo;
                    // Check if user input is a valid number
                    if (int.TryParse(moveStr2, out moveTwo))
                    {
                        // Check if moveOne is within the valid range (1-9)
                        if (moveTwo >= 1 && moveTwo <= 9)
                        {
                            // Check for an empty cell
                            if (gameBoard[moveTwo - 1] == '_')
                            {
                                gameBoard[moveTwo - 1] = 'o';
                                turns++;
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Please enter a number with an empty spot");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Please enter a valid integer between 1 and 9");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Please enter a valid integer between 1 and 9");
                    }
                }

                //increase number of turns after player 2 goes
                Console.WriteLine("turns: " + turns);

                // Check if player 2 won with that move
                // If there is no winner, keep the game going
                Console.WriteLine("CURRENT BOARD:");
                winner = ticTacToe.GetResults(gameBoard);
                
                if (winner == 'o')
                {
                    Console.WriteLine("FINAL BOARD:");
                    ticTacToe.PrintBoard(gameBoard);
                    Console.WriteLine($"{playerTwo}, you won!");
                    break;
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
