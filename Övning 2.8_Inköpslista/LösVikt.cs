using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning_2._8_Inköpslista
{
    class LösVikt : Vara
    {
        double kiloPris;
        double vikt;

        public LösVikt(string namn,double _kilopris,double _vikt) : base(namn)
        {
            this.kiloPris = _kilopris;
            this.vikt = _vikt;

        }
        public override string ToString()
        {
            return namn + " "+ vikt + " kg. " ;
        }
        public override double BeräknaPris()
        {
            return kiloPris * vikt;
        }
    }
}
