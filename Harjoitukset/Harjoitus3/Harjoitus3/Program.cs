using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus3
{
    class Program
    {
        static void Main(string[] args)
        {
            Kiuas kiuas = new Kiuas("Harvia");

            kiuas.TulostaData();

            kiuas.KiuasOnOff(true);
            kiuas.MuutaLämpötilaa(70);
            kiuas.MuutaKosteutta(90);

            kiuas.TulostaData();

            kiuas.KiuasOnOff(false);

            Console.ReadLine();
        }
    }
}
