using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace X_O
{
    class Program
    {
        static String[] board = new String[9];
        static String playsAgain = "Y";
        static int count = 0;

        static void initializeVariable()
        {
            for (int i = 0; i < 9; i++)
            {
                board[i] = i.ToString();
            }
        }

        static void playAgainMsg(String message)
        {
            Console.WriteLine(message + "Do you want to play again?");
            if (Console.ReadLine().Equals("Y"))
            {
                playAgainMsg.Equals("Y");
            }
            else
                playAgainMsg.Equals("N");
        }




        static void askData(String player)
        {
            Console.Clear();
            Console.WriteLine("Player" + player);
            int selection();
            while (true)
            {
                Console.WriteLine("Please enter your selection");
                drawBoard();
                selection = Convert.ToInt32(Console.ReadLine());
                if (selection < 0 || selection > 9 || (board[selection].Equals("X") || board[selection].Equals("O")))
                {
                    Console.WriteLine("Invalid selection");
                }
                else
                    break;
            }

            board[selection] = player;
        }

        static void drawBoard()
        {
            for (int i = 0; i < 7; i += 3)
            {
                Console.WriteLine(board[i] + "|" + board[i + 1] + "|" + board[i + 2]);

            }
        }

        static Boolean hasWon()
        {
            for (int i = 0; i < 7; i += 3)
            {
                if (board[i].Equals(board[i + 1] && board[i + 1].Equals(board[i + 2]))
                        {
                    return true;
                }
            }
            if (board[0].Equals(board[3] && board[3].Equals(board[6]))
                 {
                return true;
            }
            if (board[1].Equals(board[4] && board[4].Equals(board[7]))
                 {
                return true;
            }
            if (board[2].Equals(board[5] && board[3].Equals(board[8]))
                 {
                return true;
            }
            if (board[2].Equals(board[4] && board[4].Equals(board[6]))
                 {
                return true;
            }
            if (board[0].Equals(board[4] && board[4].Equals(board[8))
                 {
                return false;
            }

        }

        static void introduction()
        {
            Console.Title = ("X_O");
            Console.WriteLine("Welcome to X_O.\n");
            Console.WriteLine("Press any key to continue");
            Console.ReadLine();
            Console.Clear();
        }

        static void Main(string[] args)
        {
            introduction();
            while (playsAgain.Equals("Y"))
            {
                initializeVariable();
                while (hasWon() == false || count < 9)
                {
                    askData("X");
                    if (hasWon() == true)
                    {
                        break;
                    }
                    askData("O");
                }
                if (hasWon() == true)
                {
                    playsAgainMsg("Congradulations!!! You are won!!!");

                }
                else
                {
                    playsAgainMsg("Sorry but the game is over");
                }
            }
        }
    }
}

