using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pociag
{
    abstract class Wagon
    {
        protected string Model;
        protected int Masa;
        public abstract string Informacje();
        public int MasaWagonu()
        {
            return Masa;
        }

    }
}
