using StrategyPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisitorPattern;

namespace Composite
{
    /// <summary>
    /// Clase que permite a los elementos subyacentes renombrar el nombre.
    /// </summary>
   public abstract class Renombrable : Componente
    {
        public  String nombre;
        public Renombrable(string _nombre,Estrategia e):base(e) 
        {
            nombre = _nombre;
        }

        /// <summary>
        /// Metodo observador que cambia el nombre del elemento
        /// </summary>
        /// <param name="_nombre"></param>
        public void renombrar(String _nombre)
        {
           this.nombre = _nombre;
        }
        public abstract override void accept(IVisitor v);
    }
}
