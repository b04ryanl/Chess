using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabAjedrez
{
    public class Tablero
    {

        public List<Ficha> FichasJ1;
        public List<Ficha> FichasJ2;
        public List<Ficha> FichasJ1muertas;
        public List<Ficha> FichasJ2muertas;

        public Tablero()
        {
            FichasJ1 = new List<Ficha>();
            FichasJ2 = new List<Ficha>();
            FichasJ1muertas = new List<Ficha>();
            FichasJ2muertas = new List<Ficha>();
            for (int i = 0; i < 8; i++)
            {
                FichasJ1.Add(new Peon(new Posicion(i, 6), ConsoleColor.White));
            }


            FichasJ1.Add(new Reina(new Posicion(4, 7), ConsoleColor.White));
            FichasJ1.Add(new Rey(new Posicion(3, 7), ConsoleColor.White));
            FichasJ1.Add(new Torre(new Posicion(0, 7), ConsoleColor.White));
            FichasJ1.Add(new Torre(new Posicion(7, 7), ConsoleColor.White));
            FichasJ1.Add(new Caballo(new Posicion(1, 7), ConsoleColor.White));
            FichasJ1.Add(new Caballo(new Posicion(6, 7), ConsoleColor.White));
            FichasJ1.Add(new Arfil(new Posicion(2, 7), ConsoleColor.White));
            FichasJ1.Add(new Arfil(new Posicion(5, 7), ConsoleColor.White));


            for (int i = 0; i < 8; i++)
            {
                FichasJ2.Add(new Peon(new Posicion(i, 1), ConsoleColor.Red));
            }

            FichasJ2.Add(new Reina(new Posicion(4, 0), ConsoleColor.Red));
            FichasJ2.Add(new Rey(new Posicion(3, 0), ConsoleColor.Red));
            FichasJ2.Add(new Torre(new Posicion(0, 0), ConsoleColor.Red));
            FichasJ2.Add(new Torre(new Posicion(7, 0), ConsoleColor.Red));
            FichasJ2.Add(new Caballo(new Posicion(1, 0), ConsoleColor.Red));
            FichasJ2.Add(new Caballo(new Posicion(6, 0), ConsoleColor.Red));
            FichasJ2.Add(new Arfil(new Posicion(2, 0), ConsoleColor.Red));
            FichasJ2.Add(new Arfil(new Posicion(5, 0), ConsoleColor.Red));


        }

        public Ficha buscarficha(Posicion pos)
        {
            Ficha resultado = FichasJ1.Find(x => x.posicion.x == pos.x && x.posicion.y == pos.y);
            if (resultado != null)
            {
                return resultado;
            }
            else
            {
                Ficha resultado2 = FichasJ2.Find(x => x.posicion.x == pos.x && x.posicion.y == pos.y);
                return resultado2;
            }
            
        }

        public Ficha buscarfichaJ1(Posicion pos)
        {
            Ficha resultado = FichasJ1.Find(x => x.posicion.x == pos.x && x.posicion.y == pos.y);
            return resultado;

        }
        public Ficha buscarfichaJ2(Posicion pos)
        {
            Ficha resultado = FichasJ2.Find(x => x.posicion.x == pos.x && x.posicion.y == pos.y);
            return resultado;

        }

        public void pintarposibles(List<Posicion> posibles)
        {
            foreach (var pos in posibles)
            {
                pintarcuadroverde(pos.x, pos.y);
                Ficha encontrada = buscarficha(pos);
                if (encontrada != null)
                {
                    encontrada.pintar();
                }
            }
        }

        public void pintarcuadro(int x,int y,int tipo,bool par)
        {
            ConsoleColor color1 = ConsoleColor.Red,color2 = ConsoleColor.Red;
            if (tipo == 1)
            {
                color1 = ConsoleColor.DarkYellow;
                color2 = ConsoleColor.Yellow;
            }
            else
            {
                color1 = ConsoleColor.DarkCyan;
                color2 = ConsoleColor.Cyan;
            }
            pintarcuadrito(x, x+12, y, y+9, color1);

            for (int i = 0; i < 10; i++)
            {
                if (i%2 == 0)
                {
                    if (par == true)
                    {
                        pintarcuadrito(x, x, y + i, y + i, color2);
                        pintarcuadrito(x + 4, x + 4, y + i, y + i, color2);
                        pintarcuadrito(x + 8, x + 8, y + i, y + i, color2);
                        pintarcuadrito(x + 12, x + 12, y + i, y + i, color2);
                    }
                    else
                    {
                        pintarcuadrito(x + 2, x + 2, y + i, y + i, color2);
                        pintarcuadrito(x + 6, x + 6, y + i, y + i, color2);
                        pintarcuadrito(x + 10, x + 10, y + i, y + i, color2);
                    }   
                    
                }
                else
                {
                    if (par == false)
                    {
                        pintarcuadrito(x, x, y + i, y + i, color2);
                        pintarcuadrito(x + 4, x + 4, y + i, y + i, color2);
                        pintarcuadrito(x + 8, x + 8, y + i, y + i, color2);
                        pintarcuadrito(x + 12, x + 12, y + i, y + i, color2);
                    }
                    else
                    {
                        pintarcuadrito(x + 2, x + 2, y + i, y + i, color2);
                        pintarcuadrito(x + 6, x + 6, y + i, y + i, color2);
                        pintarcuadrito(x + 10, x + 10, y + i, y + i, color2);
                    }
                }
            }
            

        }

        public void pintarcuadroverde(int x, int y)
        {
            pintarcuadrito(2 + (x * 14), 2 + (x * 14) + 12, 1 + (y * 10), 1 + (y * 10) + 9, ConsoleColor.Green);
        }
        public void pintar()
        {
            pintarcuadrito(0, 150, 0, 95, ConsoleColor.DarkGray);

            pintarcuadrito(3, 13, 89, 94, ConsoleColor.Black); // A

            pintarcuadrito(5, 11, 90, 90, ConsoleColor.White);
            pintarcuadrito(5, 11, 92, 94, ConsoleColor.White);

            pintarcuadrito(18, 28, 89, 94, ConsoleColor.Black); // B

            pintarcuadrito(20, 26, 90, 90, ConsoleColor.White);
            pintarcuadrito(20, 26, 92, 93, ConsoleColor.White);


            pintarcuadrito(33, 43, 89, 94, ConsoleColor.Black); // C

            pintarcuadrito(35, 43, 90, 93, ConsoleColor.White);

            pintarcuadrito(48, 58, 89, 94, ConsoleColor.Black); //D

            pintarcuadrito(50, 52, 90, 93, ConsoleColor.White);
            pintarcuadrito(53, 55, 91, 92, ConsoleColor.White);


            pintarcuadrito(63, 73, 89, 94, ConsoleColor.Black); // E

            pintarcuadrito(66, 73, 90, 90, ConsoleColor.White);
            pintarcuadrito(66, 73, 92, 92, ConsoleColor.White);

            pintarcuadrito(78, 88, 89, 94, ConsoleColor.Black); // F

            pintarcuadrito(81, 88, 90, 90, ConsoleColor.White);
            pintarcuadrito(81, 88, 92, 94, ConsoleColor.White);


            pintarcuadrito(93, 103, 89, 94, ConsoleColor.Black); //G

            pintarcuadrito(96, 100, 90, 90, ConsoleColor.White);
            pintarcuadrito(96, 103, 91, 91, ConsoleColor.White);
            pintarcuadrito(96, 97, 92, 92, ConsoleColor.White);
            pintarcuadrito(96, 99, 93, 93, ConsoleColor.White);

            pintarcuadrito(108, 118, 89, 94, ConsoleColor.Black); // H

            pintarcuadrito(111, 115, 89, 90, ConsoleColor.White);
            pintarcuadrito(111, 115, 93, 94, ConsoleColor.White); ///RE OK


            pintarcuadrito(124, 140, 02, 09, ConsoleColor.White); //1

            pintarcuadrito(124, 126, 2, 3, ConsoleColor.Black);
            pintarcuadrito(124, 132, 4, 9, ConsoleColor.Black);
            pintarcuadrito(138, 140, 2, 9, ConsoleColor.Black);

            pintarcuadrito(124, 140, 12, 20, ConsoleColor.White); //2

            pintarcuadrito(124, 126, 12, 20, ConsoleColor.Black);
            pintarcuadrito(138, 140, 12, 20, ConsoleColor.Black);
            pintarcuadrito(127, 132, 14, 14, ConsoleColor.Black);
            pintarcuadrito(131, 137, 17, 17, ConsoleColor.Black);


            pintarcuadrito(124, 140, 23, 31, ConsoleColor.White); // 3

            pintarcuadrito(124, 126, 23, 31, ConsoleColor.Black);
            pintarcuadrito(138, 140, 23, 31, ConsoleColor.Black);
            pintarcuadrito(127, 132, 25, 25, ConsoleColor.Black);
            pintarcuadrito(127, 132, 28, 28, ConsoleColor.Black);


            pintarcuadrito(124, 140, 34, 42, ConsoleColor.White); //4

            pintarcuadrito(124, 126, 34, 42, ConsoleColor.Black);
            pintarcuadrito(138, 140, 34, 42, ConsoleColor.Black);
            pintarcuadrito(131, 133, 34, 36, ConsoleColor.Black);
            pintarcuadrito(127, 133, 39, 42, ConsoleColor.Black);

            pintarcuadrito(124, 140, 45, 53, ConsoleColor.White); //5

            pintarcuadrito(124, 126, 45, 53, ConsoleColor.Black);
            pintarcuadrito(138, 140, 45, 53, ConsoleColor.Black);
            pintarcuadrito(130, 137, 47, 47, ConsoleColor.Black);
            pintarcuadrito(127, 131, 50, 51, ConsoleColor.Black);


            pintarcuadrito(124, 140, 56, 64, ConsoleColor.White); //6 

            pintarcuadrito(124, 126, 56, 64, ConsoleColor.Black);
            pintarcuadrito(138, 140, 56, 64, ConsoleColor.Black);
            pintarcuadrito(130, 137, 58, 58, ConsoleColor.Black);
            pintarcuadrito(130, 133, 61, 62, ConsoleColor.Black);

            pintarcuadrito(124, 140, 67, 75, ConsoleColor.White); //7

            pintarcuadrito(124, 126, 67, 75, ConsoleColor.Black);
            pintarcuadrito(138, 140, 67, 75, ConsoleColor.Black);
            pintarcuadrito(127, 132, 69, 70, ConsoleColor.Black);
            pintarcuadrito(127, 132, 73, 75, ConsoleColor.Black);
            pintarcuadrito(127, 129, 71, 72, ConsoleColor.Black);

            pintarcuadrito(124, 140, 78, 86, ConsoleColor.White); // 8

            pintarcuadrito(124, 126, 78, 86, ConsoleColor.Black);
            pintarcuadrito(138, 140, 78, 86, ConsoleColor.Black);
            pintarcuadrito(131, 133, 80, 80, ConsoleColor.Black);
            pintarcuadrito(131, 133, 83, 83, ConsoleColor.Black);




            ////////////////////////////////////////////
            for (int x = 0; x < 8; x++)
            {
                for (int y = 0; y < 8; y++)
                {
                    if (x % 2 == 0)
                    {
                        if (y%2 == 0)
                        {
                            pintarcuadro(2+(x*14), 1 + (y*10), 1,true);
                        }
                        else
                        {
                            pintarcuadro(2 + (x * 14), 1 + (y *10), 2,true);
                        }
                    }
                    else
                    {
                        if (y % 2 == 0)
                        {
                            pintarcuadro(2 + (x * 14), 1 + (y * 10), 2,false);
                        }
                        else
                        {
                            pintarcuadro(2 + (x * 14), 1 + (y * 10), 1,false);
                        }
                    }
                }
            }
            

        }

        public Posicion Seleccionarcuadro(int jugador,bool seleccionactiva = false,Posicion posactiva = null, List<Posicion> movimientos = null)
        {
            if (seleccionactiva == false)
            {
                Posicion respuesta = new Posicion(0, 0);
                ConsoleKey tecla = ConsoleKey.A;
                ConsoleColor color = ConsoleColor.Red;
                switch (jugador)
                {
                    case 1:
                        color = ConsoleColor.White;
                        break;
                    case 2:
                        color = ConsoleColor.DarkRed;
                        break;
                }


                while (tecla != ConsoleKey.Enter)
                {
                    pintarcuadrito((respuesta.x * 14) + 2, (respuesta.x * 14) + 14, (respuesta.y * 10) + 1, (respuesta.y * 10) + 1, color);
                    pintarcuadrito((respuesta.x * 14) + 2, (respuesta.x * 14) + 14, (respuesta.y * 10) + 10, (respuesta.y * 10) + 10, color);
                    pintarcuadrito((respuesta.x * 14) + 2, (respuesta.x * 14) + 2, (respuesta.y * 10) + 1, (respuesta.y * 10) + 10, color);
                    pintarcuadrito((respuesta.x * 14) + 14, (respuesta.x * 14) + 14, (respuesta.y * 10) + 1, (respuesta.y * 10) + 10, color);

                    tecla = Console.ReadKey().Key;
                    if (respuesta.x % 2 == 0)
                    {
                        if (respuesta.y % 2 == 0)
                        {
                            pintarcuadro(2 + (respuesta.x * 14), 1 + (respuesta.y * 10), 1, true);
                        }
                        else
                        {
                            pintarcuadro(2 + (respuesta.x * 14), 1 + (respuesta.y * 10), 2, true);
                        }
                    }
                    else
                    {
                        if (respuesta.y % 2 == 0)
                        {
                            pintarcuadro(2 + (respuesta.x * 14), 1 + (respuesta.y * 10), 2, false);
                        }
                        else
                        {
                            pintarcuadro(2 + (respuesta.x * 14), 1 + (respuesta.y * 10), 1, false);
                        }
                    }

                    Ficha fichapintar = buscarficha(respuesta);
                    if (fichapintar != null)
                    {
                        fichapintar.pintar();
                    }

                    switch (tecla)
                    {
                        case ConsoleKey.DownArrow:
                            respuesta.y++;
                            if (respuesta.y == 8)
                            {
                                respuesta.y = 0;
                            }
                            break;
                        case ConsoleKey.LeftArrow:
                            respuesta.x--;
                            if (respuesta.x == -1)
                            {
                                respuesta.x = 7;
                            }
                            break;
                        case ConsoleKey.UpArrow:
                            respuesta.y--;
                            if (respuesta.y == -1)
                            {
                                respuesta.y = 7;
                            }
                            break;
                        case ConsoleKey.RightArrow:
                            respuesta.x++;
                            if (respuesta.x == 8)
                            {
                                respuesta.x = 0;
                            }
                            break;
                    }
                }
                return respuesta;
            }
            else
            {
                Posicion respuesta = new Posicion(0, 0);
                ConsoleKey tecla = ConsoleKey.A;
                ConsoleColor color = ConsoleColor.Red;
                switch (jugador)
                {
                    case 1:
                        color = ConsoleColor.White;
                        break;
                    case 2:
                        color = ConsoleColor.DarkRed;
                        break;
                }

                pintarcuadrito((posactiva.x * 14) + 2, (posactiva.x * 14) + 14, (posactiva.y * 10) + 1, (posactiva.y * 10) + 1, color);
                pintarcuadrito((posactiva.x * 14) + 2, (posactiva.x * 14) + 14, (posactiva.y * 10) + 10, (posactiva.y * 10) + 10, color);
                pintarcuadrito((posactiva.x * 14) + 2, (posactiva.x * 14) + 2, (posactiva.y * 10) + 1, (posactiva.y * 10) + 10, color);
                pintarcuadrito((posactiva.x * 14) + 14, (posactiva.x * 14) + 14, (posactiva.y * 10) + 1, (posactiva.y * 10) + 10, color);

                while (tecla != ConsoleKey.Enter)
                {
                    pintarcuadrito((respuesta.x * 14) + 2, (respuesta.x * 14) + 14, (respuesta.y * 10) + 1, (respuesta.y * 10) + 1, color);
                    pintarcuadrito((respuesta.x * 14) + 2, (respuesta.x * 14) + 14, (respuesta.y * 10) + 10, (respuesta.y * 10) + 10, color);
                    pintarcuadrito((respuesta.x * 14) + 2, (respuesta.x * 14) + 2, (respuesta.y * 10) + 1, (respuesta.y * 10) + 10, color);
                    pintarcuadrito((respuesta.x * 14) + 14, (respuesta.x * 14) + 14, (respuesta.y * 10) + 1, (respuesta.y * 10) + 10, color);

                    tecla = Console.ReadKey().Key;



                    if (respuesta.x % 2 == 0)
                    {
                        if (respuesta.y % 2 == 0)
                        {
                            pintarcuadro(2 + (respuesta.x * 14), 1 + (respuesta.y * 10), 1, true);
                        }
                        else
                        {
                            pintarcuadro(2 + (respuesta.x * 14), 1 + (respuesta.y * 10), 2, true);
                        }
                    }
                    else
                    {
                        if (respuesta.y % 2 == 0)
                        {
                            pintarcuadro(2 + (respuesta.x * 14), 1 + (respuesta.y * 10), 2, false);
                        }
                        else
                        {
                            pintarcuadro(2 + (respuesta.x * 14), 1 + (respuesta.y * 10), 1, false);
                        }
                    }

                    if (movimientos.Exists(x => x.x == respuesta.x && x.y == respuesta.y) == true)
                    {
                        pintarcuadroverde(respuesta.x, respuesta.y);
                    }

                    Ficha fichapintar = buscarficha(respuesta);
                    if (fichapintar != null)
                    {
                        fichapintar.pintar();
                    }

                    if (respuesta.x == posactiva.x && respuesta.y == posactiva.y)
                    {
                        pintarcuadrito((posactiva.x * 14) + 2, (posactiva.x * 14) + 14, (posactiva.y * 10) + 1, (posactiva.y * 10) + 1, color);
                        pintarcuadrito((posactiva.x * 14) + 2, (posactiva.x * 14) + 14, (posactiva.y * 10) + 10, (posactiva.y * 10) + 10, color);
                        pintarcuadrito((posactiva.x * 14) + 2, (posactiva.x * 14) + 2, (posactiva.y * 10) + 1, (posactiva.y * 10) + 10, color);
                        pintarcuadrito((posactiva.x * 14) + 14, (posactiva.x * 14) + 14, (posactiva.y * 10) + 1, (posactiva.y * 10) + 10, color);

                    }

                    switch (tecla)
                    {
                        case ConsoleKey.DownArrow:
                            respuesta.y++;
                            if (respuesta.y == 8)
                            {
                                respuesta.y = 0;
                            }
                            break;
                        case ConsoleKey.LeftArrow:
                            respuesta.x--;
                            if (respuesta.x == -1)
                            {
                                respuesta.x = 7;
                            }
                            break;
                        case ConsoleKey.UpArrow:
                            respuesta.y--;
                            if (respuesta.y == -1)
                            {
                                respuesta.y = 7;
                            }
                            break;
                        case ConsoleKey.RightArrow:
                            respuesta.x++;
                            if (respuesta.x == 8)
                            {
                                respuesta.x = 0;
                            }
                            break;
                    }
                }
                return respuesta;
            }
        }

        private void pintarcuadrito(int xdesde, int xhasta, int ydesde, int yhasta, ConsoleColor Color)
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
