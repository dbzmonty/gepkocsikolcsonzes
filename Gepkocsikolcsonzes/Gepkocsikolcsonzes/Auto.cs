using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gepkocsikolcsonzes
{
    public class Auto
    {
        private string _rendszam;
        private string _fogyasztas;
        private string _marka;

        public Auto()
        {
            _rendszam = string.Empty;
            _fogyasztas = String.Empty;
            _marka = string.Empty;
        }

        public string Rendszam
        {
            get { return _rendszam; } 
            set
            {
                if (0 < value.Length) _rendszam = value;
                else throw new Exception("Érvénytelen rendszám!");
            }
        }

        public string Fogyasztas
        {
            get { return _fogyasztas; }
            set
            {
                if (0 < value.Length) _fogyasztas = value;
                else throw new Exception("Érvénytelen fogyasztás!");
            }
        }

        public string Marka
        {
            get { return _marka; }
            set
            {
                if (0 < value.Length) _marka = value;
                else throw new Exception("Érvénytelen márka!");
            }
        }
    }
}
