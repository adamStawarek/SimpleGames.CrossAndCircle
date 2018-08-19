﻿using System;
using System.Windows.Media.Imaging;

namespace SimpleGame
{
    public class SecondPlayer : Player
    {
        public SecondPlayer(Players playerType) : base(playerType)
        {
            SymbolSource = new BitmapImage(new Uri(@"C:\Users\Administrator\source\repos\SimpleGame\SimpleGame\Images\Cross.png"));
        }
    }
}