using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Figgle;
namespace RouletteTableGame
{
    class Title
    {
        public void TitleMenu()
        {
            Console.ForegroundColor = ConsoleColor.Red;        
            Console.WriteLine(FiggleFonts.Graffiti.Render("Roulette"));
            Console.ResetColor();
        }
    }
}
