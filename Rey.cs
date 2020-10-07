using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabAjedrez
{
    class Rey:Ficha
    {
        public Rey(Posicion posini, ConsoleColor colorini) : base(posini, colorini)
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
            Console.WriteLine(" ╬ ");


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
                if (tablaAlizar.buscarficha(new Posicion(posicion.x + 1, posicion.y - 1)) == null)//arriba-derecha
                {
                    if (posicion.x + 1 < 8 && posicion.y - 1 >= 0)
                    {
                        resultado.Add(new Posicion(posicion.x + 1, posicion.y - 1));
                    }
                }
                else
                {
                    if (tablaAlizar.buscarfichaJ2(new Posicion(posicion.x + 1, posicion.y - 1)) != null)
                    {
                        resultado.Add(new Posicion(posicion.x + 1, posicion.y - 1));
                    }
                }

                /////////////////////////////////////////////////////////////////////////////////
                if (tablaAlizar.buscarficha(new Posicion(posicion.x - 1, posicion.y - 1)) == null)//arriba-izquierda
                {
                    if (posicion.x - 1 >= 0 && posicion.y - 1 >= 0)
                    {
                        resultado.Add(new Posicion(posicion.x - 1, posicion.y - 1));
                    }
                }
                else
                {
                    if (tablaAlizar.buscarfichaJ2(new Posicion(posicion.x - 1, posicion.y - 1)) != null)
                    {
                        resultado.Add(new Posicion(posicion.x - 1, posicion.y - 1));
                    }
                }

                /////////////////////////////////////////////////////////////////////////////////
                if (tablaAlizar.buscarficha(new Posicion(posicion.x + 1, posicion.y )) == null)//derecha
                {
                    if (posicion.x + 1 < 8 && posicion.y  >= 0)
                    {
                        resultado.Add(new Posicion(posicion.x + 1, posicion.y ));
                    }
                }
                else
                {
                    if (tablaAlizar.buscarfichaJ2(new Posicion(posicion.x + 1, posicion.y )) != null)
                    {
                        resultado.Add(new Posicion(posicion.x + 1, posicion.y ));
                    }
                }

                /////////////////////////////////////////////////////////////////////////////////
                if (tablaAlizar.buscarficha(new Posicion(posicion.x + 1, posicion.y + 1)) == null)//derecha-abajo
                {
                    if (posicion.x + 1 < 8 && posicion.y + 1 < 8)
                    {
                        resultado.Add(new Posicion(posicion.x + 1, posicion.y + 1));
                    }
                }
                else
                {
                    if (tablaAlizar.buscarfichaJ2(new Posicion(posicion.x + 1, posicion.y + 1)) != null)
                    {
                        resultado.Add(new Posicion(posicion.x + 1, posicion.y + 1));
                    }
                }

                /////////////////////////////////////////////////////////////////////////////////
                if (tablaAlizar.buscarficha(new Posicion(posicion.x - 1, posicion.y)) == null)//izquierda
                {
                    if (posicion.x - 1 >= 0 && posicion.y>= 0)
                    {
                        resultado.Add(new Posicion(posicion.x - 1, posicion.y));
                    }
                }
                else
                {
                    if (tablaAlizar.buscarfichaJ2(new Posicion(posicion.x - 1, posicion.y )) != null)
                    {
                        resultado.Add(new Posicion(posicion.x - 1, posicion.y ));
                    }
                }

                /////////////////////////////////////////////////////////////////////////////////
                if (tablaAlizar.buscarficha(new Posicion(posicion.x - 1, posicion.y + 1)) == null)//izquierda-abajo
                {
                    if (posicion.x - 1 >= 0 && posicion.y + 1 < 8)
                    {
                        resultado.Add(new Posicion(posicion.x - 1, posicion.y + 1));
                    }
                }
                else
                {
                    if (tablaAlizar.buscarfichaJ2(new Posicion(posicion.x - 1, posicion.y + 1)) != null)
                    {
                        resultado.Add(new Posicion(posicion.x - 1, posicion.y + 1));
                    }
                }

                ///////////////////////////////////////////////////////////////////////////////////
                if (tablaAlizar.buscarficha(new Posicion(posicion.x , posicion.y + 1)) == null)//abajo
                {
                    if (posicion.x  < 8 && posicion.y + 1 < 8)
                    {
                        resultado.Add(new Posicion(posicion.x , posicion.y + 1));
                    }
                }
                else
                {
                    if (tablaAlizar.buscarfichaJ2(new Posicion(posicion.x , posicion.y + 1)) != null)
                    {
                        resultado.Add(new Posicion(posicion.x , posicion.y + 1));
                    }
                }

                /////////////////////////////////////////////////////////////////////////////////
                if (tablaAlizar.buscarficha(new Posicion(posicion.x, posicion.y - 1)) == null)//arriba
                {
                    if (posicion.x>= 0 && posicion.y - 1< 8)
                    {
                        resultado.Add(new Posicion(posicion.x , posicion.y - 1));
                    }
                }
                else
                {
                    if (tablaAlizar.buscarfichaJ2(new Posicion(posicion.x , posicion.y - 1)) != null)
                    {
                        resultado.Add(new Posicion(posicion.x , posicion.y - 1));
                    }
                }


            }
            else
            {
                //J2
                if (tablaAlizar.buscarficha(new Posicion(posicion.x + 1, posicion.y - 1)) == null)//arriba-derecha
                {
                    if (posicion.x + 1 < 8 && posicion.y - 1 >= 0)
                    {
                        resultado.Add(new Posicion(posicion.x + 1, posicion.y - 1));
                    }
                }
                else
                {
                    if (tablaAlizar.buscarfichaJ1(new Posicion(posicion.x + 1, posicion.y - 1)) != null)
                    {
                        resultado.Add(new Posicion(posicion.x + 1, posicion.y - 1));
                    }
                }

                /////////////////////////////////////////////////////////////////////////////////
                if (tablaAlizar.buscarficha(new Posicion(posicion.x - 1, posicion.y - 1)) == null)//arriba-izquierda
                {
                    if (posicion.x - 1 >= 0 && posicion.y - 1 >= 0)
                    {
                        resultado.Add(new Posicion(posicion.x - 1, posicion.y - 1));
                    }
                }
                else
                {
                    if (tablaAlizar.buscarfichaJ1(new Posicion(posicion.x - 1, posicion.y - 1)) != null)
                    {
                        resultado.Add(new Posicion(posicion.x - 1, posicion.y - 1));
                    }
                }

                /////////////////////////////////////////////////////////////////////////////////
                if (tablaAlizar.buscarficha(new Posicion(posicion.x + 1, posicion.y)) == null)//derecha
                {
                    if (posicion.x + 1 < 8 && posicion.y >= 0)
                    {
                        resultado.Add(new Posicion(posicion.x + 1, posicion.y));
                    }
                }
                else
                {
                    if (tablaAlizar.buscarfichaJ1(new Posicion(posicion.x + 1, posicion.y)) != null)
                    {
                        resultado.Add(new Posicion(posicion.x + 1, posicion.y));
                    }
                }

                /////////////////////////////////////////////////////////////////////////////////
                if (tablaAlizar.buscarficha(new Posicion(posicion.x + 1, posicion.y + 1)) == null)//derecha-abajo
                {
                    if (posicion.x + 1 < 8 && posicion.y + 1 < 8)
                    {
                        resultado.Add(new Posicion(posicion.x + 1, posicion.y + 1));
                    }
                }
                else
                {
                    if (tablaAlizar.buscarfichaJ1(new Posicion(posicion.x + 1, posicion.y + 1)) != null)
                    {
                        resultado.Add(new Posicion(posicion.x + 1, posicion.y + 1));
                    }
                }

                /////////////////////////////////////////////////////////////////////////////////
                if (tablaAlizar.buscarficha(new Posicion(posicion.x - 1, posicion.y)) == null)//izquierda
                {
                    if (posicion.x - 1 >= 0 && posicion.y >= 0)
                    {
                        resultado.Add(new Posicion(posicion.x - 1, posicion.y));
                    }
                }
                else
                {
                    if (tablaAlizar.buscarfichaJ1(new Posicion(posicion.x - 1, posicion.y)) != null)
                    {
                        resultado.Add(new Posicion(posicion.x - 1, posicion.y));
                    }
                }

                /////////////////////////////////////////////////////////////////////////////////
                if (tablaAlizar.buscarficha(new Posicion(posicion.x - 1, posicion.y + 1)) == null)//izquierda-abajo
                {
                    if (posicion.x - 1 >= 0 && posicion.y + 1 < 8)
                    {
                        resultado.Add(new Posicion(posicion.x - 1, posicion.y + 1));
                    }
                }
                else
                {
                    if (tablaAlizar.buscarfichaJ1(new Posicion(posicion.x - 1, posicion.y + 1)) != null)
                    {
                        resultado.Add(new Posicion(posicion.x - 1, posicion.y + 1));
                    }
                }

                ///////////////////////////////////////////////////////////////////////////////////
                if (tablaAlizar.buscarficha(new Posicion(posicion.x, posicion.y + 1)) == null)//abajo
                {
                    if (posicion.x < 8 && posicion.y + 1 < 8)
                    {
                        resultado.Add(new Posicion(posicion.x, posicion.y + 1));
                    }
                }
                else
                {
                    if (tablaAlizar.buscarfichaJ1(new Posicion(posicion.x, posicion.y + 1)) != null)
                    {
                        resultado.Add(new Posicion(posicion.x, posicion.y + 1));
                    }
                }

                /////////////////////////////////////////////////////////////////////////////////
                if (tablaAlizar.buscarficha(new Posicion(posicion.x, posicion.y - 1)) == null)//arriba
                {
                    if (posicion.x >= 0 && posicion.y - 1 < 8)
                    {
                        resultado.Add(new Posicion(posicion.x, posicion.y - 1));
                    }
                }
                else
                {
                    if (tablaAlizar.buscarfichaJ1(new Posicion(posicion.x, posicion.y - 1)) != null)
                    {
                        resultado.Add(new Posicion(posicion.x, posicion.y - 1));
                    }
                }

            }
            return resultado;

        }



    }
}
