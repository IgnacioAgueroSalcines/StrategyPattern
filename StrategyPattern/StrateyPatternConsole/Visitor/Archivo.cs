using StrategyPattern;
using System;
using VisitorPattern;

namespace Composite
{
    /// <summary>
    /// Clase que simula un archivo propio del sistema.
    /// </summary>
    public class Archivo: Renombrable
    {
        public int tamano { get; set; }

        /// <summary>
        /// Metodo constructor de la clase
        /// </summary>
        /// <param name="_nombre"></param>
        /// <param name="_tamano"></param>
        public Archivo(String _nombre,int _tamano,Estrategia e) : base(_nombre,e)
        {
            tamano = _tamano;
            nombre = _nombre;
            orden = 0;
        }

        
        
        public override void accept(IVisitor v)
        {
            v.imprimeArchivo(this);
        }

        
        public override void actualizaOrden(int _orden)
        {
            throw new Exception("Este clase no tiene dicha capacidad");
        }

        
        public override int elementos()
        {
            return 1;
        }

        
        public override int getTamano()
        {
            return tamano;
        }

        /// <summary>
        /// Metodo que devuelve un string con informacion basica del archivo
        /// </summary>
        /// <returns></returns>
        public override String ToString()
        {
            return base.strategy.filtro(this.nombre);
        }

        
        public override String ToStringExtends()
        {
            return base.strategy.filtro("F " +this.nombre+".jpg");
        }

    }
}
