using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StrategyPattern;
using VisitorPattern;

namespace Composite
{
    /// <summary>
    /// Clase que simula un acceso directo a un componente del sistema.
    /// </summary>
   public class EnlaceDirecto:Componente
    {
        public int tamano;//medido en Kb
        public String nombre { get; }
        private Renombrable elemento;

        public EnlaceDirecto(Renombrable r,Estrategia e) : base(e)
        {
            tamano = 1;
            nombre = r.nombre;
            elemento = r;
            orden = 0;
        }

        public override void actualizaOrden(int _orden)
        {
            throw new Exception("Este clase no tiene dicha capacidad");
        }

        public override void accept(IVisitor v)
        {
            v.ImprimeEnlace(this);
        }

        public override int elementos()
        {
            return 0;
        }

        public override int getTamano()
        {
            return tamano;
        }

        public override String ToStringExtends()
        {
            return base.strategy.filtro("E " +this.nombre);
        }

        public override string ToString()
        {
            return base.strategy.filtro(this.nombre); 
        }
    }
}
