using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pociag
{
    class Towarowy :Wagon
    {
        private string Ladunek;
        public Towarowy(string model, int masa, string ladunek)
        {
            Model = model;
            Masa = masa;
            Ladunek = ladunek;
        }
        public override string Informacje()
        {
            return string.Format("Wagon towarowy: model {0}, waga: {1}, ładunek:{2}");
        }
    }
}
