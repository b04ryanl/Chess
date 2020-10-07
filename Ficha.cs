using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabAjedrez
{
    public abstract class Ficha
    {
        public Posicion posicion;
        public ConsoleColor color;

        public Ficha(Posicion posini, ConsoleColor colorini)
        {
            posicion = posini;
            color = colorini;
        }

        public abstract void pintar();
        public abstract List<Posicion> obtenermovs(Tablero tablaAlizar);
    }
}
