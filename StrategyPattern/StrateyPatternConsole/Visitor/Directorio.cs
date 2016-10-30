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
    /// Clase que contiene elementos e interactua con ellos
    /// </summary>
   public class Directorio : Composite
    {
        public int tamano;//medido en Kb

        public Directorio(string _nombre, Estrategia e) : base(_nombre,e)
        {
            tamano = 1;
        }

        public override void accept(IVisitor v)
        {
            v.ImprimeDirectorio(this);
        }

        /// <summary>
        /// Método que retorna el tamaño del directorio.
        /// </summary>
        /// <returns></returns>
        public override int getTamano()
        {
            int res = 0;
            for (int i = 0; i < componentes.ToArray().Length; i++)
            {
                res += componentes[i].getTamano();
            }
            return tamano + res;
        }

        

        public override String ToStringExtends()
        {
            String res = "D " + this.nombre;
            res += "\n";
            for (int i = 0; i < componentes.Count; i++)
            {
                res += insertaTabulaciones(componentes[i].orden) + componentes[i].ToStringExtends() + "\n";
            }
            return base.strategy.filtro(res);
        }
    }
}
