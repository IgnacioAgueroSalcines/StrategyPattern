using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        

        public EnlaceDirecto(Renombrable e) 
        {
            tamano = 1;
            nombre = e.nombre;
            elemento = e;
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

        public override String ToString()
        {
            return this.nombre;
        }

        public override String ToStringExtends()
        {
            return "E "+this.nombre;
        }

        
    }
}
