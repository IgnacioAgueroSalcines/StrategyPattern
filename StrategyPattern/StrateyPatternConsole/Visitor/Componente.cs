using StrategyPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisitorPattern;

namespace Composite
{
   public abstract class Componente
    {

        public int orden { get; set; }
        public Estrategia strategy;

        public Componente(Estrategia e)
        {
            strategy = e;
        }

        /// <summary>
        /// Metodo observador que devuelve el tamaño del archivo
        /// </summary>
        /// <returns></returns>
        public abstract int getTamano();

        /// <summary>
        /// Metodo que retorna el numero de elementos del obejto, contandose a si mismo mas los componentes que tenga asociados(si tiene)
        /// </summary>
        /// <returns></returns>
        public abstract int elementos();

        /// <summary>
        /// Metodo necesario para que un visitante pueda interactuar con este objeto
        /// </summary>
        /// <param name="v"></param>
        public abstract void accept(IVisitor v);

        /// <summary>
        /// Metodo que devuelve un string con informacion extendida del archivo
        /// </summary>
        /// <returns></returns>
        public abstract String ToStringExtends();

        /// <summary>
        /// Metodo que devuelve un string con informacion del archivo en base a la estrategia proporcionada
        /// </summary>
        /// <returns></returns>
        public abstract override String ToString();

        /// <summary>
        /// Retorna el numero de elementos hijos mas el mismo
        /// </summary>
        /// <returns></returns>
        public abstract void actualizaOrden(int _orden);


    }
}
