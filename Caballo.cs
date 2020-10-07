using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabAjedrez
{
    class Caballo:Ficha
    {
        public Caballo(Posicion posini, ConsoleColor colorini) : base(posini, colorini)
        {
            posicion = posini;
            color = colorini;
        }

        public override void pintar()
        {
            Console.BackgroundColor = ConsoleColor.Black;
            int x = 2 + (posicion.x * 14 + 5);
            int y = 1 + (posicion.y * 10 + 3);

            Console.SetCursorPosition(x + 1, y);
            Console.ForegroundColor = color;
            Console.WriteLine("  ▄  ");

            Console.SetCursorPosition(x, y + 1);
            Console.ForegroundColor = color;
            Console.WriteLine("  █  ");

            Console.SetCursorPosition(x, y + 2);
            Console.ForegroundColor = color;
            Console.WriteLine(" ▄▄▄ ");
        }

        public override List<Posicion> obtenermovs(Tablero tablaAlizar)
        {
            List<Posicion> resultado = new List<Posicion>();

            if (color == ConsoleColor.White)
            {
                //J1
                if (tablaAlizar.buscarficha(new Posicion(posicion.x+1, posicion.y - 2)) == null)//arriba-derecha
                {
                    if (posicion.x + 1 < 8 && posicion.y - 2 >=0)
                    {
                        resultado.Add(new Posicion(posicion.x + 1, posicion.y - 2));
                    }
                }
                else
                {
                    if(tablaAlizar.buscarfichaJ2(new Posicion(posicion.x + 1, posicion.y - 2)) != null)
                    {
                        resultado.Add(new Posicion(posicion.x + 1, posicion.y - 2));
                    }
                }

                /////////////////////////////////////////////////////////////////////////////////
                if (tablaAlizar.buscarficha(new Posicion(posicion.x-1, posicion.y - 2)) == null)//arriba-izquierda
                {
                    if (posicion.x - 1 >= 0 && posicion.y - 2 >= 0)
                    {
                        resultado.Add(new Posicion(posicion.x - 1, posicion.y - 2));
                    }
                }
                else
                {
                    if (tablaAlizar.buscarfichaJ2(new Posicion(posicion.x - 1, posicion.y - 2)) != null)
                    {
                        resultado.Add(new Posicion(posicion.x - 1, posicion.y - 2));
                    }
                }

                /////////////////////////////////////////////////////////////////////////////////
                if (tablaAlizar.buscarficha(new Posicion(posicion.x + 2, posicion.y - 1)) == null)//derecha-arriba
                {
                    if (posicion.x +2 < 8 && posicion.y - 1 >= 0)
                    {
                        resultado.Add(new Posicion(posicion.x + 2, posicion.y - 1));
                    }
                }
                else
                {
                    if (tablaAlizar.buscarfichaJ2(new Posicion(posicion.x + 2, posicion.y - 1)) != null)
                    {
                        resultado.Add(new Posicion(posicion.x +2, posicion.y - 1));
                    }
                }

                /////////////////////////////////////////////////////////////////////////////////
                if (tablaAlizar.buscarficha(new Posicion(posicion.x + 2, posicion.y + 1)) == null)//derecha-abajo
                {
                    if (posicion.x + 2 < 8 && posicion.y + 1 < 8)
                    {
                        resultado.Add(new Posicion(posicion.x + 2, posicion.y + 1));
                    }
                }
                else
                {
                    if (tablaAlizar.buscarfichaJ2(new Posicion(posicion.x + 2, posicion.y + 1)) != null)
                    {
                        resultado.Add(new Posicion(posicion.x + 2, posicion.y + 1));
                    }
                }

                /////////////////////////////////////////////////////////////////////////////////
                if (tablaAlizar.buscarficha(new Posicion(posicion.x - 2, posicion.y - 1)) == null)//izquierda-arriba
                {
                    if (posicion.x - 2 >=0 && posicion.y - 1 >= 0)
                    {
                        resultado.Add(new Posicion(posicion.x - 2, posicion.y - 1));
                    }
                }
                else
                {
                    if (tablaAlizar.buscarfichaJ2(new Posicion(posicion.x - 2, posicion.y - 1)) != null)
                    {
                        resultado.Add(new Posicion(posicion.x - 2, posicion.y - 1));
                    }
                }

                /////////////////////////////////////////////////////////////////////////////////
                if (tablaAlizar.buscarficha(new Posicion(posicion.x - 2, posicion.y + 1)) == null)//izquierda-abajo
                {
                    if (posicion.x - 2 >=0 && posicion.y + 1 < 8)
                    {
                        resultado.Add(new Posicion(posicion.x - 2, posicion.y + 1));
                    }
                }
                else
                {
                    if (tablaAlizar.buscarfichaJ2(new Posicion(posicion.x - 2, posicion.y + 1)) != null)
                    {
                        resultado.Add(new Posicion(posicion.x - 2, posicion.y + 1));
                    }
                }

                ///////////////////////////////////////////////////////////////////////////////////
                if (tablaAlizar.buscarficha(new Posicion(posicion.x + 1, posicion.y + 2)) == null)//abajo-derecha
                {
                    if (posicion.x + 1 < 8 && posicion.y + 2 < 8)
                    {
                        resultado.Add(new Posicion(posicion.x + 1, posicion.y + 2));
                    }
                }
                else
                {
                    if (tablaAlizar.buscarfichaJ2(new Posicion(posicion.x + 1, posicion.y + 2)) != null)
                    {
                        resultado.Add(new Posicion(posicion.x + 1, posicion.y + 2));
                    }
                }

                /////////////////////////////////////////////////////////////////////////////////
                if (tablaAlizar.buscarficha(new Posicion(posicion.x - 1, posicion.y + 2)) == null)//abajo-izquierda
                {
                    if (posicion.x - 1 >= 0 && posicion.y + 2 < 8)
                    {
                        resultado.Add(new Posicion(posicion.x - 1, posicion.y + 2));
                    }
                }
                else
                {
                    if (tablaAlizar.buscarfichaJ2(new Posicion(posicion.x - 1, posicion.y + 2)) != null)
                    {
                        resultado.Add(new Posicion(posicion.x - 1, posicion.y + 2));
                    }
                }


            }
            else
            {
                //J2
                if (tablaAlizar.buscarficha(new Posicion(posicion.x + 1, posicion.y - 2)) == null)//arriba-derecha
                {
                    if (posicion.x + 1 < 8 && posicion.y - 2 >= 0)
                    {
                        resultado.Add(new Posicion(posicion.x + 1, posicion.y - 2));
                    }
                }
                else
                {
                    if (tablaAlizar.buscarfichaJ1(new Posicion(posicion.x + 1, posicion.y - 2)) != null)
                    {
                        resultado.Add(new Posicion(posicion.x + 1, posicion.y - 2));
                    }
                }

                /////////////////////////////////////////////////////////////////////////////////
                if (tablaAlizar.buscarficha(new Posicion(posicion.x - 1, posicion.y - 2)) == null)//arriba-izquierda
                {
                    if (posicion.x - 1 >= 0 && posicion.y - 2 >= 0)
                    {
                        resultado.Add(new Posicion(posicion.x - 1, posicion.y - 2));
                    }
                }
                else
                {
                    if (tablaAlizar.buscarfichaJ1(new Posicion(posicion.x - 1, posicion.y - 2)) != null)
                    {
                        resultado.Add(new Posicion(posicion.x - 1, posicion.y - 2));
                    }
                }

                /////////////////////////////////////////////////////////////////////////////////
                if (tablaAlizar.buscarficha(new Posicion(posicion.x + 2, posicion.y - 1)) == null)//derecha-arriba
                {
                    if (posicion.x + 2 < 8 && posicion.y - 1 >= 0)
                    {
                        resultado.Add(new Posicion(posicion.x + 2, posicion.y - 1));
                    }
                }
                else
                {
                    if (tablaAlizar.buscarfichaJ1(new Posicion(posicion.x + 2, posicion.y - 1)) != null)
                    {
                        resultado.Add(new Posicion(posicion.x + 2, posicion.y - 1));
                    }
                }

                /////////////////////////////////////////////////////////////////////////////////
                if (tablaAlizar.buscarficha(new Posicion(posicion.x + 2, posicion.y + 1)) == null)//derecha-abajo
                {
                    if (posicion.x + 2 < 8 && posicion.y + 1 < 8)
                    {
                        resultado.Add(new Posicion(posicion.x + 2, posicion.y + 1));
                    }
                }
                else
                {
                    if (tablaAlizar.buscarfichaJ1(new Posicion(posicion.x + 2, posicion.y + 1)) != null)
                    {
                        resultado.Add(new Posicion(posicion.x + 2, posicion.y + 1));
                    }
                }

                /////////////////////////////////////////////////////////////////////////////////
                if (tablaAlizar.buscarficha(new Posicion(posicion.x - 2, posicion.y - 1)) == null)//izquierda-arriba
                {
                    if (posicion.x - 2 >= 0 && posicion.y - 1 >= 0)
                    {
                        resultado.Add(new Posicion(posicion.x - 2, posicion.y - 1));
                    }
                }
                else
                {
                    if (tablaAlizar.buscarfichaJ1(new Posicion(posicion.x - 2, posicion.y - 1)) != null)
                    {
                        resultado.Add(new Posicion(posicion.x - 2, posicion.y - 1));
                    }
                }

                /////////////////////////////////////////////////////////////////////////////////
                if (tablaAlizar.buscarficha(new Posicion(posicion.x - 2, posicion.y + 1)) == null)//izquierda-abajo
                {
                    if (posicion.x - 2 >= 0 && posicion.y + 1 < 8)
                    {
                        resultado.Add(new Posicion(posicion.x - 2, posicion.y + 1));
                    }
                }
                else
                {
                    if (tablaAlizar.buscarfichaJ1(new Posicion(posicion.x - 2, posicion.y + 1)) != null)
                    {
                        resultado.Add(new Posicion(posicion.x - 2, posicion.y + 1));
                    }
                }

                ///////////////////////////////////////////////////////////////////////////////////
                if (tablaAlizar.buscarficha(new Posicion(posicion.x + 1, posicion.y + 2)) == null)//abajo-derecha
                {
                    if (posicion.x + 1 < 8 && posicion.y + 2 < 8)
                    {
                        resultado.Add(new Posicion(posicion.x + 1, posicion.y + 2));
                    }
                }
                else
                {
                    if (tablaAlizar.buscarfichaJ1(new Posicion(posicion.x + 1, posicion.y + 2)) != null)
                    {
                        resultado.Add(new Posicion(posicion.x + 1, posicion.y + 2));
                    }
                }

                /////////////////////////////////////////////////////////////////////////////////
                if (tablaAlizar.buscarficha(new Posicion(posicion.x - 1, posicion.y + 2)) == null)//abajo-izquierda
                {
                    if (posicion.x - 1 >= 0 && posicion.y + 2 < 8)
                    {
                        resultado.Add(new Posicion(posicion.x - 1, posicion.y + 2));
                    }
                }
                else
                {
                    if (tablaAlizar.buscarfichaJ1(new Posicion(posicion.x - 1, posicion.y + 2)) != null)
                    {
                        resultado.Add(new Posicion(posicion.x - 1, posicion.y + 2));
                    }
                }

            }
            return resultado;

        }


    }
}

