using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarnoIskanje2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] teže = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int dnevi = 5;

            int minimalnaKapaciteta = NajmanjsaKapacitetaLadje(teže, dnevi);

            Console.WriteLine("Minimalna kapaciteta ladje: " + minimalnaKapaciteta);
            Console.ReadLine();
        }

        static int NajmanjsaKapacitetaLadje(int[] teze, int dnevi)
        {
            int nizkaMeja = teze.Max();
            int visokaMeja = teze.Sum();

            while (nizkaMeja < visokaMeja)
            {
                int sredina = (nizkaMeja + visokaMeja) / 2;

                if (LahkoPoslje(teze, dnevi, sredina))
                {
                    visokaMeja = sredina;
                }
                else
                {
                    nizkaMeja = sredina + 1;
                }
            }
            return nizkaMeja;
        }

        static bool LahkoPoslje(int[] teže, int dnevi, int kapaciteta)
        {
            int steviloDni = 1;
            int trenutnaTeža = 0;

            foreach (int teža in teže)
            {
                if (trenutnaTeža + teža > kapaciteta)
                {
                    steviloDni++;
                    trenutnaTeža = 0;
                }

                trenutnaTeža = trenutnaTeža + teža;
            }

            return steviloDni <= dnevi;
        }
    }
}
