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
            Padre x = new Padre();
            Hija1 y = new Hija1();
            Hija2 z = new Hija2();
            Console.WriteLine(x.imprimir());
            Console.WriteLine(y.imprimir());
            Console.WriteLine(z.imprimir());
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

    class Padre
    {
        public string imprimir()
        {
            return "Imprime el padre";
        }
    }

    class Hija1 : Padre
    {

    }

    class Hija2:Padre
    {
        public new string imprimir()
        {
            return "Imprime la hija en su propio imprimir";
        }
    }

}
