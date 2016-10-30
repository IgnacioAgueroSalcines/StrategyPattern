using StrategyPattern;
using System;
using System.Collections.Generic;
using VisitorPattern;

namespace Composite
{
    /// <summary>
    /// Clase que contiene una lista de componentes sobre la que actuar
    /// </summary>
    public abstract class Composite : Renombrable
    {
        protected List<Componente> componentes= new List<Componente>();
        private int tamano;

        public Composite(string _nombre, Estrategia e) : base(_nombre,e)
        {
            tamano = 1;
            this.nombre = _nombre;
        }
        /// <summary>
        /// Añade un componente a la lista
        /// </summary>
        /// <param name="c"></param>
        public  void addComponente(Componente c)
        {
            componentes.Add(c);
            this.actualizaOrden(this.orden);
            
        }
        
        /// <summary>
        /// Metodo que recorre la lista de componentes y les actualiza el orden
        /// _orden es el orden del padre
        /// </summary>
        public override void actualizaOrden(int _orden)
        {
            for (int i=0;i<componentes.Count;i++)
            {
                componentes[i].orden= _orden + 1;
                
                if (componentes[i].GetType().Name.Equals("Directorio") || componentes[i].GetType().Name.Equals("Comprimido"))
                {

                    componentes[i].actualizaOrden(componentes[i].orden);
                }

            }
        }


        /// <summary>
        /// Elimina un componente de la lista
        /// </summary>
        /// <param name="c"></param>
        public  void removeComponente(Componente c)
        {
            this.actualizaOrden(this.orden);
            componentes.Remove(c);
        }

        /// <summary>
        /// Método que retorna el numero de elementos hijos mas el mismo
        /// </summary>
        /// <returns></returns>
        public override int elementos()
        {
            int res = 0;
            for (int i = 0; i < componentes.ToArray().Length; i++)
            {
                res += componentes[i].elementos();
                orden = 0;
            }
            return res;
        }

        public abstract override void accept(IVisitor v);
        public abstract override int getTamano();

        /// <summary>
        /// Metodo observador de los componentes
        /// </summary>
        /// <returns></returns>
        public List<Componente> getComponentes()
        {
            return componentes;
        }

        /// <summary>
        /// Metodo que devuelve un string para mostrar
        /// </summary>
        /// <returns></returns>
        public  override String ToString()
        {
            String res = this.nombre + "\n";
            for (int i = 0; i < componentes.Count; i++)
            {
                res += insertaTabulaciones(componentes[i].orden) +componentes[i].ToString() + "\n";
            }
            return base.strategy.filtro(res);
        }

        /// <summary>
        /// Metodo que devuelve un string con el numero de tabulaciones a introducir al pintar por pantalla
        /// </summary>
        /// <param name="nivel"></param>
        /// <returns></returns>
        public string insertaTabulaciones(int nivel)
        {
            String res = "";
            for (int i=0;i<nivel;i++)
            {
                res += "\t";
            }
            return res;
        }

    }
}
