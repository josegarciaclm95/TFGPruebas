using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebasGenericas
{
    class Program
    {
        delegate void pruebaDelegate(string a_imprimir);

        static void Main(string[] args)
        {
            pruebaDelegate p = name => { Console.WriteLine(name); };
            p("Hola mundo");
            Prueba1 a = new Prueba1();
            pruebaDelegate b = a.funcion;
            b("Hola mundo");
            pruebaDelegate c = delegate (string name) { Console.WriteLine(name); };
            c("Hola mundo");
            Console.ReadLine();
        }

    
    }

    class Prueba1
    {
        public void funcion(string a_imprimir)
        {
            Console.WriteLine(a_imprimir);
        }
    }
}
