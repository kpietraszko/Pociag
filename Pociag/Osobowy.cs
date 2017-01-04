using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pociag
{
    class Osobowy :Wagon
    {
        private string Rodzaj;
        public Osobowy(string model, int masa, string rodzaj)
        {
            Model = model;
            Masa = masa;
            Rodzaj = rodzaj;
        }
        public override string Informacje()
        {
            return string.Format("Wagon osobowy: model {0}, waga: {1}, rodzaj: {2}");
        }
    }
}
