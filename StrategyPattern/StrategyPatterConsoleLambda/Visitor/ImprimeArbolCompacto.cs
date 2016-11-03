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
        public void imprimeArchivo(Archivo a)
        {
            Console.WriteLine(a.ToString());
        }

        public void ImprimeComprimido(Comprimido c)
        {
            Console.WriteLine(c.ToString());
        }

        public void ImprimeDirectorio(Directorio d)
        {
            Console.WriteLine(d.ToString());
        }

        public void ImprimeEnlace(EnlaceDirecto e)
        {
            Console.WriteLine(e.ToString());
        }
    }
}
