using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övningar
{
    class Fordon
    {
        public enum fordonstyp { Bil, MC};

        string reg;
        string modell;
        string märke;
        
        fordonstyp typ;


        public Fordon(string regnr, string Modell, string märk, fordonstyp Typ)
        {
            this.reg = regnr;
            this.märke = märk;
            this.modell = Modell;
            this.typ = Typ;
        }
        public override string ToString()
        {
            return ":"+reg+" :"+ märke + " :" + modell;
        }
        public fordonstyp Typ

        {

            get { return Typ; }

        }
    }
}
