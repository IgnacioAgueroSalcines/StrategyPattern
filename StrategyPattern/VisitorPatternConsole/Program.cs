using Composite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisitorPattern;

namespace VisitorPatternConsole
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
            Archivo arc = new Archivo("hoja4", 5);
            Archivo arc2 = new Archivo("hoja1", 5);
            Directorio composite = new Directorio("root");
            Directorio composite2 = new Directorio("dir");
            Comprimido composite3 = new Comprimido("comp");
            EnlaceDirecto e = new EnlaceDirecto(arc2);

            composite.addComponente(e);
            composite.addComponente(arc);
            composite.addComponente(composite2);
            composite.addComponente(new Archivo("hoja5",10));

            composite2.addComponente(new Archivo("hoja3", 5));
            composite2.addComponente(composite3);
            composite2.addComponente(new Archivo("hoja6", 10));

            composite3.addComponente(new Archivo("hoja1", 5));
            composite3.addComponente(new Archivo("hoja2", 5));
            composite3.addComponente(new Archivo("hoja7", 10));







            //fin creacion del arbol



            return composite;
        }
    }
}
