using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning_2._8_Inköpslista
{
    class Vara
    {
        protected string namn;

        public Vara(string _namn)
        {
            this.namn = _namn;
        }



        public virtual double BeräknaPris()
        {
            return 0;
        }
    }
}
