using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WF___medici_pacienti
{   [Serializable]
    public class Persoana
    {
        public string NumePrenume;
        public DateTime DataNasterii;
        public string Cnp;
        public Persoana(string n, DateTime d, string c)
        {
            NumePrenume = n;
            DataNasterii = d;
            Cnp = c;
        }
        public Persoana()
        { 
        }
    }
}
