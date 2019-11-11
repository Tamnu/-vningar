using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning_2._2
{
    class Anställd
    {
        protected string _namn;

        public Anställd(string namn)
        {
            this._namn = namn;
        }
        public virtual double beräkna()
        {
            { return 0; }
        }
    }
}
