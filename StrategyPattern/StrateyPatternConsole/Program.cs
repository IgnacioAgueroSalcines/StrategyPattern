using System;

using Composite;
using StrategyPattern;

using VisitorPattern;
using System.Collections.Generic;
using System.Text;

namespace StrateyPatternConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Visitor Pattern\n");

            IVisitor v = new ImprimeArbolCompacto();
            IVisitor v2 = new ImprimeArbolExtendido();

            Directorio root = inicialize();

            Console.WriteLine("\nCompacto\n");
            v.ImprimeDirectorio(root);

            Console.WriteLine("\nExtendido\n");
            v2.ImprimeDirectorio(root);

            Console.Read();



            /////////main de pablo
            OrdenaLambda<int> ordenaEnteros = new OrdenaLambda<int>();

            List<int> listaEnteros = new List<int>();

            // Inicializamos la lista en orden decreciente
            for (int i = 15; i > 0; i--)
            {
                listaEnteros.Add(i);
            } // for

            Console.Out.WriteLine("Lista Inicial  = " + serializaLista(listaEnteros));

            // Primera Opción: Cambiado la propiedad que representa una función

            // Asignamos a la propiedad mayor una función anónima (lambda) que acepta 
            // dos enteros (deducido por inferencia de tipos) que devuelve verdadero si 
            // el primeo el mayor que el segundo 
            // ordenaEnteros.Mayor = (x, y) => x > y;
            // ordenaEnteros.ordenarBurbuja(listaEnteros);

            // Segunda opción: Pasando la función como parámetro
            ordenaEnteros.ordenarBurbuja(listaEnteros, (x, y) => x > y);

            Console.Out.WriteLine("Lista Ordenada = " + serializaLista(listaEnteros));

            Console.Out.WriteLine("Pulse INTRO para continuar.");
            Console.In.ReadLine();
        }

        // Metodo auxiliar para visualizar el contenido de una lista por consola
        private static String serializaLista<T>(List<T> listaElementos)
        {
            StringBuilder result = new StringBuilder("[");

            if (listaElementos.Count > 0)
            {

                for (int i = 0; i < listaElementos.Count - 1; i++)
                {
                    result.Append(listaElementos[i] + ", ");
                } // for

                result.Append(listaElementos[listaElementos.Count - 1]);
            } // if

            result.Append("]");

            return result.ToString();
        } // serializaLista

        public static Directorio inicialize()
        {
            Estrategia est = new Gallego();
            //inicio creacion del arbol
            Archivo arc = new Archivo("ñoja4", 5, est);
            Archivo arc2 = new Archivo("hojá1", 5, est);
            Directorio composite = new Directorio("root", est);
            Directorio composite2 = new Directorio("dir", est);
            Comprimido composite3 = new Comprimido("comp", est);
            EnlaceDirecto e = new EnlaceDirecto(arc2, est);

            composite.addComponente(e);
            composite.addComponente(arc);
            composite.addComponente(composite2);
            composite.addComponente(new Archivo("ñojá5", 10, est));

            composite2.addComponente(new Archivo("hoja3", 5, est));
            composite2.addComponente(composite3);
            composite2.addComponente(new Archivo("hoja6", 10, est));

            composite3.addComponente(new Archivo("hoja1", 5, est));
            composite3.addComponente(new Archivo("hoja2", 5, est));
            composite3.addComponente(new Archivo("hoja7", 10, est));







            //fin creacion del arbol



            return composite;
        }
    }
    
}
