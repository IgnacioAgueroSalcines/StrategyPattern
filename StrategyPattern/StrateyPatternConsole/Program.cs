﻿using System;

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
            Estrategia est = new InternacionalCatalan();
            //inicio creacion del arbol
            Archivo arc = new Archivo("sueño", 5, est);
            Archivo arc2 = new Archivo("árbol", 5, est);
            Directorio composite = new Directorio("root", est);
            Directorio composite2 = new Directorio("pájaro", est);
            Comprimido composite3 = new Comprimido("contenedor", est);
            EnlaceDirecto e = new EnlaceDirecto(arc2, est);

            composite.addComponente(e);
            composite.addComponente(arc);
            composite.addComponente(composite2);
            composite.addComponente(new Archivo("ñojá5", 10, est));

            composite2.addComponente(new Archivo("hoja3", 5, est));
            composite2.addComponente(composite3);
            composite2.addComponente(new Archivo("áááááá", 10, est));

            composite3.addComponente(new Archivo("ééééé", 5, est));
            composite3.addComponente(new Archivo("ííííí", 5, est));
            composite3.addComponente(new Archivo("óóóóó", 10, est));







            //fin creacion del arbol



            return composite;
        }
    }
    
}
