using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabAjedrez
{
    class Reina:Ficha
    {
        public Reina(Posicion posini, ConsoleColor colorini) : base(posini, colorini)
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
            Console.WriteLine(" ¤ ");


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
                for (int i = 0 + 1; i < 8; i++) // derecha - abajo
                {
                    if (posicion.x + i >= 8 || posicion.y + i >= 8)
                    {
                        break;
                    }
                    if (tablaAlizar.buscarficha(new Posicion(posicion.x + i, posicion.y + i)) == null)
                    {
                        resultado.Add(new Posicion(posicion.x + i, posicion.y + i));
                    }
                    else
                    {
                        if (tablaAlizar.buscarfichaJ2(new Posicion(posicion.x + i, posicion.y + i)) != null)
                        {
                            resultado.Add(new Posicion(posicion.x + i, posicion.y + i));
                        }
                        break;
                    }
                    
                }
                ///////////////////////////////////////////////////////////////
                for (int i = 0 + 1; i < 8; i++) // derecha - arriba
                {
                    if (posicion.x + i >= 8 || posicion.y + (-1 * i) < 0)
                    {
                        break;
                    }
                    if (tablaAlizar.buscarficha(new Posicion(posicion.x + i, posicion.y + (-1 * i))) == null)
                    {
                        resultado.Add(new Posicion(posicion.x + i, posicion.y + (-1 * i)));
                    }
                    else
                    {
                        if (tablaAlizar.buscarfichaJ2(new Posicion(posicion.x + i, posicion.y + (-1 * i))) != null)
                        {
                            resultado.Add(new Posicion(posicion.x + i, posicion.y + (-1 * i)));
                        }
                        break;
                    }
                    
                }
                ///////////////////////////////////////////////////////////////////
                for (int i = 0 + 1; i < 8; i++) // izquierda - arriba
                {
                    if (posicion.x + (-1 * i) < 0 || posicion.y + (-1 * i) < 0)
                    {
                        break;
                    }
                    if (tablaAlizar.buscarficha(new Posicion(posicion.x + (-1 * i), posicion.y + (-1 * i))) == null)
                    {
                        resultado.Add(new Posicion(posicion.x + (-1 * i), posicion.y + (-1 * i)));
                    }
                    else
                    {
                        if (tablaAlizar.buscarfichaJ2(new Posicion(posicion.x + (-1 * i), posicion.y + (-1 * i))) != null)
                        {
                            resultado.Add(new Posicion(posicion.x + (-1 * i), posicion.y + (-1 * i)));
                        }
                        break;
                    }
                    if (posicion.x + (-1 * i) < 0 || posicion.y + (-1 * i) < 0)
                    {
                        break;
                    }
                }
                ///////////////////////////////////////////////////////////////
                for (int i = 0 + 1; i < 8; i++) // izquierda - abajo
                {
                    if (posicion.x + (-1 * i) < 0 || posicion.y + i >= 8)
                    {
                        break;
                    }
                    if (tablaAlizar.buscarficha(new Posicion(posicion.x + (-1 * i), posicion.y + i)) == null)
                    {
                        resultado.Add(new Posicion(posicion.x + (-1 * i), posicion.y + i));
                    }
                    else
                    {
                        if (tablaAlizar.buscarfichaJ2(new Posicion(posicion.x + (-1 * i), posicion.y + i)) != null)
                        {
                            resultado.Add(new Posicion(posicion.x + (-1 * i), posicion.y + i));
                        }
                        break;
                    }
                    
                }
                ///////////////////////////////////////////////////////////////
                for (int i = posicion.x + 1; i < 8; i++) // derecha
                {
                    if (tablaAlizar.buscarficha(new Posicion(i, posicion.y)) == null)
                    {
                        resultado.Add(new Posicion(i, posicion.y));
                    }
                    else
                    {
                        if (tablaAlizar.buscarfichaJ2(new Posicion(i, posicion.y)) != null)
                        {
                            resultado.Add(new Posicion(i, posicion.y));
                        }
                        break;
                    }
                }
                ///////////////////////////////////////////////////////////////
                for (int i = posicion.y + 1; i < 8; i++) // abajo
                {
                    if (tablaAlizar.buscarficha(new Posicion(posicion.x, i)) == null)
                    {
                        resultado.Add(new Posicion(posicion.x, i));
                    }
                    else
                    {
                        if (tablaAlizar.buscarfichaJ2(new Posicion(posicion.x, i)) != null)
                        {
                            resultado.Add(new Posicion(posicion.x, i));
                        }
                        break;
                    }
                }
                ///////////////////////////////////////////////////////////////////
                for (int i = posicion.x - 1; i >= 0; i--) // izquierda
                {
                    if (tablaAlizar.buscarficha(new Posicion(i, posicion.y)) == null)
                    {
                        resultado.Add(new Posicion(i, posicion.y));
                    }
                    else
                    {
                        if (tablaAlizar.buscarfichaJ2(new Posicion(i, posicion.y)) != null)
                        {
                            resultado.Add(new Posicion(i, posicion.y));
                        }
                        break;
                    }
                }
                ///////////////////////////////////////////////////////////////
                for (int i = posicion.y - 1; i >= 0; i--) // arriba
                {
                    if (tablaAlizar.buscarficha(new Posicion(posicion.x, i)) == null)
                    {
                        resultado.Add(new Posicion(posicion.x, i));
                    }
                    else
                    {
                        if (tablaAlizar.buscarfichaJ2(new Posicion(posicion.x, i)) != null)
                        {
                            resultado.Add(new Posicion(posicion.x, i));
                        }
                        break;
                    }
                }

            }
            else
            {
                //J2
                for (int i = 0 + 1; i < 8; i++) // derecha - abajo
                {
                    if (posicion.x + i >= 8 || posicion.y + i >= 8)
                    {
                        break;
                    }
                    if (tablaAlizar.buscarficha(new Posicion(posicion.x + i, posicion.y + i)) == null)
                    {
                        resultado.Add(new Posicion(posicion.x + i, posicion.y + i));
                    }
                    else
                    {
                        if (tablaAlizar.buscarfichaJ1(new Posicion(posicion.x + i, posicion.y + i)) != null)
                        {
                            resultado.Add(new Posicion(posicion.x + i, posicion.y + i));
                        }
                        break;
                    }
                    
                }
                ///////////////////////////////////////////////////////////////
                for (int i = 0 + 1; i < 8; i++) // derecha - arriba
                {
                    if (posicion.x + i >= 8 || posicion.y + (-1 * i) < 0)
                    {
                        break;
                    }
                    if (tablaAlizar.buscarficha(new Posicion(posicion.x + i, posicion.y + (-1 * i))) == null)
                    {
                        resultado.Add(new Posicion(posicion.x + i, posicion.y + (-1 * i)));
                    }
                    else
                    {
                        if (tablaAlizar.buscarfichaJ1(new Posicion(posicion.x + i, posicion.y + (-1 * i))) != null)
                        {
                            resultado.Add(new Posicion(posicion.x + i, posicion.y + (-1 * i)));
                        }
                        break;
                    }
                    
                }
                ///////////////////////////////////////////////////////////////////
                for (int i = 0 + 1; i < 8; i++) // izquierda - arriba
                {
                    if (posicion.x + (-1 * i) < 0 || posicion.y + (-1 * i) < 0)
                    {
                        break;
                    }
                    if (tablaAlizar.buscarficha(new Posicion(posicion.x + (-1 * i), posicion.y + (-1 * i))) == null)
                    {
                        resultado.Add(new Posicion(posicion.x + (-1 * i), posicion.y + (-1 * i)));
                    }
                    else
                    {
                        if (tablaAlizar.buscarfichaJ1(new Posicion(posicion.x + (-1 * i), posicion.y + (-1 * i))) != null)
                        {
                            resultado.Add(new Posicion(posicion.x + (-1 * i), posicion.y + (-1 * i)));
                        }
                        break;
                    }
                    
                }
                ///////////////////////////////////////////////////////////////
                for (int i = 0 + 1; i < 8; i++) // izquierda - abajo
                {
                    if (posicion.x + (-1 * i) < 0 || posicion.y + i >= 8)
                    {
                        break;
                    }
                    if (tablaAlizar.buscarficha(new Posicion(posicion.x + (-1 * i), posicion.y + i)) == null)
                    {
                        resultado.Add(new Posicion(posicion.x + (-1 * i), posicion.y + i));
                    }
                    else
                    {
                        if (tablaAlizar.buscarfichaJ1(new Posicion(posicion.x + (-1 * i), posicion.y + i)) != null)
                        {
                            resultado.Add(new Posicion(posicion.x + (-1 * i), posicion.y + i));
                        }
                        break;
                    }
                    
                }
                ///////////////////////////////////////////////////////////////
                for (int i = posicion.x + 1; i < 8; i++) // derecha
                {
                    if (tablaAlizar.buscarficha(new Posicion(i, posicion.y)) == null)
                    {
                        resultado.Add(new Posicion(i, posicion.y));
                    }
                    else
                    {
                        if (tablaAlizar.buscarfichaJ1(new Posicion(i, posicion.y)) != null)
                        {
                            resultado.Add(new Posicion(i, posicion.y));
                        }
                        break;
                    }
                }
                ///////////////////////////////////////////////////////////////
                for (int i = posicion.y + 1; i < 8; i++) // abajo
                {
                    if (tablaAlizar.buscarficha(new Posicion(posicion.x, i)) == null)
                    {
                        resultado.Add(new Posicion(posicion.x, i));
                    }
                    else
                    {
                        if (tablaAlizar.buscarfichaJ1(new Posicion(posicion.x, i)) != null)
                        {
                            resultado.Add(new Posicion(posicion.x, i));
                        }
                        break;
                    }
                }
                ///////////////////////////////////////////////////////////////////
                for (int i = posicion.x - 1; i >= 0; i--) // izquierda
                {
                    if (tablaAlizar.buscarficha(new Posicion(i, posicion.y)) == null)
                    {
                        resultado.Add(new Posicion(i, posicion.y));
                    }
                    else
                    {
                        if (tablaAlizar.buscarfichaJ1(new Posicion(i, posicion.y)) != null)
                        {
                            resultado.Add(new Posicion(i, posicion.y));
                        }
                        break;
                    }
                }
                ///////////////////////////////////////////////////////////////
                for (int i = posicion.y - 1; i >= 0; i--) // arriba
                {
                    if (tablaAlizar.buscarficha(new Posicion(posicion.x, i)) == null)
                    {
                        resultado.Add(new Posicion(posicion.x, i));
                    }
                    else
                    {
                        if (tablaAlizar.buscarfichaJ1(new Posicion(posicion.x, i)) != null)
                        {
                            resultado.Add(new Posicion(posicion.x, i));
                        }
                        break;
                    }
                }
            }
            return resultado;

        }


    }
}
