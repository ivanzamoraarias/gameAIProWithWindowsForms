using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
    A random count of events based in the Poisson distribution when there are average u 
    independent events per a measurement unit.
*/
namespace windowsAppGame.commons.randomNumbers
{
    class RandomPoisson : RandomGenerator
    {
        private int u;
        RandomPoisson(int u)
        {
            this.u = u;
        }
        public long GetRandom()
        {
            double t = Math.Exp(-u);
            int n = -1;
            double p = 1;
            do
            {
                n = n + 1;
                p = p * RandomUnit();
            } while (p <= t);
            return n;            
        }
        private double RandomUnit() => new Random().Next(0, 1);
    }
}
