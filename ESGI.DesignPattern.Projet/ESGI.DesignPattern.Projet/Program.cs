using System;

namespace ESGI.DesignPattern.Projet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            TennisGame1 game = new TennisGame1("abc", "def");
            Console.WriteLine(game.GetScore());
            game.WonPoint("abc");
            game.WonPoint("abc");
            game.WonPoint("def");
            Console.WriteLine(game.GetScore());
        }
    }
}
