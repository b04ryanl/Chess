using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace LabAjedrez
{
    class Program
    {
        static void Main(string[] args)
        {
            
            /*Console.WriteLine("Digite nombre del 1er jugador: ");
            string nombrej1= Console.ReadLine();
            Console.WriteLine("Digite nombre del 2do jugador: ");
            string nombrej2 = Console.ReadLine();
            Console.Clear();*/

            Tablero tabla = new Tablero();
            tabla.pintar();
            foreach (var ficha in tabla.FichasJ1)
            {
                ficha.pintar();
            }
            foreach (var ficha in tabla.FichasJ2)
            {
                ficha.pintar();
            }


            while (true)
            {


                ////////////////////////////////////////////////////
                //turno jugador 1

                Posicion posescogida = null;
                Ficha fichaescogida = null;
                List<Posicion> movs = null;
                bool salir = false;
                while (salir == false)
                {
                    Posicion posgenerada = tabla.Seleccionarcuadro(1);
                    Ficha escogida = tabla.buscarfichaJ1(posgenerada);
                    if (escogida != null)
                    {
                        movs = escogida.obtenermovs(tabla);

                        if (movs.Count() > 0)
                        {
                            tabla.pintarposibles(movs);
                            Posicion posgenposibles = tabla.Seleccionarcuadro(1,true,posgenerada,movs);
                            if (movs.Exists(x => x.x == posgenposibles.x && x.y == posgenposibles.y ) == true)
                            {
                                salir = true;
                                posescogida = posgenposibles;
                                fichaescogida = escogida;
                            }
                            else
                            {
                                foreach (var pos in movs)
                                {
                                    if (pos.x % 2 == 0)
                                    {
                                        if (pos.y % 2 == 0)
                                        {
                                            tabla.pintarcuadro(2 + (pos.x * 14), 1 + (pos.y * 10), 1, true);
                                        }
                                        else
                                        {
                                            tabla.pintarcuadro(2 + (pos.x * 14), 1 + (pos.y * 10), 2, true);
                                        }
                                    }
                                    else
                                    {
                                        if (pos.y % 2 == 0)
                                        {
                                            tabla.pintarcuadro(2 + (pos.x * 14), 1 + (pos.y * 10), 2, false);
                                        }
                                        else
                                        {
                                            tabla.pintarcuadro(2 + (pos.x * 14), 1 + (pos.y * 10), 1, false);
                                        }
                                    }

                                    Ficha encont = tabla.buscarficha(pos);
                                    if (encont != null)
                                    {
                                        encont.pintar();
                                    }
                                }
                                if (posgenerada.x % 2 == 0)
                                {
                                    if (posgenerada.y % 2 == 0)
                                    {
                                        tabla.pintarcuadro(2 + (posgenerada.x * 14), 1 + (posgenerada.y * 10), 1, true);
                                    }
                                    else
                                    {
                                        tabla.pintarcuadro(2 + (posgenerada.x * 14), 1 + (posgenerada.y * 10), 2, true);
                                    }
                                }
                                else
                                {
                                    if (posgenerada.y % 2 == 0)
                                    {
                                        tabla.pintarcuadro(2 + (posgenerada.x * 14), 1 + (posgenerada.y * 10), 2, false);
                                    }
                                    else
                                    {
                                        tabla.pintarcuadro(2 + (posgenerada.x * 14), 1 + (posgenerada.y * 10), 1, false);
                                    }
                                }

                                Ficha encontrada = tabla.buscarficha(posgenerada);
                                if (encontrada != null)
                                {
                                    encontrada.pintar();
                                }
                            }
                        }
                    }
                }

                foreach (var pos in movs)
                {
                    if (pos.x % 2 == 0)
                    {
                        if (pos.y % 2 == 0)
                        {
                            tabla.pintarcuadro(2 + (pos.x * 14), 1 + (pos.y * 10), 1, true);
                        }
                        else
                        {
                            tabla.pintarcuadro(2 + (pos.x * 14), 1 + (pos.y * 10), 2, true);
                        }
                    }
                    else
                    {
                        if (pos.y % 2 == 0)
                        {
                            tabla.pintarcuadro(2 + (pos.x * 14), 1 + (pos.y * 10), 2, false);
                        }
                        else
                        {
                            tabla.pintarcuadro(2 + (pos.x * 14), 1 + (pos.y * 10), 1, false);
                        }
                    }

                    Ficha encontrada = tabla.buscarficha(pos);
                    if (encontrada != null)
                    {
                        encontrada.pintar();
                    }
                }


                //Mover
                if (fichaescogida.posicion.x % 2 == 0)
                {
                    if (fichaescogida.posicion.y % 2 == 0)
                    {
                        tabla.pintarcuadro(2 + (fichaescogida.posicion.x * 14), 1 + (fichaescogida.posicion.y * 10), 1, true);
                    }
                    else
                    {
                        tabla.pintarcuadro(2 + (fichaescogida.posicion.x * 14), 1 + (fichaescogida.posicion.y * 10), 2, true);
                    }
                }
                else
                {
                    if (fichaescogida.posicion.y % 2 == 0)
                    {
                        tabla.pintarcuadro(2 + (fichaescogida.posicion.x * 14), 1 + (fichaescogida.posicion.y * 10), 2, false);
                    }
                    else
                    {
                        tabla.pintarcuadro(2 + (fichaescogida.posicion.x * 14), 1 + (fichaescogida.posicion.y * 10), 1, false);
                    }
                }

                tabla.FichasJ1.Remove(fichaescogida);
                fichaescogida.posicion = posescogida;
                tabla.FichasJ1.Add(fichaescogida);
                fichaescogida.pintar();


                Ficha fichamatar = tabla.buscarfichaJ2(posescogida);
                if ( fichamatar != null)
                {
                    //Matar
                    tabla.FichasJ2.Remove(fichamatar);
                    tabla.FichasJ2muertas.Add(fichamatar);
                    int x = 0, y = 0;
                    foreach (var ficha in tabla.FichasJ2muertas)
                    {
                        ficha.posicion.x = x + 12;
                        ficha.posicion.y = y + 5;
                        ficha.pintar();
                        x++;
                        if (x > 4)
                        {
                            x = 0;
                            y++;
                        }
                    }

                }


                ////////////////////////////////////////////////////
                //turno jugador 2

                posescogida = null;
                fichaescogida = null;
                movs = null;
                salir = false;
                while (salir == false)
                {
                    Posicion posgenerada = tabla.Seleccionarcuadro(2);
                    Ficha escogida = tabla.buscarfichaJ2(posgenerada);
                    if (escogida != null)
                    {
                        movs = escogida.obtenermovs(tabla);

                        if (movs.Count() > 0)
                        {
                            tabla.pintarposibles(movs);
                            Posicion posgenposibles = tabla.Seleccionarcuadro(2, true, posgenerada, movs);
                            if (movs.Exists(x => x.x == posgenposibles.x && x.y == posgenposibles.y) == true)
                            {
                                salir = true;
                                posescogida = posgenposibles;
                                fichaescogida = escogida;
                            }
                            else
                            {
                                foreach (var pos in movs)
                                {
                                    if (pos.x % 2 == 0)
                                    {
                                        if (pos.y % 2 == 0)
                                        {
                                            tabla.pintarcuadro(2 + (pos.x * 14), 1 + (pos.y * 10), 1, true);
                                        }
                                        else
                                        {
                                            tabla.pintarcuadro(2 + (pos.x * 14), 1 + (pos.y * 10), 2, true);
                                        }
                                    }
                                    else
                                    {
                                        if (pos.y % 2 == 0)
                                        {
                                            tabla.pintarcuadro(2 + (pos.x * 14), 1 + (pos.y * 10), 2, false);
                                        }
                                        else
                                        {
                                            tabla.pintarcuadro(2 + (pos.x * 14), 1 + (pos.y * 10), 1, false);
                                        }
                                    }

                                    Ficha encont = tabla.buscarficha(pos);
                                    if (encont != null)
                                    {
                                        encont.pintar();
                                    }
                                }

                                if (posgenerada.x % 2 == 0)
                                {
                                    if (posgenerada.y % 2 == 0)
                                    {
                                        tabla.pintarcuadro(2 + (posgenerada.x * 14), 1 + (posgenerada.y * 10), 1, true);
                                    }
                                    else
                                    {
                                        tabla.pintarcuadro(2 + (posgenerada.x * 14), 1 + (posgenerada.y * 10), 2, true);
                                    }
                                }
                                else
                                {
                                    if (posgenerada.y % 2 == 0)
                                    {
                                        tabla.pintarcuadro(2 + (posgenerada.x * 14), 1 + (posgenerada.y * 10), 2, false);
                                    }
                                    else
                                    {
                                        tabla.pintarcuadro(2 + (posgenerada.x * 14), 1 + (posgenerada.y * 10), 1, false);
                                    }
                                }

                                Ficha encontrada = tabla.buscarficha(posgenerada);
                                if (encontrada != null)
                                {
                                    encontrada.pintar();
                                }
                            }
                        }
                    }
                }

                foreach (var pos in movs)
                {
                    if (pos.x % 2 == 0)
                    {
                        if (pos.y % 2 == 0)
                        {
                            tabla.pintarcuadro(2 + (pos.x * 14), 1 + (pos.y * 10), 1, true);
                        }
                        else
                        {
                            tabla.pintarcuadro(2 + (pos.x * 14), 1 + (pos.y * 10), 2, true);
                        }
                    }
                    else
                    {
                        if (pos.y % 2 == 0)
                        {
                            tabla.pintarcuadro(2 + (pos.x * 14), 1 + (pos.y * 10), 2, false);
                        }
                        else
                        {
                            tabla.pintarcuadro(2 + (pos.x * 14), 1 + (pos.y * 10), 1, false);
                        }
                    }

                    Ficha encontrada = tabla.buscarficha(pos);
                    if (encontrada != null)
                    {
                        encontrada.pintar();
                    }
                }


                //Mover
                if (fichaescogida.posicion.x % 2 == 0)
                {
                    if (fichaescogida.posicion.y % 2 == 0)
                    {
                        tabla.pintarcuadro(2 + (fichaescogida.posicion.x * 14), 1 + (fichaescogida.posicion.y * 10), 1, true);
                    }
                    else
                    {
                        tabla.pintarcuadro(2 + (fichaescogida.posicion.x * 14), 1 + (fichaescogida.posicion.y * 10), 2, true);
                    }
                }
                else
                {
                    if (fichaescogida.posicion.y % 2 == 0)
                    {
                        tabla.pintarcuadro(2 + (fichaescogida.posicion.x * 14), 1 + (fichaescogida.posicion.y * 10), 2, false);
                    }
                    else
                    {
                        tabla.pintarcuadro(2 + (fichaescogida.posicion.x * 14), 1 + (fichaescogida.posicion.y * 10), 1, false);
                    }
                }

                tabla.FichasJ2.Remove(fichaescogida);
                fichaescogida.posicion = posescogida;
                tabla.FichasJ2.Add(fichaescogida);
                fichaescogida.pintar();


                Ficha fichamatar2 = tabla.buscarfichaJ1(posescogida);
                if (fichamatar2 != null)
                {
                    //Matar
                    tabla.FichasJ1.Remove(fichamatar2);
                    tabla.FichasJ1muertas.Add(fichamatar2);
                    int x = 0, y = 0;
                    foreach (var ficha in tabla.FichasJ1muertas)
                    {
                        ficha.posicion.x = x + 12;
                        ficha.posicion.y = y;
                        ficha.pintar();
                        x++;
                        if (x > 4)
                        {
                            x = 0;
                            y++;
                        }
                    }

                }


            }




            /*
            
            ConsoleKey tecla = ConsoleKey.A;

            Peon peon = new Peon('A', 2, ConsoleColor.White);
            peon.PintarPeon();
            Peon peon2 = new Peon('B', 2, ConsoleColor.White);
            peon2.PintarPeon();
            Peon peon3 = new Peon('C', 2, ConsoleColor.White);
            peon3.PintarPeon();
            Peon peon4 = new Peon('D', 2, ConsoleColor.White);
            peon4.PintarPeon();
            Peon peon5 = new Peon('E', 2, ConsoleColor.White);
            peon5.PintarPeon();
            Peon peon6 = new Peon('F', 2, ConsoleColor.White);
            peon6.PintarPeon();
            Peon peon7 = new Peon('G', 2, ConsoleColor.White);
            peon7.PintarPeon();
            Peon peon8 = new Peon('H', 2, ConsoleColor.White);
            peon8.PintarPeon();

            Torre torre = new Torre('A', 1, ConsoleColor.White);
            torre.PintarTorre();
            Torre torre2 = new Torre('H', 1, ConsoleColor.White);
            torre2.PintarTorre();

            Caballo caballo = new Caballo('B', 1, ConsoleColor.White);
            caballo.PintarCaballo();
            Caballo caballo2 = new Caballo('G', 1, ConsoleColor.White);
            caballo2.PintarCaballo();

            Arfil arfil = new Arfil('C', 1, ConsoleColor.White);
            arfil.PintarArfil();
            Arfil arfil2 = new Arfil('F', 1, ConsoleColor.White);
            arfil2.PintarArfil();

            Reina reina = new Reina('D', 1, ConsoleColor.White);
            reina.PintarReina();

            Rey rey = new Rey('E', 1, ConsoleColor.White);
            rey.PintarRey();






            Peon peon9 = new Peon('A', 7, ConsoleColor.Red);
            peon9.PintarPeon();
            Peon peon10 = new Peon('B', 7, ConsoleColor.Red);
            peon10.PintarPeon();
            Peon peon11 = new Peon('C', 7, ConsoleColor.Red);
            peon11.PintarPeon();
            Peon peon12 = new Peon('D', 7, ConsoleColor.Red);
            peon12.PintarPeon();
            Peon peon13 = new Peon('E', 7, ConsoleColor.Red);
            peon13.PintarPeon();
            Peon peon14 = new Peon('F', 7, ConsoleColor.Red);
            peon14.PintarPeon();
            Peon peon15 = new Peon('G', 7, ConsoleColor.Red);
            peon15.PintarPeon();
            Peon peon16 = new Peon('H', 7, ConsoleColor.Red);
            peon16.PintarPeon();

            Torre torre3 = new Torre('A', 8, ConsoleColor.Red);
            torre3.PintarTorre();
            Torre torre4 = new Torre('H', 8, ConsoleColor.Red);
            torre4.PintarTorre();

            Caballo caballo3 = new Caballo('B', 8, ConsoleColor.Red);
            caballo3.PintarCaballo();
            Caballo caballo4 = new Caballo('G', 8, ConsoleColor.Red);
            caballo4.PintarCaballo();

            Arfil arfil3 = new Arfil('C', 8, ConsoleColor.Red);
            arfil3.PintarArfil();
            Arfil arfil4 = new Arfil('F', 8, ConsoleColor.Red);
            arfil4.PintarArfil();

            Reina reina2 = new Reina('D', 8, ConsoleColor.Red);
            reina2.PintarReina();

            Rey rey2 = new Rey('E', 8, ConsoleColor.Red);
            rey2.PintarRey();


            do
            {
                Console.SetCursorPosition(0, 0);
                Point position = Mouse.GetPosition(displayArea);

                if (Console.KeyAvailable)
                {
                    tecla = Console.ReadKey().Key;
                }
                Console.SetCursorPosition(170, 5);
                Console.Write("Seleccione numero de columna inicial: ");
                string ColumnaInicial = Console.ReadLine();
                Console.SetCursorPosition(170, 10);
                Console.Write("Seleccione letra de fila inicial: ");
                string FilaInicial = Console.ReadLine();
                int datoColumnaInicial = int.Parse(ColumnaInicial);
                char[] Letra = FilaInicial.ToCharArray();

                Console.SetCursorPosition(170, 15);
                Console.Write("Seleccione numero de columna final: ");
                string DatoA = Console.ReadLine();
                Console.SetCursorPosition(170, 20);
                Console.Write("Seleccione letra de fila final: ");
                string DatoB = Console.ReadLine();
                int datoconvertido = int.Parse(DatoA);
                char[] LetraFinal = DatoB.ToCharArray();

                if (peon.posicionL == Letra[0] && peon.posicionN == datoColumnaInicial)
                {

                    if (peon.posicionL==LetraFinal[0])
                    {

                        if (datoconvertido-datoColumnaInicial<=2)
                        {
                            peon.color = ConsoleColor.Black;
                            peon.PintarPeon();
                            peon.color = ConsoleColor.White;
                            peon.posicionL = LetraFinal[0];
                            peon.posicionN = datoconvertido;
                            peon.PintarPeon();

                        }
                        else
                        {
                            Console.SetCursorPosition(170, 25);
                            Console.WriteLine("Movimiento inválido");
                                                    
                        }
                    }
                    else
                    {
                        Console.SetCursorPosition(170, 30);
                        Console.WriteLine("Movimiento inválido");
                    }
                    
                }

                if (peon2.posicionL == Letra[0] && peon2.posicionN == datoColumnaInicial)
                {
                    if (peon2.posicionL == LetraFinal[0])
                    {

                        if (datoconvertido - datoColumnaInicial <= 2)
                        {
                            peon2.color = ConsoleColor.Black;
                            peon2.PintarPeon();
                            peon2.color = ConsoleColor.White;
                            peon2.posicionL = LetraFinal[0];
                            peon2.posicionN = datoconvertido;
                            peon2.PintarPeon();

                        }
                        else
                        {
                            Console.SetCursorPosition(170, 25);
                            Console.WriteLine("Movimiento inválido");

                        }
                    }
                    else
                    {
                        Console.SetCursorPosition(170, 30);
                        Console.WriteLine("Movimiento inválido");
                    }
                }

                if (peon3.posicionL == Letra[0] && peon3.posicionN == datoColumnaInicial)
                {
                    if (peon3.posicionL == LetraFinal[0])
                    {

                        if (datoconvertido - datoColumnaInicial <= 2)
                        {
                            peon3.color = ConsoleColor.Black;
                            peon3.PintarPeon();
                            peon3.color = ConsoleColor.White;
                            peon3.posicionL = LetraFinal[0];
                            peon3.posicionN = datoconvertido;
                            peon3.PintarPeon();

                        }
                        else
                        {
                            Console.SetCursorPosition(170, 25);
                            Console.WriteLine("Movimiento inválido");

                        }
                    }
                    else
                    {
                        Console.SetCursorPosition(170, 30);
                        Console.WriteLine("Movimiento inválido");
                    }
                }

                if (peon4.posicionL == Letra[0] && peon4.posicionN == datoColumnaInicial)
                {
                    if (peon4.posicionL == LetraFinal[0])
                    {

                        if (datoconvertido - datoColumnaInicial <= 2)
                        {
                            peon4.color = ConsoleColor.Black;
                            peon4.PintarPeon();
                            peon4.color = ConsoleColor.White;
                            peon4.posicionL = LetraFinal[0];
                            peon4.posicionN = datoconvertido;
                            peon4.PintarPeon();

                        }
                        else
                        {
                            Console.SetCursorPosition(170, 25);
                            Console.WriteLine("Movimiento inválido");

                        }
                    }
                    else
                    {
                        Console.SetCursorPosition(170, 30);
                        Console.WriteLine("Movimiento inválido");
                    }
                }

                if (peon5.posicionL == Letra[0] && peon5.posicionN == datoColumnaInicial)
                {
                    if (peon5.posicionL == LetraFinal[0])
                    {

                        if (datoconvertido - datoColumnaInicial <= 2)
                        {
                            peon5.color = ConsoleColor.Black;
                            peon5.PintarPeon();
                            peon5.color = ConsoleColor.White;
                            peon5.posicionL = LetraFinal[0];
                            peon5.posicionN = datoconvertido;
                            peon5.PintarPeon();

                        }
                        else
                        {
                            Console.SetCursorPosition(170, 25);
                            Console.WriteLine("Movimiento inválido");

                        }
                    }
                    else
                    {
                        Console.SetCursorPosition(170, 25);
                        Console.WriteLine("Movimiento inválido");

                    }
                }


                if (peon6.posicionL == Letra[0] && peon6.posicionN == datoColumnaInicial)
                {
                    if (peon6.posicionL == LetraFinal[0])
                    {

                        if (datoconvertido - datoColumnaInicial <= 2)
                        {
                            peon6.color = ConsoleColor.Black;
                            peon6.PintarPeon();
                            peon6.color = ConsoleColor.White;
                            peon6.posicionL = LetraFinal[0];
                            peon6.posicionN = datoconvertido;
                            peon6.PintarPeon();

                        }
                        else
                        {
                            Console.SetCursorPosition(170, 25);
                            Console.WriteLine("Movimiento inválido");

                        }
                    }
                    else
                    {
                        Console.SetCursorPosition(170, 25);
                        Console.WriteLine("Movimiento inválido");

                    }
                }


                if (peon7.posicionL == Letra[0] && peon7.posicionN == datoColumnaInicial)
                {
                    if (peon7.posicionL == LetraFinal[0])
                    {

                        if (datoconvertido - datoColumnaInicial <= 2)
                        {
                            peon7.color = ConsoleColor.Black;
                            peon7.PintarPeon();
                            peon7.color = ConsoleColor.White;
                            peon7.posicionL = LetraFinal[0];
                            peon7.posicionN = datoconvertido;
                            peon7.PintarPeon();

                        }
                        else
                        {
                            Console.SetCursorPosition(170, 25);
                            Console.WriteLine("Movimiento inválido");

                        }
                    }
                    else
                    {
                        Console.SetCursorPosition(170, 25);
                        Console.WriteLine("Movimiento inválido");

                    }
                }



                if (peon8.posicionL == Letra[0] && peon8.posicionN == datoColumnaInicial)
                {
                    if (peon8.posicionL == LetraFinal[0])
                    {

                        if (datoconvertido - datoColumnaInicial <= 2)
                        {
                            peon8.color = ConsoleColor.Black;
                            peon8.PintarPeon();
                            peon8.color = ConsoleColor.Red;
                            peon8.posicionL = LetraFinal[0];
                            peon8.posicionN = datoconvertido;
                            peon8.PintarPeon();

                        }
                        else
                        {
                            Console.SetCursorPosition(170, 25);
                            Console.WriteLine("Movimiento inválido");

                        }
                    }
                    else
                    {
                        Console.SetCursorPosition(170, 30);
                        Console.WriteLine("Movimiento inválido");
                    }
                    
                }


                if (peon9.posicionL == Letra[0] && peon9.posicionN == datoColumnaInicial)
                {
                    if (peon9.posicionL == LetraFinal[0])
                    {

                        if (datoconvertido - datoColumnaInicial <= 2)
                        {
                            peon9.color = ConsoleColor.Black;
                            peon9.PintarPeon();
                            peon9.color = ConsoleColor.Red;
                            peon9.posicionL = LetraFinal[0];
                            peon9.posicionN = datoconvertido;
                            peon9.PintarPeon();

                        }
                        else
                        {
                            Console.SetCursorPosition(170, 25);
                            Console.WriteLine("Movimiento inválido");

                        }
                    }
                    else
                    {
                        Console.SetCursorPosition(170, 30);
                        Console.WriteLine("Movimiento inválido");
                    }

                }


                if (peon10.posicionL == Letra[0] && peon10.posicionN == datoColumnaInicial)
                {
                    if (peon10.posicionL == LetraFinal[0])
                    {

                        if (datoconvertido - datoColumnaInicial <= 2)
                        {
                            peon10.color = ConsoleColor.Black;
                            peon10.PintarPeon();
                            peon10.color = ConsoleColor.Red;
                            peon10.posicionL = LetraFinal[0];
                            peon10.posicionN = datoconvertido;
                            peon10.PintarPeon();

                        }
                        else
                        {
                            Console.SetCursorPosition(170, 25);
                            Console.WriteLine("Movimiento inválido");

                        }
                    }
                    else
                    {
                        Console.SetCursorPosition(170, 30);
                        Console.WriteLine("Movimiento inválido");
                    }

                }


                if (peon11.posicionL == Letra[0] && peon11.posicionN == datoColumnaInicial)
                {
                    if (peon11.posicionL == LetraFinal[0])
                    {

                        if (datoconvertido - datoColumnaInicial <= 2)
                        {
                            peon11.color = ConsoleColor.Black;
                            peon11.PintarPeon();
                            peon11.color = ConsoleColor.Red;
                            peon11.posicionL = LetraFinal[0];
                            peon11.posicionN = datoconvertido;
                            peon11.PintarPeon();

                        }
                        else
                        {
                            Console.SetCursorPosition(170, 25);
                            Console.WriteLine("Movimiento inválido");

                        }
                    }
                    else
                    {
                        Console.SetCursorPosition(170, 30);
                        Console.WriteLine("Movimiento inválido");
                    }

                }



                if (peon12.posicionL == Letra[0] && peon12.posicionN == datoColumnaInicial)
                {
                    if (peon12.posicionL == LetraFinal[0])
                    {

                        if (datoconvertido - datoColumnaInicial <= 2)
                        {
                            peon12.color = ConsoleColor.Black;
                            peon12.PintarPeon();
                            peon12.color = ConsoleColor.Red;
                            peon12.posicionL = LetraFinal[0];
                            peon12.posicionN = datoconvertido;
                            peon12.PintarPeon();

                        }
                        else
                        {
                            Console.SetCursorPosition(170, 25);
                            Console.WriteLine("Movimiento inválido");

                        }
                    }
                    else
                    {
                        Console.SetCursorPosition(170, 30);
                        Console.WriteLine("Movimiento inválido");
                    }

                }



                if (peon13.posicionL == Letra[0] && peon13.posicionN == datoColumnaInicial)
                {
                    if (peon13.posicionL == LetraFinal[0])
                    {

                        if (datoconvertido - datoColumnaInicial <= 2)
                        {
                            peon13.color = ConsoleColor.Black;
                            peon13.PintarPeon();
                            peon13.color = ConsoleColor.Red;
                            peon13.posicionL = LetraFinal[0];
                            peon13.posicionN = datoconvertido;
                            peon13.PintarPeon();

                        }
                        else
                        {
                            Console.SetCursorPosition(170, 25);
                            Console.WriteLine("Movimiento inválido");

                        }
                    }
                    else
                    {
                        Console.SetCursorPosition(170, 30);
                        Console.WriteLine("Movimiento inválido");
                    }

                }



                if (peon14.posicionL == Letra[0] && peon14.posicionN == datoColumnaInicial)
                {
                    if (peon14.posicionL == LetraFinal[0])
                    {

                        if (datoconvertido - datoColumnaInicial <= 2)
                        {
                            peon14.color = ConsoleColor.Black;
                            peon14.PintarPeon();
                            peon14.color = ConsoleColor.Red;
                            peon14.posicionL = LetraFinal[0];
                            peon14.posicionN = datoconvertido;
                            peon14.PintarPeon();

                        }
                        else
                        {
                            Console.SetCursorPosition(170, 25);
                            Console.WriteLine("Movimiento inválido");

                        }
                    }
                    else
                    {
                        Console.SetCursorPosition(170, 30);
                        Console.WriteLine("Movimiento inválido");
                    }

                }



                if (peon15.posicionL == Letra[0] && peon15.posicionN == datoColumnaInicial)
                {
                    if (peon15.posicionL == LetraFinal[0])
                    {

                        if (datoconvertido - datoColumnaInicial <= 2)
                        {
                            peon15.color = ConsoleColor.Black;
                            peon15.PintarPeon();
                            peon15.color = ConsoleColor.Red;
                            peon15.posicionL = LetraFinal[0];
                            peon15.posicionN = datoconvertido;
                            peon15.PintarPeon();

                        }
                        else
                        {
                            Console.SetCursorPosition(170, 25);
                            Console.WriteLine("Movimiento inválido");

                        }
                    }
                    else
                    {
                        Console.SetCursorPosition(170, 30);
                        Console.WriteLine("Movimiento inválido");
                    }

                }


                if (peon16.posicionL == Letra[0] && peon16.posicionN == datoColumnaInicial)
                {
                    if (peon16.posicionL == LetraFinal[0])
                    {

                        if (datoconvertido - datoColumnaInicial <= 2)
                        {
                            peon16.color = ConsoleColor.Black;
                            peon16.PintarPeon();
                            peon16.color = ConsoleColor.Red;
                            peon16.posicionL = LetraFinal[0];
                            peon16.posicionN = datoconvertido;
                            peon16.PintarPeon();

                        }
                        else
                        {
                            Console.SetCursorPosition(170, 25);
                            Console.WriteLine("Movimiento inválido");

                        }
                    }
                    else
                    {
                        Console.SetCursorPosition(170, 30);
                        Console.WriteLine("Movimiento inválido");
                    }

                }



                if (torre.posicionL == Letra[0] && torre.posicionN == datoColumnaInicial)
                {
                    if (torre.posicionL == LetraFinal[0])
                    {
                        torre.color = ConsoleColor.Black;
                        torre.PintarTorre();
                        torre.color = ConsoleColor.White;
                        torre.posicionL = LetraFinal[0];
                        torre.posicionN = datoconvertido;
                        torre.PintarTorre();

                        if (torre.posicionN == datoconvertido)
                        {
                            torre.color = ConsoleColor.Black;
                            torre.PintarTorre();
                            torre.color = ConsoleColor.White;
                            torre.posicionL = LetraFinal[0];
                            torre.posicionN = datoconvertido;
                            torre.PintarTorre();
                        }
                        else
                        {
                            Console.SetCursorPosition(170, 30);
                            Console.WriteLine("Movimiento inválido");
                        }

                    }
                    else
                    {
                        Console.SetCursorPosition(170, 30);
                        Console.WriteLine("Movimiento inválido");
                    }

                }
                if (torre2.posicionL == Letra[0] && torre2.posicionN == datoColumnaInicial)
                {
                    torre2.posicionL = LetraFinal[0];
                    torre2.posicionN = datoconvertido;
                    torre2.PintarTorre();
                }
                if (torre3.posicionL == Letra[0] && torre3.posicionN == datoColumnaInicial)
                {
                    torre3.posicionL = LetraFinal[0];
                    torre3.posicionN = datoconvertido;
                    torre3.PintarTorre();
                }
                if (torre4.posicionL == Letra[0] && torre4.posicionN == datoColumnaInicial)
                {
                    torre4.posicionL = LetraFinal[0];
                    torre4.posicionN = datoconvertido;
                    torre4.PintarTorre();
                }

                if (caballo.posicionL == Letra[0] && caballo.posicionN == datoColumnaInicial)
                {
                    caballo.posicionL = LetraFinal[0];
                    caballo.posicionN = datoconvertido;
                    caballo.PintarCaballo();
                }
                if (caballo2.posicionL == Letra[0] && caballo2.posicionN == datoColumnaInicial)
                {
                    caballo2.posicionL = LetraFinal[0];
                    caballo2.posicionN = datoconvertido;
                    caballo2.PintarCaballo();
                }
                if (caballo3.posicionL == Letra[0] && caballo3.posicionN == datoColumnaInicial)
                {
                    caballo3.posicionL = LetraFinal[0];
                    caballo3.posicionN = datoconvertido;
                    caballo3.PintarCaballo();
                }
                if (caballo4.posicionL == Letra[0] && caballo4.posicionN == datoColumnaInicial)
                {
                    caballo4.posicionL = LetraFinal[0];
                    caballo4.posicionN = datoconvertido;
                    caballo4.PintarCaballo();
                }


                if (arfil.posicionL == Letra[0] && arfil.posicionN == datoColumnaInicial)
                {
                    arfil.posicionL = LetraFinal[0];
                    arfil.posicionN = datoconvertido;
                    arfil.PintarArfil();
                }
                if (arfil2.posicionL == Letra[0] && arfil2.posicionN == datoColumnaInicial)
                {
                    arfil2.posicionL = LetraFinal[0];
                    arfil2.posicionN = datoconvertido;
                    arfil2.PintarArfil();
                }
                if (arfil3.posicionL == Letra[0] && arfil3.posicionN == datoColumnaInicial)
                {
                    arfil3.posicionL = LetraFinal[0];
                    arfil3.posicionN = datoconvertido;
                    arfil3.PintarArfil();
                }
                if (arfil4.posicionL == Letra[0] && arfil4.posicionN == datoColumnaInicial)
                {
                    arfil4.posicionL = LetraFinal[0];
                    arfil4.posicionN = datoconvertido;
                    arfil4.PintarArfil();
                }

                if (reina.posicionL == Letra[0] && reina.posicionN == datoColumnaInicial)
                {
                    reina.posicionL = LetraFinal[0];
                    reina.posicionN = datoconvertido;
                    reina.PintarReina();
                }
                if (reina2.posicionL == Letra[0] && reina2.posicionN == datoColumnaInicial)
                {
                    reina2.posicionL = LetraFinal[0];
                    reina2.posicionN = datoconvertido;
                    reina2.PintarReina();
                }

                if (rey.posicionL == Letra[0] && rey.posicionN == datoColumnaInicial)
                {
                    rey.posicionL = LetraFinal[0];
                    rey.posicionN = datoconvertido;
                    rey.PintarRey();
                }
                if (rey2.posicionL == Letra[0] && rey2.posicionN == datoColumnaInicial)
                {
                    rey2.posicionL = LetraFinal[0];
                    rey2.posicionN = datoconvertido;
                    rey2.PintarRey();
                }
                Console.ReadKey();
            } while (tecla!=ConsoleKey.Escape);

            */
        }

    }
}
