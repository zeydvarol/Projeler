using System;
using System.Collections.Generic;

namespace oyun
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("YILAN OYUNU");


            var cerceve = new Cerceve();

            cerceve.printFrame();
            cerceve.SetScore(0);
            cerceve.SetTime();
            List<Coordinate> snake = new List<Coordinate>();
            snake.Add(new Coordinate(40,15));
            snake.Add(new Coordinate(41, 15));
            snake.Add(new Coordinate(42, 15));
            snake.Add(new Coordinate(43, 15));

            Console.ReadKey();

        }
    }
    class Cerceve
    {
        public void printFrame()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            for (int x = 0; x < 80; x++)
            {
                for (int y = 0; y < 23; y++)
                {
                    if (y == 0 || y == 22 || x == 0 || x == 79)
                    {
                        Console.SetCursorPosition(x, y);
                        Console.Write((char)200);
                    }
                }
            }
        }
        public void SetScore(int score)
        {
            Console.SetCursorPosition(0, 23);
            Console.Write("Score : {0}", score);
        }
        public void SetTime()
        {
           
            Console.SetCursorPosition(68, 23);
            Console.Write("Time : 00:00");
        }
      
    }
    class Coordinate
    {
        public int x;
        public int y;

        public Coordinate(int x, int y)
        {
            Console.SetCursorPosition(x,y);
            Console.WriteLine("█");
        }
        
    }
   
}




