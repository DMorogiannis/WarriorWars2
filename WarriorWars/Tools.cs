using System;
using System.Collections.Generic;
using System.Text;

namespace WarriorWars
{
    class Tools
    {
        public static void ColorfulWriteLine(string randomtext, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            //Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine(randomtext);
            Console.ResetColor();
        }
    }
}
