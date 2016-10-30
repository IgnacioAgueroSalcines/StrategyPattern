using Composite;
using StrategyPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPattern
{
    public interface IVisitor
    {
        void imprimeArchivo(Archivo a);
        void ImprimeDirectorio(Directorio d);
        void ImprimeComprimido(Comprimido c);
        void ImprimeEnlace(EnlaceDirecto e);
    }
}
