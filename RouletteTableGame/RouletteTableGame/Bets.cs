using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RouletteTableGame
{
    class Bets
    {   //Number array representing the numbers of roulette wheel
        static int[] wheelNum =
       {
            00, 1, 13, 36, 24, 3, 15, 34, 22, 5, 17, 32, 20, 7, 11, 30, 26, 9, 28, 0, 2,
            14, 35, 23, 4, 16, 33, 21, 6, 18, 31, 19, 8, 12, 29, 25, 10, 27
        };

        //Character array representing the colors of the roulette wheel (i.e. R=Red, B=Black, G=Green)
        static char[] wheelColor =
        {
            'G', 'R', 'B', 'R', 'B', 'R', 'B', 'R', 'B', 'R', 'B', 'R', 'B', 'R', 'B', 'R', 'B', 'R', 'B',
            'G', 'B', 'R', 'B', 'R', 'B', 'R', 'B', 'R', 'B', 'R', 'B', 'R', 'B', 'R', 'B', 'R', 'B', 'R'
        };

        static Random wheelStop = new Random();

        private static int wheelIndex = wheelStop.Next(wheelNum.Length); //roulette stops on random number index of number wheel array

        public static void NumberResult()
        {
            Console.WriteLine($"\nNumber: {wheelNum[wheelIndex]} wins");
        }
       
        public static void EvenOdd()
        {
            if (wheelNum[wheelIndex] % 2 == 0)
            {
                Console.WriteLine("Even/Odd: Even wins");
            }
            else if (wheelNum[wheelIndex] % 2 == 1)
            {
                Console.WriteLine("Even/Odd: Odd wins");
            }
            else
            {
                Console.WriteLine("Even/Odd: House wins...better luck next time!!!");
            }
        }

        public static void Color()
        {
            Console.WriteLine($"Color: {wheelColor[wheelIndex]} wins");
        }

        public static void LoHi()
        {
            if (wheelNum[wheelIndex] >= 1 && wheelNum[wheelIndex] <= 18)
            {
                Console.WriteLine("Lo/Hi: Low wins");
            }
            else if (wheelNum[wheelIndex] >= 19 && wheelNum[wheelIndex] <= 36)
            {
                Console.WriteLine("Lo/Hi: High wins");
            }
            else
            {
                Console.WriteLine("Lo/Hi: House wins...what are the odds?");
            }
        }

        public static void Dozens()
        {
            if (wheelNum[wheelIndex] >= 1 && wheelNum[wheelIndex] <= 12)
            {
                Console.WriteLine("Dozens: 1-12 wins");
            }
            else if (wheelNum[wheelIndex] >= 13 && wheelNum[wheelIndex] <= 24)
            {
                Console.WriteLine("Dozens: 13-24 wins");
            }
            else if (wheelNum[wheelIndex] > 24)
            {
                Console.WriteLine("Dozens: 25-36 wins");
            }
            else
            {
                Console.WriteLine("Dozens: House wins...quit gambling");
            }
        }

        public static void Columns()
        {

            if (wheelNum[wheelIndex] == 1 || wheelNum[wheelIndex] == 4 || wheelNum[wheelIndex] == 7 || wheelNum[wheelIndex] == 10 ||
                wheelNum[wheelIndex] == 13 || wheelNum[wheelIndex] == 16 || wheelNum[wheelIndex] == 19 || wheelNum[wheelIndex] == 22 ||
                wheelNum[wheelIndex] == 25 || wheelNum[wheelIndex] == 28 || wheelNum[wheelIndex] == 31 || wheelNum[wheelIndex] == 34)
            {
                Console.WriteLine("Columns: Column 1 wins");
            }
            else if (wheelNum[wheelIndex] == 2 || wheelNum[wheelIndex] == 5 || wheelNum[wheelIndex] == 8 || wheelNum[wheelIndex] == 11 ||
                     wheelNum[wheelIndex] == 14 || wheelNum[wheelIndex] == 17 || wheelNum[wheelIndex] == 20 || wheelNum[wheelIndex] == 23 ||
                     wheelNum[wheelIndex] == 26 || wheelNum[wheelIndex] == 29 || wheelNum[wheelIndex] == 32 || wheelNum[wheelIndex] == 35)
            {
                Console.WriteLine("Columns: Column 2 wins");
            }
            else if (wheelNum[wheelIndex] == 3 || wheelNum[wheelIndex] == 6 || wheelNum[wheelIndex] == 9 || wheelNum[wheelIndex] == 12 ||
                     wheelNum[wheelIndex] == 15 || wheelNum[wheelIndex] == 18 || wheelNum[wheelIndex] == 21 || wheelNum[wheelIndex] == 24 ||
                     wheelNum[wheelIndex] == 27 || wheelNum[wheelIndex] == 30 || wheelNum[wheelIndex] == 33 || wheelNum[wheelIndex] == 36)
            {
                Console.WriteLine("Columns: Columns 3 wins");
            }

            else
            {
                Console.WriteLine("Columns: House wins");
            }
        }

        public static void Street()
        {
            if (wheelNum[wheelIndex] >= 1 && wheelNum[wheelIndex] <= 3)
            {
                Console.WriteLine("Street: 1/2/3 wins");
            }
            else if (wheelNum[wheelIndex] >= 4 && wheelNum[wheelIndex] <= 6)
            {
                Console.WriteLine("Street: 4/5/6 wins");
            }
            else if (wheelNum[wheelIndex] >= 7 && wheelNum[wheelIndex] <= 9)
            {
                Console.WriteLine("Street: 7/8/9 wins");
            }
            else if (wheelNum[wheelIndex] >= 10 && wheelNum[wheelIndex] <= 12)
            {
                Console.WriteLine("Street: 10/11/12 wins");
            }
            else if (wheelNum[wheelIndex] >= 13 && wheelNum[wheelIndex] <= 15)
            {
                Console.WriteLine("Street: 13/14/15 wins");
            }
            else if (wheelNum[wheelIndex] >= 16 && wheelNum[wheelIndex] <= 18)
            {
                Console.WriteLine("Street: 16/17/18 wins");
            }
            else if (wheelNum[wheelIndex] >= 19 && wheelNum[wheelIndex] <= 21)
            {
                Console.WriteLine("Street: 19/20/21 wins");
            }
            else if (wheelNum[wheelIndex] >= 22 && wheelNum[wheelIndex] <= 24)
            {
                Console.WriteLine("Street: 22/23/24 wins");
            }
            else if (wheelNum[wheelIndex] >= 25 && wheelNum[wheelIndex] <= 27)
            {
                Console.WriteLine("Street: 25/26/27 wins");
            }
            else if (wheelNum[wheelIndex] >= 28 && wheelNum[wheelIndex] <= 30)
            {
                Console.WriteLine("Street: 28/29/30 wins");
            }
            else if (wheelNum[wheelIndex] >= 31 && wheelNum[wheelIndex] <= 33)
            {
                Console.WriteLine("Street: 31/32/33 wins");
            }
            else if (wheelNum[wheelIndex] >= 34 && wheelNum[wheelIndex] <= 36)
            {
                Console.WriteLine("Street: 34/35/36 wins");
            }
            else
            {
                Console.WriteLine("Street: House wins");
            }
        }

        public static void DoubleRow()
        {
            if (wheelNum[wheelIndex] >= 1 && wheelNum[wheelIndex] <= 6)
            {
                Console.WriteLine("Double Row: 1-6 or 4-9 wins");
            }
            else if (wheelNum[wheelIndex] >= 7 && wheelNum[wheelIndex] <= 12)
            {
                Console.WriteLine("Double Row: 7-12 or 10-15 wins");
            }
            else if (wheelNum[wheelIndex] >= 13 && wheelNum[wheelIndex] <= 18)
            {
                Console.WriteLine("Double Row: 13-18 or 16-21 wins");
            }
            else if (wheelNum[wheelIndex] >= 19 && wheelNum[wheelIndex] <= 24)
            {
                Console.WriteLine("Double Row: 19-24 or 25-30 wins");
            }
            else if (wheelNum[wheelIndex] >= 25 && wheelNum[wheelIndex] <= 30)
            {
                Console.WriteLine("Double Row: 25-30 or 28-33 wins");
            }
            else if (wheelNum[wheelIndex] >= 31 && wheelNum[wheelIndex] <= 36)
            {
                Console.WriteLine("Double Row: 31-36 wins");
            }
            else
            {
                Console.WriteLine("Double Row: House wins");
            }
        }

        public static void Split()
        {
            Console.WriteLine($"Split: {wheelNum[wheelIndex]} + number above/below or number side/side wins (e.g. 1/2, 11/14)");
        }

        public static void Corners()
        {
            Console.WriteLine($"Corners: Intersection of {wheelNum[wheelIndex]} + four contiguous numbers (e.g. 1/2/4/5 or 23/24/26/27)");
        }

    }
}

