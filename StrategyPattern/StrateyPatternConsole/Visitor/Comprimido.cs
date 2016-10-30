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
    /// Clase cuyo tamaño de la lista se reduce en un 30%, simula un archivo comprimido
    /// </summary>
     public class Comprimido : Composite
    {
        public Comprimido(string _nombre, Estrategia e) : base(_nombre,e)
        {
        }

        public override void accept(IVisitor v)
        {
            v.ImprimeComprimido(this);
        }

        /// <summary>
        /// Método que retorna el tamaño del comprimido, el cual se corresponde con el 30% del tamaño total de los archivos que alberga.
        /// </summary>
        /// <returns></returns>
        public override int getTamano()
        {
            double res = 0;
            for (int i = 0; i < base.componentes.ToArray().Length; i++)
            {
                res += base.componentes[i].getTamano();
            }
            int result=(int)Math.Round(res*0.3, 0);
            return result;
        }

       

        public override String ToStringExtends()
        {
            String res = "C " + this.nombre + ".zip\n"; 
            for (int i = 0; i < componentes.Count; i++)
            {
                res += insertaTabulaciones(componentes[i].orden) + componentes[i].ToStringExtends() + "\n";
            }
            return base.strategy.filtro(res);
           
        }

    }
}
