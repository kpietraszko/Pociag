using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pociag
{
    class Pociag :IPoprawnyPociag, IUzupelnijSklad
    {
        List<Wagon> Wagony = new List<Wagon>();
        List<Lokomotywa> Lokomotywy = new List<Lokomotywa>();
        public bool MozeJechac()
        {
            int sumaMasWagonow = 0;
            int sumaMasLokomotyw = 0;
            foreach(var wagon in Wagony)
            {
                sumaMasWagonow += wagon.MasaWagonu();
            }
            foreach(var lokomotywa in Lokomotywy)
            {
                sumaMasLokomotyw += lokomotywa.MasaLokomotywy();
            }
            if (sumaMasLokomotyw >= sumaMasWagonow)
                return true;
            else return false;
        }
        void DodajOsobowy(int masa, string model, string rodzaj)
        {
            Wagony.Add(new Osobowy(model, masa, rodzaj));
        }
        void DodajTowarowy(int masa, string model, string ladunek)
        {
            Wagony.Add(new Towarowy(model, masa, ladunek));
        }
        void DodajLokomotywe(int masa, string model)
        {
            Lokomotywy.Add(new Lokomotywa(model, masa));
        }
        public string Informacje()
        {
            string informacje = "Skład pociągu:" + Environment.NewLine;
            foreach(var lokomotywa in Lokomotywy)
            {
                informacje += lokomotywa.Informacje() + Environment.NewLine;
            }
            foreach(var wagon in Wagony)
            {
                informacje += wagon.Informacje() + Environment.NewLine;
            }
            return informacje;
        }
    }
}
