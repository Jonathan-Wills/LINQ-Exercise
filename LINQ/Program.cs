using System;
using System.Collections.Generic;
using System.Linq;


namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            var games = new List<string>
            {"Call of Duty", "Terraria","Minecraft", "Tetris"};
            
            foreach (var game in games)
            {
                Console.WriteLine(game);
            }

            var two = games.OrderByDescending(x => x.Length).ToList();
        }
    }
}
