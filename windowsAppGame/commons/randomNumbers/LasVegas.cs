using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace windowsAppGame.commons.randomNumbers
{
    class LasVegas : LinearCongruentialMethod
    {
        private int l;
        private int u;

        public LasVegas(int m,int a,int c, int l, int u): base(m, a, c)
        {
            this.l = l;
            this.u = u;
         
        }
       
        public new long GetRandom()
        {
            int w = u - l;
            long r = 0;
            do
            {
                r = base.GetRandom();
            } while (r < w);
            r = r + l;
            return r;
        }
    }
}
