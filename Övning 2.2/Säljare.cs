using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning_2._2
{
    class Säljare : Anställd
    {
        double _provition;
        double _försäljning;

        public Säljare(string namn, double provition, double försäljning) : base(namn)
        {
            this._försäljning = försäljning;
            this._provition = provition;
        }
    }
}
