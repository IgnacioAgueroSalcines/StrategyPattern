using System;

using Composite;

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

        
       

        public static Directorio inicialize()
        {
            
            //inicio creacion del arbol
            Archivo arc = new Archivo("sueño", 5, x=>x.Replace("ñ","nh"));
            Archivo arc2 = new Archivo("árbol", 5, x => x.Replace("ñ", "nh"));
            Directorio composite = new Directorio("root", x => x.Replace("ñ" ,"nh"));
            Directorio composite2 = new Directorio("pájaro", x => x.Replace("ñ", "nh"));
            Comprimido composite3 = new Comprimido("contenedor", x => x.Replace("ñ", "nh"));
            EnlaceDirecto e = new EnlaceDirecto(arc2, x => x.Replace("ñ", "nh"));

            composite.addComponente(e);
            composite.addComponente(arc);
            composite.addComponente(composite2);
            composite.addComponente(new Archivo("ñojá5", 10, x => x.Replace("ñ", "nh")));

            composite2.addComponente(new Archivo("hoja3", 5, x => x.Replace("ñ", "nh")));
            composite2.addComponente(composite3);
            composite2.addComponente(new Archivo("áááááá", 10, x => x.Replace("ñ", "nh")));

            composite3.addComponente(new Archivo("ééééé", 5, x => x.Replace("ñ", "nh")));
            composite3.addComponente(new Archivo("ííííí", 5, x => x.Replace("ñ", "nh")));
            composite3.addComponente(new Archivo("óóóóó", 10, x => x.Replace("ñ", "nh")));







            //fin creacion del arbol



            return composite;
        }
    }
    
}
