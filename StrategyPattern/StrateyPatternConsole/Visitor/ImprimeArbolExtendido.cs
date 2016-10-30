using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Composite;

namespace VisitorPattern
{
    public class ImprimeArbolExtendido : IVisitor
    {
        public void imprimeArchivo(Archivo a)
        {
            Console.WriteLine(a.ToStringExtends());
        }

        public void ImprimeComprimido(Comprimido c)
        {
            Console.WriteLine(c.ToStringExtends());
        }

        public void ImprimeDirectorio(Directorio d)
        {
            Console.WriteLine(d.ToStringExtends());
        }

        public void ImprimeEnlace(EnlaceDirecto e)
        {
            Console.WriteLine(e.ToStringExtends());
        }
    }
}
