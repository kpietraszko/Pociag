using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pociag
{
    class Lokomotywa
    {
        string Model;
        int Masa;
        public Lokomotywa(string model, int masa)
        {
            Model = model;
            Masa = masa;
        }
        public int MasaLokomotywy()
        {
            return Masa;
        }
        public string Informacje()
        {
            return string.Format("Lokomotywa: model {0}, masa {1}.",
                Model, Masa.ToString());
        }

    }
}
