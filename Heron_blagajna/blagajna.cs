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

            int _1000, _500, _200, _100, _50, _20, _10, _5, _1 = 0;

            if (temp_ostatak >= 1000)
            {
                _1000 = temp_ostatak / 1000;
                Console.WriteLine("Novčanice od 1000kn: " + _1000);
                temp_ostatak %= 1000;
            }

            if (temp_ostatak >= 500)
            {
                _500 = temp_ostatak / 500;
                Console.WriteLine("Novčanice od 500kn: " + _500);
                temp_ostatak %= 500;
            }

            if (temp_ostatak >= 200)
            {
                _200 = temp_ostatak / 200;
                Console.WriteLine("Novčanice od 200kn: " + _200);
                temp_ostatak %= 200;
            }

            if (temp_ostatak >= 100)
            {
                _100 = temp_ostatak / 100;
                Console.WriteLine("Novčanice od 100kn: " + _100);
                temp_ostatak %= 100;
            }

            if (temp_ostatak >= 50)
            {
                _50 = temp_ostatak / 50;
                Console.WriteLine("Novčanice od 50kn: " + _50);
                temp_ostatak %= 50;
            }

            if (temp_ostatak >= 20)
            {
                _20 = temp_ostatak / 20;
                Console.WriteLine("Novčanice od 20kn: " + _20);
                temp_ostatak %= 20;
            }

            if (temp_ostatak >= 10)
            {
                _10 = temp_ostatak / 10;
                Console.WriteLine("Novčanice od 10kn: " + _10);
                temp_ostatak %= 10;
            }

            if (temp_ostatak >= 5)
            {
                _5 = temp_ostatak / 5;
                Console.WriteLine("Novčanice od 5kn: " + _5);
                temp_ostatak %= 5;
            }

            if (temp_ostatak >= 1)
            {
                _1 = temp_ostatak / 1;
                Console.WriteLine("Novčanice od 1kn: " + _1);
                temp_ostatak %= 1;
            }

        }
    }
}
