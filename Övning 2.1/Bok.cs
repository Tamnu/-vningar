using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning_2._1
{
    class Bok : Media
    {
        protected int _antalsidor = 0;

        public Bok(string title, int antalsidor) : base(title)
        {
            this._antalsidor = antalsidor;
        }
        public override string ToString()
        {
            return _title + ": " + _antalsidor + " sidor";
        }
    }
}
