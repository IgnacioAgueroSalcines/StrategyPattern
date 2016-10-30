using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Composite;
using StrategyPattern;

namespace VisitorPattern
{
    public class ImprimeArbolCompacto : IVisitor
    {
        public void imprimeArchivo(Archivo a, Estrategia e)
        {
            Console.WriteLine(a.ToString(e));
        }

        public void ImprimeComprimido(Comprimido c, Estrategia e)
        {
            Console.WriteLine(c.ToString(e));
        }

        public void ImprimeDirectorio(Directorio d, Estrategia e)
        {
            Console.WriteLine(d.ToString(e));
        }

        public void ImprimeEnlace(EnlaceDirecto e, Estrategia est)
        {
            Console.WriteLine(e.ToString(est));
        }
    }
}
