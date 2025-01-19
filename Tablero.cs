using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabAjedrez
{
    class Tablero
    {
        public void pintar()
        {
            cuadrito(0, 150, 0, 95, ConsoleColor.DarkGray);

            cuadrito(3, 13, 89, 94, ConsoleColor.Black); // A

            cuadrito(5, 11, 90, 90, ConsoleColor.White);
            cuadrito(5, 11, 92, 94, ConsoleColor.White);

            cuadrito(18, 28, 89, 94, ConsoleColor.Black); // B

            cuadrito(20, 26, 90, 90, ConsoleColor.White);
            cuadrito(20, 26, 92, 93, ConsoleColor.White);


            cuadrito(33, 43, 89, 94, ConsoleColor.Black); // C

            cuadrito(35, 43, 90, 93, ConsoleColor.White);

            cuadrito(48, 58, 89, 94, ConsoleColor.Black); //D

            cuadrito(50, 52, 90, 93, ConsoleColor.White);
            cuadrito(53, 55, 91, 92, ConsoleColor.White);


            cuadrito(63, 73, 89, 94, ConsoleColor.Black); // E

            cuadrito(66, 73, 90, 90, ConsoleColor.White);
            cuadrito(66, 73, 92, 92, ConsoleColor.White);

            cuadrito(78, 88, 89, 94, ConsoleColor.Black); // F

            cuadrito(81, 88, 90, 90, ConsoleColor.White);
            cuadrito(81, 88, 92, 94, ConsoleColor.White);


            cuadrito(93, 103, 89, 94, ConsoleColor.Black); //G

            cuadrito(96, 100, 90, 90, ConsoleColor.White);
            cuadrito(96, 103, 91, 91, ConsoleColor.White);
            cuadrito(96, 97, 92, 92, ConsoleColor.White);
            cuadrito(96, 99, 93, 93, ConsoleColor.White);

            cuadrito(108, 118, 89, 94, ConsoleColor.Black); // H

            cuadrito(111, 115, 89, 90, ConsoleColor.White);
            cuadrito(111, 115, 93, 94, ConsoleColor.White); ///RE OK


            cuadrito(124, 140, 02, 09, ConsoleColor.White); //1

            cuadrito(124, 126, 2, 3, ConsoleColor.Black);
            cuadrito(124, 132, 4, 9, ConsoleColor.Black);
            cuadrito(138, 140, 2, 9, ConsoleColor.Black);

            cuadrito(124, 140, 12, 20, ConsoleColor.White); //2

            cuadrito(124, 126, 12, 20, ConsoleColor.Black);
            cuadrito(138, 140, 12, 20, ConsoleColor.Black);
            cuadrito(127, 132, 14, 14, ConsoleColor.Black);
            cuadrito(131, 137, 17, 17, ConsoleColor.Black);


            cuadrito(124, 140, 23, 31, ConsoleColor.White); // 3

            cuadrito(124, 126, 23, 31, ConsoleColor.Black);
            cuadrito(138, 140, 23, 31, ConsoleColor.Black);
            cuadrito(127, 132, 25, 25, ConsoleColor.Black);
            cuadrito(127, 132, 28, 28, ConsoleColor.Black);


            cuadrito(124, 140, 34, 42, ConsoleColor.White); //4

            cuadrito(124, 126, 34, 42, ConsoleColor.Black);
            cuadrito(138, 140, 34, 42, ConsoleColor.Black);
            cuadrito(131, 133, 34, 36, ConsoleColor.Black);
            cuadrito(127, 133, 39, 42, ConsoleColor.Black);

            cuadrito(124, 140, 45, 53, ConsoleColor.White); //5

            cuadrito(124, 126, 45, 53, ConsoleColor.Black);
            cuadrito(138, 140, 45, 53, ConsoleColor.Black);
            cuadrito(130, 137, 47, 47, ConsoleColor.Black);
            cuadrito(127, 131, 50, 51, ConsoleColor.Black);


            cuadrito(124, 140, 56, 64, ConsoleColor.White); //6 

            cuadrito(124, 126, 56, 64, ConsoleColor.Black);
            cuadrito(138, 140, 56, 64, ConsoleColor.Black);
            cuadrito(130, 137, 58, 58, ConsoleColor.Black);
            cuadrito(130, 133, 61, 62, ConsoleColor.Black);

            cuadrito(124, 140, 67, 75, ConsoleColor.White); //7

            cuadrito(124, 126, 67, 75, ConsoleColor.Black);
            cuadrito(138, 140, 67, 75, ConsoleColor.Black);
            cuadrito(127, 132, 69, 70, ConsoleColor.Black);
            cuadrito(127, 132, 73, 75, ConsoleColor.Black);
            cuadrito(127, 129, 71, 72, ConsoleColor.Black);

            cuadrito(124, 140, 78, 86, ConsoleColor.White); // 8

            cuadrito(124, 126, 78, 86, ConsoleColor.Black);
            cuadrito(138, 140, 78, 86, ConsoleColor.Black);
            cuadrito(131, 133, 80, 80, ConsoleColor.Black);
            cuadrito(131, 133, 83, 83, ConsoleColor.Black);






            cuadrito(2, 15, 1, 10, ConsoleColor.DarkYellow);

            cuadrito(2, 2, 1, 1, ConsoleColor.Yellow);
            cuadrito(6, 6, 1, 1, ConsoleColor.Yellow);
            cuadrito(10, 10, 1, 1, ConsoleColor.Yellow);
            cuadrito(14, 14, 1, 1, ConsoleColor.Yellow);

            cuadrito(4, 4, 2, 2, ConsoleColor.Yellow);
            cuadrito(8, 8, 2, 2, ConsoleColor.Yellow);
            cuadrito(12, 12, 2, 2, ConsoleColor.Yellow);

            cuadrito(2, 2, 3, 3, ConsoleColor.Yellow);
            cuadrito(6, 6, 3, 3, ConsoleColor.Yellow);
            cuadrito(10, 10, 3, 3, ConsoleColor.Yellow);
            cuadrito(14, 14, 3, 3, ConsoleColor.Yellow);

            cuadrito(4, 4, 4, 4, ConsoleColor.Yellow);
            cuadrito(8, 8, 4, 4, ConsoleColor.Yellow);
            cuadrito(12, 12, 4, 4, ConsoleColor.Yellow);

            cuadrito(2, 2, 5, 5, ConsoleColor.Yellow);
            cuadrito(6, 6, 5, 5, ConsoleColor.Yellow);
            cuadrito(10, 10, 5, 5, ConsoleColor.Yellow);
            cuadrito(14, 14, 5, 5, ConsoleColor.Yellow);

            cuadrito(4, 4, 6, 6, ConsoleColor.Yellow);
            cuadrito(8, 8, 6, 6, ConsoleColor.Yellow);
            cuadrito(12, 12, 6, 6, ConsoleColor.Yellow);

            cuadrito(2, 2, 7, 7, ConsoleColor.Yellow);
            cuadrito(6, 6, 7, 7, ConsoleColor.Yellow);
            cuadrito(10, 10, 7, 7, ConsoleColor.Yellow);
            cuadrito(14, 14, 7, 7, ConsoleColor.Yellow);

            cuadrito(4, 4, 8, 8, ConsoleColor.Yellow);
            cuadrito(8, 8, 8, 8, ConsoleColor.Yellow);
            cuadrito(12, 12, 8, 8, ConsoleColor.Yellow);

            cuadrito(2, 2, 9, 9, ConsoleColor.Yellow);
            cuadrito(6, 6, 9, 9, ConsoleColor.Yellow);
            cuadrito(10, 10, 9, 9, ConsoleColor.Yellow);
            cuadrito(14, 14, 9, 9, ConsoleColor.Yellow);

            cuadrito(4, 4, 10, 10, ConsoleColor.Yellow);
            cuadrito(8, 8, 10, 10, ConsoleColor.Yellow);
            cuadrito(12, 12, 10, 10, ConsoleColor.Yellow); // H

            cuadrito(2, 15, 11, 21, ConsoleColor.DarkCyan);

            cuadrito(2, 2, 11, 11, ConsoleColor.Cyan);
            cuadrito(6, 6, 11, 11, ConsoleColor.Cyan);
            cuadrito(10, 10, 11, 11, ConsoleColor.Cyan);
            cuadrito(14, 14, 11, 11, ConsoleColor.Cyan);

            cuadrito(4, 4, 12, 12, ConsoleColor.Cyan);
            cuadrito(8, 8, 12, 12, ConsoleColor.Cyan);
            cuadrito(12, 12, 12, 12, ConsoleColor.Cyan);

            cuadrito(2, 2, 13, 13, ConsoleColor.Cyan);
            cuadrito(6, 6, 13, 13, ConsoleColor.Cyan);
            cuadrito(10, 10, 13, 13, ConsoleColor.Cyan);
            cuadrito(14, 14, 13, 13, ConsoleColor.Cyan);

            cuadrito(4, 4, 14, 14, ConsoleColor.Cyan);
            cuadrito(8, 8, 14, 14, ConsoleColor.Cyan);
            cuadrito(12, 12, 14, 14, ConsoleColor.Cyan);

            cuadrito(2, 2, 15, 15, ConsoleColor.Cyan);
            cuadrito(6, 6, 15, 15, ConsoleColor.Cyan);
            cuadrito(10, 10, 15, 15, ConsoleColor.Cyan);
            cuadrito(14, 14, 15, 15, ConsoleColor.Cyan);

            cuadrito(4, 4, 16, 16, ConsoleColor.Cyan);
            cuadrito(8, 8, 16, 16, ConsoleColor.Cyan);
            cuadrito(12, 12, 16, 16, ConsoleColor.Cyan);

            cuadrito(2, 2, 17, 17, ConsoleColor.Cyan);
            cuadrito(6, 6, 17, 17, ConsoleColor.Cyan);
            cuadrito(10, 10, 17, 17, ConsoleColor.Cyan);
            cuadrito(14, 14, 17, 17, ConsoleColor.Cyan);

            cuadrito(4, 4, 18, 18, ConsoleColor.Cyan);
            cuadrito(8, 8, 18, 18, ConsoleColor.Cyan);
            cuadrito(12, 12, 18, 18, ConsoleColor.Cyan);

            cuadrito(2, 2, 19, 19, ConsoleColor.Cyan);
            cuadrito(6, 6, 19, 19, ConsoleColor.Cyan);
            cuadrito(10, 10, 19, 19, ConsoleColor.Cyan);
            cuadrito(14, 14, 19, 19, ConsoleColor.Cyan);

            cuadrito(4, 4, 20, 20, ConsoleColor.Cyan);
            cuadrito(8, 8, 20, 20, ConsoleColor.Cyan);
            cuadrito(12, 12, 20, 20, ConsoleColor.Cyan);

            cuadrito(2, 2, 21, 21, ConsoleColor.Cyan);
            cuadrito(6, 6, 21, 21, ConsoleColor.Cyan);
            cuadrito(10, 10, 21, 21, ConsoleColor.Cyan);
            cuadrito(14, 14, 21, 21, ConsoleColor.Cyan);// H
            //*

            cuadrito(2, 15, 22, 32, ConsoleColor.DarkYellow);


            cuadrito(4, 4, 22, 22, ConsoleColor.Yellow);
            cuadrito(8, 8, 22, 22, ConsoleColor.Yellow);
            cuadrito(12, 12, 22, 22, ConsoleColor.Yellow);

            cuadrito(2, 2, 23, 23, ConsoleColor.Yellow);
            cuadrito(6, 6, 23, 23, ConsoleColor.Yellow);
            cuadrito(10, 10, 23, 23, ConsoleColor.Yellow);
            cuadrito(14, 14, 23, 23, ConsoleColor.Yellow);

            cuadrito(4, 4, 24, 24, ConsoleColor.Yellow);
            cuadrito(8, 8, 24, 24, ConsoleColor.Yellow);
            cuadrito(12, 12, 24, 24, ConsoleColor.Yellow);

            cuadrito(2, 2, 25, 25, ConsoleColor.Yellow);
            cuadrito(6, 6, 25, 25, ConsoleColor.Yellow);
            cuadrito(10, 10, 25, 25, ConsoleColor.Yellow);
            cuadrito(14, 14, 25, 25, ConsoleColor.Yellow);

            cuadrito(4, 4, 26, 26, ConsoleColor.Yellow);
            cuadrito(8, 8, 26, 26, ConsoleColor.Yellow);
            cuadrito(12, 12, 26, 26, ConsoleColor.Yellow);

            cuadrito(2, 2, 27, 27, ConsoleColor.Yellow);
            cuadrito(6, 6, 27, 27, ConsoleColor.Yellow);
            cuadrito(10, 10, 27, 27, ConsoleColor.Yellow);
            cuadrito(14, 14, 27, 27, ConsoleColor.Yellow);

            cuadrito(4, 4, 28, 28, ConsoleColor.Yellow);
            cuadrito(8, 8, 28, 28, ConsoleColor.Yellow);
            cuadrito(12, 12, 28, 28, ConsoleColor.Yellow);

            cuadrito(2, 2, 29, 29, ConsoleColor.Yellow);
            cuadrito(6, 6, 29, 29, ConsoleColor.Yellow);
            cuadrito(10, 10, 29, 29, ConsoleColor.Yellow);
            cuadrito(14, 14, 29, 29, ConsoleColor.Yellow);

            cuadrito(4, 4, 30, 30, ConsoleColor.Yellow);
            cuadrito(8, 8, 30, 30, ConsoleColor.Yellow);
            cuadrito(12, 12, 30, 30, ConsoleColor.Yellow);

            cuadrito(2, 2, 31, 31, ConsoleColor.Yellow);
            cuadrito(6, 6, 31, 31, ConsoleColor.Yellow);
            cuadrito(10, 10, 31, 31, ConsoleColor.Yellow);
            cuadrito(14, 14, 31, 31, ConsoleColor.Yellow);

            cuadrito(4, 4, 32, 32, ConsoleColor.Yellow);
            cuadrito(8, 8, 32, 32, ConsoleColor.Yellow);
            cuadrito(12, 12, 32, 32, ConsoleColor.Yellow);

            //*

            cuadrito(2, 15, 33, 43, ConsoleColor.DarkCyan);

            cuadrito(2, 2, 33, 33, ConsoleColor.Cyan);
            cuadrito(6, 6, 33, 33, ConsoleColor.Cyan);
            cuadrito(10, 10, 33, 33, ConsoleColor.Cyan);
            cuadrito(14, 14, 33, 33, ConsoleColor.Cyan);

            cuadrito(4, 4, 34, 34, ConsoleColor.Cyan);
            cuadrito(8, 8, 34, 34, ConsoleColor.Cyan);
            cuadrito(12, 12, 34, 34, ConsoleColor.Cyan);

            cuadrito(2, 2, 35, 35, ConsoleColor.Cyan);
            cuadrito(6, 6, 35, 35, ConsoleColor.Cyan);
            cuadrito(10, 10, 35, 35, ConsoleColor.Cyan);
            cuadrito(14, 14, 35, 35, ConsoleColor.Cyan);

            cuadrito(4, 4, 36, 36, ConsoleColor.Cyan);
            cuadrito(8, 8, 36, 36, ConsoleColor.Cyan);
            cuadrito(12, 12, 36, 36, ConsoleColor.Cyan);

            cuadrito(2, 2, 37, 37, ConsoleColor.Cyan);
            cuadrito(6, 6, 37, 37, ConsoleColor.Cyan);
            cuadrito(10, 10, 37, 37, ConsoleColor.Cyan);
            cuadrito(14, 14, 37, 37, ConsoleColor.Cyan);

            cuadrito(4, 4, 38, 38, ConsoleColor.Cyan);
            cuadrito(8, 8, 38, 38, ConsoleColor.Cyan);
            cuadrito(12, 12, 38, 38, ConsoleColor.Cyan);

            cuadrito(2, 2, 39, 39, ConsoleColor.Cyan);
            cuadrito(6, 6, 39, 39, ConsoleColor.Cyan);
            cuadrito(10, 10, 39, 39, ConsoleColor.Cyan);
            cuadrito(14, 14, 39, 39, ConsoleColor.Cyan);

            cuadrito(4, 4, 40, 40, ConsoleColor.Cyan);
            cuadrito(8, 8, 40, 40, ConsoleColor.Cyan);
            cuadrito(12, 12, 40, 40, ConsoleColor.Cyan);

            cuadrito(2, 2, 41, 41, ConsoleColor.Cyan);
            cuadrito(6, 6, 41, 41, ConsoleColor.Cyan);
            cuadrito(10, 10, 41, 41, ConsoleColor.Cyan);
            cuadrito(14, 14, 41, 41, ConsoleColor.Cyan);

            cuadrito(4, 4, 42, 42, ConsoleColor.Cyan);
            cuadrito(8, 8, 42, 42, ConsoleColor.Cyan);
            cuadrito(12, 12, 42, 42, ConsoleColor.Cyan);

            cuadrito(2, 2, 43, 43, ConsoleColor.Cyan);
            cuadrito(6, 6, 43, 43, ConsoleColor.Cyan);
            cuadrito(10, 10, 43, 43, ConsoleColor.Cyan);
            cuadrito(14, 14, 43, 43, ConsoleColor.Cyan);

            //*

            cuadrito(2, 15, 44, 54, ConsoleColor.DarkYellow);

            cuadrito(4, 4, 44, 44, ConsoleColor.Yellow);
            cuadrito(8, 8, 44, 44, ConsoleColor.Yellow);
            cuadrito(12, 12, 44, 44, ConsoleColor.Yellow);

            cuadrito(2, 2, 45, 45, ConsoleColor.Yellow);
            cuadrito(6, 6, 45, 45, ConsoleColor.Yellow);
            cuadrito(10, 10, 45, 45, ConsoleColor.Yellow);
            cuadrito(14, 14, 45, 45, ConsoleColor.Yellow);

            cuadrito(4, 4, 46, 46, ConsoleColor.Yellow);
            cuadrito(8, 8, 46, 46, ConsoleColor.Yellow);
            cuadrito(12, 12, 46, 46, ConsoleColor.Yellow);

            cuadrito(2, 2, 47, 47, ConsoleColor.Yellow);
            cuadrito(6, 6, 47, 47, ConsoleColor.Yellow);
            cuadrito(10, 10, 47, 47, ConsoleColor.Yellow);
            cuadrito(14, 14, 47, 47, ConsoleColor.Yellow);

            cuadrito(4, 4, 48, 48, ConsoleColor.Yellow);
            cuadrito(8, 8, 48, 48, ConsoleColor.Yellow);
            cuadrito(12, 12, 48, 48, ConsoleColor.Yellow);

            cuadrito(2, 2, 49, 49, ConsoleColor.Yellow);
            cuadrito(6, 6, 49, 49, ConsoleColor.Yellow);
            cuadrito(10, 10, 49, 49, ConsoleColor.Yellow);
            cuadrito(14, 14, 49, 49, ConsoleColor.Yellow);

            cuadrito(4, 4, 50, 50, ConsoleColor.Yellow);
            cuadrito(8, 8, 50, 50, ConsoleColor.Yellow);
            cuadrito(12, 12, 50, 50, ConsoleColor.Yellow);

            cuadrito(2, 2, 51, 51, ConsoleColor.Yellow);
            cuadrito(6, 6, 51, 51, ConsoleColor.Yellow);
            cuadrito(10, 10, 51, 51, ConsoleColor.Yellow);
            cuadrito(14, 14, 51, 51, ConsoleColor.Yellow);

            cuadrito(4, 4, 52, 52, ConsoleColor.Yellow);
            cuadrito(8, 8, 52, 52, ConsoleColor.Yellow);
            cuadrito(12, 12, 52, 52, ConsoleColor.Yellow);

            cuadrito(2, 2, 53, 53, ConsoleColor.Yellow);
            cuadrito(6, 6, 53, 53, ConsoleColor.Yellow);
            cuadrito(10, 10, 53, 53, ConsoleColor.Yellow);
            cuadrito(14, 14, 53, 53, ConsoleColor.Yellow);

            cuadrito(4, 4, 54, 54, ConsoleColor.Yellow);
            cuadrito(8, 8, 54, 54, ConsoleColor.Yellow);
            cuadrito(12, 12, 54, 54, ConsoleColor.Yellow);// H

            //*
            cuadrito(2, 15, 55, 65, ConsoleColor.DarkCyan);

            cuadrito(2, 2, 55, 55, ConsoleColor.Cyan);
            cuadrito(6, 6, 55, 55, ConsoleColor.Cyan);
            cuadrito(10, 10, 55, 55, ConsoleColor.Cyan);
            cuadrito(14, 14, 55, 55, ConsoleColor.Cyan);

            cuadrito(4, 4, 56, 56, ConsoleColor.Cyan);
            cuadrito(8, 8, 56, 56, ConsoleColor.Cyan);
            cuadrito(12, 12, 56, 56, ConsoleColor.Cyan);

            cuadrito(2, 2, 57, 57, ConsoleColor.Cyan);
            cuadrito(6, 6, 57, 57, ConsoleColor.Cyan);
            cuadrito(10, 10, 57, 57, ConsoleColor.Cyan);
            cuadrito(14, 14, 57, 57, ConsoleColor.Cyan);

            cuadrito(4, 4, 58, 58, ConsoleColor.Cyan);
            cuadrito(8, 8, 58, 58, ConsoleColor.Cyan);
            cuadrito(12, 12, 58, 58, ConsoleColor.Cyan);

            cuadrito(2, 2, 59, 59, ConsoleColor.Cyan);
            cuadrito(6, 6, 59, 59, ConsoleColor.Cyan);
            cuadrito(10, 10, 59, 59, ConsoleColor.Cyan);
            cuadrito(14, 14, 59, 59, ConsoleColor.Cyan);

            cuadrito(4, 4, 60, 60, ConsoleColor.Cyan);
            cuadrito(8, 8, 60, 60, ConsoleColor.Cyan);
            cuadrito(12, 12, 60, 60, ConsoleColor.Cyan);

            cuadrito(2, 2, 61, 61, ConsoleColor.Cyan);
            cuadrito(6, 6, 61, 61, ConsoleColor.Cyan);
            cuadrito(10, 10, 61, 61, ConsoleColor.Cyan);
            cuadrito(14, 14, 61, 61, ConsoleColor.Cyan);

            cuadrito(4, 4, 62, 62, ConsoleColor.Cyan);
            cuadrito(8, 8, 62, 62, ConsoleColor.Cyan);
            cuadrito(12, 12, 62, 62, ConsoleColor.Cyan);

            cuadrito(2, 2, 63, 63, ConsoleColor.Cyan);
            cuadrito(6, 6, 63, 63, ConsoleColor.Cyan);
            cuadrito(10, 10, 63, 63, ConsoleColor.Cyan);
            cuadrito(14, 14, 63, 63, ConsoleColor.Cyan);

            cuadrito(4, 4, 64, 64, ConsoleColor.Cyan);
            cuadrito(8, 8, 64, 64, ConsoleColor.Cyan);
            cuadrito(12, 12, 64, 64, ConsoleColor.Cyan);

            cuadrito(2, 2, 65, 65, ConsoleColor.Cyan);
            cuadrito(6, 6, 65, 65, ConsoleColor.Cyan);
            cuadrito(10, 10, 65, 65, ConsoleColor.Cyan);
            cuadrito(14, 14, 65, 65, ConsoleColor.Cyan);
            //*
            cuadrito(2, 15, 66, 76, ConsoleColor.DarkYellow);

            cuadrito(4, 4, 66, 66, ConsoleColor.Yellow);
            cuadrito(8, 8, 66, 66, ConsoleColor.Yellow);
            cuadrito(12, 12, 66, 66, ConsoleColor.Yellow);

            cuadrito(2, 2, 67, 67, ConsoleColor.Yellow);
            cuadrito(6, 6, 67, 67, ConsoleColor.Yellow);
            cuadrito(10, 10, 67, 67, ConsoleColor.Yellow);
            cuadrito(14, 14, 67, 67, ConsoleColor.Yellow);

            cuadrito(4, 4, 68, 68, ConsoleColor.Yellow);
            cuadrito(8, 8, 68, 68, ConsoleColor.Yellow);
            cuadrito(12, 12, 68, 68, ConsoleColor.Yellow);

            cuadrito(2, 2, 69, 69, ConsoleColor.Yellow);
            cuadrito(6, 6, 69, 69, ConsoleColor.Yellow);
            cuadrito(10, 10, 69, 69, ConsoleColor.Yellow);
            cuadrito(14, 14, 69, 69, ConsoleColor.Yellow);

            cuadrito(4, 4, 70, 70, ConsoleColor.Yellow);
            cuadrito(8, 8, 70, 70, ConsoleColor.Yellow);
            cuadrito(12, 12, 70, 70, ConsoleColor.Yellow);

            cuadrito(2, 2, 71, 71, ConsoleColor.Yellow);
            cuadrito(6, 6, 71, 71, ConsoleColor.Yellow);
            cuadrito(10, 10, 71, 71, ConsoleColor.Yellow);
            cuadrito(14, 14, 71, 71, ConsoleColor.Yellow);

            cuadrito(4, 4, 72, 72, ConsoleColor.Yellow);
            cuadrito(8, 8, 72, 72, ConsoleColor.Yellow);
            cuadrito(12, 12, 72, 72, ConsoleColor.Yellow);

            cuadrito(2, 2, 73, 73, ConsoleColor.Yellow);
            cuadrito(6, 6, 73, 73, ConsoleColor.Yellow);
            cuadrito(10, 10, 73, 73, ConsoleColor.Yellow);
            cuadrito(14, 14, 73, 73, ConsoleColor.Yellow);

            cuadrito(4, 4, 74, 74, ConsoleColor.Yellow);
            cuadrito(8, 8, 74, 74, ConsoleColor.Yellow);
            cuadrito(12, 12, 74, 74, ConsoleColor.Yellow);

            cuadrito(2, 2, 75, 75, ConsoleColor.Yellow);
            cuadrito(6, 6, 75, 75, ConsoleColor.Yellow);
            cuadrito(10, 10, 75, 75, ConsoleColor.Yellow);
            cuadrito(14, 14, 75, 75, ConsoleColor.Yellow);

            cuadrito(4, 4, 76, 76, ConsoleColor.Yellow);
            cuadrito(8, 8, 76, 76, ConsoleColor.Yellow);
            cuadrito(12, 12, 76, 76, ConsoleColor.Yellow);// H

            //*
            cuadrito(2, 15, 77, 87, ConsoleColor.DarkCyan);

            cuadrito(2, 2, 77, 77, ConsoleColor.Cyan);
            cuadrito(6, 6, 77, 77, ConsoleColor.Cyan);
            cuadrito(10, 10, 77, 77, ConsoleColor.Cyan);
            cuadrito(14, 14, 77, 77, ConsoleColor.Cyan);

            cuadrito(4, 4, 78, 78, ConsoleColor.Cyan);
            cuadrito(8, 8, 78, 78, ConsoleColor.Cyan);
            cuadrito(12, 12, 78, 78, ConsoleColor.Cyan);

            cuadrito(2, 2, 79, 79, ConsoleColor.Cyan);
            cuadrito(6, 6, 79, 79, ConsoleColor.Cyan);
            cuadrito(10, 10, 79, 79, ConsoleColor.Cyan);
            cuadrito(14, 14, 79, 79, ConsoleColor.Cyan);

            cuadrito(4, 4, 80, 80, ConsoleColor.Cyan);
            cuadrito(8, 8, 80, 80, ConsoleColor.Cyan);
            cuadrito(12, 12, 80, 80, ConsoleColor.Cyan);

            cuadrito(2, 2, 81, 81, ConsoleColor.Cyan);
            cuadrito(6, 6, 81, 81, ConsoleColor.Cyan);
            cuadrito(10, 10, 81, 81, ConsoleColor.Cyan);
            cuadrito(14, 14, 81, 81, ConsoleColor.Cyan);

            cuadrito(4, 4, 82, 82, ConsoleColor.Cyan);
            cuadrito(8, 8, 82, 82, ConsoleColor.Cyan);
            cuadrito(12, 12, 82, 82, ConsoleColor.Cyan);

            cuadrito(2, 2, 83, 83, ConsoleColor.Cyan);
            cuadrito(6, 6, 83, 83, ConsoleColor.Cyan);
            cuadrito(10, 10, 83, 83, ConsoleColor.Cyan);
            cuadrito(14, 14, 83, 83, ConsoleColor.Cyan);

            cuadrito(4, 4, 84, 84, ConsoleColor.Cyan);
            cuadrito(8, 8, 84, 84, ConsoleColor.Cyan);
            cuadrito(12, 12, 84, 84, ConsoleColor.Cyan);

            cuadrito(2, 2, 85, 85, ConsoleColor.Cyan);
            cuadrito(6, 6, 85, 85, ConsoleColor.Cyan);
            cuadrito(10, 10, 85, 85, ConsoleColor.Cyan);
            cuadrito(14, 14, 85, 85, ConsoleColor.Cyan);

            cuadrito(4, 4, 86, 86, ConsoleColor.Cyan);
            cuadrito(8, 8, 86, 86, ConsoleColor.Cyan);
            cuadrito(12, 12, 86, 86, ConsoleColor.Cyan);

            cuadrito(2, 2, 87, 87, ConsoleColor.Cyan);
            cuadrito(6, 6, 87, 87, ConsoleColor.Cyan);
            cuadrito(10, 10, 87, 87, ConsoleColor.Cyan);
            cuadrito(14, 14, 87, 87, ConsoleColor.Cyan);

            //*

            cuadrito(16, 30, 1, 10, ConsoleColor.DarkCyan);

            cuadrito(18, 18, 1, 1, ConsoleColor.Cyan);
            cuadrito(22, 22, 1, 1, ConsoleColor.Cyan);
            cuadrito(26, 26, 1, 1, ConsoleColor.Cyan);
            cuadrito(30, 30, 1, 1, ConsoleColor.Cyan);

            cuadrito(16, 16, 2, 2, ConsoleColor.Cyan);
            cuadrito(20, 20, 2, 2, ConsoleColor.Cyan);
            cuadrito(24, 24, 2, 2, ConsoleColor.Cyan);
            cuadrito(28, 28, 2, 2, ConsoleColor.Cyan);

            cuadrito(18, 18, 3, 3, ConsoleColor.Cyan);
            cuadrito(22, 22, 3, 3, ConsoleColor.Cyan);
            cuadrito(26, 26, 3, 3, ConsoleColor.Cyan);
            cuadrito(30, 30, 3, 3, ConsoleColor.Cyan);

            cuadrito(16, 16, 4, 4, ConsoleColor.Cyan);
            cuadrito(20, 20, 4, 4, ConsoleColor.Cyan);
            cuadrito(24, 24, 4, 4, ConsoleColor.Cyan);
            cuadrito(28, 28, 4, 4, ConsoleColor.Cyan);

            cuadrito(18, 18, 5, 5, ConsoleColor.Cyan);
            cuadrito(22, 22, 5, 5, ConsoleColor.Cyan);
            cuadrito(26, 26, 5, 5, ConsoleColor.Cyan);
            cuadrito(30, 30, 5, 5, ConsoleColor.Cyan);

            cuadrito(16, 16, 6, 6, ConsoleColor.Cyan);
            cuadrito(20, 20, 6, 6, ConsoleColor.Cyan);
            cuadrito(24, 24, 6, 6, ConsoleColor.Cyan);
            cuadrito(28, 28, 6, 6, ConsoleColor.Cyan);

            cuadrito(18, 18, 7, 7, ConsoleColor.Cyan);
            cuadrito(22, 22, 7, 7, ConsoleColor.Cyan);
            cuadrito(26, 26, 7, 7, ConsoleColor.Cyan);
            cuadrito(30, 30, 7, 7, ConsoleColor.Cyan);

            cuadrito(16, 16, 8, 8, ConsoleColor.Cyan);
            cuadrito(20, 20, 8, 8, ConsoleColor.Cyan);
            cuadrito(24, 24, 8, 8, ConsoleColor.Cyan);
            cuadrito(28, 28, 8, 8, ConsoleColor.Cyan);

            cuadrito(18, 18, 9, 9, ConsoleColor.Cyan);
            cuadrito(22, 22, 9, 9, ConsoleColor.Cyan);
            cuadrito(26, 26, 9, 9, ConsoleColor.Cyan);
            cuadrito(30, 30, 9, 9, ConsoleColor.Cyan);

            cuadrito(16, 16, 10, 10, ConsoleColor.Cyan);
            cuadrito(20, 20, 10, 10, ConsoleColor.Cyan);
            cuadrito(24, 24, 10, 10, ConsoleColor.Cyan);
            cuadrito(28, 28, 10, 10, ConsoleColor.Cyan);


            //*
            cuadrito(16, 30, 11, 21, ConsoleColor.DarkYellow);

            cuadrito(18, 18, 11, 11, ConsoleColor.Yellow);
            cuadrito(22, 22, 11, 11, ConsoleColor.Yellow);
            cuadrito(26, 26, 11, 11, ConsoleColor.Yellow);
            cuadrito(30, 30, 11, 11, ConsoleColor.Yellow);

            cuadrito(16, 16, 12, 12, ConsoleColor.Yellow);
            cuadrito(20, 20, 12, 12, ConsoleColor.Yellow);
            cuadrito(24, 24, 12, 12, ConsoleColor.Yellow);
            cuadrito(28, 28, 12, 12, ConsoleColor.Yellow);

            cuadrito(18, 18, 13, 13, ConsoleColor.Yellow);
            cuadrito(22, 22, 13, 13, ConsoleColor.Yellow);
            cuadrito(26, 26, 13, 13, ConsoleColor.Yellow);
            cuadrito(30, 30, 13, 13, ConsoleColor.Yellow);

            cuadrito(16, 16, 14, 14, ConsoleColor.Yellow);
            cuadrito(20, 20, 14, 14, ConsoleColor.Yellow);
            cuadrito(24, 24, 14, 14, ConsoleColor.Yellow);
            cuadrito(28, 28, 14, 14, ConsoleColor.Yellow);

            cuadrito(18, 18, 15, 15, ConsoleColor.Yellow);
            cuadrito(22, 22, 15, 15, ConsoleColor.Yellow);
            cuadrito(26, 26, 15, 15, ConsoleColor.Yellow);
            cuadrito(30, 30, 15, 15, ConsoleColor.Yellow);

            cuadrito(16, 16, 16, 16, ConsoleColor.Yellow);
            cuadrito(20, 20, 16, 16, ConsoleColor.Yellow);
            cuadrito(24, 24, 16, 16, ConsoleColor.Yellow);
            cuadrito(28, 28, 16, 16, ConsoleColor.Yellow);

            cuadrito(18, 18, 17, 17, ConsoleColor.Yellow);
            cuadrito(22, 22, 17, 17, ConsoleColor.Yellow);
            cuadrito(26, 26, 17, 17, ConsoleColor.Yellow);
            cuadrito(30, 30, 17, 17, ConsoleColor.Yellow);

            cuadrito(16, 16, 18, 18, ConsoleColor.Yellow);
            cuadrito(20, 20, 18, 18, ConsoleColor.Yellow);
            cuadrito(24, 24, 18, 18, ConsoleColor.Yellow);
            cuadrito(28, 28, 18, 18, ConsoleColor.Yellow);

            cuadrito(18, 18, 19, 19, ConsoleColor.Yellow);
            cuadrito(22, 22, 19, 19, ConsoleColor.Yellow);
            cuadrito(26, 26, 19, 19, ConsoleColor.Yellow);
            cuadrito(30, 30, 19, 19, ConsoleColor.Yellow);

            cuadrito(16, 16, 20, 20, ConsoleColor.Yellow);
            cuadrito(20, 20, 20, 20, ConsoleColor.Yellow);
            cuadrito(24, 24, 20, 20, ConsoleColor.Yellow);
            cuadrito(28, 28, 20, 20, ConsoleColor.Yellow);

            cuadrito(18, 18, 21, 21, ConsoleColor.Yellow);
            cuadrito(22, 22, 21, 21, ConsoleColor.Yellow);
            cuadrito(26, 26, 21, 21, ConsoleColor.Yellow);
            cuadrito(30, 30, 21, 21, ConsoleColor.Yellow);
            //*
            cuadrito(16, 30, 22, 32, ConsoleColor.DarkCyan);

            cuadrito(16, 16, 22, 22, ConsoleColor.Cyan);
            cuadrito(20, 20, 22, 22, ConsoleColor.Cyan);
            cuadrito(24, 24, 22, 22, ConsoleColor.Cyan);
            cuadrito(28, 28, 22, 22, ConsoleColor.Cyan);

            cuadrito(18, 18, 23, 23, ConsoleColor.Cyan);
            cuadrito(22, 22, 23, 23, ConsoleColor.Cyan);
            cuadrito(26, 26, 23, 23, ConsoleColor.Cyan);
            cuadrito(30, 30, 23, 23, ConsoleColor.Cyan);

            cuadrito(16, 16, 24, 24, ConsoleColor.Cyan);
            cuadrito(20, 20, 24, 24, ConsoleColor.Cyan);
            cuadrito(24, 24, 24, 24, ConsoleColor.Cyan);
            cuadrito(28, 28, 24, 24, ConsoleColor.Cyan);

            cuadrito(18, 18, 25, 25, ConsoleColor.Cyan);
            cuadrito(22, 22, 25, 25, ConsoleColor.Cyan);
            cuadrito(26, 26, 25, 25, ConsoleColor.Cyan);
            cuadrito(30, 30, 25, 25, ConsoleColor.Cyan);

            cuadrito(16, 16, 26, 26, ConsoleColor.Cyan);
            cuadrito(20, 20, 26, 26, ConsoleColor.Cyan);
            cuadrito(24, 24, 26, 26, ConsoleColor.Cyan);
            cuadrito(28, 28, 26, 26, ConsoleColor.Cyan);

            cuadrito(18, 18, 27, 27, ConsoleColor.Cyan);
            cuadrito(22, 22, 27, 27, ConsoleColor.Cyan);
            cuadrito(26, 26, 27, 27, ConsoleColor.Cyan);
            cuadrito(30, 30, 27, 27, ConsoleColor.Cyan);

            cuadrito(16, 16, 28, 28, ConsoleColor.Cyan);
            cuadrito(20, 20, 28, 28, ConsoleColor.Cyan);
            cuadrito(24, 24, 28, 28, ConsoleColor.Cyan);
            cuadrito(28, 28, 28, 28, ConsoleColor.Cyan);

            cuadrito(18, 18, 29, 29, ConsoleColor.Cyan);
            cuadrito(22, 22, 29, 29, ConsoleColor.Cyan);
            cuadrito(26, 26, 29, 29, ConsoleColor.Cyan);
            cuadrito(30, 30, 29, 29, ConsoleColor.Cyan);

            cuadrito(16, 16, 30, 30, ConsoleColor.Cyan);
            cuadrito(20, 20, 30, 30, ConsoleColor.Cyan);
            cuadrito(24, 24, 30, 30, ConsoleColor.Cyan);
            cuadrito(28, 28, 30, 30, ConsoleColor.Cyan);

            cuadrito(18, 18, 31, 31, ConsoleColor.Cyan);
            cuadrito(22, 22, 31, 31, ConsoleColor.Cyan);
            cuadrito(26, 26, 31, 31, ConsoleColor.Cyan);
            cuadrito(30, 30, 31, 31, ConsoleColor.Cyan);

            cuadrito(16, 16, 32, 32, ConsoleColor.Cyan);
            cuadrito(20, 20, 32, 32, ConsoleColor.Cyan);
            cuadrito(24, 24, 32, 32, ConsoleColor.Cyan);
            cuadrito(28, 28, 32, 32, ConsoleColor.Cyan);

            //*
            cuadrito(16, 30, 33, 43, ConsoleColor.DarkYellow);

            cuadrito(18, 18, 33, 33, ConsoleColor.Yellow);
            cuadrito(22, 22, 33, 33, ConsoleColor.Yellow);
            cuadrito(26, 26, 33, 33, ConsoleColor.Yellow);
            cuadrito(30, 30, 33, 33, ConsoleColor.Yellow);

            cuadrito(16, 16, 34, 34, ConsoleColor.Yellow);
            cuadrito(20, 20, 34, 34, ConsoleColor.Yellow);
            cuadrito(24, 24, 34, 34, ConsoleColor.Yellow);
            cuadrito(28, 28, 34, 34, ConsoleColor.Yellow);

            cuadrito(18, 18, 35, 35, ConsoleColor.Yellow);
            cuadrito(22, 22, 35, 35, ConsoleColor.Yellow);
            cuadrito(26, 26, 35, 35, ConsoleColor.Yellow);
            cuadrito(30, 30, 35, 35, ConsoleColor.Yellow);

            cuadrito(16, 16, 36, 36, ConsoleColor.Yellow);
            cuadrito(20, 20, 36, 36, ConsoleColor.Yellow);
            cuadrito(24, 24, 36, 36, ConsoleColor.Yellow);
            cuadrito(28, 28, 36, 36, ConsoleColor.Yellow);

            cuadrito(18, 18, 37, 37, ConsoleColor.Yellow);
            cuadrito(22, 22, 37, 37, ConsoleColor.Yellow);
            cuadrito(26, 26, 37, 37, ConsoleColor.Yellow);
            cuadrito(30, 30, 37, 37, ConsoleColor.Yellow);

            cuadrito(16, 16, 38, 38, ConsoleColor.Yellow);
            cuadrito(20, 20, 38, 38, ConsoleColor.Yellow);
            cuadrito(24, 24, 38, 38, ConsoleColor.Yellow);
            cuadrito(28, 28, 38, 38, ConsoleColor.Yellow);

            cuadrito(18, 18, 39, 39, ConsoleColor.Yellow);
            cuadrito(22, 22, 39, 39, ConsoleColor.Yellow);
            cuadrito(26, 26, 39, 39, ConsoleColor.Yellow);
            cuadrito(30, 30, 39, 39, ConsoleColor.Yellow);

            cuadrito(16, 16, 40, 40, ConsoleColor.Yellow);
            cuadrito(20, 20, 40, 40, ConsoleColor.Yellow);
            cuadrito(24, 24, 40, 40, ConsoleColor.Yellow);
            cuadrito(28, 28, 40, 40, ConsoleColor.Yellow);

            cuadrito(18, 18, 41, 41, ConsoleColor.Yellow);
            cuadrito(22, 22, 41, 41, ConsoleColor.Yellow);
            cuadrito(26, 26, 41, 41, ConsoleColor.Yellow);
            cuadrito(30, 30, 41, 41, ConsoleColor.Yellow);

            cuadrito(16, 16, 42, 42, ConsoleColor.Yellow);
            cuadrito(20, 20, 42, 42, ConsoleColor.Yellow);
            cuadrito(24, 24, 42, 42, ConsoleColor.Yellow);
            cuadrito(28, 28, 42, 42, ConsoleColor.Yellow);

            cuadrito(18, 18, 43, 43, ConsoleColor.Yellow);
            cuadrito(22, 22, 43, 43, ConsoleColor.Yellow);
            cuadrito(26, 26, 43, 43, ConsoleColor.Yellow);
            cuadrito(30, 30, 43, 43, ConsoleColor.Yellow);//*

            //*

            cuadrito(16, 30, 44, 54, ConsoleColor.DarkCyan);

            cuadrito(16, 16, 44, 44, ConsoleColor.Cyan);
            cuadrito(20, 20, 44, 44, ConsoleColor.Cyan);
            cuadrito(24, 24, 44, 44, ConsoleColor.Cyan);
            cuadrito(28, 28, 44, 44, ConsoleColor.Cyan);

            cuadrito(18, 18, 45, 45, ConsoleColor.Cyan);
            cuadrito(22, 22, 45, 45, ConsoleColor.Cyan);
            cuadrito(26, 26, 45, 45, ConsoleColor.Cyan);
            cuadrito(30, 30, 45, 45, ConsoleColor.Cyan);

            cuadrito(16, 16, 46, 46, ConsoleColor.Cyan);
            cuadrito(20, 20, 46, 46, ConsoleColor.Cyan);
            cuadrito(24, 24, 46, 46, ConsoleColor.Cyan);
            cuadrito(28, 28, 46, 46, ConsoleColor.Cyan);

            cuadrito(18, 18, 47, 47, ConsoleColor.Cyan);
            cuadrito(22, 22, 47, 47, ConsoleColor.Cyan);
            cuadrito(26, 26, 47, 47, ConsoleColor.Cyan);
            cuadrito(30, 30, 47, 47, ConsoleColor.Cyan);

            cuadrito(16, 16, 48, 48, ConsoleColor.Cyan);
            cuadrito(20, 20, 48, 48, ConsoleColor.Cyan);
            cuadrito(24, 24, 48, 48, ConsoleColor.Cyan);
            cuadrito(28, 28, 48, 48, ConsoleColor.Cyan);

            cuadrito(18, 18, 49, 49, ConsoleColor.Cyan);
            cuadrito(22, 22, 49, 49, ConsoleColor.Cyan);
            cuadrito(26, 26, 49, 49, ConsoleColor.Cyan);
            cuadrito(30, 30, 49, 49, ConsoleColor.Cyan);

            cuadrito(16, 16, 50, 50, ConsoleColor.Cyan);
            cuadrito(20, 20, 50, 50, ConsoleColor.Cyan);
            cuadrito(24, 24, 50, 50, ConsoleColor.Cyan);
            cuadrito(28, 28, 50, 50, ConsoleColor.Cyan);

            cuadrito(18, 18, 51, 51, ConsoleColor.Cyan);
            cuadrito(22, 22, 51, 51, ConsoleColor.Cyan);
            cuadrito(26, 26, 51, 51, ConsoleColor.Cyan);
            cuadrito(30, 30, 51, 51, ConsoleColor.Cyan);

            cuadrito(16, 16, 52, 52, ConsoleColor.Cyan);
            cuadrito(20, 20, 52, 52, ConsoleColor.Cyan);
            cuadrito(24, 24, 52, 52, ConsoleColor.Cyan);
            cuadrito(28, 28, 52, 52, ConsoleColor.Cyan);

            cuadrito(18, 18, 53, 53, ConsoleColor.Cyan);
            cuadrito(22, 22, 53, 53, ConsoleColor.Cyan);
            cuadrito(26, 26, 53, 53, ConsoleColor.Cyan);
            cuadrito(30, 30, 53, 53, ConsoleColor.Cyan);

            cuadrito(16, 16, 54, 54, ConsoleColor.Cyan);
            cuadrito(20, 20, 54, 54, ConsoleColor.Cyan);
            cuadrito(24, 24, 54, 54, ConsoleColor.Cyan);
            cuadrito(28, 28, 54, 54, ConsoleColor.Cyan);

            //*
            cuadrito(16, 30, 55, 65, ConsoleColor.DarkYellow);

            cuadrito(18, 18, 55, 55, ConsoleColor.Yellow);
            cuadrito(22, 22, 55, 55, ConsoleColor.Yellow);
            cuadrito(26, 26, 55, 55, ConsoleColor.Yellow);
            cuadrito(30, 30, 55, 55, ConsoleColor.Yellow);

            cuadrito(16, 16, 56, 56, ConsoleColor.Yellow);
            cuadrito(20, 20, 56, 56, ConsoleColor.Yellow);
            cuadrito(24, 24, 56, 56, ConsoleColor.Yellow);
            cuadrito(28, 28, 56, 56, ConsoleColor.Yellow);

            cuadrito(18, 18, 57, 57, ConsoleColor.Yellow);
            cuadrito(22, 22, 57, 57, ConsoleColor.Yellow);
            cuadrito(26, 26, 57, 57, ConsoleColor.Yellow);
            cuadrito(30, 30, 57, 57, ConsoleColor.Yellow);

            cuadrito(16, 16, 58, 58, ConsoleColor.Yellow);
            cuadrito(20, 20, 58, 58, ConsoleColor.Yellow);
            cuadrito(24, 24, 58, 58, ConsoleColor.Yellow);
            cuadrito(28, 28, 58, 58, ConsoleColor.Yellow);

            cuadrito(18, 18, 59, 59, ConsoleColor.Yellow);
            cuadrito(22, 22, 59, 59, ConsoleColor.Yellow);
            cuadrito(26, 26, 59, 59, ConsoleColor.Yellow);
            cuadrito(30, 30, 59, 59, ConsoleColor.Yellow);

            cuadrito(16, 16, 60, 60, ConsoleColor.Yellow);
            cuadrito(20, 20, 60, 60, ConsoleColor.Yellow);
            cuadrito(24, 24, 60, 60, ConsoleColor.Yellow);
            cuadrito(28, 28, 60, 60, ConsoleColor.Yellow);

            cuadrito(18, 18, 61, 61, ConsoleColor.Yellow);
            cuadrito(22, 22, 61, 61, ConsoleColor.Yellow);
            cuadrito(26, 26, 61, 61, ConsoleColor.Yellow);
            cuadrito(30, 30, 61, 61, ConsoleColor.Yellow);

            cuadrito(16, 16, 62, 62, ConsoleColor.Yellow);
            cuadrito(20, 20, 62, 62, ConsoleColor.Yellow);
            cuadrito(24, 24, 62, 62, ConsoleColor.Yellow);
            cuadrito(28, 28, 62, 62, ConsoleColor.Yellow);

            cuadrito(18, 18, 63, 63, ConsoleColor.Yellow);
            cuadrito(22, 22, 63, 63, ConsoleColor.Yellow);
            cuadrito(26, 26, 63, 63, ConsoleColor.Yellow);
            cuadrito(30, 30, 63, 63, ConsoleColor.Yellow);

            cuadrito(16, 16, 64, 64, ConsoleColor.Yellow);
            cuadrito(20, 20, 64, 64, ConsoleColor.Yellow);
            cuadrito(24, 24, 64, 64, ConsoleColor.Yellow);
            cuadrito(28, 28, 64, 64, ConsoleColor.Yellow);

            cuadrito(18, 18, 65, 65, ConsoleColor.Yellow);
            cuadrito(22, 22, 65, 65, ConsoleColor.Yellow);
            cuadrito(26, 26, 65, 65, ConsoleColor.Yellow);
            cuadrito(30, 30, 65, 65, ConsoleColor.Yellow);

            //*
            cuadrito(16, 30, 66, 76, ConsoleColor.DarkCyan);

            cuadrito(16, 16, 66, 66, ConsoleColor.Cyan);
            cuadrito(20, 20, 66, 66, ConsoleColor.Cyan);
            cuadrito(24, 24, 66, 66, ConsoleColor.Cyan);
            cuadrito(28, 28, 66, 66, ConsoleColor.Cyan);

            cuadrito(18, 18, 67, 67, ConsoleColor.Cyan);
            cuadrito(22, 22, 67, 67, ConsoleColor.Cyan);
            cuadrito(26, 26, 67, 67, ConsoleColor.Cyan);
            cuadrito(30, 30, 67, 67, ConsoleColor.Cyan);

            cuadrito(16, 16, 68, 68, ConsoleColor.Cyan);
            cuadrito(20, 20, 68, 68, ConsoleColor.Cyan);
            cuadrito(24, 24, 68, 68, ConsoleColor.Cyan);
            cuadrito(28, 28, 68, 68, ConsoleColor.Cyan);

            cuadrito(18, 18, 69, 69, ConsoleColor.Cyan);
            cuadrito(22, 22, 69, 69, ConsoleColor.Cyan);
            cuadrito(26, 26, 69, 69, ConsoleColor.Cyan);
            cuadrito(30, 30, 69, 69, ConsoleColor.Cyan);

            cuadrito(16, 16, 70, 70, ConsoleColor.Cyan);
            cuadrito(20, 20, 70, 70, ConsoleColor.Cyan);
            cuadrito(24, 24, 70, 70, ConsoleColor.Cyan);
            cuadrito(28, 28, 70, 70, ConsoleColor.Cyan);

            cuadrito(18, 18, 71, 71, ConsoleColor.Cyan);
            cuadrito(22, 22, 71, 71, ConsoleColor.Cyan);
            cuadrito(26, 26, 71, 71, ConsoleColor.Cyan);
            cuadrito(30, 30, 71, 71, ConsoleColor.Cyan);

            cuadrito(16, 16, 72, 72, ConsoleColor.Cyan);
            cuadrito(20, 20, 72, 72, ConsoleColor.Cyan);
            cuadrito(24, 24, 72, 72, ConsoleColor.Cyan);
            cuadrito(28, 28, 72, 72, ConsoleColor.Cyan);

            cuadrito(18, 18, 73, 73, ConsoleColor.Cyan);
            cuadrito(22, 22, 73, 73, ConsoleColor.Cyan);
            cuadrito(26, 26, 73, 73, ConsoleColor.Cyan);
            cuadrito(30, 30, 73, 73, ConsoleColor.Cyan);

            cuadrito(16, 16, 74, 74, ConsoleColor.Cyan);
            cuadrito(20, 20, 74, 74, ConsoleColor.Cyan);
            cuadrito(24, 24, 74, 74, ConsoleColor.Cyan);
            cuadrito(28, 28, 74, 74, ConsoleColor.Cyan);

            cuadrito(18, 18, 75, 75, ConsoleColor.Cyan);
            cuadrito(22, 22, 75, 75, ConsoleColor.Cyan);
            cuadrito(26, 26, 75, 75, ConsoleColor.Cyan);
            cuadrito(30, 30, 75, 75, ConsoleColor.Cyan);

            cuadrito(16, 16, 76, 76, ConsoleColor.Cyan);
            cuadrito(20, 20, 76, 76, ConsoleColor.Cyan);
            cuadrito(24, 24, 76, 76, ConsoleColor.Cyan);
            cuadrito(28, 28, 76, 76, ConsoleColor.Cyan);

            //*
            cuadrito(16, 30, 77, 87, ConsoleColor.DarkYellow);

            cuadrito(18, 18, 77, 77, ConsoleColor.Yellow);
            cuadrito(22, 22, 77, 77, ConsoleColor.Yellow);
            cuadrito(26, 26, 77, 77, ConsoleColor.Yellow);
            cuadrito(30, 30, 77, 77, ConsoleColor.Yellow);

            cuadrito(16, 16, 78, 78, ConsoleColor.Yellow);
            cuadrito(20, 20, 78, 78, ConsoleColor.Yellow);
            cuadrito(24, 24, 78, 78, ConsoleColor.Yellow);
            cuadrito(28, 28, 78, 78, ConsoleColor.Yellow);

            cuadrito(18, 18, 79, 79, ConsoleColor.Yellow);
            cuadrito(22, 22, 79, 79, ConsoleColor.Yellow);
            cuadrito(26, 26, 79, 79, ConsoleColor.Yellow);
            cuadrito(30, 30, 79, 79, ConsoleColor.Yellow);

            cuadrito(16, 16, 80, 80, ConsoleColor.Yellow);
            cuadrito(20, 20, 80, 80, ConsoleColor.Yellow);
            cuadrito(24, 24, 80, 80, ConsoleColor.Yellow);
            cuadrito(28, 28, 80, 80, ConsoleColor.Yellow);

            cuadrito(18, 18, 81, 81, ConsoleColor.Yellow);
            cuadrito(22, 22, 81, 81, ConsoleColor.Yellow);
            cuadrito(26, 26, 81, 81, ConsoleColor.Yellow);
            cuadrito(30, 30, 81, 81, ConsoleColor.Yellow);

            cuadrito(16, 16, 82, 82, ConsoleColor.Yellow);
            cuadrito(20, 20, 82, 82, ConsoleColor.Yellow);
            cuadrito(24, 24, 82, 82, ConsoleColor.Yellow);
            cuadrito(28, 28, 82, 82, ConsoleColor.Yellow);

            cuadrito(18, 18, 83, 83, ConsoleColor.Yellow);
            cuadrito(22, 22, 83, 83, ConsoleColor.Yellow);
            cuadrito(26, 26, 83, 83, ConsoleColor.Yellow);
            cuadrito(30, 30, 83, 83, ConsoleColor.Yellow);

            cuadrito(16, 16, 84, 84, ConsoleColor.Yellow);
            cuadrito(20, 20, 84, 84, ConsoleColor.Yellow);
            cuadrito(24, 24, 84, 84, ConsoleColor.Yellow);
            cuadrito(28, 28, 84, 84, ConsoleColor.Yellow);

            cuadrito(18, 18, 85, 85, ConsoleColor.Yellow);
            cuadrito(22, 22, 85, 85, ConsoleColor.Yellow);
            cuadrito(26, 26, 85, 85, ConsoleColor.Yellow);
            cuadrito(30, 30, 85, 85, ConsoleColor.Yellow);

            cuadrito(16, 16, 86, 86, ConsoleColor.Yellow);
            cuadrito(20, 20, 86, 86, ConsoleColor.Yellow);
            cuadrito(24, 24, 86, 86, ConsoleColor.Yellow);
            cuadrito(28, 28, 86, 86, ConsoleColor.Yellow);

            cuadrito(18, 18, 87, 87, ConsoleColor.Yellow);
            cuadrito(22, 22, 87, 87, ConsoleColor.Yellow);
            cuadrito(26, 26, 87, 87, ConsoleColor.Yellow);
            cuadrito(30, 30, 87, 87, ConsoleColor.Yellow);

            //*

            cuadrito(32, 46, 1, 10, ConsoleColor.DarkYellow);

            cuadrito(34, 34, 1, 1, ConsoleColor.Yellow);
            cuadrito(38, 38, 1, 1, ConsoleColor.Yellow);
            cuadrito(42, 42, 1, 1, ConsoleColor.Yellow);

            cuadrito(32, 32, 2, 2, ConsoleColor.Yellow);
            cuadrito(36, 36, 2, 2, ConsoleColor.Yellow);
            cuadrito(40, 40, 2, 2, ConsoleColor.Yellow);
            cuadrito(44, 44, 2, 2, ConsoleColor.Yellow);

            cuadrito(34, 34, 3, 3, ConsoleColor.Yellow);
            cuadrito(38, 38, 3, 3, ConsoleColor.Yellow);
            cuadrito(42, 42, 3, 3, ConsoleColor.Yellow);

            cuadrito(32, 32, 4, 4, ConsoleColor.Yellow);
            cuadrito(36, 36, 4, 4, ConsoleColor.Yellow);
            cuadrito(40, 40, 4, 4, ConsoleColor.Yellow);
            cuadrito(44, 44, 4, 4, ConsoleColor.Yellow);

            cuadrito(34, 34, 5, 5, ConsoleColor.Yellow);
            cuadrito(38, 38, 5, 5, ConsoleColor.Yellow);
            cuadrito(42, 42, 5, 5, ConsoleColor.Yellow);

            cuadrito(32, 32, 6, 6, ConsoleColor.Yellow);
            cuadrito(36, 36, 6, 6, ConsoleColor.Yellow);
            cuadrito(40, 40, 6, 6, ConsoleColor.Yellow);
            cuadrito(44, 44, 6, 6, ConsoleColor.Yellow);

            cuadrito(34, 34, 7, 7, ConsoleColor.Yellow);
            cuadrito(38, 38, 7, 7, ConsoleColor.Yellow);
            cuadrito(42, 42, 7, 7, ConsoleColor.Yellow);

            cuadrito(32, 32, 8, 8, ConsoleColor.Yellow);
            cuadrito(36, 36, 8, 8, ConsoleColor.Yellow);
            cuadrito(40, 40, 8, 8, ConsoleColor.Yellow);
            cuadrito(44, 44, 8, 8, ConsoleColor.Yellow);

            cuadrito(34, 34, 9, 9, ConsoleColor.Yellow);
            cuadrito(38, 38, 9, 9, ConsoleColor.Yellow);
            cuadrito(42, 42, 9, 9, ConsoleColor.Yellow);

            cuadrito(32, 32, 10, 10, ConsoleColor.Yellow);
            cuadrito(36, 36, 10, 10, ConsoleColor.Yellow);
            cuadrito(40, 40, 10, 10, ConsoleColor.Yellow);
            cuadrito(44, 44, 10, 10, ConsoleColor.Yellow);

            //*
            cuadrito(32, 46, 11, 21, ConsoleColor.DarkCyan);

            cuadrito(34, 34, 11, 11, ConsoleColor.Cyan);
            cuadrito(38, 38, 11, 11, ConsoleColor.Cyan);
            cuadrito(42, 42, 11, 11, ConsoleColor.Cyan);

            cuadrito(32, 32, 12, 12, ConsoleColor.Cyan);
            cuadrito(36, 36, 12, 12, ConsoleColor.Cyan);
            cuadrito(40, 40, 12, 12, ConsoleColor.Cyan);
            cuadrito(44, 44, 12, 12, ConsoleColor.Cyan);

            cuadrito(34, 34, 13, 13, ConsoleColor.Cyan);
            cuadrito(38, 38, 13, 13, ConsoleColor.Cyan);
            cuadrito(42, 42, 13, 13, ConsoleColor.Cyan);

            cuadrito(32, 32, 14, 14, ConsoleColor.Cyan);
            cuadrito(36, 36, 14, 14, ConsoleColor.Cyan);
            cuadrito(40, 40, 14, 14, ConsoleColor.Cyan);
            cuadrito(44, 44, 14, 14, ConsoleColor.Cyan);

            cuadrito(34, 34, 15, 15, ConsoleColor.Cyan);
            cuadrito(38, 38, 15, 15, ConsoleColor.Cyan);
            cuadrito(42, 42, 15, 15, ConsoleColor.Cyan);

            cuadrito(32, 32, 16, 16, ConsoleColor.Cyan);
            cuadrito(36, 36, 16, 16, ConsoleColor.Cyan);
            cuadrito(40, 40, 16, 16, ConsoleColor.Cyan);
            cuadrito(44, 44, 16, 16, ConsoleColor.Cyan);

            cuadrito(34, 34, 17, 17, ConsoleColor.Cyan);
            cuadrito(38, 38, 17, 17, ConsoleColor.Cyan);
            cuadrito(42, 42, 17, 17, ConsoleColor.Cyan);

            cuadrito(32, 32, 18, 18, ConsoleColor.Cyan);
            cuadrito(36, 36, 18, 18, ConsoleColor.Cyan);
            cuadrito(40, 40, 18, 18, ConsoleColor.Cyan);
            cuadrito(44, 44, 18, 18, ConsoleColor.Cyan);

            cuadrito(34, 34, 19, 19, ConsoleColor.Cyan);
            cuadrito(38, 38, 19, 19, ConsoleColor.Cyan);
            cuadrito(42, 42, 19, 19, ConsoleColor.Cyan);

            cuadrito(32, 32, 20, 20, ConsoleColor.Cyan);
            cuadrito(36, 36, 20, 20, ConsoleColor.Cyan);
            cuadrito(40, 40, 20, 20, ConsoleColor.Cyan);
            cuadrito(44, 44, 20, 20, ConsoleColor.Cyan);

            cuadrito(34, 34, 21, 21, ConsoleColor.Cyan);
            cuadrito(38, 38, 21, 21, ConsoleColor.Cyan);
            cuadrito(42, 42, 21, 21, ConsoleColor.Cyan);

            //*

            cuadrito(32, 46, 22, 32, ConsoleColor.DarkYellow);

            cuadrito(32, 32, 22, 22, ConsoleColor.Yellow);
            cuadrito(36, 36, 22, 22, ConsoleColor.Yellow);
            cuadrito(40, 40, 22, 22, ConsoleColor.Yellow);
            cuadrito(44, 44, 22, 22, ConsoleColor.Yellow);

            cuadrito(34, 34, 23, 23, ConsoleColor.Yellow);
            cuadrito(38, 38, 23, 23, ConsoleColor.Yellow);
            cuadrito(42, 42, 23, 23, ConsoleColor.Yellow);

            cuadrito(32, 32, 24, 24, ConsoleColor.Yellow);
            cuadrito(36, 36, 24, 24, ConsoleColor.Yellow);
            cuadrito(40, 40, 24, 24, ConsoleColor.Yellow);
            cuadrito(44, 44, 24, 24, ConsoleColor.Yellow);

            cuadrito(34, 34, 25, 25, ConsoleColor.Yellow);
            cuadrito(38, 38, 25, 25, ConsoleColor.Yellow);
            cuadrito(42, 42, 25, 25, ConsoleColor.Yellow);

            cuadrito(32, 32, 26, 26, ConsoleColor.Yellow);
            cuadrito(36, 36, 26, 26, ConsoleColor.Yellow);
            cuadrito(40, 40, 26, 26, ConsoleColor.Yellow);
            cuadrito(44, 44, 26, 26, ConsoleColor.Yellow);

            cuadrito(34, 34, 27, 27, ConsoleColor.Yellow);
            cuadrito(38, 38, 27, 27, ConsoleColor.Yellow);
            cuadrito(42, 42, 27, 27, ConsoleColor.Yellow);

            cuadrito(32, 32, 28, 28, ConsoleColor.Yellow);
            cuadrito(36, 36, 28, 28, ConsoleColor.Yellow);
            cuadrito(40, 40, 28, 28, ConsoleColor.Yellow);
            cuadrito(44, 44, 28, 28, ConsoleColor.Yellow);

            cuadrito(34, 34, 29, 29, ConsoleColor.Yellow);
            cuadrito(38, 38, 29, 29, ConsoleColor.Yellow);
            cuadrito(42, 42, 29, 29, ConsoleColor.Yellow);

            cuadrito(32, 32, 30, 30, ConsoleColor.Yellow);
            cuadrito(36, 36, 30, 30, ConsoleColor.Yellow);
            cuadrito(40, 40, 30, 30, ConsoleColor.Yellow);
            cuadrito(44, 44, 30, 30, ConsoleColor.Yellow);

            cuadrito(34, 34, 31, 31, ConsoleColor.Yellow);
            cuadrito(38, 38, 31, 31, ConsoleColor.Yellow);
            cuadrito(42, 42, 31, 31, ConsoleColor.Yellow);

            cuadrito(32, 32, 32, 32, ConsoleColor.Yellow);
            cuadrito(36, 36, 32, 32, ConsoleColor.Yellow);
            cuadrito(40, 40, 32, 32, ConsoleColor.Yellow);
            cuadrito(44, 44, 32, 32, ConsoleColor.Yellow);

            //*
            cuadrito(32, 46, 33, 43, ConsoleColor.DarkCyan);

            cuadrito(34, 34, 33, 33, ConsoleColor.Cyan);
            cuadrito(38, 38, 33, 33, ConsoleColor.Cyan);
            cuadrito(42, 42, 33, 33, ConsoleColor.Cyan);

            cuadrito(32, 32, 34, 34, ConsoleColor.Cyan);
            cuadrito(36, 36, 34, 34, ConsoleColor.Cyan);
            cuadrito(40, 40, 34, 34, ConsoleColor.Cyan);
            cuadrito(44, 44, 34, 34, ConsoleColor.Cyan);

            cuadrito(34, 34, 35, 35, ConsoleColor.Cyan);
            cuadrito(38, 38, 35, 35, ConsoleColor.Cyan);
            cuadrito(42, 42, 35, 35, ConsoleColor.Cyan);

            cuadrito(32, 32, 36, 36, ConsoleColor.Cyan);
            cuadrito(36, 36, 36, 36, ConsoleColor.Cyan);
            cuadrito(40, 40, 36, 36, ConsoleColor.Cyan);
            cuadrito(44, 44, 36, 36, ConsoleColor.Cyan);

            cuadrito(34, 34, 37, 37, ConsoleColor.Cyan);
            cuadrito(38, 38, 37, 37, ConsoleColor.Cyan);
            cuadrito(42, 42, 37, 37, ConsoleColor.Cyan);

            cuadrito(32, 32, 38, 38, ConsoleColor.Cyan);
            cuadrito(36, 36, 38, 38, ConsoleColor.Cyan);
            cuadrito(40, 40, 38, 38, ConsoleColor.Cyan);
            cuadrito(44, 44, 38, 38, ConsoleColor.Cyan);

            cuadrito(34, 34, 39, 39, ConsoleColor.Cyan);
            cuadrito(38, 38, 39, 39, ConsoleColor.Cyan);
            cuadrito(42, 42, 39, 39, ConsoleColor.Cyan);

            cuadrito(32, 32, 40, 40, ConsoleColor.Cyan);
            cuadrito(36, 36, 40, 40, ConsoleColor.Cyan);
            cuadrito(40, 40, 40, 40, ConsoleColor.Cyan);
            cuadrito(44, 44, 40, 40, ConsoleColor.Cyan);

            cuadrito(34, 34, 41, 41, ConsoleColor.Cyan);
            cuadrito(38, 38, 41, 41, ConsoleColor.Cyan);
            cuadrito(42, 42, 41, 41, ConsoleColor.Cyan);

            cuadrito(32, 32, 42, 42, ConsoleColor.Cyan);
            cuadrito(36, 36, 42, 42, ConsoleColor.Cyan);
            cuadrito(40, 40, 42, 42, ConsoleColor.Cyan);
            cuadrito(44, 44, 42, 42, ConsoleColor.Cyan);

            cuadrito(34, 34, 43, 43, ConsoleColor.Cyan);
            cuadrito(38, 38, 43, 43, ConsoleColor.Cyan);
            cuadrito(42, 42, 43, 43, ConsoleColor.Cyan);

            //*

            cuadrito(32, 46, 44, 54, ConsoleColor.DarkYellow);

            cuadrito(32, 32, 44, 44, ConsoleColor.Yellow);
            cuadrito(36, 36, 44, 44, ConsoleColor.Yellow);
            cuadrito(40, 40, 44, 44, ConsoleColor.Yellow);
            cuadrito(44, 44, 44, 44, ConsoleColor.Yellow);

            cuadrito(34, 34, 45, 45, ConsoleColor.Yellow);
            cuadrito(38, 38, 45, 45, ConsoleColor.Yellow);
            cuadrito(42, 42, 45, 45, ConsoleColor.Yellow);

            cuadrito(32, 32, 46, 46, ConsoleColor.Yellow);
            cuadrito(36, 36, 46, 46, ConsoleColor.Yellow);
            cuadrito(40, 40, 46, 46, ConsoleColor.Yellow);
            cuadrito(44, 44, 46, 46, ConsoleColor.Yellow);

            cuadrito(34, 34, 47, 47, ConsoleColor.Yellow);
            cuadrito(38, 38, 47, 47, ConsoleColor.Yellow);
            cuadrito(42, 42, 47, 47, ConsoleColor.Yellow);

            cuadrito(32, 32, 48, 48, ConsoleColor.Yellow);
            cuadrito(36, 36, 48, 48, ConsoleColor.Yellow);
            cuadrito(40, 40, 48, 48, ConsoleColor.Yellow);
            cuadrito(44, 44, 48, 48, ConsoleColor.Yellow);

            cuadrito(34, 34, 49, 49, ConsoleColor.Yellow);
            cuadrito(38, 38, 49, 49, ConsoleColor.Yellow);
            cuadrito(42, 42, 49, 49, ConsoleColor.Yellow);

            cuadrito(32, 32, 50, 50, ConsoleColor.Yellow);
            cuadrito(36, 36, 50, 50, ConsoleColor.Yellow);
            cuadrito(40, 40, 50, 50, ConsoleColor.Yellow);
            cuadrito(44, 44, 50, 50, ConsoleColor.Yellow);

            cuadrito(34, 34, 51, 51, ConsoleColor.Yellow);
            cuadrito(38, 38, 51, 51, ConsoleColor.Yellow);
            cuadrito(42, 42, 51, 51, ConsoleColor.Yellow);

            cuadrito(32, 32, 52, 52, ConsoleColor.Yellow);
            cuadrito(36, 36, 52, 52, ConsoleColor.Yellow);
            cuadrito(40, 40, 52, 52, ConsoleColor.Yellow);
            cuadrito(44, 44, 52, 52, ConsoleColor.Yellow);

            cuadrito(34, 34, 53, 53, ConsoleColor.Yellow);
            cuadrito(38, 38, 53, 53, ConsoleColor.Yellow);
            cuadrito(42, 42, 53, 53, ConsoleColor.Yellow);

            cuadrito(32, 32, 54, 54, ConsoleColor.Yellow);
            cuadrito(36, 36, 54, 54, ConsoleColor.Yellow);
            cuadrito(40, 40, 54, 54, ConsoleColor.Yellow);
            cuadrito(44, 44, 54, 54, ConsoleColor.Yellow);

            //*
            cuadrito(32, 46, 55, 65, ConsoleColor.DarkCyan);

            cuadrito(34, 34, 55, 55, ConsoleColor.Cyan);
            cuadrito(38, 38, 55, 55, ConsoleColor.Cyan);
            cuadrito(42, 42, 55, 55, ConsoleColor.Cyan);

            cuadrito(32, 32, 56, 56, ConsoleColor.Cyan);
            cuadrito(36, 36, 56, 56, ConsoleColor.Cyan);
            cuadrito(40, 40, 56, 56, ConsoleColor.Cyan);
            cuadrito(44, 44, 56, 56, ConsoleColor.Cyan);

            cuadrito(34, 34, 57, 57, ConsoleColor.Cyan);
            cuadrito(38, 38, 57, 57, ConsoleColor.Cyan);
            cuadrito(42, 42, 57, 57, ConsoleColor.Cyan);

            cuadrito(32, 32, 58, 58, ConsoleColor.Cyan);
            cuadrito(36, 36, 58, 58, ConsoleColor.Cyan);
            cuadrito(40, 40, 58, 58, ConsoleColor.Cyan);
            cuadrito(44, 44, 58, 58, ConsoleColor.Cyan);

            cuadrito(34, 34, 59, 59, ConsoleColor.Cyan);
            cuadrito(38, 38, 59, 59, ConsoleColor.Cyan);
            cuadrito(42, 42, 59, 59, ConsoleColor.Cyan);

            cuadrito(32, 32, 60, 60, ConsoleColor.Cyan);
            cuadrito(36, 36, 60, 60, ConsoleColor.Cyan);
            cuadrito(40, 40, 60, 60, ConsoleColor.Cyan);
            cuadrito(44, 44, 60, 60, ConsoleColor.Cyan);

            cuadrito(34, 34, 61, 61, ConsoleColor.Cyan);
            cuadrito(38, 38, 61, 61, ConsoleColor.Cyan);
            cuadrito(42, 42, 61, 61, ConsoleColor.Cyan);

            cuadrito(32, 32, 62, 62, ConsoleColor.Cyan);
            cuadrito(36, 36, 62, 62, ConsoleColor.Cyan);
            cuadrito(40, 40, 62, 62, ConsoleColor.Cyan);
            cuadrito(44, 44, 62, 62, ConsoleColor.Cyan);

            cuadrito(34, 34, 63, 63, ConsoleColor.Cyan);
            cuadrito(38, 38, 63, 63, ConsoleColor.Cyan);
            cuadrito(42, 42, 63, 63, ConsoleColor.Cyan);

            cuadrito(32, 32, 64, 64, ConsoleColor.Cyan);
            cuadrito(36, 36, 64, 64, ConsoleColor.Cyan);
            cuadrito(40, 40, 64, 64, ConsoleColor.Cyan);
            cuadrito(44, 44, 64, 64, ConsoleColor.Cyan);

            cuadrito(34, 34, 65, 65, ConsoleColor.Cyan);
            cuadrito(38, 38, 65, 65, ConsoleColor.Cyan);
            cuadrito(42, 42, 65, 65, ConsoleColor.Cyan);

            //*
            cuadrito(32, 46, 66, 76, ConsoleColor.DarkYellow);

            cuadrito(32, 32, 66, 66, ConsoleColor.Yellow);
            cuadrito(36, 36, 66, 66, ConsoleColor.Yellow);
            cuadrito(40, 40, 66, 66, ConsoleColor.Yellow);
            cuadrito(44, 44, 66, 66, ConsoleColor.Yellow);

            cuadrito(34, 34, 67, 67, ConsoleColor.Yellow);
            cuadrito(38, 38, 67, 67, ConsoleColor.Yellow);
            cuadrito(42, 42, 67, 67, ConsoleColor.Yellow);

            cuadrito(32, 32, 68, 68, ConsoleColor.Yellow);
            cuadrito(36, 36, 68, 68, ConsoleColor.Yellow);
            cuadrito(40, 40, 68, 68, ConsoleColor.Yellow);
            cuadrito(44, 44, 68, 68, ConsoleColor.Yellow);

            cuadrito(34, 34, 69, 69, ConsoleColor.Yellow);
            cuadrito(38, 38, 69, 69, ConsoleColor.Yellow);
            cuadrito(42, 42, 69, 69, ConsoleColor.Yellow);

            cuadrito(32, 32, 70, 70, ConsoleColor.Yellow);
            cuadrito(36, 36, 70, 70, ConsoleColor.Yellow);
            cuadrito(40, 40, 70, 70, ConsoleColor.Yellow);
            cuadrito(44, 44, 70, 70, ConsoleColor.Yellow);

            cuadrito(34, 34, 71, 71, ConsoleColor.Yellow);
            cuadrito(38, 38, 71, 71, ConsoleColor.Yellow);
            cuadrito(42, 42, 71, 71, ConsoleColor.Yellow);

            cuadrito(32, 32, 72, 72, ConsoleColor.Yellow);
            cuadrito(36, 36, 72, 72, ConsoleColor.Yellow);
            cuadrito(40, 40, 72, 72, ConsoleColor.Yellow);
            cuadrito(44, 44, 72, 72, ConsoleColor.Yellow);

            cuadrito(34, 34, 73, 73, ConsoleColor.Yellow);
            cuadrito(38, 38, 73, 73, ConsoleColor.Yellow);
            cuadrito(42, 42, 73, 73, ConsoleColor.Yellow);

            cuadrito(32, 32, 74, 74, ConsoleColor.Yellow);
            cuadrito(36, 36, 74, 74, ConsoleColor.Yellow);
            cuadrito(40, 40, 74, 74, ConsoleColor.Yellow);
            cuadrito(44, 44, 74, 74, ConsoleColor.Yellow);

            cuadrito(34, 34, 75, 75, ConsoleColor.Yellow);
            cuadrito(38, 38, 75, 75, ConsoleColor.Yellow);
            cuadrito(42, 42, 75, 75, ConsoleColor.Yellow);

            cuadrito(32, 32, 76, 76, ConsoleColor.Yellow);
            cuadrito(36, 36, 76, 76, ConsoleColor.Yellow);
            cuadrito(40, 40, 76, 76, ConsoleColor.Yellow);
            cuadrito(44, 44, 76, 76, ConsoleColor.Yellow);

            //*
            cuadrito(32, 46, 77, 87, ConsoleColor.DarkCyan);

            cuadrito(34, 34, 77, 77, ConsoleColor.Cyan);
            cuadrito(38, 38, 77, 77, ConsoleColor.Cyan);
            cuadrito(42, 42, 77, 77, ConsoleColor.Cyan);

            cuadrito(32, 32, 78, 78, ConsoleColor.Cyan);
            cuadrito(36, 36, 78, 78, ConsoleColor.Cyan);
            cuadrito(40, 40, 78, 78, ConsoleColor.Cyan);
            cuadrito(44, 44, 78, 78, ConsoleColor.Cyan);

            cuadrito(34, 34, 79, 79, ConsoleColor.Cyan);
            cuadrito(38, 38, 79, 79, ConsoleColor.Cyan);
            cuadrito(42, 42, 79, 79, ConsoleColor.Cyan);

            cuadrito(32, 32, 80, 80, ConsoleColor.Cyan);
            cuadrito(36, 36, 80, 80, ConsoleColor.Cyan);
            cuadrito(40, 40, 80, 80, ConsoleColor.Cyan);
            cuadrito(44, 44, 80, 80, ConsoleColor.Cyan);

            cuadrito(34, 34, 81, 81, ConsoleColor.Cyan);
            cuadrito(38, 38, 81, 81, ConsoleColor.Cyan);
            cuadrito(42, 42, 81, 81, ConsoleColor.Cyan);

            cuadrito(32, 32, 82, 82, ConsoleColor.Cyan);
            cuadrito(36, 36, 82, 82, ConsoleColor.Cyan);
            cuadrito(40, 40, 82, 82, ConsoleColor.Cyan);
            cuadrito(44, 44, 82, 82, ConsoleColor.Cyan);

            cuadrito(34, 34, 83, 83, ConsoleColor.Cyan);
            cuadrito(38, 38, 83, 83, ConsoleColor.Cyan);
            cuadrito(42, 42, 83, 83, ConsoleColor.Cyan);

            cuadrito(32, 32, 84, 84, ConsoleColor.Cyan);
            cuadrito(36, 36, 84, 84, ConsoleColor.Cyan);
            cuadrito(40, 40, 84, 84, ConsoleColor.Cyan);
            cuadrito(44, 44, 84, 84, ConsoleColor.Cyan);

            cuadrito(34, 34, 85, 85, ConsoleColor.Cyan);
            cuadrito(38, 38, 85, 85, ConsoleColor.Cyan);
            cuadrito(42, 42, 85, 85, ConsoleColor.Cyan);

            cuadrito(32, 32, 86, 86, ConsoleColor.Cyan);
            cuadrito(36, 36, 86, 86, ConsoleColor.Cyan);
            cuadrito(40, 40, 86, 86, ConsoleColor.Cyan);
            cuadrito(44, 44, 86, 86, ConsoleColor.Cyan);

            cuadrito(34, 34, 87, 87, ConsoleColor.Cyan);
            cuadrito(38, 38, 87, 87, ConsoleColor.Cyan);
            cuadrito(42, 42, 87, 87, ConsoleColor.Cyan);

            //*

            cuadrito(46, 60, 1, 10, ConsoleColor.DarkCyan);

            cuadrito(46, 46, 1, 1, ConsoleColor.Cyan);
            cuadrito(50, 50, 1, 1, ConsoleColor.Cyan);
            cuadrito(54, 54, 1, 1, ConsoleColor.Cyan);
            cuadrito(58, 58, 1, 1, ConsoleColor.Cyan);

            cuadrito(48, 48, 2, 2, ConsoleColor.Cyan);
            cuadrito(52, 52, 2, 2, ConsoleColor.Cyan);
            cuadrito(56, 56, 2, 2, ConsoleColor.Cyan);
            cuadrito(60, 60, 2, 2, ConsoleColor.Cyan);

            cuadrito(46, 46, 3, 3, ConsoleColor.Cyan);
            cuadrito(50, 50, 3, 3, ConsoleColor.Cyan);
            cuadrito(54, 54, 3, 3, ConsoleColor.Cyan);
            cuadrito(58, 58, 3, 3, ConsoleColor.Cyan);

            cuadrito(48, 48, 4, 4, ConsoleColor.Cyan);
            cuadrito(52, 52, 4, 4, ConsoleColor.Cyan);
            cuadrito(56, 56, 4, 4, ConsoleColor.Cyan);
            cuadrito(60, 60, 4, 4, ConsoleColor.Cyan);

            cuadrito(46, 46, 5, 5, ConsoleColor.Cyan);
            cuadrito(50, 50, 5, 5, ConsoleColor.Cyan);
            cuadrito(54, 54, 5, 5, ConsoleColor.Cyan);
            cuadrito(58, 58, 5, 5, ConsoleColor.Cyan);

            cuadrito(48, 48, 6, 6, ConsoleColor.Cyan);
            cuadrito(52, 52, 6, 6, ConsoleColor.Cyan);
            cuadrito(56, 56, 6, 6, ConsoleColor.Cyan);
            cuadrito(60, 60, 6, 6, ConsoleColor.Cyan);

            cuadrito(46, 46, 7, 7, ConsoleColor.Cyan);
            cuadrito(50, 50, 7, 7, ConsoleColor.Cyan);
            cuadrito(54, 54, 7, 7, ConsoleColor.Cyan);
            cuadrito(58, 58, 7, 7, ConsoleColor.Cyan);

            cuadrito(48, 48, 8, 8, ConsoleColor.Cyan);
            cuadrito(52, 52, 8, 8, ConsoleColor.Cyan);
            cuadrito(56, 56, 8, 8, ConsoleColor.Cyan);
            cuadrito(60, 60, 8, 8, ConsoleColor.Cyan);

            cuadrito(46, 46, 9, 9, ConsoleColor.Cyan);
            cuadrito(50, 50, 9, 9, ConsoleColor.Cyan);
            cuadrito(54, 54, 9, 9, ConsoleColor.Cyan);
            cuadrito(58, 58, 9, 9, ConsoleColor.Cyan);

            cuadrito(48, 48, 10, 10, ConsoleColor.Cyan);
            cuadrito(52, 52, 10, 10, ConsoleColor.Cyan);
            cuadrito(56, 56, 10, 10, ConsoleColor.Cyan);
            cuadrito(60, 60, 10, 10, ConsoleColor.Cyan);

            //*

            cuadrito(46, 60, 11, 21, ConsoleColor.DarkYellow);

            cuadrito(46, 46, 11, 11, ConsoleColor.Yellow);
            cuadrito(50, 50, 11, 11, ConsoleColor.Yellow);
            cuadrito(54, 54, 11, 11, ConsoleColor.Yellow);
            cuadrito(58, 58, 11, 11, ConsoleColor.Yellow);

            cuadrito(48, 48, 12, 12, ConsoleColor.Yellow);
            cuadrito(52, 52, 12, 12, ConsoleColor.Yellow);
            cuadrito(56, 56, 12, 12, ConsoleColor.Yellow);
            cuadrito(60, 60, 12, 12, ConsoleColor.Yellow);

            cuadrito(46, 46, 13, 13, ConsoleColor.Yellow);
            cuadrito(50, 50, 13, 13, ConsoleColor.Yellow);
            cuadrito(54, 54, 13, 13, ConsoleColor.Yellow);
            cuadrito(58, 58, 13, 13, ConsoleColor.Yellow);

            cuadrito(48, 48, 14, 14, ConsoleColor.Yellow);
            cuadrito(52, 52, 14, 14, ConsoleColor.Yellow);
            cuadrito(56, 56, 14, 14, ConsoleColor.Yellow);
            cuadrito(60, 60, 14, 14, ConsoleColor.Yellow);

            cuadrito(46, 46, 15, 15, ConsoleColor.Yellow);
            cuadrito(50, 50, 15, 15, ConsoleColor.Yellow);
            cuadrito(54, 54, 15, 15, ConsoleColor.Yellow);
            cuadrito(58, 58, 15, 15, ConsoleColor.Yellow);

            cuadrito(48, 48, 16, 16, ConsoleColor.Yellow);
            cuadrito(52, 52, 16, 16, ConsoleColor.Yellow);
            cuadrito(56, 56, 16, 16, ConsoleColor.Yellow);
            cuadrito(60, 60, 16, 16, ConsoleColor.Yellow);

            cuadrito(46, 46, 17, 17, ConsoleColor.Yellow);
            cuadrito(50, 50, 17, 17, ConsoleColor.Yellow);
            cuadrito(54, 54, 17, 17, ConsoleColor.Yellow);
            cuadrito(58, 58, 17, 17, ConsoleColor.Yellow);

            cuadrito(48, 48, 18, 18, ConsoleColor.Yellow);
            cuadrito(52, 52, 18, 18, ConsoleColor.Yellow);
            cuadrito(56, 56, 18, 18, ConsoleColor.Yellow);
            cuadrito(60, 60, 18, 18, ConsoleColor.Yellow);

            cuadrito(46, 46, 19, 19, ConsoleColor.Yellow);
            cuadrito(50, 50, 19, 19, ConsoleColor.Yellow);
            cuadrito(54, 54, 19, 19, ConsoleColor.Yellow);
            cuadrito(58, 58, 19, 19, ConsoleColor.Yellow);

            cuadrito(48, 48, 20, 20, ConsoleColor.Yellow);
            cuadrito(52, 52, 20, 20, ConsoleColor.Yellow);
            cuadrito(56, 56, 20, 20, ConsoleColor.Yellow);
            cuadrito(60, 60, 20, 20, ConsoleColor.Yellow);

            cuadrito(46, 46, 21, 21, ConsoleColor.Yellow);
            cuadrito(50, 50, 21, 21, ConsoleColor.Yellow);
            cuadrito(54, 54, 21, 21, ConsoleColor.Yellow);
            cuadrito(58, 58, 21, 21, ConsoleColor.Yellow);

            //*

            cuadrito(46, 60, 22, 32, ConsoleColor.DarkCyan);

            cuadrito(48, 48, 22, 22, ConsoleColor.Cyan);
            cuadrito(52, 52, 22, 22, ConsoleColor.Cyan);
            cuadrito(56, 56, 22, 22, ConsoleColor.Cyan);
            cuadrito(60, 60, 22, 22, ConsoleColor.Cyan);

            cuadrito(46, 46, 23, 23, ConsoleColor.Cyan);
            cuadrito(50, 50, 23, 23, ConsoleColor.Cyan);
            cuadrito(54, 54, 23, 23, ConsoleColor.Cyan);
            cuadrito(58, 58, 23, 23, ConsoleColor.Cyan);

            cuadrito(48, 48, 24, 24, ConsoleColor.Cyan);
            cuadrito(52, 52, 24, 24, ConsoleColor.Cyan);
            cuadrito(56, 56, 24, 24, ConsoleColor.Cyan);
            cuadrito(60, 60, 24, 24, ConsoleColor.Cyan);

            cuadrito(46, 46, 25, 25, ConsoleColor.Cyan);
            cuadrito(50, 50, 25, 25, ConsoleColor.Cyan);
            cuadrito(54, 54, 25, 25, ConsoleColor.Cyan);
            cuadrito(58, 58, 25, 25, ConsoleColor.Cyan);

            cuadrito(48, 48, 26, 26, ConsoleColor.Cyan);
            cuadrito(52, 52, 26, 26, ConsoleColor.Cyan);
            cuadrito(56, 56, 26, 26, ConsoleColor.Cyan);
            cuadrito(60, 60, 26, 26, ConsoleColor.Cyan);

            cuadrito(46, 46, 27, 27, ConsoleColor.Cyan);
            cuadrito(50, 50, 27, 27, ConsoleColor.Cyan);
            cuadrito(54, 54, 27, 27, ConsoleColor.Cyan);
            cuadrito(58, 58, 27, 27, ConsoleColor.Cyan);

            cuadrito(48, 48, 28, 28, ConsoleColor.Cyan);
            cuadrito(52, 52, 28, 28, ConsoleColor.Cyan);
            cuadrito(56, 56, 28, 28, ConsoleColor.Cyan);
            cuadrito(60, 60, 28, 28, ConsoleColor.Cyan);

            cuadrito(46, 46, 29, 29, ConsoleColor.Cyan);
            cuadrito(50, 50, 29, 29, ConsoleColor.Cyan);
            cuadrito(54, 54, 29, 29, ConsoleColor.Cyan);
            cuadrito(58, 58, 29, 29, ConsoleColor.Cyan);

            cuadrito(48, 48, 30, 30, ConsoleColor.Cyan);
            cuadrito(52, 52, 30, 30, ConsoleColor.Cyan);
            cuadrito(56, 56, 30, 30, ConsoleColor.Cyan);
            cuadrito(60, 60, 30, 30, ConsoleColor.Cyan);

            cuadrito(46, 46, 31, 31, ConsoleColor.Cyan);
            cuadrito(50, 50, 31, 31, ConsoleColor.Cyan);
            cuadrito(54, 54, 31, 31, ConsoleColor.Cyan);
            cuadrito(58, 58, 31, 31, ConsoleColor.Cyan);

            cuadrito(48, 48, 32, 32, ConsoleColor.Cyan);
            cuadrito(52, 52, 32, 32, ConsoleColor.Cyan);
            cuadrito(56, 56, 32, 32, ConsoleColor.Cyan);
            cuadrito(60, 60, 32, 32, ConsoleColor.Cyan);

            //*
            cuadrito(46, 60, 33, 43, ConsoleColor.DarkYellow);

            cuadrito(46, 46, 33, 33, ConsoleColor.Yellow);
            cuadrito(50, 50, 33, 33, ConsoleColor.Yellow);
            cuadrito(54, 54, 33, 33, ConsoleColor.Yellow);
            cuadrito(58, 58, 33, 33, ConsoleColor.Yellow);

            cuadrito(48, 48, 34, 34, ConsoleColor.Yellow);
            cuadrito(52, 52, 34, 34, ConsoleColor.Yellow);
            cuadrito(56, 56, 34, 34, ConsoleColor.Yellow);
            cuadrito(60, 60, 34, 34, ConsoleColor.Yellow);

            cuadrito(46, 46, 35, 35, ConsoleColor.Yellow);
            cuadrito(50, 50, 35, 35, ConsoleColor.Yellow);
            cuadrito(54, 54, 35, 35, ConsoleColor.Yellow);
            cuadrito(58, 58, 35, 35, ConsoleColor.Yellow);

            cuadrito(48, 48, 36, 36, ConsoleColor.Yellow);
            cuadrito(52, 52, 36, 36, ConsoleColor.Yellow);
            cuadrito(56, 56, 36, 36, ConsoleColor.Yellow);
            cuadrito(60, 60, 36, 36, ConsoleColor.Yellow);

            cuadrito(46, 46, 37, 37, ConsoleColor.Yellow);
            cuadrito(50, 50, 37, 37, ConsoleColor.Yellow);
            cuadrito(54, 54, 37, 37, ConsoleColor.Yellow);
            cuadrito(58, 58, 37, 37, ConsoleColor.Yellow);

            cuadrito(48, 48, 38, 38, ConsoleColor.Yellow);
            cuadrito(52, 52, 38, 38, ConsoleColor.Yellow);
            cuadrito(56, 56, 38, 38, ConsoleColor.Yellow);
            cuadrito(60, 60, 38, 38, ConsoleColor.Yellow);

            cuadrito(46, 46, 39, 39, ConsoleColor.Yellow);
            cuadrito(50, 50, 39, 39, ConsoleColor.Yellow);
            cuadrito(54, 54, 39, 39, ConsoleColor.Yellow);
            cuadrito(58, 58, 39, 39, ConsoleColor.Yellow);

            cuadrito(48, 48, 40, 40, ConsoleColor.Yellow);
            cuadrito(52, 52, 40, 40, ConsoleColor.Yellow);
            cuadrito(56, 56, 40, 40, ConsoleColor.Yellow);
            cuadrito(60, 60, 40, 40, ConsoleColor.Yellow);

            cuadrito(46, 46, 41, 41, ConsoleColor.Yellow);
            cuadrito(50, 50, 41, 41, ConsoleColor.Yellow);
            cuadrito(54, 54, 41, 41, ConsoleColor.Yellow);
            cuadrito(58, 58, 41, 41, ConsoleColor.Yellow);

            cuadrito(48, 48, 42, 42, ConsoleColor.Yellow);
            cuadrito(52, 52, 42, 42, ConsoleColor.Yellow);
            cuadrito(56, 56, 42, 42, ConsoleColor.Yellow);
            cuadrito(60, 60, 42, 42, ConsoleColor.Yellow);

            cuadrito(46, 46, 43, 43, ConsoleColor.Yellow);
            cuadrito(50, 50, 43, 43, ConsoleColor.Yellow);
            cuadrito(54, 54, 43, 43, ConsoleColor.Yellow);
            cuadrito(58, 58, 43, 43, ConsoleColor.Yellow);

            //*
            cuadrito(46, 60, 44, 54, ConsoleColor.DarkCyan);

            cuadrito(48, 48, 44, 44, ConsoleColor.Cyan);
            cuadrito(52, 52, 44, 44, ConsoleColor.Cyan);
            cuadrito(56, 56, 44, 44, ConsoleColor.Cyan);
            cuadrito(60, 60, 44, 44, ConsoleColor.Cyan);

            cuadrito(46, 46, 45, 45, ConsoleColor.Cyan);
            cuadrito(50, 50, 45, 45, ConsoleColor.Cyan);
            cuadrito(54, 54, 45, 45, ConsoleColor.Cyan);
            cuadrito(58, 58, 45, 45, ConsoleColor.Cyan);

            cuadrito(48, 48, 46, 46, ConsoleColor.Cyan);
            cuadrito(52, 52, 46, 46, ConsoleColor.Cyan);
            cuadrito(56, 56, 46, 46, ConsoleColor.Cyan);
            cuadrito(60, 60, 46, 46, ConsoleColor.Cyan);

            cuadrito(46, 46, 47, 47, ConsoleColor.Cyan);
            cuadrito(50, 50, 47, 47, ConsoleColor.Cyan);
            cuadrito(54, 54, 47, 47, ConsoleColor.Cyan);
            cuadrito(58, 58, 47, 47, ConsoleColor.Cyan);

            cuadrito(48, 48, 48, 48, ConsoleColor.Cyan);
            cuadrito(52, 52, 48, 48, ConsoleColor.Cyan);
            cuadrito(56, 56, 48, 48, ConsoleColor.Cyan);
            cuadrito(60, 60, 48, 48, ConsoleColor.Cyan);

            cuadrito(46, 46, 49, 49, ConsoleColor.Cyan);
            cuadrito(50, 50, 49, 49, ConsoleColor.Cyan);
            cuadrito(54, 54, 49, 49, ConsoleColor.Cyan);
            cuadrito(58, 58, 49, 49, ConsoleColor.Cyan);

            cuadrito(48, 48, 50, 50, ConsoleColor.Cyan);
            cuadrito(52, 52, 50, 50, ConsoleColor.Cyan);
            cuadrito(56, 56, 50, 50, ConsoleColor.Cyan);
            cuadrito(60, 60, 50, 50, ConsoleColor.Cyan);

            cuadrito(46, 46, 51, 51, ConsoleColor.Cyan);
            cuadrito(50, 50, 51, 51, ConsoleColor.Cyan);
            cuadrito(54, 54, 51, 51, ConsoleColor.Cyan);
            cuadrito(58, 58, 51, 51, ConsoleColor.Cyan);

            cuadrito(48, 48, 52, 52, ConsoleColor.Cyan);
            cuadrito(52, 52, 52, 52, ConsoleColor.Cyan);
            cuadrito(56, 56, 52, 52, ConsoleColor.Cyan);
            cuadrito(60, 60, 52, 52, ConsoleColor.Cyan);

            cuadrito(46, 46, 53, 53, ConsoleColor.Cyan);
            cuadrito(50, 50, 53, 53, ConsoleColor.Cyan);
            cuadrito(54, 54, 53, 53, ConsoleColor.Cyan);
            cuadrito(58, 58, 53, 53, ConsoleColor.Cyan);

            cuadrito(48, 48, 54, 54, ConsoleColor.Cyan);
            cuadrito(52, 52, 54, 54, ConsoleColor.Cyan);
            cuadrito(56, 56, 54, 54, ConsoleColor.Cyan);
            cuadrito(60, 60, 54, 54, ConsoleColor.Cyan);

            //*
            cuadrito(46, 60, 55, 65, ConsoleColor.DarkYellow);

            cuadrito(46, 46, 55, 55, ConsoleColor.Yellow);
            cuadrito(50, 50, 55, 55, ConsoleColor.Yellow);
            cuadrito(54, 54, 55, 55, ConsoleColor.Yellow);
            cuadrito(58, 58, 55, 55, ConsoleColor.Yellow);

            cuadrito(48, 48, 56, 56, ConsoleColor.Yellow);
            cuadrito(52, 52, 56, 56, ConsoleColor.Yellow);
            cuadrito(56, 56, 56, 56, ConsoleColor.Yellow);
            cuadrito(60, 60, 56, 56, ConsoleColor.Yellow);

            cuadrito(46, 46, 57, 57, ConsoleColor.Yellow);
            cuadrito(50, 50, 57, 57, ConsoleColor.Yellow);
            cuadrito(54, 54, 57, 57, ConsoleColor.Yellow);
            cuadrito(58, 58, 57, 57, ConsoleColor.Yellow);

            cuadrito(48, 48, 58, 58, ConsoleColor.Yellow);
            cuadrito(52, 52, 58, 58, ConsoleColor.Yellow);
            cuadrito(56, 56, 58, 58, ConsoleColor.Yellow);
            cuadrito(60, 60, 58, 58, ConsoleColor.Yellow);

            cuadrito(46, 46, 59, 59, ConsoleColor.Yellow);
            cuadrito(50, 50, 59, 59, ConsoleColor.Yellow);
            cuadrito(54, 54, 59, 59, ConsoleColor.Yellow);
            cuadrito(58, 58, 59, 59, ConsoleColor.Yellow);

            cuadrito(48, 48, 60, 60, ConsoleColor.Yellow);
            cuadrito(52, 52, 60, 60, ConsoleColor.Yellow);
            cuadrito(56, 56, 60, 60, ConsoleColor.Yellow);
            cuadrito(60, 60, 60, 60, ConsoleColor.Yellow);

            cuadrito(46, 46, 61, 61, ConsoleColor.Yellow);
            cuadrito(50, 50, 61, 61, ConsoleColor.Yellow);
            cuadrito(54, 54, 61, 61, ConsoleColor.Yellow);
            cuadrito(58, 58, 61, 61, ConsoleColor.Yellow);

            cuadrito(48, 48, 62, 62, ConsoleColor.Yellow);
            cuadrito(52, 52, 62, 62, ConsoleColor.Yellow);
            cuadrito(56, 56, 62, 62, ConsoleColor.Yellow);
            cuadrito(60, 60, 62, 62, ConsoleColor.Yellow);

            cuadrito(46, 46, 63, 63, ConsoleColor.Yellow);
            cuadrito(50, 50, 63, 63, ConsoleColor.Yellow);
            cuadrito(54, 54, 63, 63, ConsoleColor.Yellow);
            cuadrito(58, 58, 63, 63, ConsoleColor.Yellow);

            cuadrito(48, 48, 64, 64, ConsoleColor.Yellow);
            cuadrito(52, 52, 64, 64, ConsoleColor.Yellow);
            cuadrito(56, 56, 64, 64, ConsoleColor.Yellow);
            cuadrito(60, 60, 64, 64, ConsoleColor.Yellow);

            cuadrito(46, 46, 65, 65, ConsoleColor.Yellow);
            cuadrito(50, 50, 65, 65, ConsoleColor.Yellow);
            cuadrito(54, 54, 65, 65, ConsoleColor.Yellow);
            cuadrito(58, 58, 65, 65, ConsoleColor.Yellow);

            //*

            cuadrito(46, 60, 66, 76, ConsoleColor.DarkCyan);

            cuadrito(48, 48, 66, 66, ConsoleColor.Cyan);
            cuadrito(52, 52, 66, 66, ConsoleColor.Cyan);
            cuadrito(56, 56, 66, 66, ConsoleColor.Cyan);
            cuadrito(60, 60, 66, 66, ConsoleColor.Cyan);

            cuadrito(46, 46, 67, 67, ConsoleColor.Cyan);
            cuadrito(50, 50, 67, 67, ConsoleColor.Cyan);
            cuadrito(54, 54, 67, 67, ConsoleColor.Cyan);
            cuadrito(58, 58, 67, 67, ConsoleColor.Cyan);

            cuadrito(48, 48, 68, 68, ConsoleColor.Cyan);
            cuadrito(52, 52, 68, 68, ConsoleColor.Cyan);
            cuadrito(56, 56, 68, 68, ConsoleColor.Cyan);
            cuadrito(60, 60, 68, 68, ConsoleColor.Cyan);

            cuadrito(46, 46, 69, 69, ConsoleColor.Cyan);
            cuadrito(50, 50, 69, 69, ConsoleColor.Cyan);
            cuadrito(54, 54, 69, 69, ConsoleColor.Cyan);
            cuadrito(58, 58, 69, 69, ConsoleColor.Cyan);

            cuadrito(48, 48, 70, 70, ConsoleColor.Cyan);
            cuadrito(52, 52, 70, 70, ConsoleColor.Cyan);
            cuadrito(56, 56, 70, 70, ConsoleColor.Cyan);
            cuadrito(60, 60, 70, 70, ConsoleColor.Cyan);

            cuadrito(46, 46, 71, 71, ConsoleColor.Cyan);
            cuadrito(50, 50, 71, 71, ConsoleColor.Cyan);
            cuadrito(54, 54, 71, 71, ConsoleColor.Cyan);
            cuadrito(58, 58, 71, 71, ConsoleColor.Cyan);

            cuadrito(48, 48, 72, 72, ConsoleColor.Cyan);
            cuadrito(52, 52, 72, 72, ConsoleColor.Cyan);
            cuadrito(56, 56, 72, 72, ConsoleColor.Cyan);
            cuadrito(60, 60, 72, 72, ConsoleColor.Cyan);

            cuadrito(46, 46, 73, 73, ConsoleColor.Cyan);
            cuadrito(50, 50, 73, 73, ConsoleColor.Cyan);
            cuadrito(54, 54, 73, 73, ConsoleColor.Cyan);
            cuadrito(58, 58, 73, 73, ConsoleColor.Cyan);

            cuadrito(48, 48, 74, 74, ConsoleColor.Cyan);
            cuadrito(52, 52, 74, 74, ConsoleColor.Cyan);
            cuadrito(56, 56, 74, 74, ConsoleColor.Cyan);
            cuadrito(60, 60, 74, 74, ConsoleColor.Cyan);

            cuadrito(46, 46, 75, 75, ConsoleColor.Cyan);
            cuadrito(50, 50, 75, 75, ConsoleColor.Cyan);
            cuadrito(54, 54, 75, 75, ConsoleColor.Cyan);
            cuadrito(58, 58, 75, 75, ConsoleColor.Cyan);

            cuadrito(48, 48, 76, 76, ConsoleColor.Cyan);
            cuadrito(52, 52, 76, 76, ConsoleColor.Cyan);
            cuadrito(56, 56, 76, 76, ConsoleColor.Cyan);
            cuadrito(60, 60, 76, 76, ConsoleColor.Cyan);

            //*
            cuadrito(46, 60, 77, 87, ConsoleColor.DarkYellow);

            cuadrito(46, 46, 77, 77, ConsoleColor.Yellow);
            cuadrito(50, 50, 77, 77, ConsoleColor.Yellow);
            cuadrito(54, 54, 77, 77, ConsoleColor.Yellow);
            cuadrito(58, 58, 77, 77, ConsoleColor.Yellow);

            cuadrito(48, 48, 78, 78, ConsoleColor.Yellow);
            cuadrito(52, 52, 78, 78, ConsoleColor.Yellow);
            cuadrito(56, 56, 78, 78, ConsoleColor.Yellow);
            cuadrito(60, 60, 78, 78, ConsoleColor.Yellow);

            cuadrito(46, 46, 79, 79, ConsoleColor.Yellow);
            cuadrito(50, 50, 79, 79, ConsoleColor.Yellow);
            cuadrito(54, 54, 79, 79, ConsoleColor.Yellow);
            cuadrito(58, 58, 79, 79, ConsoleColor.Yellow);

            cuadrito(48, 48, 80, 80, ConsoleColor.Yellow);
            cuadrito(52, 52, 80, 80, ConsoleColor.Yellow);
            cuadrito(56, 56, 80, 80, ConsoleColor.Yellow);
            cuadrito(60, 60, 80, 80, ConsoleColor.Yellow);

            cuadrito(46, 46, 81, 81, ConsoleColor.Yellow);
            cuadrito(50, 50, 81, 81, ConsoleColor.Yellow);
            cuadrito(54, 54, 81, 81, ConsoleColor.Yellow);
            cuadrito(58, 58, 81, 81, ConsoleColor.Yellow);

            cuadrito(48, 48, 82, 82, ConsoleColor.Yellow);
            cuadrito(52, 52, 82, 82, ConsoleColor.Yellow);
            cuadrito(56, 56, 82, 82, ConsoleColor.Yellow);
            cuadrito(60, 60, 82, 82, ConsoleColor.Yellow);

            cuadrito(46, 46, 83, 83, ConsoleColor.Yellow);
            cuadrito(50, 50, 83, 83, ConsoleColor.Yellow);
            cuadrito(54, 54, 83, 83, ConsoleColor.Yellow);
            cuadrito(58, 58, 83, 83, ConsoleColor.Yellow);

            cuadrito(48, 48, 84, 84, ConsoleColor.Yellow);
            cuadrito(52, 52, 84, 84, ConsoleColor.Yellow);
            cuadrito(56, 56, 84, 84, ConsoleColor.Yellow);
            cuadrito(60, 60, 84, 84, ConsoleColor.Yellow);

            cuadrito(46, 46, 85, 85, ConsoleColor.Yellow);
            cuadrito(50, 50, 85, 85, ConsoleColor.Yellow);
            cuadrito(54, 54, 85, 85, ConsoleColor.Yellow);
            cuadrito(58, 58, 85, 85, ConsoleColor.Yellow);

            cuadrito(48, 48, 86, 86, ConsoleColor.Yellow);
            cuadrito(52, 52, 86, 86, ConsoleColor.Yellow);
            cuadrito(56, 56, 86, 86, ConsoleColor.Yellow);
            cuadrito(60, 60, 86, 86, ConsoleColor.Yellow);

            cuadrito(46, 46, 87, 87, ConsoleColor.Yellow);
            cuadrito(50, 50, 87, 87, ConsoleColor.Yellow);
            cuadrito(54, 54, 87, 87, ConsoleColor.Yellow);
            cuadrito(58, 58, 87, 87, ConsoleColor.Yellow);

            //*

            cuadrito(62, 74, 1, 10, ConsoleColor.DarkYellow);

            cuadrito(62, 62, 1, 1, ConsoleColor.Yellow);
            cuadrito(66, 66, 1, 1, ConsoleColor.Yellow);
            cuadrito(70, 70, 1, 1, ConsoleColor.Yellow);
            cuadrito(74, 74, 1, 1, ConsoleColor.Yellow);

            cuadrito(64, 64, 2, 2, ConsoleColor.Yellow);
            cuadrito(68, 68, 2, 2, ConsoleColor.Yellow);
            cuadrito(72, 72, 2, 2, ConsoleColor.Yellow);

            cuadrito(62, 62, 3, 3, ConsoleColor.Yellow);
            cuadrito(66, 66, 3, 3, ConsoleColor.Yellow);
            cuadrito(70, 70, 3, 3, ConsoleColor.Yellow);
            cuadrito(74, 74, 3, 3, ConsoleColor.Yellow);

            cuadrito(64, 64, 4, 4, ConsoleColor.Yellow);
            cuadrito(68, 68, 4, 4, ConsoleColor.Yellow);
            cuadrito(72, 72, 4, 4, ConsoleColor.Yellow);

            cuadrito(62, 62, 5, 5, ConsoleColor.Yellow);
            cuadrito(66, 66, 5, 5, ConsoleColor.Yellow);
            cuadrito(70, 70, 5, 5, ConsoleColor.Yellow);
            cuadrito(74, 74, 5, 5, ConsoleColor.Yellow);

            cuadrito(64, 64, 6, 6, ConsoleColor.Yellow);
            cuadrito(68, 68, 6, 6, ConsoleColor.Yellow);
            cuadrito(72, 72, 6, 6, ConsoleColor.Yellow);

            cuadrito(62, 62, 7, 7, ConsoleColor.Yellow);
            cuadrito(66, 66, 7, 7, ConsoleColor.Yellow);
            cuadrito(70, 70, 7, 7, ConsoleColor.Yellow);
            cuadrito(74, 74, 7, 7, ConsoleColor.Yellow);

            cuadrito(64, 64, 8, 8, ConsoleColor.Yellow);
            cuadrito(68, 68, 8, 8, ConsoleColor.Yellow);
            cuadrito(72, 72, 8, 8, ConsoleColor.Yellow);

            cuadrito(62, 62, 9, 9, ConsoleColor.Yellow);
            cuadrito(66, 66, 9, 9, ConsoleColor.Yellow);
            cuadrito(70, 70, 9, 9, ConsoleColor.Yellow);
            cuadrito(74, 74, 9, 9, ConsoleColor.Yellow);

            cuadrito(64, 64, 10, 10, ConsoleColor.Yellow);
            cuadrito(68, 68, 10, 10, ConsoleColor.Yellow);
            cuadrito(72, 72, 10, 10, ConsoleColor.Yellow);

            //*

            cuadrito(62, 74, 11, 21, ConsoleColor.DarkCyan);

            cuadrito(62, 62, 11, 11, ConsoleColor.Cyan);
            cuadrito(66, 66, 11, 11, ConsoleColor.Cyan);
            cuadrito(70, 70, 11, 11, ConsoleColor.Cyan);
            cuadrito(74, 74, 11, 11, ConsoleColor.Cyan);

            cuadrito(64, 64, 12, 12, ConsoleColor.Cyan);
            cuadrito(68, 68, 12, 12, ConsoleColor.Cyan);
            cuadrito(72, 72, 12, 12, ConsoleColor.Cyan);

            cuadrito(62, 62, 13, 13, ConsoleColor.Cyan);
            cuadrito(66, 66, 13, 13, ConsoleColor.Cyan);
            cuadrito(70, 70, 13, 13, ConsoleColor.Cyan);
            cuadrito(74, 74, 13, 13, ConsoleColor.Cyan);

            cuadrito(64, 64, 14, 14, ConsoleColor.Cyan);
            cuadrito(68, 68, 14, 14, ConsoleColor.Cyan);
            cuadrito(72, 72, 14, 14, ConsoleColor.Cyan);

            cuadrito(62, 62, 15, 15, ConsoleColor.Cyan);
            cuadrito(66, 66, 15, 15, ConsoleColor.Cyan);
            cuadrito(70, 70, 15, 15, ConsoleColor.Cyan);
            cuadrito(74, 74, 15, 15, ConsoleColor.Cyan);

            cuadrito(64, 64, 16, 16, ConsoleColor.Cyan);
            cuadrito(68, 68, 16, 16, ConsoleColor.Cyan);
            cuadrito(72, 72, 16, 16, ConsoleColor.Cyan);

            cuadrito(62, 62, 17, 17, ConsoleColor.Cyan);
            cuadrito(66, 66, 17, 17, ConsoleColor.Cyan);
            cuadrito(70, 70, 17, 17, ConsoleColor.Cyan);
            cuadrito(74, 74, 17, 17, ConsoleColor.Cyan);

            cuadrito(64, 64, 18, 18, ConsoleColor.Cyan);
            cuadrito(68, 68, 18, 18, ConsoleColor.Cyan);
            cuadrito(72, 72, 18, 18, ConsoleColor.Cyan);

            cuadrito(62, 62, 19, 19, ConsoleColor.Cyan);
            cuadrito(66, 66, 19, 19, ConsoleColor.Cyan);
            cuadrito(70, 70, 19, 19, ConsoleColor.Cyan);
            cuadrito(74, 74, 19, 19, ConsoleColor.Cyan);

            cuadrito(64, 64, 20, 20, ConsoleColor.Cyan);
            cuadrito(68, 68, 20, 20, ConsoleColor.Cyan);
            cuadrito(72, 72, 20, 20, ConsoleColor.Cyan);

            cuadrito(62, 62, 21, 21, ConsoleColor.Cyan);
            cuadrito(66, 66, 21, 21, ConsoleColor.Cyan);
            cuadrito(70, 70, 21, 21, ConsoleColor.Cyan);
            cuadrito(74, 74, 21, 21, ConsoleColor.Cyan);

            //*

            cuadrito(62, 75, 22, 32, ConsoleColor.DarkYellow);

            cuadrito(64, 64, 22, 22, ConsoleColor.Yellow);
            cuadrito(68, 68, 22, 22, ConsoleColor.Yellow);
            cuadrito(72, 72, 22, 22, ConsoleColor.Yellow);

            cuadrito(62, 62, 23, 23, ConsoleColor.Yellow);
            cuadrito(66, 66, 23, 23, ConsoleColor.Yellow);
            cuadrito(70, 70, 23, 23, ConsoleColor.Yellow);
            cuadrito(74, 74, 23, 23, ConsoleColor.Yellow);

            cuadrito(64, 64, 24, 24, ConsoleColor.Yellow);
            cuadrito(68, 68, 24, 24, ConsoleColor.Yellow);
            cuadrito(72, 72, 24, 24, ConsoleColor.Yellow);

            cuadrito(62, 62, 25, 25, ConsoleColor.Yellow);
            cuadrito(66, 66, 25, 25, ConsoleColor.Yellow);
            cuadrito(70, 70, 25, 25, ConsoleColor.Yellow);
            cuadrito(74, 74, 25, 25, ConsoleColor.Yellow);

            cuadrito(64, 64, 26, 26, ConsoleColor.Yellow);
            cuadrito(68, 68, 26, 26, ConsoleColor.Yellow);
            cuadrito(72, 72, 26, 26, ConsoleColor.Yellow);

            cuadrito(62, 62, 27, 27, ConsoleColor.Yellow);
            cuadrito(66, 66, 27, 27, ConsoleColor.Yellow);
            cuadrito(70, 70, 27, 27, ConsoleColor.Yellow);
            cuadrito(74, 74, 27, 27, ConsoleColor.Yellow);

            cuadrito(64, 64, 28, 28, ConsoleColor.Yellow);
            cuadrito(68, 68, 28, 28, ConsoleColor.Yellow);
            cuadrito(72, 72, 28, 28, ConsoleColor.Yellow);

            cuadrito(62, 62, 29, 29, ConsoleColor.Yellow);
            cuadrito(66, 66, 29, 29, ConsoleColor.Yellow);
            cuadrito(70, 70, 29, 29, ConsoleColor.Yellow);
            cuadrito(74, 74, 29, 29, ConsoleColor.Yellow);

            cuadrito(64, 64, 30, 30, ConsoleColor.Yellow);
            cuadrito(68, 68, 30, 30, ConsoleColor.Yellow);
            cuadrito(72, 72, 30, 30, ConsoleColor.Yellow);

            cuadrito(62, 62, 31, 31, ConsoleColor.Yellow);
            cuadrito(66, 66, 31, 31, ConsoleColor.Yellow);
            cuadrito(70, 70, 31, 31, ConsoleColor.Yellow);
            cuadrito(74, 74, 31, 31, ConsoleColor.Yellow);

            cuadrito(64, 64, 32, 32, ConsoleColor.Yellow);
            cuadrito(68, 68, 32, 32, ConsoleColor.Yellow);
            cuadrito(72, 72, 32, 32, ConsoleColor.Yellow);

            //*

            cuadrito(62, 74, 33, 43, ConsoleColor.DarkCyan);

            cuadrito(62, 62, 33, 33, ConsoleColor.Cyan);
            cuadrito(66, 66, 33, 33, ConsoleColor.Cyan);
            cuadrito(70, 70, 33, 33, ConsoleColor.Cyan);
            cuadrito(74, 74, 33, 33, ConsoleColor.Cyan);

            cuadrito(64, 64, 34, 34, ConsoleColor.Cyan);
            cuadrito(68, 68, 34, 34, ConsoleColor.Cyan);
            cuadrito(72, 72, 34, 34, ConsoleColor.Cyan);

            cuadrito(62, 62, 35, 35, ConsoleColor.Cyan);
            cuadrito(66, 66, 35, 35, ConsoleColor.Cyan);
            cuadrito(70, 70, 35, 35, ConsoleColor.Cyan);
            cuadrito(74, 74, 35, 35, ConsoleColor.Cyan);

            cuadrito(64, 64, 36, 36, ConsoleColor.Cyan);
            cuadrito(68, 68, 36, 36, ConsoleColor.Cyan);
            cuadrito(72, 72, 36, 36, ConsoleColor.Cyan);

            cuadrito(62, 62, 37, 37, ConsoleColor.Cyan);
            cuadrito(66, 66, 37, 37, ConsoleColor.Cyan);
            cuadrito(70, 70, 37, 37, ConsoleColor.Cyan);
            cuadrito(74, 74, 37, 37, ConsoleColor.Cyan);

            cuadrito(64, 64, 38, 38, ConsoleColor.Cyan);
            cuadrito(68, 68, 38, 38, ConsoleColor.Cyan);
            cuadrito(72, 72, 38, 38, ConsoleColor.Cyan);

            cuadrito(62, 62, 39, 39, ConsoleColor.Cyan);
            cuadrito(66, 66, 39, 39, ConsoleColor.Cyan);
            cuadrito(70, 70, 39, 39, ConsoleColor.Cyan);
            cuadrito(74, 74, 39, 39, ConsoleColor.Cyan);

            cuadrito(64, 64, 40, 40, ConsoleColor.Cyan);
            cuadrito(68, 68, 40, 40, ConsoleColor.Cyan);
            cuadrito(72, 72, 40, 40, ConsoleColor.Cyan);

            cuadrito(62, 62, 41, 41, ConsoleColor.Cyan);
            cuadrito(66, 66, 41, 41, ConsoleColor.Cyan);
            cuadrito(70, 70, 41, 41, ConsoleColor.Cyan);
            cuadrito(74, 74, 41, 41, ConsoleColor.Cyan);

            cuadrito(64, 64, 42, 42, ConsoleColor.Cyan);
            cuadrito(68, 68, 42, 42, ConsoleColor.Cyan);
            cuadrito(72, 72, 42, 42, ConsoleColor.Cyan);

            cuadrito(62, 62, 43, 43, ConsoleColor.Cyan);
            cuadrito(66, 66, 43, 43, ConsoleColor.Cyan);
            cuadrito(70, 70, 43, 43, ConsoleColor.Cyan);
            cuadrito(74, 74, 43, 43, ConsoleColor.Cyan);

            //*
            cuadrito(62, 74, 44, 54, ConsoleColor.DarkYellow);

            cuadrito(64, 64, 44, 44, ConsoleColor.Yellow);
            cuadrito(68, 68, 44, 44, ConsoleColor.Yellow);
            cuadrito(72, 72, 44, 44, ConsoleColor.Yellow);

            cuadrito(62, 62, 45, 45, ConsoleColor.Yellow);
            cuadrito(66, 66, 45, 45, ConsoleColor.Yellow);
            cuadrito(70, 70, 45, 45, ConsoleColor.Yellow);
            cuadrito(74, 74, 45, 45, ConsoleColor.Yellow);

            cuadrito(64, 64, 46, 46, ConsoleColor.Yellow);
            cuadrito(68, 68, 46, 46, ConsoleColor.Yellow);
            cuadrito(72, 72, 46, 46, ConsoleColor.Yellow);

            cuadrito(62, 62, 47, 47, ConsoleColor.Yellow);
            cuadrito(66, 66, 47, 47, ConsoleColor.Yellow);
            cuadrito(70, 70, 47, 47, ConsoleColor.Yellow);
            cuadrito(74, 74, 47, 47, ConsoleColor.Yellow);

            cuadrito(64, 64, 48, 48, ConsoleColor.Yellow);
            cuadrito(68, 68, 48, 48, ConsoleColor.Yellow);
            cuadrito(72, 72, 48, 48, ConsoleColor.Yellow);

            cuadrito(62, 62, 49, 49, ConsoleColor.Yellow);
            cuadrito(66, 66, 49, 49, ConsoleColor.Yellow);
            cuadrito(70, 70, 49, 49, ConsoleColor.Yellow);
            cuadrito(74, 74, 49, 49, ConsoleColor.Yellow);

            cuadrito(64, 64, 50, 50, ConsoleColor.Yellow);
            cuadrito(68, 68, 50, 50, ConsoleColor.Yellow);
            cuadrito(72, 72, 50, 50, ConsoleColor.Yellow);

            cuadrito(62, 62, 51, 51, ConsoleColor.Yellow);
            cuadrito(66, 66, 51, 51, ConsoleColor.Yellow);
            cuadrito(70, 70, 51, 51, ConsoleColor.Yellow);
            cuadrito(74, 74, 51, 51, ConsoleColor.Yellow);

            cuadrito(64, 64, 52, 52, ConsoleColor.Yellow);
            cuadrito(68, 68, 52, 52, ConsoleColor.Yellow);
            cuadrito(72, 72, 52, 52, ConsoleColor.Yellow);

            cuadrito(62, 62, 53, 53, ConsoleColor.Yellow);
            cuadrito(66, 66, 53, 53, ConsoleColor.Yellow);
            cuadrito(70, 70, 53, 53, ConsoleColor.Yellow);
            cuadrito(74, 74, 53, 53, ConsoleColor.Yellow);

            cuadrito(64, 64, 54, 54, ConsoleColor.Yellow);
            cuadrito(68, 68, 54, 54, ConsoleColor.Yellow);
            cuadrito(72, 72, 54, 54, ConsoleColor.Yellow);

            //*
            cuadrito(62, 74, 55, 65, ConsoleColor.DarkCyan);

            cuadrito(62, 62, 55, 55, ConsoleColor.Cyan);
            cuadrito(66, 66, 55, 55, ConsoleColor.Cyan);
            cuadrito(70, 70, 55, 55, ConsoleColor.Cyan);
            cuadrito(74, 74, 55, 55, ConsoleColor.Cyan);

            cuadrito(64, 64, 56, 56, ConsoleColor.Cyan);
            cuadrito(68, 68, 56, 56, ConsoleColor.Cyan);
            cuadrito(72, 72, 56, 56, ConsoleColor.Cyan);

            cuadrito(62, 62, 57, 57, ConsoleColor.Cyan);
            cuadrito(66, 66, 57, 57, ConsoleColor.Cyan);
            cuadrito(70, 70, 57, 57, ConsoleColor.Cyan);
            cuadrito(74, 74, 57, 57, ConsoleColor.Cyan);

            cuadrito(64, 64, 58, 58, ConsoleColor.Cyan);
            cuadrito(68, 68, 58, 58, ConsoleColor.Cyan);
            cuadrito(72, 72, 58, 58, ConsoleColor.Cyan);

            cuadrito(62, 62, 59, 59, ConsoleColor.Cyan);
            cuadrito(66, 66, 59, 59, ConsoleColor.Cyan);
            cuadrito(70, 70, 59, 59, ConsoleColor.Cyan);
            cuadrito(74, 74, 59, 59, ConsoleColor.Cyan);

            cuadrito(64, 64, 60, 60, ConsoleColor.Cyan);
            cuadrito(68, 68, 60, 60, ConsoleColor.Cyan);
            cuadrito(72, 72, 60, 60, ConsoleColor.Cyan);

            cuadrito(62, 62, 61, 61, ConsoleColor.Cyan);
            cuadrito(66, 66, 61, 61, ConsoleColor.Cyan);
            cuadrito(70, 70, 61, 61, ConsoleColor.Cyan);
            cuadrito(74, 74, 61, 61, ConsoleColor.Cyan);

            cuadrito(64, 64, 62, 62, ConsoleColor.Cyan);
            cuadrito(68, 68, 62, 62, ConsoleColor.Cyan);
            cuadrito(72, 72, 62, 62, ConsoleColor.Cyan);

            cuadrito(62, 62, 63, 63, ConsoleColor.Cyan);
            cuadrito(66, 66, 63, 63, ConsoleColor.Cyan);
            cuadrito(70, 70, 63, 63, ConsoleColor.Cyan);
            cuadrito(74, 74, 63, 63, ConsoleColor.Cyan);

            cuadrito(64, 64, 64, 64, ConsoleColor.Cyan);
            cuadrito(68, 68, 64, 64, ConsoleColor.Cyan);
            cuadrito(72, 72, 64, 64, ConsoleColor.Cyan);

            cuadrito(62, 62, 65, 65, ConsoleColor.Cyan);
            cuadrito(66, 66, 65, 65, ConsoleColor.Cyan);
            cuadrito(70, 70, 65, 65, ConsoleColor.Cyan);
            cuadrito(74, 74, 65, 65, ConsoleColor.Cyan);

            //*
            cuadrito(62, 74, 66, 76, ConsoleColor.DarkYellow);

            cuadrito(64, 64, 66, 66, ConsoleColor.Yellow);
            cuadrito(68, 68, 66, 66, ConsoleColor.Yellow);
            cuadrito(72, 72, 66, 66, ConsoleColor.Yellow);

            cuadrito(62, 62, 67, 67, ConsoleColor.Yellow);
            cuadrito(66, 66, 67, 67, ConsoleColor.Yellow);
            cuadrito(70, 70, 67, 67, ConsoleColor.Yellow);
            cuadrito(74, 74, 67, 67, ConsoleColor.Yellow);

            cuadrito(64, 64, 68, 68, ConsoleColor.Yellow);
            cuadrito(68, 68, 68, 68, ConsoleColor.Yellow);
            cuadrito(72, 72, 68, 68, ConsoleColor.Yellow);

            cuadrito(62, 62, 69, 69, ConsoleColor.Yellow);
            cuadrito(66, 66, 69, 69, ConsoleColor.Yellow);
            cuadrito(70, 70, 69, 69, ConsoleColor.Yellow);
            cuadrito(74, 74, 69, 69, ConsoleColor.Yellow);

            cuadrito(64, 64, 70, 70, ConsoleColor.Yellow);
            cuadrito(68, 68, 70, 70, ConsoleColor.Yellow);
            cuadrito(72, 72, 70, 70, ConsoleColor.Yellow);

            cuadrito(62, 62, 71, 71, ConsoleColor.Yellow);
            cuadrito(66, 66, 71, 71, ConsoleColor.Yellow);
            cuadrito(70, 70, 71, 71, ConsoleColor.Yellow);
            cuadrito(74, 74, 71, 71, ConsoleColor.Yellow);

            cuadrito(64, 64, 72, 72, ConsoleColor.Yellow);
            cuadrito(68, 68, 72, 72, ConsoleColor.Yellow);
            cuadrito(72, 72, 72, 72, ConsoleColor.Yellow);

            cuadrito(62, 62, 73, 73, ConsoleColor.Yellow);
            cuadrito(66, 66, 73, 73, ConsoleColor.Yellow);
            cuadrito(70, 70, 73, 73, ConsoleColor.Yellow);
            cuadrito(74, 74, 73, 73, ConsoleColor.Yellow);

            cuadrito(64, 64, 74, 74, ConsoleColor.Yellow);
            cuadrito(68, 68, 74, 74, ConsoleColor.Yellow);
            cuadrito(72, 72, 74, 74, ConsoleColor.Yellow);

            cuadrito(62, 62, 75, 75, ConsoleColor.Yellow);
            cuadrito(66, 66, 75, 75, ConsoleColor.Yellow);
            cuadrito(70, 70, 75, 75, ConsoleColor.Yellow);
            cuadrito(74, 74, 75, 75, ConsoleColor.Yellow);

            cuadrito(64, 64, 76, 76, ConsoleColor.Yellow);
            cuadrito(68, 68, 76, 76, ConsoleColor.Yellow);
            cuadrito(72, 72, 76, 76, ConsoleColor.Yellow);

            //*
            cuadrito(62, 74, 77, 87, ConsoleColor.DarkCyan);

            cuadrito(62, 62, 77, 77, ConsoleColor.Cyan);
            cuadrito(66, 66, 77, 77, ConsoleColor.Cyan);
            cuadrito(70, 70, 77, 77, ConsoleColor.Cyan);
            cuadrito(74, 74, 77, 77, ConsoleColor.Cyan);

            cuadrito(64, 64, 78, 78, ConsoleColor.Cyan);
            cuadrito(68, 68, 78, 78, ConsoleColor.Cyan);
            cuadrito(72, 72, 78, 78, ConsoleColor.Cyan);

            cuadrito(62, 62, 79, 79, ConsoleColor.Cyan);
            cuadrito(66, 66, 79, 79, ConsoleColor.Cyan);
            cuadrito(70, 70, 79, 79, ConsoleColor.Cyan);
            cuadrito(74, 74, 79, 79, ConsoleColor.Cyan);

            cuadrito(64, 64, 80, 80, ConsoleColor.Cyan);
            cuadrito(68, 68, 80, 80, ConsoleColor.Cyan);
            cuadrito(72, 72, 80, 80, ConsoleColor.Cyan);

            cuadrito(62, 62, 81, 81, ConsoleColor.Cyan);
            cuadrito(66, 66, 81, 81, ConsoleColor.Cyan);
            cuadrito(70, 70, 81, 81, ConsoleColor.Cyan);
            cuadrito(74, 74, 81, 81, ConsoleColor.Cyan);

            cuadrito(64, 64, 82, 82, ConsoleColor.Cyan);
            cuadrito(68, 68, 82, 82, ConsoleColor.Cyan);
            cuadrito(72, 72, 82, 82, ConsoleColor.Cyan);

            cuadrito(62, 62, 83, 83, ConsoleColor.Cyan);
            cuadrito(66, 66, 83, 83, ConsoleColor.Cyan);
            cuadrito(70, 70, 83, 83, ConsoleColor.Cyan);
            cuadrito(74, 74, 83, 83, ConsoleColor.Cyan);

            cuadrito(64, 64, 84, 84, ConsoleColor.Cyan);
            cuadrito(68, 68, 84, 84, ConsoleColor.Cyan);
            cuadrito(72, 72, 84, 84, ConsoleColor.Cyan);

            cuadrito(62, 62, 85, 85, ConsoleColor.Cyan);
            cuadrito(66, 66, 85, 85, ConsoleColor.Cyan);
            cuadrito(70, 70, 85, 85, ConsoleColor.Cyan);
            cuadrito(74, 74, 85, 85, ConsoleColor.Cyan);

            cuadrito(64, 64, 86, 86, ConsoleColor.Cyan);
            cuadrito(68, 68, 86, 86, ConsoleColor.Cyan);
            cuadrito(72, 72, 86, 86, ConsoleColor.Cyan);

            cuadrito(62, 62, 87, 87, ConsoleColor.Cyan);
            cuadrito(66, 66, 87, 87, ConsoleColor.Cyan);
            cuadrito(70, 70, 87, 87, ConsoleColor.Cyan);
            cuadrito(74, 74, 87, 87, ConsoleColor.Cyan);

            //*

            cuadrito(76, 90, 1, 10, ConsoleColor.DarkCyan);

            cuadrito(78, 78, 1, 1, ConsoleColor.Cyan);
            cuadrito(82, 82, 1, 1, ConsoleColor.Cyan);
            cuadrito(86, 86, 1, 1, ConsoleColor.Cyan);
            cuadrito(90, 90, 1, 1, ConsoleColor.Cyan);

            cuadrito(76, 76, 2, 2, ConsoleColor.Cyan);
            cuadrito(80, 80, 2, 2, ConsoleColor.Cyan);
            cuadrito(84, 84, 2, 2, ConsoleColor.Cyan);
            cuadrito(88, 88, 2, 2, ConsoleColor.Cyan);

            cuadrito(78, 78, 3, 3, ConsoleColor.Cyan);
            cuadrito(82, 82, 3, 3, ConsoleColor.Cyan);
            cuadrito(86, 86, 3, 3, ConsoleColor.Cyan);
            cuadrito(90, 90, 3, 3, ConsoleColor.Cyan);

            cuadrito(76, 76, 4, 4, ConsoleColor.Cyan);
            cuadrito(80, 80, 4, 4, ConsoleColor.Cyan);
            cuadrito(84, 84, 4, 4, ConsoleColor.Cyan);
            cuadrito(88, 88, 4, 4, ConsoleColor.Cyan);

            cuadrito(78, 78, 5, 5, ConsoleColor.Cyan);
            cuadrito(82, 82, 5, 5, ConsoleColor.Cyan);
            cuadrito(86, 86, 5, 5, ConsoleColor.Cyan);
            cuadrito(90, 90, 5, 5, ConsoleColor.Cyan);

            cuadrito(76, 76, 6, 6, ConsoleColor.Cyan);
            cuadrito(80, 80, 6, 6, ConsoleColor.Cyan);
            cuadrito(84, 84, 6, 6, ConsoleColor.Cyan);
            cuadrito(88, 88, 6, 6, ConsoleColor.Cyan);

            cuadrito(78, 78, 7, 7, ConsoleColor.Cyan);
            cuadrito(82, 82, 7, 7, ConsoleColor.Cyan);
            cuadrito(86, 86, 7, 7, ConsoleColor.Cyan);
            cuadrito(90, 90, 7, 7, ConsoleColor.Cyan);

            cuadrito(76, 76, 8, 8, ConsoleColor.Cyan);
            cuadrito(80, 80, 8, 8, ConsoleColor.Cyan);
            cuadrito(84, 84, 8, 8, ConsoleColor.Cyan);
            cuadrito(88, 88, 8, 8, ConsoleColor.Cyan);

            cuadrito(78, 78, 9, 9, ConsoleColor.Cyan);
            cuadrito(82, 82, 9, 9, ConsoleColor.Cyan);
            cuadrito(86, 86, 9, 9, ConsoleColor.Cyan);
            cuadrito(90, 90, 9, 9, ConsoleColor.Cyan);

            cuadrito(76, 76, 10, 10, ConsoleColor.Cyan);
            cuadrito(80, 80, 10, 10, ConsoleColor.Cyan);
            cuadrito(84, 84, 10, 10, ConsoleColor.Cyan);
            cuadrito(88, 88, 10, 10, ConsoleColor.Cyan);

            //*
            cuadrito(76, 90, 11, 21, ConsoleColor.DarkYellow);

            cuadrito(78, 78, 11, 11, ConsoleColor.Yellow);
            cuadrito(82, 82, 11, 11, ConsoleColor.Yellow);
            cuadrito(86, 86, 11, 11, ConsoleColor.Yellow);
            cuadrito(90, 90, 11, 11, ConsoleColor.Yellow);

            cuadrito(76, 76, 12, 12, ConsoleColor.Yellow);
            cuadrito(80, 80, 12, 12, ConsoleColor.Yellow);
            cuadrito(84, 84, 12, 12, ConsoleColor.Yellow);
            cuadrito(88, 88, 12, 12, ConsoleColor.Yellow);

            cuadrito(78, 78, 13, 13, ConsoleColor.Yellow);
            cuadrito(82, 82, 13, 13, ConsoleColor.Yellow);
            cuadrito(86, 86, 13, 13, ConsoleColor.Yellow);
            cuadrito(90, 90, 13, 13, ConsoleColor.Yellow);

            cuadrito(76, 76, 14, 14, ConsoleColor.Yellow);
            cuadrito(80, 80, 14, 14, ConsoleColor.Yellow);
            cuadrito(84, 84, 14, 14, ConsoleColor.Yellow);
            cuadrito(88, 88, 14, 14, ConsoleColor.Yellow);

            cuadrito(78, 78, 15, 15, ConsoleColor.Yellow);
            cuadrito(82, 82, 15, 15, ConsoleColor.Yellow);
            cuadrito(86, 86, 15, 15, ConsoleColor.Yellow);
            cuadrito(90, 90, 15, 15, ConsoleColor.Yellow);

            cuadrito(76, 76, 16, 16, ConsoleColor.Yellow);
            cuadrito(80, 80, 16, 16, ConsoleColor.Yellow);
            cuadrito(84, 84, 16, 16, ConsoleColor.Yellow);
            cuadrito(88, 88, 16, 16, ConsoleColor.Yellow);

            cuadrito(78, 78, 17, 17, ConsoleColor.Yellow);
            cuadrito(82, 82, 17, 17, ConsoleColor.Yellow);
            cuadrito(86, 86, 17, 17, ConsoleColor.Yellow);
            cuadrito(90, 90, 17, 17, ConsoleColor.Yellow);

            cuadrito(76, 76, 18, 18, ConsoleColor.Yellow);
            cuadrito(80, 80, 18, 18, ConsoleColor.Yellow);
            cuadrito(84, 84, 18, 18, ConsoleColor.Yellow);
            cuadrito(88, 88, 18, 18, ConsoleColor.Yellow);

            cuadrito(78, 78, 19, 19, ConsoleColor.Yellow);
            cuadrito(82, 82, 19, 19, ConsoleColor.Yellow);
            cuadrito(86, 86, 19, 19, ConsoleColor.Yellow);
            cuadrito(90, 90, 19, 19, ConsoleColor.Yellow);

            cuadrito(76, 76, 20, 20, ConsoleColor.Yellow);
            cuadrito(80, 80, 20, 20, ConsoleColor.Yellow);
            cuadrito(84, 84, 20, 20, ConsoleColor.Yellow);
            cuadrito(88, 88, 20, 20, ConsoleColor.Yellow);

            cuadrito(78, 78, 21, 21, ConsoleColor.Yellow);
            cuadrito(82, 82, 21, 21, ConsoleColor.Yellow);
            cuadrito(86, 86, 21, 21, ConsoleColor.Yellow);
            cuadrito(90, 90, 21, 21, ConsoleColor.Yellow);

            //*
            cuadrito(76, 90, 22, 32, ConsoleColor.DarkCyan);

            cuadrito(76, 76, 22, 22, ConsoleColor.Cyan);
            cuadrito(80, 80, 22, 22, ConsoleColor.Cyan);
            cuadrito(84, 84, 22, 22, ConsoleColor.Cyan);
            cuadrito(88, 88, 22, 22, ConsoleColor.Cyan);

            cuadrito(78, 78, 23, 23, ConsoleColor.Cyan);
            cuadrito(82, 82, 23, 23, ConsoleColor.Cyan);
            cuadrito(86, 86, 23, 23, ConsoleColor.Cyan);
            cuadrito(90, 90, 23, 23, ConsoleColor.Cyan);

            cuadrito(76, 76, 24, 24, ConsoleColor.Cyan);
            cuadrito(80, 80, 24, 24, ConsoleColor.Cyan);
            cuadrito(84, 84, 24, 24, ConsoleColor.Cyan);
            cuadrito(88, 88, 24, 24, ConsoleColor.Cyan);

            cuadrito(78, 78, 25, 25, ConsoleColor.Cyan);
            cuadrito(82, 82, 25, 25, ConsoleColor.Cyan);
            cuadrito(86, 86, 25, 25, ConsoleColor.Cyan);
            cuadrito(90, 90, 25, 25, ConsoleColor.Cyan);

            cuadrito(76, 76, 26, 26, ConsoleColor.Cyan);
            cuadrito(80, 80, 26, 26, ConsoleColor.Cyan);
            cuadrito(84, 84, 26, 26, ConsoleColor.Cyan);
            cuadrito(88, 88, 26, 26, ConsoleColor.Cyan);

            cuadrito(78, 78, 27, 27, ConsoleColor.Cyan);
            cuadrito(82, 82, 27, 27, ConsoleColor.Cyan);
            cuadrito(86, 86, 27, 27, ConsoleColor.Cyan);
            cuadrito(90, 90, 27, 27, ConsoleColor.Cyan);

            cuadrito(76, 76, 28, 28, ConsoleColor.Cyan);
            cuadrito(80, 80, 28, 28, ConsoleColor.Cyan);
            cuadrito(84, 84, 28, 28, ConsoleColor.Cyan);
            cuadrito(88, 88, 28, 28, ConsoleColor.Cyan);

            cuadrito(78, 78, 29, 29, ConsoleColor.Cyan);
            cuadrito(82, 82, 29, 29, ConsoleColor.Cyan);
            cuadrito(86, 86, 29, 29, ConsoleColor.Cyan);
            cuadrito(90, 90, 29, 29, ConsoleColor.Cyan);

            cuadrito(76, 76, 30, 30, ConsoleColor.Cyan);
            cuadrito(80, 80, 30, 30, ConsoleColor.Cyan);
            cuadrito(84, 84, 30, 30, ConsoleColor.Cyan);
            cuadrito(88, 88, 30, 30, ConsoleColor.Cyan);

            cuadrito(78, 78, 31, 31, ConsoleColor.Cyan);
            cuadrito(82, 82, 31, 31, ConsoleColor.Cyan);
            cuadrito(86, 86, 31, 31, ConsoleColor.Cyan);
            cuadrito(90, 90, 31, 31, ConsoleColor.Cyan);

            cuadrito(76, 76, 32, 32, ConsoleColor.Cyan);
            cuadrito(80, 80, 32, 32, ConsoleColor.Cyan);
            cuadrito(84, 84, 32, 32, ConsoleColor.Cyan);
            cuadrito(88, 88, 32, 32, ConsoleColor.Cyan);

            //*
            cuadrito(76, 90, 33, 43, ConsoleColor.DarkYellow);

            cuadrito(78, 78, 33, 33, ConsoleColor.Yellow);
            cuadrito(82, 82, 33, 33, ConsoleColor.Yellow);
            cuadrito(86, 86, 33, 33, ConsoleColor.Yellow);
            cuadrito(90, 90, 33, 33, ConsoleColor.Yellow);

            cuadrito(76, 76, 34, 34, ConsoleColor.Yellow);
            cuadrito(80, 80, 34, 34, ConsoleColor.Yellow);
            cuadrito(84, 84, 34, 34, ConsoleColor.Yellow);
            cuadrito(88, 88, 34, 34, ConsoleColor.Yellow);

            cuadrito(78, 78, 35, 35, ConsoleColor.Yellow);
            cuadrito(82, 82, 35, 35, ConsoleColor.Yellow);
            cuadrito(86, 86, 35, 35, ConsoleColor.Yellow);
            cuadrito(90, 90, 35, 35, ConsoleColor.Yellow);

            cuadrito(76, 76, 36, 36, ConsoleColor.Yellow);
            cuadrito(80, 80, 36, 36, ConsoleColor.Yellow);
            cuadrito(84, 84, 36, 36, ConsoleColor.Yellow);
            cuadrito(88, 88, 36, 36, ConsoleColor.Yellow);

            cuadrito(78, 78, 37, 37, ConsoleColor.Yellow);
            cuadrito(82, 82, 37, 37, ConsoleColor.Yellow);
            cuadrito(86, 86, 37, 37, ConsoleColor.Yellow);
            cuadrito(90, 90, 37, 37, ConsoleColor.Yellow);

            cuadrito(76, 76, 38, 38, ConsoleColor.Yellow);
            cuadrito(80, 80, 38, 38, ConsoleColor.Yellow);
            cuadrito(84, 84, 38, 38, ConsoleColor.Yellow);
            cuadrito(88, 88, 38, 38, ConsoleColor.Yellow);

            cuadrito(78, 78, 39, 39, ConsoleColor.Yellow);
            cuadrito(82, 82, 39, 39, ConsoleColor.Yellow);
            cuadrito(86, 86, 39, 39, ConsoleColor.Yellow);
            cuadrito(90, 90, 39, 39, ConsoleColor.Yellow);

            cuadrito(76, 76, 40, 40, ConsoleColor.Yellow);
            cuadrito(80, 80, 40, 40, ConsoleColor.Yellow);
            cuadrito(84, 84, 40, 40, ConsoleColor.Yellow);
            cuadrito(88, 88, 40, 40, ConsoleColor.Yellow);

            cuadrito(78, 78, 41, 41, ConsoleColor.Yellow);
            cuadrito(82, 82, 41, 41, ConsoleColor.Yellow);
            cuadrito(86, 86, 41, 41, ConsoleColor.Yellow);
            cuadrito(90, 90, 41, 41, ConsoleColor.Yellow);

            cuadrito(76, 76, 42, 42, ConsoleColor.Yellow);
            cuadrito(80, 80, 42, 42, ConsoleColor.Yellow);
            cuadrito(84, 84, 42, 42, ConsoleColor.Yellow);
            cuadrito(88, 88, 42, 42, ConsoleColor.Yellow);

            cuadrito(78, 78, 43, 43, ConsoleColor.Yellow);
            cuadrito(82, 82, 43, 43, ConsoleColor.Yellow);
            cuadrito(86, 86, 43, 43, ConsoleColor.Yellow);
            cuadrito(90, 90, 43, 43, ConsoleColor.Yellow);

            //*
            cuadrito(76, 90, 44, 54, ConsoleColor.DarkCyan);

            cuadrito(76, 76, 44, 44, ConsoleColor.Cyan);
            cuadrito(80, 80, 44, 44, ConsoleColor.Cyan);
            cuadrito(84, 84, 44, 44, ConsoleColor.Cyan);
            cuadrito(88, 88, 44, 44, ConsoleColor.Cyan);

            cuadrito(78, 78, 45, 45, ConsoleColor.Cyan);
            cuadrito(82, 82, 45, 45, ConsoleColor.Cyan);
            cuadrito(86, 86, 45, 45, ConsoleColor.Cyan);
            cuadrito(90, 90, 45, 45, ConsoleColor.Cyan);

            cuadrito(76, 76, 46, 46, ConsoleColor.Cyan);
            cuadrito(80, 80, 46, 46, ConsoleColor.Cyan);
            cuadrito(84, 84, 46, 46, ConsoleColor.Cyan);
            cuadrito(88, 88, 46, 46, ConsoleColor.Cyan);

            cuadrito(78, 78, 47, 47, ConsoleColor.Cyan);
            cuadrito(82, 82, 47, 47, ConsoleColor.Cyan);
            cuadrito(86, 86, 47, 47, ConsoleColor.Cyan);
            cuadrito(90, 90, 47, 47, ConsoleColor.Cyan);

            cuadrito(76, 76, 48, 48, ConsoleColor.Cyan);
            cuadrito(80, 80, 48, 48, ConsoleColor.Cyan);
            cuadrito(84, 84, 48, 48, ConsoleColor.Cyan);
            cuadrito(88, 88, 48, 48, ConsoleColor.Cyan);

            cuadrito(78, 78, 49, 49, ConsoleColor.Cyan);
            cuadrito(82, 82, 49, 49, ConsoleColor.Cyan);
            cuadrito(86, 86, 49, 49, ConsoleColor.Cyan);
            cuadrito(90, 90, 49, 49, ConsoleColor.Cyan);

            cuadrito(76, 76, 50, 50, ConsoleColor.Cyan);
            cuadrito(80, 80, 50, 50, ConsoleColor.Cyan);
            cuadrito(84, 84, 50, 50, ConsoleColor.Cyan);
            cuadrito(88, 88, 50, 50, ConsoleColor.Cyan);

            cuadrito(78, 78, 51, 51, ConsoleColor.Cyan);
            cuadrito(82, 82, 51, 51, ConsoleColor.Cyan);
            cuadrito(86, 86, 51, 51, ConsoleColor.Cyan);
            cuadrito(90, 90, 51, 51, ConsoleColor.Cyan);

            cuadrito(76, 76, 52, 52, ConsoleColor.Cyan);
            cuadrito(80, 80, 52, 52, ConsoleColor.Cyan);
            cuadrito(84, 84, 52, 52, ConsoleColor.Cyan);
            cuadrito(88, 88, 52, 52, ConsoleColor.Cyan);

            cuadrito(78, 78, 53, 53, ConsoleColor.Cyan);
            cuadrito(82, 82, 53, 53, ConsoleColor.Cyan);
            cuadrito(86, 86, 53, 53, ConsoleColor.Cyan);
            cuadrito(90, 90, 53, 53, ConsoleColor.Cyan);

            cuadrito(76, 76, 54, 54, ConsoleColor.Cyan);
            cuadrito(80, 80, 54, 54, ConsoleColor.Cyan);
            cuadrito(84, 84, 54, 54, ConsoleColor.Cyan);
            cuadrito(88, 88, 54, 54, ConsoleColor.Cyan);

            //*
            cuadrito(76, 90, 55, 65, ConsoleColor.DarkYellow);

            cuadrito(78, 78, 55, 55, ConsoleColor.Yellow);
            cuadrito(82, 82, 55, 55, ConsoleColor.Yellow);
            cuadrito(86, 86, 55, 55, ConsoleColor.Yellow);
            cuadrito(90, 90, 55, 55, ConsoleColor.Yellow);

            cuadrito(76, 76, 56, 56, ConsoleColor.Yellow);
            cuadrito(80, 80, 56, 56, ConsoleColor.Yellow);
            cuadrito(84, 84, 56, 56, ConsoleColor.Yellow);
            cuadrito(88, 88, 56, 56, ConsoleColor.Yellow);

            cuadrito(78, 78, 57, 57, ConsoleColor.Yellow);
            cuadrito(82, 82, 57, 57, ConsoleColor.Yellow);
            cuadrito(86, 86, 57, 57, ConsoleColor.Yellow);
            cuadrito(90, 90, 57, 57, ConsoleColor.Yellow);

            cuadrito(76, 76, 58, 58, ConsoleColor.Yellow);
            cuadrito(80, 80, 58, 58, ConsoleColor.Yellow);
            cuadrito(84, 84, 58, 58, ConsoleColor.Yellow);
            cuadrito(88, 88, 58, 58, ConsoleColor.Yellow);

            cuadrito(78, 78, 59, 59, ConsoleColor.Yellow);
            cuadrito(82, 82, 59, 59, ConsoleColor.Yellow);
            cuadrito(86, 86, 59, 59, ConsoleColor.Yellow);
            cuadrito(90, 90, 59, 59, ConsoleColor.Yellow);

            cuadrito(76, 76, 60, 60, ConsoleColor.Yellow);
            cuadrito(80, 80, 60, 60, ConsoleColor.Yellow);
            cuadrito(84, 84, 60, 60, ConsoleColor.Yellow);
            cuadrito(88, 88, 60, 60, ConsoleColor.Yellow);

            cuadrito(78, 78, 61, 61, ConsoleColor.Yellow);
            cuadrito(82, 82, 61, 61, ConsoleColor.Yellow);
            cuadrito(86, 86, 61, 61, ConsoleColor.Yellow);
            cuadrito(90, 90, 61, 61, ConsoleColor.Yellow);

            cuadrito(76, 76, 62, 62, ConsoleColor.Yellow);
            cuadrito(80, 80, 62, 62, ConsoleColor.Yellow);
            cuadrito(84, 84, 62, 62, ConsoleColor.Yellow);
            cuadrito(88, 88, 62, 62, ConsoleColor.Yellow);

            cuadrito(78, 78, 63, 63, ConsoleColor.Yellow);
            cuadrito(82, 82, 63, 63, ConsoleColor.Yellow);
            cuadrito(86, 86, 63, 63, ConsoleColor.Yellow);
            cuadrito(90, 90, 63, 63, ConsoleColor.Yellow);

            cuadrito(76, 76, 64, 64, ConsoleColor.Yellow);
            cuadrito(80, 80, 64, 64, ConsoleColor.Yellow);
            cuadrito(84, 84, 64, 64, ConsoleColor.Yellow);
            cuadrito(88, 88, 64, 64, ConsoleColor.Yellow);

            cuadrito(78, 78, 65, 65, ConsoleColor.Yellow);
            cuadrito(82, 82, 65, 65, ConsoleColor.Yellow);
            cuadrito(86, 86, 65, 65, ConsoleColor.Yellow);
            cuadrito(90, 90, 65, 65, ConsoleColor.Yellow);

            //*
            cuadrito(76, 90, 66, 76, ConsoleColor.DarkCyan);

            cuadrito(76, 76, 66, 66, ConsoleColor.Cyan);
            cuadrito(80, 80, 66, 66, ConsoleColor.Cyan);
            cuadrito(84, 84, 66, 66, ConsoleColor.Cyan);
            cuadrito(88, 88, 66, 66, ConsoleColor.Cyan);

            cuadrito(78, 78, 67, 67, ConsoleColor.Cyan);
            cuadrito(82, 82, 67, 67, ConsoleColor.Cyan);
            cuadrito(86, 86, 67, 67, ConsoleColor.Cyan);
            cuadrito(90, 90, 67, 67, ConsoleColor.Cyan);

            cuadrito(76, 76, 68, 68, ConsoleColor.Cyan);
            cuadrito(80, 80, 68, 68, ConsoleColor.Cyan);
            cuadrito(84, 84, 68, 68, ConsoleColor.Cyan);
            cuadrito(88, 88, 68, 68, ConsoleColor.Cyan);

            cuadrito(78, 78, 69, 69, ConsoleColor.Cyan);
            cuadrito(82, 82, 69, 69, ConsoleColor.Cyan);
            cuadrito(86, 86, 69, 69, ConsoleColor.Cyan);
            cuadrito(90, 90, 69, 69, ConsoleColor.Cyan);

            cuadrito(76, 76, 70, 70, ConsoleColor.Cyan);
            cuadrito(80, 80, 70, 70, ConsoleColor.Cyan);
            cuadrito(84, 84, 70, 70, ConsoleColor.Cyan);
            cuadrito(88, 88, 70, 70, ConsoleColor.Cyan);

            cuadrito(78, 78, 71, 71, ConsoleColor.Cyan);
            cuadrito(82, 82, 71, 71, ConsoleColor.Cyan);
            cuadrito(86, 86, 71, 71, ConsoleColor.Cyan);
            cuadrito(90, 90, 71, 71, ConsoleColor.Cyan);

            cuadrito(76, 76, 72, 72, ConsoleColor.Cyan);
            cuadrito(80, 80, 72, 72, ConsoleColor.Cyan);
            cuadrito(84, 84, 72, 72, ConsoleColor.Cyan);
            cuadrito(88, 88, 72, 72, ConsoleColor.Cyan);

            cuadrito(78, 78, 73, 73, ConsoleColor.Cyan);
            cuadrito(82, 82, 73, 73, ConsoleColor.Cyan);
            cuadrito(86, 86, 73, 73, ConsoleColor.Cyan);
            cuadrito(90, 90, 73, 73, ConsoleColor.Cyan);

            cuadrito(76, 76, 74, 74, ConsoleColor.Cyan);
            cuadrito(80, 80, 74, 74, ConsoleColor.Cyan);
            cuadrito(84, 84, 74, 74, ConsoleColor.Cyan);
            cuadrito(88, 88, 74, 74, ConsoleColor.Cyan);

            cuadrito(78, 78, 75, 75, ConsoleColor.Cyan);
            cuadrito(82, 82, 75, 75, ConsoleColor.Cyan);
            cuadrito(86, 86, 75, 75, ConsoleColor.Cyan);
            cuadrito(90, 90, 75, 75, ConsoleColor.Cyan);

            cuadrito(76, 76, 76, 76, ConsoleColor.Cyan);
            cuadrito(80, 80, 76, 76, ConsoleColor.Cyan);
            cuadrito(84, 84, 76, 76, ConsoleColor.Cyan);
            cuadrito(88, 88, 76, 76, ConsoleColor.Cyan);

            //*
            cuadrito(76, 90, 77, 87, ConsoleColor.DarkYellow);

            cuadrito(78, 78, 77, 77, ConsoleColor.Yellow);
            cuadrito(82, 82, 77, 77, ConsoleColor.Yellow);
            cuadrito(86, 86, 77, 77, ConsoleColor.Yellow);
            cuadrito(90, 90, 77, 77, ConsoleColor.Yellow);

            cuadrito(76, 76, 78, 78, ConsoleColor.Yellow);
            cuadrito(80, 80, 78, 78, ConsoleColor.Yellow);
            cuadrito(84, 84, 78, 78, ConsoleColor.Yellow);
            cuadrito(88, 88, 78, 78, ConsoleColor.Yellow);

            cuadrito(78, 78, 79, 79, ConsoleColor.Yellow);
            cuadrito(82, 82, 79, 79, ConsoleColor.Yellow);
            cuadrito(86, 86, 79, 79, ConsoleColor.Yellow);
            cuadrito(90, 90, 79, 79, ConsoleColor.Yellow);

            cuadrito(76, 76, 80, 80, ConsoleColor.Yellow);
            cuadrito(80, 80, 80, 80, ConsoleColor.Yellow);
            cuadrito(84, 84, 80, 80, ConsoleColor.Yellow);
            cuadrito(88, 88, 80, 80, ConsoleColor.Yellow);

            cuadrito(78, 78, 81, 81, ConsoleColor.Yellow);
            cuadrito(82, 82, 81, 81, ConsoleColor.Yellow);
            cuadrito(86, 86, 81, 81, ConsoleColor.Yellow);
            cuadrito(90, 90, 81, 81, ConsoleColor.Yellow);

            cuadrito(76, 76, 82, 82, ConsoleColor.Yellow);
            cuadrito(80, 80, 82, 82, ConsoleColor.Yellow);
            cuadrito(84, 84, 82, 82, ConsoleColor.Yellow);
            cuadrito(88, 88, 82, 82, ConsoleColor.Yellow);

            cuadrito(78, 78, 83, 83, ConsoleColor.Yellow);
            cuadrito(82, 82, 83, 83, ConsoleColor.Yellow);
            cuadrito(86, 86, 83, 83, ConsoleColor.Yellow);
            cuadrito(90, 90, 83, 83, ConsoleColor.Yellow);

            cuadrito(76, 76, 84, 84, ConsoleColor.Yellow);
            cuadrito(80, 80, 84, 84, ConsoleColor.Yellow);
            cuadrito(84, 84, 84, 84, ConsoleColor.Yellow);
            cuadrito(88, 88, 84, 84, ConsoleColor.Yellow);

            cuadrito(78, 78, 85, 85, ConsoleColor.Yellow);
            cuadrito(82, 82, 85, 85, ConsoleColor.Yellow);
            cuadrito(86, 86, 85, 85, ConsoleColor.Yellow);
            cuadrito(90, 90, 85, 85, ConsoleColor.Yellow);

            cuadrito(76, 76, 86, 86, ConsoleColor.Yellow);
            cuadrito(80, 80, 86, 86, ConsoleColor.Yellow);
            cuadrito(84, 84, 86, 86, ConsoleColor.Yellow);
            cuadrito(88, 88, 86, 86, ConsoleColor.Yellow);

            cuadrito(78, 78, 87, 87, ConsoleColor.Yellow);
            cuadrito(82, 82, 87, 87, ConsoleColor.Yellow);
            cuadrito(86, 86, 87, 87, ConsoleColor.Yellow);
            cuadrito(90, 90, 87, 87, ConsoleColor.Yellow);

            //*

            cuadrito(92, 104, 1, 10, ConsoleColor.DarkYellow);

            cuadrito(94, 94, 1, 1, ConsoleColor.Yellow);
            cuadrito(98, 98, 1, 1, ConsoleColor.Yellow);
            cuadrito(102, 102, 1, 1, ConsoleColor.Yellow);
            cuadrito(106, 106, 1, 1, ConsoleColor.Yellow);

            cuadrito(92, 92, 2, 2, ConsoleColor.Yellow);
            cuadrito(96, 96, 2, 2, ConsoleColor.Yellow);
            cuadrito(100, 100, 2, 2, ConsoleColor.Yellow);
            cuadrito(104, 104, 2, 2, ConsoleColor.Yellow);

            cuadrito(94, 94, 3, 3, ConsoleColor.Yellow);
            cuadrito(98, 98, 3, 3, ConsoleColor.Yellow);
            cuadrito(102, 102, 3, 3, ConsoleColor.Yellow);
            cuadrito(106, 106, 3, 3, ConsoleColor.Yellow);

            cuadrito(92, 92, 4, 4, ConsoleColor.Yellow);
            cuadrito(96, 96, 4, 4, ConsoleColor.Yellow);
            cuadrito(100, 100, 4, 4, ConsoleColor.Yellow);
            cuadrito(104, 104, 4, 4, ConsoleColor.Yellow);

            cuadrito(94, 94, 5, 5, ConsoleColor.Yellow);
            cuadrito(98, 98, 5, 5, ConsoleColor.Yellow);
            cuadrito(102, 102, 5, 5, ConsoleColor.Yellow);
            cuadrito(106, 106, 5, 5, ConsoleColor.Yellow);

            cuadrito(92, 92, 6, 6, ConsoleColor.Yellow);
            cuadrito(96, 96, 6, 6, ConsoleColor.Yellow);
            cuadrito(100, 100, 6, 6, ConsoleColor.Yellow);
            cuadrito(104, 104, 6, 6, ConsoleColor.Yellow);

            cuadrito(94, 94, 7, 7, ConsoleColor.Yellow);
            cuadrito(98, 98, 7, 7, ConsoleColor.Yellow);
            cuadrito(102, 102, 7, 7, ConsoleColor.Yellow);
            cuadrito(106, 106, 7, 7, ConsoleColor.Yellow);

            cuadrito(92, 92, 8, 8, ConsoleColor.Yellow);
            cuadrito(96, 96, 8, 8, ConsoleColor.Yellow);
            cuadrito(100, 100, 8, 8, ConsoleColor.Yellow);
            cuadrito(104, 104, 8, 8, ConsoleColor.Yellow);

            cuadrito(94, 94, 9, 9, ConsoleColor.Yellow);
            cuadrito(98, 98, 9, 9, ConsoleColor.Yellow);
            cuadrito(102, 102, 9, 9, ConsoleColor.Yellow);
            cuadrito(106, 106, 9, 9, ConsoleColor.Yellow);

            cuadrito(92, 92, 10, 10, ConsoleColor.Yellow);
            cuadrito(96, 96, 10, 10, ConsoleColor.Yellow);
            cuadrito(100, 100, 10, 10, ConsoleColor.Yellow);
            cuadrito(104, 104, 10, 10, ConsoleColor.Yellow);

            //*
            cuadrito(92, 104, 11, 21, ConsoleColor.DarkCyan);

            cuadrito(94, 94, 11, 11, ConsoleColor.Cyan);
            cuadrito(98, 98, 11, 11, ConsoleColor.Cyan);
            cuadrito(102, 102, 11, 11, ConsoleColor.Cyan);
            cuadrito(106, 106, 11, 11, ConsoleColor.Cyan);

            cuadrito(92, 92, 12, 12, ConsoleColor.Cyan);
            cuadrito(96, 96, 12, 12, ConsoleColor.Cyan);
            cuadrito(100, 100, 12, 12, ConsoleColor.Cyan);
            cuadrito(104, 104, 12, 12, ConsoleColor.Cyan);

            cuadrito(94, 94, 13, 13, ConsoleColor.Cyan);
            cuadrito(98, 98, 13, 13, ConsoleColor.Cyan);
            cuadrito(102, 102, 13, 13, ConsoleColor.Cyan);
            cuadrito(106, 106, 13, 13, ConsoleColor.Cyan);

            cuadrito(92, 92, 14, 14, ConsoleColor.Cyan);
            cuadrito(96, 96, 14, 14, ConsoleColor.Cyan);
            cuadrito(100, 100, 14, 14, ConsoleColor.Cyan);
            cuadrito(104, 104, 14, 14, ConsoleColor.Cyan);

            cuadrito(94, 94, 15, 15, ConsoleColor.Cyan);
            cuadrito(98, 98, 15, 15, ConsoleColor.Cyan);
            cuadrito(102, 102, 15, 15, ConsoleColor.Cyan);
            cuadrito(106, 106, 15, 15, ConsoleColor.Cyan);

            cuadrito(92, 92, 16, 16, ConsoleColor.Cyan);
            cuadrito(96, 96, 16, 16, ConsoleColor.Cyan);
            cuadrito(100, 100, 16, 16, ConsoleColor.Cyan);
            cuadrito(104, 104, 16, 16, ConsoleColor.Cyan);

            cuadrito(94, 94, 17, 17, ConsoleColor.Cyan);
            cuadrito(98, 98, 17, 17, ConsoleColor.Cyan);
            cuadrito(102, 102, 17, 17, ConsoleColor.Cyan);
            cuadrito(106, 106, 17, 17, ConsoleColor.Cyan);

            cuadrito(92, 92, 18, 18, ConsoleColor.Cyan);
            cuadrito(96, 96, 18, 18, ConsoleColor.Cyan);
            cuadrito(100, 100, 18, 18, ConsoleColor.Cyan);
            cuadrito(104, 104, 18, 18, ConsoleColor.Cyan);

            cuadrito(94, 94, 19, 19, ConsoleColor.Cyan);
            cuadrito(98, 98, 19, 19, ConsoleColor.Cyan);
            cuadrito(102, 102, 19, 19, ConsoleColor.Cyan);
            cuadrito(106, 106, 19, 19, ConsoleColor.Cyan);

            cuadrito(92, 92, 20, 20, ConsoleColor.Cyan);
            cuadrito(96, 96, 20, 20, ConsoleColor.Cyan);
            cuadrito(100, 100, 20, 20, ConsoleColor.Cyan);
            cuadrito(104, 104, 20, 20, ConsoleColor.Cyan);

            cuadrito(94, 94, 21, 21, ConsoleColor.Cyan);
            cuadrito(98, 98, 21, 21, ConsoleColor.Cyan);
            cuadrito(102, 102, 21, 21, ConsoleColor.Cyan);
            cuadrito(106, 106, 21, 21, ConsoleColor.Cyan);

            //*
            cuadrito(92, 104, 22, 32, ConsoleColor.DarkYellow);

            cuadrito(92, 92, 22, 22, ConsoleColor.Yellow);
            cuadrito(96, 96, 22, 22, ConsoleColor.Yellow);
            cuadrito(100, 100, 22, 22, ConsoleColor.Yellow);
            cuadrito(104, 104, 22, 22, ConsoleColor.Yellow);

            cuadrito(94, 94, 23, 23, ConsoleColor.Yellow);
            cuadrito(98, 98, 23, 23, ConsoleColor.Yellow);
            cuadrito(102, 102, 23, 23, ConsoleColor.Yellow);
            cuadrito(106, 106, 23, 23, ConsoleColor.Yellow);

            cuadrito(92, 92, 24, 24, ConsoleColor.Yellow);
            cuadrito(96, 96, 24, 24, ConsoleColor.Yellow);
            cuadrito(100, 100, 24, 24, ConsoleColor.Yellow);
            cuadrito(104, 104, 24, 24, ConsoleColor.Yellow);

            cuadrito(94, 94, 25, 25, ConsoleColor.Yellow);
            cuadrito(98, 98, 25, 25, ConsoleColor.Yellow);
            cuadrito(102, 102, 25, 25, ConsoleColor.Yellow);
            cuadrito(106, 106, 25, 25, ConsoleColor.Yellow);

            cuadrito(92, 92, 26, 26, ConsoleColor.Yellow);
            cuadrito(96, 96, 26, 26, ConsoleColor.Yellow);
            cuadrito(100, 100, 26, 26, ConsoleColor.Yellow);
            cuadrito(104, 104, 26, 26, ConsoleColor.Yellow);

            cuadrito(94, 94, 27, 27, ConsoleColor.Yellow);
            cuadrito(98, 98, 27, 27, ConsoleColor.Yellow);
            cuadrito(102, 102, 27, 27, ConsoleColor.Yellow);
            cuadrito(106, 106, 27, 27, ConsoleColor.Yellow);

            cuadrito(92, 92, 28, 28, ConsoleColor.Yellow);
            cuadrito(96, 96, 28, 28, ConsoleColor.Yellow);
            cuadrito(100, 100, 28, 28, ConsoleColor.Yellow);
            cuadrito(104, 104, 28, 28, ConsoleColor.Yellow);

            cuadrito(94, 94, 29, 29, ConsoleColor.Yellow);
            cuadrito(98, 98, 29, 29, ConsoleColor.Yellow);
            cuadrito(102, 102, 29, 29, ConsoleColor.Yellow);
            cuadrito(106, 106, 29, 29, ConsoleColor.Yellow);

            cuadrito(92, 92, 30, 30, ConsoleColor.Yellow);
            cuadrito(96, 96, 30, 30, ConsoleColor.Yellow);
            cuadrito(100, 100, 30, 30, ConsoleColor.Yellow);
            cuadrito(104, 104, 30, 30, ConsoleColor.Yellow);

            cuadrito(94, 94, 31, 31, ConsoleColor.Yellow);
            cuadrito(98, 98, 31, 31, ConsoleColor.Yellow);
            cuadrito(102, 102, 31, 31, ConsoleColor.Yellow);
            cuadrito(106, 106, 31, 31, ConsoleColor.Yellow);

            cuadrito(92, 92, 32, 32, ConsoleColor.Yellow);
            cuadrito(96, 96, 32, 32, ConsoleColor.Yellow);
            cuadrito(100, 100, 32, 32, ConsoleColor.Yellow);
            cuadrito(104, 104, 32, 32, ConsoleColor.Yellow);

            //**
            cuadrito(92, 104, 33, 43, ConsoleColor.DarkCyan);

            cuadrito(94, 94, 33, 33, ConsoleColor.Cyan);
            cuadrito(98, 98, 33, 33, ConsoleColor.Cyan);
            cuadrito(102, 102, 33, 33, ConsoleColor.Cyan);
            cuadrito(106, 106, 33, 33, ConsoleColor.Cyan);

            cuadrito(92, 92, 34, 34, ConsoleColor.Cyan);
            cuadrito(96, 96, 34, 34, ConsoleColor.Cyan);
            cuadrito(100, 100, 34, 34, ConsoleColor.Cyan);
            cuadrito(104, 104, 34, 34, ConsoleColor.Cyan);

            cuadrito(94, 94, 35, 35, ConsoleColor.Cyan);
            cuadrito(98, 98, 35, 35, ConsoleColor.Cyan);
            cuadrito(102, 102, 35, 35, ConsoleColor.Cyan);
            cuadrito(106, 106, 35, 35, ConsoleColor.Cyan);

            cuadrito(92, 92, 36, 36, ConsoleColor.Cyan);
            cuadrito(96, 96, 36, 36, ConsoleColor.Cyan);
            cuadrito(100, 100, 36, 36, ConsoleColor.Cyan);
            cuadrito(104, 104, 36, 36, ConsoleColor.Cyan);

            cuadrito(94, 94, 37, 37, ConsoleColor.Cyan);
            cuadrito(98, 98, 37, 37, ConsoleColor.Cyan);
            cuadrito(102, 102, 37, 37, ConsoleColor.Cyan);
            cuadrito(106, 106, 37, 37, ConsoleColor.Cyan);

            cuadrito(92, 92, 38, 38, ConsoleColor.Cyan);
            cuadrito(96, 96, 38, 38, ConsoleColor.Cyan);
            cuadrito(100, 100, 38, 38, ConsoleColor.Cyan);
            cuadrito(104, 104, 38, 38, ConsoleColor.Cyan);

            cuadrito(94, 94, 39, 39, ConsoleColor.Cyan);
            cuadrito(98, 98, 39, 39, ConsoleColor.Cyan);
            cuadrito(102, 102, 39, 39, ConsoleColor.Cyan);
            cuadrito(106, 106, 39, 39, ConsoleColor.Cyan);

            cuadrito(92, 92, 40, 40, ConsoleColor.Cyan);
            cuadrito(96, 96, 40, 40, ConsoleColor.Cyan);
            cuadrito(100, 100, 40, 40, ConsoleColor.Cyan);
            cuadrito(104, 104, 40, 40, ConsoleColor.Cyan);

            cuadrito(94, 94, 41, 41, ConsoleColor.Cyan);
            cuadrito(98, 98, 41, 41, ConsoleColor.Cyan);
            cuadrito(102, 102, 41, 41, ConsoleColor.Cyan);
            cuadrito(106, 106, 41, 41, ConsoleColor.Cyan);

            cuadrito(92, 92, 42, 42, ConsoleColor.Cyan);
            cuadrito(96, 96, 42, 42, ConsoleColor.Cyan);
            cuadrito(100, 100, 42, 42, ConsoleColor.Cyan);
            cuadrito(104, 104, 42, 42, ConsoleColor.Cyan);

            cuadrito(94, 94, 43, 43, ConsoleColor.Cyan);
            cuadrito(98, 98, 43, 43, ConsoleColor.Cyan);
            cuadrito(102, 102, 43, 43, ConsoleColor.Cyan);
            cuadrito(106, 106, 43, 43, ConsoleColor.Cyan);

            //*
            cuadrito(92, 104, 44, 54, ConsoleColor.DarkYellow);

            cuadrito(92, 92, 44, 44, ConsoleColor.Yellow);
            cuadrito(96, 96, 44, 44, ConsoleColor.Yellow);
            cuadrito(100, 100, 44, 44, ConsoleColor.Yellow);
            cuadrito(104, 104, 44, 44, ConsoleColor.Yellow);

            cuadrito(94, 94, 45, 45, ConsoleColor.Yellow);
            cuadrito(98, 98, 45, 45, ConsoleColor.Yellow);
            cuadrito(102, 102, 45, 45, ConsoleColor.Yellow);
            cuadrito(106, 106, 45, 45, ConsoleColor.Yellow);

            cuadrito(92, 92, 46, 46, ConsoleColor.Yellow);
            cuadrito(96, 96, 46, 46, ConsoleColor.Yellow);
            cuadrito(100, 100, 46, 46, ConsoleColor.Yellow);
            cuadrito(104, 104, 46, 46, ConsoleColor.Yellow);

            cuadrito(94, 94, 47, 47, ConsoleColor.Yellow);
            cuadrito(98, 98, 47, 47, ConsoleColor.Yellow);
            cuadrito(102, 102, 47, 47, ConsoleColor.Yellow);
            cuadrito(106, 106, 47, 47, ConsoleColor.Yellow);

            cuadrito(92, 92, 48, 48, ConsoleColor.Yellow);
            cuadrito(96, 96, 48, 48, ConsoleColor.Yellow);
            cuadrito(100, 100, 48, 48, ConsoleColor.Yellow);
            cuadrito(104, 104, 48, 48, ConsoleColor.Yellow);

            cuadrito(94, 94, 49, 49, ConsoleColor.Yellow);
            cuadrito(98, 98, 49, 49, ConsoleColor.Yellow);
            cuadrito(102, 102, 49, 49, ConsoleColor.Yellow);
            cuadrito(106, 106, 49, 49, ConsoleColor.Yellow);

            cuadrito(92, 92, 50, 50, ConsoleColor.Yellow);
            cuadrito(96, 96, 50, 50, ConsoleColor.Yellow);
            cuadrito(100, 100, 50, 50, ConsoleColor.Yellow);
            cuadrito(104, 104, 50, 50, ConsoleColor.Yellow);

            cuadrito(94, 94, 51, 51, ConsoleColor.Yellow);
            cuadrito(98, 98, 51, 51, ConsoleColor.Yellow);
            cuadrito(102, 102, 51, 51, ConsoleColor.Yellow);
            cuadrito(106, 106, 51, 51, ConsoleColor.Yellow);

            cuadrito(92, 92, 52, 52, ConsoleColor.Yellow);
            cuadrito(96, 96, 52, 52, ConsoleColor.Yellow);
            cuadrito(100, 100, 52, 52, ConsoleColor.Yellow);
            cuadrito(104, 104, 52, 52, ConsoleColor.Yellow);

            cuadrito(94, 94, 53, 53, ConsoleColor.Yellow);
            cuadrito(98, 98, 53, 53, ConsoleColor.Yellow);
            cuadrito(102, 102, 53, 53, ConsoleColor.Yellow);
            cuadrito(106, 106, 53, 53, ConsoleColor.Yellow);

            cuadrito(92, 92, 54, 54, ConsoleColor.Yellow);
            cuadrito(96, 96, 54, 54, ConsoleColor.Yellow);
            cuadrito(100, 100, 54, 54, ConsoleColor.Yellow);
            cuadrito(104, 104, 54, 54, ConsoleColor.Yellow);

            //*
            cuadrito(92, 104, 55, 65, ConsoleColor.DarkCyan);

            cuadrito(94, 94, 55, 55, ConsoleColor.Cyan);
            cuadrito(98, 98, 55, 55, ConsoleColor.Cyan);
            cuadrito(102, 102, 55, 55, ConsoleColor.Cyan);
            cuadrito(106, 106, 55, 55, ConsoleColor.Cyan);

            cuadrito(92, 92, 56, 56, ConsoleColor.Cyan);
            cuadrito(96, 96, 56, 56, ConsoleColor.Cyan);
            cuadrito(100, 100, 56, 56, ConsoleColor.Cyan);
            cuadrito(104, 104, 56, 56, ConsoleColor.Cyan);

            cuadrito(94, 94, 57, 57, ConsoleColor.Cyan);
            cuadrito(98, 98, 57, 57, ConsoleColor.Cyan);
            cuadrito(102, 102, 57, 57, ConsoleColor.Cyan);
            cuadrito(106, 106, 57, 57, ConsoleColor.Cyan);

            cuadrito(92, 92, 58, 58, ConsoleColor.Cyan);
            cuadrito(96, 96, 58, 58, ConsoleColor.Cyan);
            cuadrito(100, 100, 58, 58, ConsoleColor.Cyan);
            cuadrito(104, 104, 58, 58, ConsoleColor.Cyan);

            cuadrito(94, 94, 59, 59, ConsoleColor.Cyan);
            cuadrito(98, 98, 59, 59, ConsoleColor.Cyan);
            cuadrito(102, 102, 59, 59, ConsoleColor.Cyan);
            cuadrito(106, 106, 59, 59, ConsoleColor.Cyan);

            cuadrito(92, 92, 60, 60, ConsoleColor.Cyan);
            cuadrito(96, 96, 60, 60, ConsoleColor.Cyan);
            cuadrito(100, 100, 60, 60, ConsoleColor.Cyan);
            cuadrito(104, 104, 60, 60, ConsoleColor.Cyan);

            cuadrito(94, 94, 61, 61, ConsoleColor.Cyan);
            cuadrito(98, 98, 61, 61, ConsoleColor.Cyan);
            cuadrito(102, 102, 61, 61, ConsoleColor.Cyan);
            cuadrito(106, 106, 61, 61, ConsoleColor.Cyan);

            cuadrito(92, 92, 62, 62, ConsoleColor.Cyan);
            cuadrito(96, 96, 62, 62, ConsoleColor.Cyan);
            cuadrito(100, 100, 62, 62, ConsoleColor.Cyan);
            cuadrito(104, 104, 62, 62, ConsoleColor.Cyan);

            cuadrito(94, 94, 63, 63, ConsoleColor.Cyan);
            cuadrito(98, 98, 63, 63, ConsoleColor.Cyan);
            cuadrito(102, 102, 63, 63, ConsoleColor.Cyan);
            cuadrito(106, 106, 63, 63, ConsoleColor.Cyan);

            cuadrito(92, 92, 64, 64, ConsoleColor.Cyan);
            cuadrito(96, 96, 64, 64, ConsoleColor.Cyan);
            cuadrito(100, 100, 64, 64, ConsoleColor.Cyan);
            cuadrito(104, 104, 64, 64, ConsoleColor.Cyan);

            cuadrito(94, 94, 65, 65, ConsoleColor.Cyan);
            cuadrito(98, 98, 65, 65, ConsoleColor.Cyan);
            cuadrito(102, 102, 65, 65, ConsoleColor.Cyan);
            cuadrito(106, 106, 65, 65, ConsoleColor.Cyan);

            //*
            cuadrito(92, 104, 66, 76, ConsoleColor.DarkYellow);

            cuadrito(92, 92, 66, 66, ConsoleColor.Yellow);
            cuadrito(96, 96, 66, 66, ConsoleColor.Yellow);
            cuadrito(100, 100, 66, 66, ConsoleColor.Yellow);
            cuadrito(104, 104, 66, 66, ConsoleColor.Yellow);

            cuadrito(94, 94, 67, 67, ConsoleColor.Yellow);
            cuadrito(98, 98, 67, 67, ConsoleColor.Yellow);
            cuadrito(102, 102, 67, 67, ConsoleColor.Yellow);
            cuadrito(106, 106, 67, 67, ConsoleColor.Yellow);

            cuadrito(92, 92, 68, 68, ConsoleColor.Yellow);
            cuadrito(96, 96, 68, 68, ConsoleColor.Yellow);
            cuadrito(100, 100, 68, 68, ConsoleColor.Yellow);
            cuadrito(104, 104, 68, 68, ConsoleColor.Yellow);

            cuadrito(94, 94, 69, 69, ConsoleColor.Yellow);
            cuadrito(98, 98, 69, 69, ConsoleColor.Yellow);
            cuadrito(102, 102, 69, 69, ConsoleColor.Yellow);
            cuadrito(106, 106, 69, 69, ConsoleColor.Yellow);

            cuadrito(92, 92, 70, 70, ConsoleColor.Yellow);
            cuadrito(96, 96, 70, 70, ConsoleColor.Yellow);
            cuadrito(100, 100, 70, 70, ConsoleColor.Yellow);
            cuadrito(104, 104, 70, 70, ConsoleColor.Yellow);

            cuadrito(94, 94, 71, 71, ConsoleColor.Yellow);
            cuadrito(98, 98, 71, 71, ConsoleColor.Yellow);
            cuadrito(102, 102, 71, 71, ConsoleColor.Yellow);
            cuadrito(106, 106, 71, 71, ConsoleColor.Yellow);

            cuadrito(92, 92, 72, 72, ConsoleColor.Yellow);
            cuadrito(96, 96, 72, 72, ConsoleColor.Yellow);
            cuadrito(100, 100, 72, 72, ConsoleColor.Yellow);
            cuadrito(104, 104, 72, 72, ConsoleColor.Yellow);

            cuadrito(94, 94, 73, 73, ConsoleColor.Yellow);
            cuadrito(98, 98, 73, 73, ConsoleColor.Yellow);
            cuadrito(102, 102, 73, 73, ConsoleColor.Yellow);
            cuadrito(106, 106, 73, 73, ConsoleColor.Yellow);

            cuadrito(92, 92, 74, 74, ConsoleColor.Yellow);
            cuadrito(96, 96, 74, 74, ConsoleColor.Yellow);
            cuadrito(100, 100, 74, 74, ConsoleColor.Yellow);
            cuadrito(104, 104, 74, 74, ConsoleColor.Yellow);

            cuadrito(94, 94, 75, 75, ConsoleColor.Yellow);
            cuadrito(98, 98, 75, 75, ConsoleColor.Yellow);
            cuadrito(102, 102, 75, 75, ConsoleColor.Yellow);
            cuadrito(106, 106, 75, 75, ConsoleColor.Yellow);

            cuadrito(92, 92, 76, 76, ConsoleColor.Yellow);
            cuadrito(96, 96, 76, 76, ConsoleColor.Yellow);
            cuadrito(100, 100, 76, 76, ConsoleColor.Yellow);
            cuadrito(104, 104, 76, 76, ConsoleColor.Yellow);

            //*
            cuadrito(92, 104, 77, 87, ConsoleColor.DarkCyan);

            cuadrito(94, 94, 77, 77, ConsoleColor.Cyan);
            cuadrito(98, 98, 77, 77, ConsoleColor.Cyan);
            cuadrito(102, 102, 77, 77, ConsoleColor.Cyan);
            cuadrito(106, 106, 77, 77, ConsoleColor.Cyan);

            cuadrito(92, 92, 78, 78, ConsoleColor.Cyan);
            cuadrito(96, 96, 78, 78, ConsoleColor.Cyan);
            cuadrito(100, 100, 78, 78, ConsoleColor.Cyan);
            cuadrito(104, 104, 78, 78, ConsoleColor.Cyan);

            cuadrito(94, 94, 79, 79, ConsoleColor.Cyan);
            cuadrito(98, 98, 79, 79, ConsoleColor.Cyan);
            cuadrito(102, 102, 79, 79, ConsoleColor.Cyan);
            cuadrito(106, 106, 79, 79, ConsoleColor.Cyan);

            cuadrito(92, 92, 80, 80, ConsoleColor.Cyan);
            cuadrito(96, 96, 80, 80, ConsoleColor.Cyan);
            cuadrito(100, 100, 80, 80, ConsoleColor.Cyan);
            cuadrito(104, 104, 80, 80, ConsoleColor.Cyan);

            cuadrito(94, 94, 81, 81, ConsoleColor.Cyan);
            cuadrito(98, 98, 81, 81, ConsoleColor.Cyan);
            cuadrito(102, 102, 81, 81, ConsoleColor.Cyan);
            cuadrito(106, 106, 81, 81, ConsoleColor.Cyan);

            cuadrito(92, 92, 82, 82, ConsoleColor.Cyan);
            cuadrito(96, 96, 82, 82, ConsoleColor.Cyan);
            cuadrito(100, 100, 82, 82, ConsoleColor.Cyan);
            cuadrito(104, 104, 82, 82, ConsoleColor.Cyan);

            cuadrito(94, 94, 83, 83, ConsoleColor.Cyan);
            cuadrito(98, 98, 83, 83, ConsoleColor.Cyan);
            cuadrito(102, 102, 83, 83, ConsoleColor.Cyan);
            cuadrito(106, 106, 83, 83, ConsoleColor.Cyan);

            cuadrito(92, 92, 84, 84, ConsoleColor.Cyan);
            cuadrito(96, 96, 84, 84, ConsoleColor.Cyan);
            cuadrito(100, 100, 84, 84, ConsoleColor.Cyan);
            cuadrito(104, 104, 84, 84, ConsoleColor.Cyan);

            cuadrito(94, 94, 85, 85, ConsoleColor.Cyan);
            cuadrito(98, 98, 85, 85, ConsoleColor.Cyan);
            cuadrito(102, 102, 85, 85, ConsoleColor.Cyan);
            cuadrito(106, 106, 85, 85, ConsoleColor.Cyan);

            cuadrito(92, 92, 86, 86, ConsoleColor.Cyan);
            cuadrito(96, 96, 86, 86, ConsoleColor.Cyan);
            cuadrito(100, 100, 86, 86, ConsoleColor.Cyan);
            cuadrito(104, 104, 86, 86, ConsoleColor.Cyan);

            cuadrito(94, 94, 87, 87, ConsoleColor.Cyan);
            cuadrito(98, 98, 87, 87, ConsoleColor.Cyan);
            cuadrito(102, 102, 87, 87, ConsoleColor.Cyan);
            cuadrito(106, 106, 87, 87, ConsoleColor.Cyan);

            //*

            cuadrito(106, 120, 1, 10, ConsoleColor.DarkCyan);

            cuadrito(106, 106, 1, 1, ConsoleColor.Cyan);
            cuadrito(110, 110, 1, 1, ConsoleColor.Cyan);
            cuadrito(114, 114, 1, 1, ConsoleColor.Cyan);
            cuadrito(118, 118, 1, 1, ConsoleColor.Cyan);

            cuadrito(108, 108, 2, 2, ConsoleColor.Cyan);
            cuadrito(112, 112, 2, 2, ConsoleColor.Cyan);
            cuadrito(116, 116, 2, 2, ConsoleColor.Cyan);
            cuadrito(120, 120, 2, 2, ConsoleColor.Cyan);

            cuadrito(106, 106, 3, 3, ConsoleColor.Cyan);
            cuadrito(110, 110, 3, 3, ConsoleColor.Cyan);
            cuadrito(114, 114, 3, 3, ConsoleColor.Cyan);
            cuadrito(118, 118, 3, 3, ConsoleColor.Cyan);

            cuadrito(108, 108, 4, 4, ConsoleColor.Cyan);
            cuadrito(112, 112, 4, 4, ConsoleColor.Cyan);
            cuadrito(116, 116, 4, 4, ConsoleColor.Cyan);
            cuadrito(120, 120, 4, 4, ConsoleColor.Cyan);

            cuadrito(106, 106, 5, 5, ConsoleColor.Cyan);
            cuadrito(110, 110, 5, 5, ConsoleColor.Cyan);
            cuadrito(114, 114, 5, 5, ConsoleColor.Cyan);
            cuadrito(118, 118, 5, 5, ConsoleColor.Cyan);

            cuadrito(108, 108, 6, 6, ConsoleColor.Cyan);
            cuadrito(112, 112, 6, 6, ConsoleColor.Cyan);
            cuadrito(116, 116, 6, 6, ConsoleColor.Cyan);
            cuadrito(120, 120, 6, 6, ConsoleColor.Cyan);

            cuadrito(106, 106, 7, 7, ConsoleColor.Cyan);
            cuadrito(110, 110, 7, 7, ConsoleColor.Cyan);
            cuadrito(114, 114, 7, 7, ConsoleColor.Cyan);
            cuadrito(118, 118, 7, 7, ConsoleColor.Cyan);

            cuadrito(108, 108, 8, 8, ConsoleColor.Cyan);
            cuadrito(112, 112, 8, 8, ConsoleColor.Cyan);
            cuadrito(116, 116, 8, 8, ConsoleColor.Cyan);
            cuadrito(120, 120, 8, 8, ConsoleColor.Cyan);

            cuadrito(106, 106, 9, 9, ConsoleColor.Cyan);
            cuadrito(110, 110, 9, 9, ConsoleColor.Cyan);
            cuadrito(114, 114, 9, 9, ConsoleColor.Cyan);
            cuadrito(118, 118, 9, 9, ConsoleColor.Cyan);

            cuadrito(108, 108, 10, 10, ConsoleColor.Cyan);
            cuadrito(112, 112, 10, 10, ConsoleColor.Cyan);
            cuadrito(116, 116, 10, 10, ConsoleColor.Cyan);
            cuadrito(120, 120, 10, 10, ConsoleColor.Cyan);

            //*

            cuadrito(106, 120, 11, 21, ConsoleColor.DarkYellow);

            cuadrito(106, 106, 11, 11, ConsoleColor.Yellow);
            cuadrito(110, 110, 11, 11, ConsoleColor.Yellow);
            cuadrito(114, 114, 11, 11, ConsoleColor.Yellow);
            cuadrito(118, 118, 11, 11, ConsoleColor.Yellow);

            cuadrito(108, 108, 12, 12, ConsoleColor.Yellow);
            cuadrito(112, 112, 12, 12, ConsoleColor.Yellow);
            cuadrito(116, 116, 12, 12, ConsoleColor.Yellow);
            cuadrito(120, 120, 12, 12, ConsoleColor.Yellow);

            cuadrito(106, 106, 13, 13, ConsoleColor.Yellow);
            cuadrito(110, 110, 13, 13, ConsoleColor.Yellow);
            cuadrito(114, 114, 13, 13, ConsoleColor.Yellow);
            cuadrito(118, 118, 13, 13, ConsoleColor.Yellow);

            cuadrito(108, 108, 14, 14, ConsoleColor.Yellow);
            cuadrito(112, 112, 14, 14, ConsoleColor.Yellow);
            cuadrito(116, 116, 14, 14, ConsoleColor.Yellow);
            cuadrito(120, 120, 14, 14, ConsoleColor.Yellow);

            cuadrito(106, 106, 15, 15, ConsoleColor.Yellow);
            cuadrito(110, 110, 15, 15, ConsoleColor.Yellow);
            cuadrito(114, 114, 15, 15, ConsoleColor.Yellow);
            cuadrito(118, 118, 15, 15, ConsoleColor.Yellow);

            cuadrito(108, 108, 16, 16, ConsoleColor.Yellow);
            cuadrito(112, 112, 16, 16, ConsoleColor.Yellow);
            cuadrito(116, 116, 16, 16, ConsoleColor.Yellow);
            cuadrito(120, 120, 16, 16, ConsoleColor.Yellow);

            cuadrito(106, 106, 17, 17, ConsoleColor.Yellow);
            cuadrito(110, 110, 17, 17, ConsoleColor.Yellow);
            cuadrito(114, 114, 17, 17, ConsoleColor.Yellow);
            cuadrito(118, 118, 17, 17, ConsoleColor.Yellow);

            cuadrito(108, 108, 18, 18, ConsoleColor.Yellow);
            cuadrito(112, 112, 18, 18, ConsoleColor.Yellow);
            cuadrito(116, 116, 18, 18, ConsoleColor.Yellow);
            cuadrito(120, 120, 18, 18, ConsoleColor.Yellow);

            cuadrito(106, 106, 19, 19, ConsoleColor.Yellow);
            cuadrito(110, 110, 19, 19, ConsoleColor.Yellow);
            cuadrito(114, 114, 19, 19, ConsoleColor.Yellow);
            cuadrito(118, 118, 19, 19, ConsoleColor.Yellow);

            cuadrito(108, 108, 20, 20, ConsoleColor.Yellow);
            cuadrito(112, 112, 20, 20, ConsoleColor.Yellow);
            cuadrito(116, 116, 20, 20, ConsoleColor.Yellow);
            cuadrito(120, 120, 20, 20, ConsoleColor.Yellow);

            cuadrito(106, 106, 21, 21, ConsoleColor.Yellow);
            cuadrito(110, 110, 21, 21, ConsoleColor.Yellow);
            cuadrito(114, 114, 21, 21, ConsoleColor.Yellow);
            cuadrito(118, 118, 21, 21, ConsoleColor.Yellow);

            //*
            cuadrito(106, 120, 22, 32, ConsoleColor.DarkCyan);

            cuadrito(108, 108, 22, 22, ConsoleColor.Cyan);
            cuadrito(112, 112, 22, 22, ConsoleColor.Cyan);
            cuadrito(116, 116, 22, 22, ConsoleColor.Cyan);
            cuadrito(120, 120, 22, 22, ConsoleColor.Cyan);

            cuadrito(106, 106, 23, 23, ConsoleColor.Cyan);
            cuadrito(110, 110, 23, 23, ConsoleColor.Cyan);
            cuadrito(114, 114, 23, 23, ConsoleColor.Cyan);
            cuadrito(118, 118, 23, 23, ConsoleColor.Cyan);

            cuadrito(108, 108, 24, 24, ConsoleColor.Cyan);
            cuadrito(112, 112, 24, 24, ConsoleColor.Cyan);
            cuadrito(116, 116, 24, 24, ConsoleColor.Cyan);
            cuadrito(120, 120, 24, 24, ConsoleColor.Cyan);

            cuadrito(106, 106, 25, 25, ConsoleColor.Cyan);
            cuadrito(110, 110, 25, 25, ConsoleColor.Cyan);
            cuadrito(114, 114, 25, 25, ConsoleColor.Cyan);
            cuadrito(118, 118, 25, 25, ConsoleColor.Cyan);

            cuadrito(108, 108, 26, 26, ConsoleColor.Cyan);
            cuadrito(112, 112, 26, 26, ConsoleColor.Cyan);
            cuadrito(116, 116, 26, 26, ConsoleColor.Cyan);
            cuadrito(120, 120, 26, 26, ConsoleColor.Cyan);

            cuadrito(106, 106, 27, 27, ConsoleColor.Cyan);
            cuadrito(110, 110, 27, 27, ConsoleColor.Cyan);
            cuadrito(114, 114, 27, 27, ConsoleColor.Cyan);
            cuadrito(118, 118, 27, 27, ConsoleColor.Cyan);

            cuadrito(108, 108, 28, 28, ConsoleColor.Cyan);
            cuadrito(112, 112, 28, 28, ConsoleColor.Cyan);
            cuadrito(116, 116, 28, 28, ConsoleColor.Cyan);
            cuadrito(120, 120, 28, 28, ConsoleColor.Cyan);

            cuadrito(106, 106, 29, 29, ConsoleColor.Cyan);
            cuadrito(110, 110, 29, 29, ConsoleColor.Cyan);
            cuadrito(114, 114, 29, 29, ConsoleColor.Cyan);
            cuadrito(118, 118, 29, 29, ConsoleColor.Cyan);

            cuadrito(108, 108, 30, 30, ConsoleColor.Cyan);
            cuadrito(112, 112, 30, 30, ConsoleColor.Cyan);
            cuadrito(116, 116, 30, 30, ConsoleColor.Cyan);
            cuadrito(120, 120, 30, 30, ConsoleColor.Cyan);

            cuadrito(106, 106, 31, 31, ConsoleColor.Cyan);
            cuadrito(110, 110, 31, 31, ConsoleColor.Cyan);
            cuadrito(114, 114, 31, 31, ConsoleColor.Cyan);
            cuadrito(118, 118, 31, 31, ConsoleColor.Cyan);

            cuadrito(108, 108, 32, 32, ConsoleColor.Cyan);
            cuadrito(112, 112, 32, 32, ConsoleColor.Cyan);
            cuadrito(116, 116, 32, 32, ConsoleColor.Cyan);
            cuadrito(120, 120, 32, 32, ConsoleColor.Cyan);

            //*

            cuadrito(106, 120, 33, 43, ConsoleColor.DarkYellow);

            cuadrito(106, 106, 33, 33, ConsoleColor.Yellow);
            cuadrito(110, 110, 33, 33, ConsoleColor.Yellow);
            cuadrito(114, 114, 33, 33, ConsoleColor.Yellow);
            cuadrito(118, 118, 33, 33, ConsoleColor.Yellow);

            cuadrito(108, 108, 34, 34, ConsoleColor.Yellow);
            cuadrito(112, 112, 34, 34, ConsoleColor.Yellow);
            cuadrito(116, 116, 34, 34, ConsoleColor.Yellow);
            cuadrito(120, 120, 34, 34, ConsoleColor.Yellow);

            cuadrito(106, 106, 35, 35, ConsoleColor.Yellow);
            cuadrito(110, 110, 35, 35, ConsoleColor.Yellow);
            cuadrito(114, 114, 35, 35, ConsoleColor.Yellow);
            cuadrito(118, 118, 35, 35, ConsoleColor.Yellow);

            cuadrito(108, 108, 36, 36, ConsoleColor.Yellow);
            cuadrito(112, 112, 36, 36, ConsoleColor.Yellow);
            cuadrito(116, 116, 36, 36, ConsoleColor.Yellow);
            cuadrito(120, 120, 36, 36, ConsoleColor.Yellow);

            cuadrito(106, 106, 37, 37, ConsoleColor.Yellow);
            cuadrito(110, 110, 37, 37, ConsoleColor.Yellow);
            cuadrito(114, 114, 37, 37, ConsoleColor.Yellow);
            cuadrito(118, 118, 37, 37, ConsoleColor.Yellow);

            cuadrito(108, 108, 38, 38, ConsoleColor.Yellow);
            cuadrito(112, 112, 38, 38, ConsoleColor.Yellow);
            cuadrito(116, 116, 38, 38, ConsoleColor.Yellow);
            cuadrito(120, 120, 38, 38, ConsoleColor.Yellow);

            cuadrito(106, 106, 39, 39, ConsoleColor.Yellow);
            cuadrito(110, 110, 39, 39, ConsoleColor.Yellow);
            cuadrito(114, 114, 39, 39, ConsoleColor.Yellow);
            cuadrito(118, 118, 39, 39, ConsoleColor.Yellow);

            cuadrito(108, 108, 40, 40, ConsoleColor.Yellow);
            cuadrito(112, 112, 40, 40, ConsoleColor.Yellow);
            cuadrito(116, 116, 40, 40, ConsoleColor.Yellow);
            cuadrito(120, 120, 40, 40, ConsoleColor.Yellow);

            cuadrito(106, 106, 41, 41, ConsoleColor.Yellow);
            cuadrito(110, 110, 41, 41, ConsoleColor.Yellow);
            cuadrito(114, 114, 41, 41, ConsoleColor.Yellow);
            cuadrito(118, 118, 41, 41, ConsoleColor.Yellow);

            cuadrito(108, 108, 42, 42, ConsoleColor.Yellow);
            cuadrito(112, 112, 42, 42, ConsoleColor.Yellow);
            cuadrito(116, 116, 42, 42, ConsoleColor.Yellow);
            cuadrito(120, 120, 42, 42, ConsoleColor.Yellow);

            cuadrito(106, 106, 43, 43, ConsoleColor.Yellow);
            cuadrito(110, 110, 43, 43, ConsoleColor.Yellow);
            cuadrito(114, 114, 43, 43, ConsoleColor.Yellow);
            cuadrito(118, 118, 43, 43, ConsoleColor.Yellow);

            //*
            cuadrito(106, 120, 44, 54, ConsoleColor.DarkCyan);

            cuadrito(108, 108, 44, 44, ConsoleColor.Cyan);
            cuadrito(112, 112, 44, 44, ConsoleColor.Cyan);
            cuadrito(116, 116, 44, 44, ConsoleColor.Cyan);
            cuadrito(120, 120, 44, 44, ConsoleColor.Cyan);

            cuadrito(106, 106, 45, 45, ConsoleColor.Cyan);
            cuadrito(110, 110, 45, 45, ConsoleColor.Cyan);
            cuadrito(114, 114, 45, 45, ConsoleColor.Cyan);
            cuadrito(118, 118, 45, 45, ConsoleColor.Cyan);

            cuadrito(108, 108, 46, 46, ConsoleColor.Cyan);
            cuadrito(112, 112, 46, 46, ConsoleColor.Cyan);
            cuadrito(116, 116, 46, 46, ConsoleColor.Cyan);
            cuadrito(120, 120, 46, 46, ConsoleColor.Cyan);

            cuadrito(106, 106, 47, 47, ConsoleColor.Cyan);
            cuadrito(110, 110, 47, 47, ConsoleColor.Cyan);
            cuadrito(114, 114, 47, 47, ConsoleColor.Cyan);
            cuadrito(118, 118, 47, 47, ConsoleColor.Cyan);

            cuadrito(108, 108, 48, 48, ConsoleColor.Cyan);
            cuadrito(112, 112, 48, 48, ConsoleColor.Cyan);
            cuadrito(116, 116, 48, 48, ConsoleColor.Cyan);
            cuadrito(120, 120, 48, 48, ConsoleColor.Cyan);

            cuadrito(106, 106, 49, 49, ConsoleColor.Cyan);
            cuadrito(110, 110, 49, 49, ConsoleColor.Cyan);
            cuadrito(114, 114, 49, 49, ConsoleColor.Cyan);
            cuadrito(118, 118, 49, 49, ConsoleColor.Cyan);

            cuadrito(108, 108, 50, 50, ConsoleColor.Cyan);
            cuadrito(112, 112, 50, 50, ConsoleColor.Cyan);
            cuadrito(116, 116, 50, 50, ConsoleColor.Cyan);
            cuadrito(120, 120, 50, 50, ConsoleColor.Cyan);

            cuadrito(106, 106, 51, 51, ConsoleColor.Cyan);
            cuadrito(110, 110, 51, 51, ConsoleColor.Cyan);
            cuadrito(114, 114, 51, 51, ConsoleColor.Cyan);
            cuadrito(118, 118, 51, 51, ConsoleColor.Cyan);

            cuadrito(108, 108, 52, 52, ConsoleColor.Cyan);
            cuadrito(112, 112, 52, 52, ConsoleColor.Cyan);
            cuadrito(116, 116, 52, 52, ConsoleColor.Cyan);
            cuadrito(120, 120, 52, 52, ConsoleColor.Cyan);

            cuadrito(106, 106, 53, 53, ConsoleColor.Cyan);
            cuadrito(110, 110, 53, 53, ConsoleColor.Cyan);
            cuadrito(114, 114, 53, 53, ConsoleColor.Cyan);
            cuadrito(118, 118, 53, 53, ConsoleColor.Cyan);

            cuadrito(108, 108, 54, 54, ConsoleColor.Cyan);
            cuadrito(112, 112, 54, 54, ConsoleColor.Cyan);
            cuadrito(116, 116, 54, 54, ConsoleColor.Cyan);
            cuadrito(120, 120, 54, 54, ConsoleColor.Cyan);

            //*
            cuadrito(106, 120, 55, 65, ConsoleColor.DarkYellow);

            cuadrito(106, 106, 55, 55, ConsoleColor.Yellow);
            cuadrito(110, 110, 55, 55, ConsoleColor.Yellow);
            cuadrito(114, 114, 55, 55, ConsoleColor.Yellow);
            cuadrito(118, 118, 55, 55, ConsoleColor.Yellow);

            cuadrito(108, 108, 56, 56, ConsoleColor.Yellow);
            cuadrito(112, 112, 56, 56, ConsoleColor.Yellow);
            cuadrito(116, 116, 56, 56, ConsoleColor.Yellow);
            cuadrito(120, 120, 56, 56, ConsoleColor.Yellow);

            cuadrito(106, 106, 57, 57, ConsoleColor.Yellow);
            cuadrito(110, 110, 57, 57, ConsoleColor.Yellow);
            cuadrito(114, 114, 57, 57, ConsoleColor.Yellow);
            cuadrito(118, 118, 57, 57, ConsoleColor.Yellow);

            cuadrito(108, 108, 58, 58, ConsoleColor.Yellow);
            cuadrito(112, 112, 58, 58, ConsoleColor.Yellow);
            cuadrito(116, 116, 58, 58, ConsoleColor.Yellow);
            cuadrito(120, 120, 58, 58, ConsoleColor.Yellow);

            cuadrito(106, 106, 59, 59, ConsoleColor.Yellow);
            cuadrito(110, 110, 59, 59, ConsoleColor.Yellow);
            cuadrito(114, 114, 59, 59, ConsoleColor.Yellow);
            cuadrito(118, 118, 59, 59, ConsoleColor.Yellow);

            cuadrito(108, 108, 60, 60, ConsoleColor.Yellow);
            cuadrito(112, 112, 60, 60, ConsoleColor.Yellow);
            cuadrito(116, 116, 60, 60, ConsoleColor.Yellow);
            cuadrito(120, 120, 60, 60, ConsoleColor.Yellow);

            cuadrito(106, 106, 61, 61, ConsoleColor.Yellow);
            cuadrito(110, 110, 61, 61, ConsoleColor.Yellow);
            cuadrito(114, 114, 61, 61, ConsoleColor.Yellow);
            cuadrito(118, 118, 61, 61, ConsoleColor.Yellow);

            cuadrito(108, 108, 62, 62, ConsoleColor.Yellow);
            cuadrito(112, 112, 62, 62, ConsoleColor.Yellow);
            cuadrito(116, 116, 62, 62, ConsoleColor.Yellow);
            cuadrito(120, 120, 62, 62, ConsoleColor.Yellow);

            cuadrito(106, 106, 63, 63, ConsoleColor.Yellow);
            cuadrito(110, 110, 63, 63, ConsoleColor.Yellow);
            cuadrito(114, 114, 63, 63, ConsoleColor.Yellow);
            cuadrito(118, 118, 63, 63, ConsoleColor.Yellow);

            cuadrito(108, 108, 64, 64, ConsoleColor.Yellow);
            cuadrito(112, 112, 64, 64, ConsoleColor.Yellow);
            cuadrito(116, 116, 64, 64, ConsoleColor.Yellow);
            cuadrito(120, 120, 64, 64, ConsoleColor.Yellow);

            cuadrito(106, 106, 65, 65, ConsoleColor.Yellow);
            cuadrito(110, 110, 65, 65, ConsoleColor.Yellow);
            cuadrito(114, 114, 65, 65, ConsoleColor.Yellow);
            cuadrito(118, 118, 65, 65, ConsoleColor.Yellow);

            //*
            cuadrito(106, 120, 66, 76, ConsoleColor.DarkCyan);

            cuadrito(108, 108, 66, 66, ConsoleColor.Cyan);
            cuadrito(112, 112, 66, 66, ConsoleColor.Cyan);
            cuadrito(116, 116, 66, 66, ConsoleColor.Cyan);
            cuadrito(120, 120, 66, 66, ConsoleColor.Cyan);

            cuadrito(106, 106, 67, 67, ConsoleColor.Cyan);
            cuadrito(110, 110, 67, 67, ConsoleColor.Cyan);
            cuadrito(114, 114, 67, 67, ConsoleColor.Cyan);
            cuadrito(118, 118, 67, 67, ConsoleColor.Cyan);

            cuadrito(108, 108, 68, 68, ConsoleColor.Cyan);
            cuadrito(112, 112, 68, 68, ConsoleColor.Cyan);
            cuadrito(116, 116, 68, 68, ConsoleColor.Cyan);
            cuadrito(120, 120, 68, 68, ConsoleColor.Cyan);

            cuadrito(106, 106, 69, 69, ConsoleColor.Cyan);
            cuadrito(110, 110, 69, 69, ConsoleColor.Cyan);
            cuadrito(114, 114, 69, 69, ConsoleColor.Cyan);
            cuadrito(118, 118, 69, 69, ConsoleColor.Cyan);

            cuadrito(108, 108, 70, 70, ConsoleColor.Cyan);
            cuadrito(112, 112, 70, 70, ConsoleColor.Cyan);
            cuadrito(116, 116, 70, 70, ConsoleColor.Cyan);
            cuadrito(120, 120, 70, 70, ConsoleColor.Cyan);

            cuadrito(106, 106, 71, 71, ConsoleColor.Cyan);
            cuadrito(110, 110, 71, 71, ConsoleColor.Cyan);
            cuadrito(114, 114, 71, 71, ConsoleColor.Cyan);
            cuadrito(118, 118, 71, 71, ConsoleColor.Cyan);

            cuadrito(108, 108, 72, 72, ConsoleColor.Cyan);
            cuadrito(112, 112, 72, 72, ConsoleColor.Cyan);
            cuadrito(116, 116, 72, 72, ConsoleColor.Cyan);
            cuadrito(120, 120, 72, 72, ConsoleColor.Cyan);

            cuadrito(106, 106, 73, 73, ConsoleColor.Cyan);
            cuadrito(110, 110, 73, 73, ConsoleColor.Cyan);
            cuadrito(114, 114, 73, 73, ConsoleColor.Cyan);
            cuadrito(118, 118, 73, 73, ConsoleColor.Cyan);

            cuadrito(108, 108, 74, 74, ConsoleColor.Cyan);
            cuadrito(112, 112, 74, 74, ConsoleColor.Cyan);
            cuadrito(116, 116, 74, 74, ConsoleColor.Cyan);
            cuadrito(120, 120, 74, 74, ConsoleColor.Cyan);

            cuadrito(106, 106, 75, 75, ConsoleColor.Cyan);
            cuadrito(110, 110, 75, 75, ConsoleColor.Cyan);
            cuadrito(114, 114, 75, 75, ConsoleColor.Cyan);
            cuadrito(118, 118, 75, 75, ConsoleColor.Cyan);

            cuadrito(108, 108, 76, 76, ConsoleColor.Cyan);
            cuadrito(112, 112, 76, 76, ConsoleColor.Cyan);
            cuadrito(116, 116, 76, 76, ConsoleColor.Cyan);
            cuadrito(120, 120, 76, 76, ConsoleColor.Cyan);

            //*
            cuadrito(106, 120, 77, 87, ConsoleColor.DarkYellow);

            cuadrito(106, 106, 77, 77, ConsoleColor.Yellow);
            cuadrito(110, 110, 77, 77, ConsoleColor.Yellow);
            cuadrito(114, 114, 77, 77, ConsoleColor.Yellow);
            cuadrito(118, 118, 77, 77, ConsoleColor.Yellow);

            cuadrito(108, 108, 78, 78, ConsoleColor.Yellow);
            cuadrito(112, 112, 78, 78, ConsoleColor.Yellow);
            cuadrito(116, 116, 78, 78, ConsoleColor.Yellow);
            cuadrito(120, 120, 78, 78, ConsoleColor.Yellow);

            cuadrito(106, 106, 79, 79, ConsoleColor.Yellow);
            cuadrito(110, 110, 79, 79, ConsoleColor.Yellow);
            cuadrito(114, 114, 79, 79, ConsoleColor.Yellow);
            cuadrito(118, 118, 79, 79, ConsoleColor.Yellow);

            cuadrito(108, 108, 80, 80, ConsoleColor.Yellow);
            cuadrito(112, 112, 80, 80, ConsoleColor.Yellow);
            cuadrito(116, 116, 80, 80, ConsoleColor.Yellow);
            cuadrito(120, 120, 80, 80, ConsoleColor.Yellow);

            cuadrito(106, 106, 81, 81, ConsoleColor.Yellow);
            cuadrito(110, 110, 81, 81, ConsoleColor.Yellow);
            cuadrito(114, 114, 81, 81, ConsoleColor.Yellow);
            cuadrito(118, 118, 81, 81, ConsoleColor.Yellow);

            cuadrito(108, 108, 82, 82, ConsoleColor.Yellow);
            cuadrito(112, 112, 82, 82, ConsoleColor.Yellow);
            cuadrito(116, 116, 82, 82, ConsoleColor.Yellow);
            cuadrito(120, 120, 82, 82, ConsoleColor.Yellow);

            cuadrito(106, 106, 83, 83, ConsoleColor.Yellow);
            cuadrito(110, 110, 83, 83, ConsoleColor.Yellow);
            cuadrito(114, 114, 83, 83, ConsoleColor.Yellow);
            cuadrito(118, 118, 83, 83, ConsoleColor.Yellow);

            cuadrito(108, 108, 84, 84, ConsoleColor.Yellow);
            cuadrito(112, 112, 84, 84, ConsoleColor.Yellow);
            cuadrito(116, 116, 84, 84, ConsoleColor.Yellow);
            cuadrito(120, 120, 84, 84, ConsoleColor.Yellow);

            cuadrito(106, 106, 85, 85, ConsoleColor.Yellow);
            cuadrito(110, 110, 85, 85, ConsoleColor.Yellow);
            cuadrito(114, 114, 85, 85, ConsoleColor.Yellow);
            cuadrito(118, 118, 85, 85, ConsoleColor.Yellow);

            cuadrito(108, 108, 86, 86, ConsoleColor.Yellow);
            cuadrito(112, 112, 86, 86, ConsoleColor.Yellow);
            cuadrito(116, 116, 86, 86, ConsoleColor.Yellow);
            cuadrito(120, 120, 86, 86, ConsoleColor.Yellow);

            cuadrito(106, 106, 87, 87, ConsoleColor.Yellow);
            cuadrito(110, 110, 87, 87, ConsoleColor.Yellow);
            cuadrito(114, 114, 87, 87, ConsoleColor.Yellow);
            cuadrito(118, 118, 87, 87, ConsoleColor.Yellow);
            //*



            Console.SetCursorPosition(5, 2);
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine(" ");

        }
        private void cuadrito(int xdesde, int xhasta, int ydesde, int yhasta, ConsoleColor Color)
        {
            Console.BackgroundColor = Color;

            for (int y = ydesde; y <= yhasta; y++)
            {
                for (int x = xdesde; x <= xhasta; x++)
                {
                    Console.SetCursorPosition(x, y);
                    Console.WriteLine("  ");

                }

            }
        }

    }
}
