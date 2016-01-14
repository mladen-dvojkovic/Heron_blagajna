using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heron_blagajna

{
    
    class Program
    {
        static void Main(string[] args)
        {
            Blagajna Heron = new Blagajna();

            Console.WriteLine(" Heron blagajna ");
            Console.WriteLine("----------------");
            Console.WriteLine("Unesite cijenu proizvoda: ");
            Heron.Cijena = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Unesite uplaćeni iznos: ");
            Heron.Placeno = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("----------------");

            Console.WriteLine("Cijena proizvoda iznosi {0}kn, a plaćeno je {1}kn. Potrebno je vratiti {2}kn.", Heron.Cijena, Heron.Placeno, Heron.Ostatak(Heron.Cijena, Heron.Placeno));
            Console.WriteLine("----------------");

            Console.WriteLine("Broj novčanica:");
            Heron.Novcanice();
            
        }
    }
}
