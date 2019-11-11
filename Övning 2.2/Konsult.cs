using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning_2._2
{
    class Konsult : Anställd 
    {
        double _arbetadeTimmar;
        double _timLön;

        public Konsult(string namn, double arbetadeTimmar, double timLön): base(namn)
        {
            this._arbetadeTimmar = arbetadeTimmar;
            this._timLön = timLön;
        }
        public override string ToString()
        {
            return _namn + " (Konsult)";
        }
        public override double beräkna()
        {
            { return _arbetadeTimmar * _timLön; }
        
        }
    }
}
