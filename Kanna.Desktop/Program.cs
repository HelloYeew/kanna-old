﻿using Kanna.Framework;

namespace Kanna.Desktop;

public class Program
{
    public static void Main(string[] args)
    {
        using (var game = new Game(800, 600))
        {
            game.Run();
        }
    }
}
