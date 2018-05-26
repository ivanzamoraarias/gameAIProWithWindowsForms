using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace windowsAppGame.commons.randomNumbers
{
    class LasVegas : RandomGenerator
    {
        private int l;
        private int u;
        private int m;

        LasVegas(int m, int l, int u)
        {
            this.l = l;
            this.u = u;
        }
        public long GetRandom()
        {
            throw new NotImplementedException();
        }
    }
}
