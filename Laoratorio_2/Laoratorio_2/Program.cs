using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laoratorio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Song s1 = new Song("Rojo", "J balvin", "Colores", "Urbano");
            Console.WriteLine(s1.Information());

            Song s2 = new Song("Alguien soy yo", "Enrique Iglesias", "Insomniac", "Baladas");
            Console.WriteLine(s2.Information());

            Song s3 = new Song("The One", "Back Street Boys", "Millennium", "Pop");
            Console.WriteLine(s3.Information());

            Console.ReadKey();



        }

    }
}
