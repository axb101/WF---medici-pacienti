using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WF___medici_pacienti
{
    public class Medic:Persoana
    {
        public int AnAbsolvire;
        public string Specializare = "Fara Specializare";
        public Medic(string n, DateTime d, string c, int a, string s) : base(n, d, c)
        {
            AnAbsolvire = a;
            Specializare = s;
        }
        public Medic() : base()
        {
            AnAbsolvire = 0;
            Specializare = "";
        }
    }
}
