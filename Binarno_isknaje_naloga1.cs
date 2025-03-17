using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarnoIskanje
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] števila = { 5, 7, 7, 8, 10 };
            int cilj = 8;

            int[] rezultat = NajdiPrviInZadnjiPolozaj(števila, cilj);
            Console.WriteLine("Prvi in zadnji položaj števila " + cilj + " sta: [" + rezultat[0] + "," + rezultat[1] + "]");
            Console.ReadLine();
        }

        static int[] NajdiPrviInZadnjiPolozaj(int[] seznam, int cilj)
        {
            int prvi = BinarnoIskanje(seznam, cilj, true);
            int zadnji = BinarnoIskanje(seznam, cilj, false);
            return new int[] { prvi, zadnji };
        }

        static int BinarnoIskanje(int[] seznam, int cilj, bool Prvi)
        {
            int levo = 0;
            int desno = seznam.Length - 1;
            int rezultat = -1;

            while(levo <= desno)
            {
                int sredina = levo + (desno - levo) / 2;

                if (seznam[sredina] == cilj)
                {
                    rezultat = sredina;
                    if (Prvi)
                        desno = sredina - 1;
                    else
                        levo = sredina + 1;
                }
                else if (seznam[sredina] < cilj)
                {
                    levo = sredina + 1;
                }
                else
                {
                    desno = sredina - 1;
                }
            }
            return rezultat;
        }
    }
}
