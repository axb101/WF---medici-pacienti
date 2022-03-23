using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WF___medici_pacienti
{
    public class Pacient:Persoana
    {
        public string CardSanatate;
        public string Ocupatie;
        public Pacient(string n, DateTime d, string c, string cs, string o) : base(n, d, c)
        {
            CardSanatate = cs;
            Ocupatie = o;
        }
        public Pacient() : base()
        { 
        }

    }
}
