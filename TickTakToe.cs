using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeGame
{
    class TickTacToe
    {
        static char[,] playField = {
                            {'1','2','3' },
                            {'4','5','6'},
                            {'7','8','9' }
                           };
        static int player;
        public static void ShowField()
        {
            Console.WriteLine(" {0} | {1} | {2} ", playField[0, 0], playField[0, 1], playField[0, 2]);
            Console.WriteLine("---|---|---");
            Console.WriteLine(" {0} | {1} | {2} ", playField[1, 0], playField[1, 1], playField[1, 2]);
            Console.WriteLine("---|---|---");
            Console.WriteLine(" {0} | {1} | {2} ", playField[2, 0], playField[2, 1], playField[2, 2]);

        }
        public static int SetPlayers()
        {
            Console.WriteLine("Enter player 1 as 1 and player 2 as 2");
            player = Convert.ToInt32(Console.ReadLine());

            if (player == 1)
            {
                Console.WriteLine("Player {0} has X", 1);
                Console.WriteLine("Player {0} has 0", 2);
            }
            return player;

        }
        public static void PlayerEnterdXorO()
        {
            SetPlayers();
            Console.WriteLine("Please select input for Tic Tac Toe game. Select between 1 to 9.");
            int input = Convert.ToInt32(Console.ReadLine());
            if (player == 1)
            {
                switch (input)
                {
                    case 1:
                        if (input == 1)
                        {
                            playField[0, 0] = 'x';
                        }
                        break;
                    case 2:
                        if (input == 2)
                        {
                            playField[0, 1] = 'x';
                        }
                        break;
                    case 3:
                        if (input == 3)
                        {
                            playField[0, 2] = 'x';
                        }
                        break;
                    case 4:
                        if (input == 4)
                        {
                            playField[1, 0] = 'x';
                        }
                        break;
                    case 5:
                        if (input == 5)
                        {
                            playField[1, 1] = 'x';
                        }
                        break;
                    case 6:
                        if (input == 6)
                        {
                            playField[1, 2] = 'x';
                        }
                        break;
                    case 7:
                        if (input == 7)
                        {
                            playField[2, 0] = 'x';
                        }
                        break;
                    case 8:
                        if (input == 8)
                        {
                            playField[2, 1] = 'x';
                        }
                        break;
                    case 9:
                        if (input == 9)
                        {
                            playField[2, 2] = 'x';
                        }
                        break;
                }
            }
            else
            {
                switch (input)
                {
                    case 1:
                        if (input == 1)
                        {
                            playField[0, 0] = 'O';
                        }
                        break;
                    case 2:
                        if (input == 2)
                        {
                            playField[0, 1] = 'O';
                        }
                        break;
                    case 3:
                        if (input == 3)
                        {
                            playField[0, 2] = 'O';
                        }
                        break;
                    case 4:
                        if (input == 4)
                        {
                            playField[1, 0] = 'O';
                        }
                        break;
                    case 5:
                        if (input == 5)
                        {
                            playField[1, 1] = 'O';
                        }
                        break;
                    case 6:
                        if (input == 6)
                        {
                            playField[1, 2] = 'O';
                        }
                        break;
                    case 7:
                        if (input == 7)
                        {
                            playField[2, 0] = 'O';
                        }
                        break;
                    case 8:
                        if (input == 8)
                        {
                            playField[2, 1] = 'O';
                        }
                        break;
                    case 9:
                        if (input == 9)
                        {
                            playField[2, 2] = 'O';
                        }
                        break;
                }
            }

        }
        public static void Main(string[] args)
        {
            for (int i = 0; i < 8; i++)
            {
                ShowField();
                PlayerEnterdXorO();
                //ShowField();
            }

        }


    }
}
