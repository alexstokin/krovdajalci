using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Krvodajalci1
{
    class Osebe
    {
        string ime, priimek, kraj;
        DateTime datRojstva;
        char spol;

        public Osebe(string i, string p, string k, DateTime d, char s)
        {
            ime = i;
            priimek = p;
            kraj = k;
            datRojstva = d;
            spol = s;
        }

        public int Starost()
        {
            return DateTime.Now.Year - datRojstva.Year;
        }

        public string Ime
        {
            get { return ime; }
            set { ime = value; }
        }

        public string Priimek
        {
            get { return priimek; }
            set { priimek = value; }
        }

        public string Kraj
        {
            get { return kraj; }
            set { kraj = value; }
        }
        public DateTime DatumRojstva
        {
            get { return datRojstva; }
            set { datRojstva = value; }
        }

        public char Spol
        {
            get { return spol; }
            set { spol = value; }
        }
    }
    class Krvodajalci : Osebe
    {
        string krvnaSkupina;
        int stDarovanj;
        DateTime zadnjeDarovanje;

        public Krvodajalci(string i, string p, string k, DateTime d, char s, 
            string ks, int stDar, DateTime zDar) : base(i, p, k, d, s)
        {
            krvnaSkupina = ks;
            stDarovanj = stDar;
            zadnjeDarovanje = zDar;
        }
        
        public string KrvnaSkupina
        {
            get { return krvnaSkupina; } 
            set { krvnaSkupina = value; }
        }
        public int SteviloDarovanj
        {
            get { return stDarovanj; }
            set { stDarovanj = value; }
        }
        public DateTime ZadnjeDarovanje
        {
            get { return zadnjeDarovanje; }
            set { zadnjeDarovanje = value; }
        }
    }

}
