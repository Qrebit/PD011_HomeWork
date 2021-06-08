using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boards
{
    class Program
    {
        static void Main(string[] args)
        {
            var board = new Chalk();
            board.Info = ShowGood;
            board.Error = ShowBad;
            board.List = ShowConsole;
            board.Draw();
            board.State();
            var board2 = new Marker();
            board2.Info = ShowGood;
            board2.Error = ShowBad;
            board2.List = ShowConsole;
            board2.Clear();
            board2.State();
            var board3 = new Interactive();
            board3.Info = ShowGood;
            board3.Error = ShowBad;
            board3.List = ShowConsole;
            board3.Draw();
            board3.Draw();
            board3.State();
        }

        static void ShowConsole(string msg)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(msg);
            Console.ResetColor();
        }
        static void ShowGood(string msg)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(msg);
            Console.ResetColor();
        }
        static void ShowBad(string msg)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(msg);
            Console.ResetColor();
        }
    }
}
