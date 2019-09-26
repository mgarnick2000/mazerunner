using System;
using System.Collections.Generic;
using static System.Console;

namespace mazerunner
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            string[] directions = new string[] { "N", "N", "N", "W", "W" };
            int[,] maze = new int[,] {
                {1, 1, 1, 1, 1, 1, 1},
                {1, 0, 0, 0, 0, 0, 3},
                {1, 0, 1, 0, 1, 0, 1},
                {0, 0, 1, 0, 0, 0, 1},
                {1, 0, 1, 0, 1, 0, 1},
                {1, 0, 0, 0, 0, 0, 1},
                {1, 2, 1, 0, 1, 0, 1}};


            mazeRunner(maze, directions);
        }

        public static string mazeRunner(int[,] maze, string[] directions)
        {
            // Code here
            int startX = 0;
            int startY = 0;
            double len = Math.Sqrt(maze.Length);
            for (int x = 0; x < len; x++)
            {
                for (int y = 0; y < len; y++)
                {
                    if (maze[y, x] == 2) { startX = x; startY = y; }
                }
            }
            for (int x = 0; x < directions.Length; x++)
            {
                switch (directions[x])
                {
                    case "N": startY -= 1; break;
                    case "E": startX += 1; break;
                    case "S": startY += 1; break;
                    case "W": startX -= 1; break;
                }
                if (startY < 0 || startY > len - 1 || startX < 0 || startX > len - 1 || maze[startY, startX] == 1) { return "Dead"; }
                if (maze[startY, startX] == 3) { return "Finish"; }
            }

            return "Lost";
        }
    }
};
