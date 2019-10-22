using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning_2._1
{
    class Film : Ljudspår
    {
        protected string _upplösning;


        public Film(string title, int speltid, string upplösning) : base(title, speltid)
        {
            this._upplösning = upplösning;
        }
        public override string ToString()
        {
            return _title + ": " + _speltid + " minuter " + _upplösning; 
        }

        public string upplösning
        {
            get
            {
                return this._upplösning;
            }
        }
    }
}
