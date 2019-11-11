using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning_2._2
{
    class Kontorist : Anställd
    {
        double _månadsLön;

        public Kontorist(string namn, double månadsLön): base(namn)
        {
            this._namn = namn;
            this._månadsLön = månadsLön;

        }
        public override string ToString()
        {
            return _namn + " (Kontorist)";
        }
        public override double beräkna()
        {
            { return _månadsLön; }
        }
        
    }
}
