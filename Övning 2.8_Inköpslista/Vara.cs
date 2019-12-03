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
            return 0 ;
        }

        public override string ToString()
        {
            return this.namn + "Du får fixa så att priset räkas ut och står här";
        }
    }
}
