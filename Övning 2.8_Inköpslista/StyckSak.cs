using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning_2._8_Inköpslista
{
    class StyckSak : Vara
    {
        double styckPris;
        int antal;

        public StyckSak(string namn,double _stckPris, int _antal) : base(namn)
        {
            this.styckPris = _stckPris;
            this.antal = _antal;
        }
        public override double BeräknaPris()
        {
            return styckPris * antal;
        }
        public override string ToString()
        {
            return namn + " " + antal + " st. ";
        }
    }
}
