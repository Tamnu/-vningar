using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning_2._1
{
    class Ljudspår : Media
    {
        protected int _speltid = 0;

        public Ljudspår(string title, int speltid) : base(title)
        {
            this._speltid = speltid;
        }
        public override string ToString()
        {
            return _title + ": " + _speltid + " minuter";
        }

        
    }
}
