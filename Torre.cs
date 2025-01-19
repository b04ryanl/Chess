using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabAjedrez
{
    class Torre
    {
        public ConsoleColor color;
        public char posicionL;
        public int posicionN;
        public Torre(char PosicionL, int PosicionN, ConsoleColor Color)
        {
            color = Color;
            posicionL = PosicionL;
            posicionN = PosicionN;

        }


        public void PintarTorre()
        {
            int x = 0;
            int y = 0;

            switch (posicionL)
            {
                case 'A':
                    x = 7;
                    break;
                case 'B':
                    x = 22;
                    break;
                case 'C':
                    x = 37;
                    break;
                case 'D':
                    x = 52;
                    break;
                case 'E':
                    x = 67;
                    break;
                case 'F':
                    x = 82;
                    break;
                case 'G':
                    x = 97;
                    break;
                case 'H':
                    x = 112;
                    break;
            }


            switch (posicionN)
            {
                case 1:
                    y = 5;
                    break;
                case 2:
                    y = 16;
                    break;
                case 3:
                    y = 26;
                    break;
                case 4:
                    y = 37;
                    break;
                case 5:
                    y = 48;
                    break;
                case 6:
                    y = 59;
                    break;
                case 7:
                    y = 70;
                    break;
                case 8:
                    y = 81;
                    break;


                    //case 9:
                    //    y = 70;
                    //    break;
                    //case 10:
                    //    y = 59;
                    //    break;
                    //case 11:
                    //    y = 48;
                    //    break;
                    //case 12:
                    //    y = 37;
                    //    break;
                    //case 13:
                    //    y = 26;
                    //    break;
                    //case 14:
                    //    y = 15;
                    //    break;
                    //case 15:
                    //    y = 5;
                    //    break;
                    //case 16:
                    //    y = 1;
                    //    break;
            }
            Console.SetCursorPosition(x , y);
            Console.ForegroundColor = color;
            Console.WriteLine(" ▄▄▄ ");

            //Console.SetCursorPosition(x, y);
            //Console.ForegroundColor = color;
            //Console.WriteLine("▄▄▄▄▄");

            Console.SetCursorPosition(x, y + 1);
            Console.ForegroundColor = color;
            Console.WriteLine("  █  ");

            Console.SetCursorPosition(x, y + 2);
            Console.ForegroundColor = color;
            Console.WriteLine(" ▄▄▄ ");
        }

        public void PintarTorre2(int x, int y, ConsoleColor color)
        {
            Console.SetCursorPosition(x, y);
            Console.ForegroundColor = color;
            Console.WriteLine(" ▄▄▄ ");

            Console.SetCursorPosition(x, y + 1);
            Console.ForegroundColor = color;
            Console.WriteLine("  █  ");

            Console.SetCursorPosition(x, y + 2);
            Console.ForegroundColor = color;
            Console.WriteLine(" ▄▄▄ ");
        }
    }
}
