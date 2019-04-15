using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Figgle;
namespace RouletteTableGame
{
    class Program
    {   
        static void Main(string[] args)
        {
            Title title = new Title();
            title.TitleMenu();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Winner, winner chicken dinner!!!\n All possible wins are as follows:");
            Console.WriteLine();
            Bets.NumberResult();
            Bets.EvenOdd();
            Bets.Color();
            Bets.LoHi();
            Bets.Dozens();
            Bets.Columns();
            Bets.Street();
            Bets.DoubleRow();
            Bets.Split();
            Bets.Corners();
          
        }
    }
}
