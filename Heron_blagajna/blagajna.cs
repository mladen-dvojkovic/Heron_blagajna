using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heron_blagajna
{
    class Blagajna
    {
        public int Cijena { get; set; }

        public int Placeno { get; set; }

        public int Ostatak(int Cijena, int Placeno)
        {
            int ostatak = Placeno - Cijena;
            return ostatak;
        }

        public void Novcanice()
        {
            int temp_ostatak = Placeno - Cijena;

            int _temp_novcanica = 0;

            int[] novcanice = new int[] {1000, 500, 200, 100, 50, 20, 10, 5, 1};

            for(int i = 0; i < novcanice.Length; i++){
                //Console.WriteLine(novcanice[i]);

                if (temp_ostatak >= novcanice[i])
                {
                    _temp_novcanica = temp_ostatak / novcanice[i];
                    Console.WriteLine("Novčanice od {0}kn: " + _temp_novcanica, novcanice[i]);
                    temp_ostatak %= novcanice[i];
                }
            }
        }
    }
}
