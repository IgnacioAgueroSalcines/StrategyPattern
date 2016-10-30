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
        void imprimeArchivo(Archivo a,Estrategia e);
        void ImprimeDirectorio(Directorio d, Estrategia e);
        void ImprimeComprimido(Comprimido c, Estrategia e);
        void ImprimeEnlace(EnlaceDirecto e, Estrategia est);
    }
}
