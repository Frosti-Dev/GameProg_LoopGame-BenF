using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProg_LoopGame_BenF
{
    internal class Program
    {
        //variables
        static int playerPosX = 2;
        static int playerPosY = 2;
        static bool gameOver = false;

        static bool[] Map = new bool[60];


        static void CheckLoss()
        {
            //lose conditions
            if (playerPosX > 119)
            {
                gameOver = true;
            }

            if (playerPosY < 1)
            {
                gameOver = true;
            }

            if (playerPosY == 29)
            {
                gameOver = true;
            }

            if (playerPosX < 1)
            {
                gameOver = true;
            }

        }
        static void PlayerDraw(int x, int y)
        {
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.Write(" ");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.SetCursorPosition(x, y);
            Console.Write("0");
            Console.SetCursorPosition(x, y);
        }

        static void PlayerUpdate()
        {
            
            ConsoleKeyInfo keyinfo = Console.ReadKey(true);

            switch (keyinfo.Key)
            {
                case ConsoleKey.W:
                    playerPosY -= 1;
                    break;

                case ConsoleKey.A:
                    
                    playerPosX -= 1;
                    break;

                case ConsoleKey.S:
                   
                    playerPosY += 1;
                    break;

                case ConsoleKey.D:
                    
                    playerPosX += 1;
                    break;

                case ConsoleKey.Escape:

                    Console.Clear();
                    Console.WriteLine("You Quit.");
                    Environment.Exit(0);
                    break;
            }
        }

        static void Main(string[] args)
        {
        
            while (true)
            {
                CheckLoss();
                if (gameOver == true)
                {
                    Console.Clear();
                    Console.WriteLine("You Loss.");
                    Environment.Exit(0);
                }

                PlayerDraw(playerPosX, playerPosY);
                PlayerUpdate();
                
            }
        }
    }
}
