using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Random numbers algorithm
 * Linear Congruential Method: Generationg random integer numbers within the interval [0,m)This algorithm is know as the linear congriential method,
 * and since its inception ithas quite firmily stood the test of time. 
 * The algorithm is simple to implement and requires only a rigorous coice of four fixed integer prarmeters
 * modulus: m(0<m)
 * multiplier: a(0<=a<m)
 * increment: c(0<=c<m)
 * starting value: X0(0<=X0<m)
*/
namespace windowsAppGame.commons.randomNumbers
{
    class LinearCongruentialMethod : RandomGenerator
    {
        private int m;
        private int a;
        private int c;
        private int xo;

        LinearCongruentialMethod(int m, int a, int c)
        {
            this.m = m;
            this.a = a;
            this.c = c;
            this.xo = this.generateInitialValue();
        }
      
        public long GetRandom()
        {
            int q = m / a;
            int p = m % a;
            int r = a * (xo % q) - p * (xo / q);
            if (r < 0)
            {
                r = r + m;
            }
            r = moduloSum(r,c,m);
            xo = r;
            return r;
        }
        private int generateInitialValue() => new Random().Next(0, m - 1);

        private int moduloSum(int x, int y, int mo)
        {
            if (x <= mo - 1 - y)
            {
                return x + y;
            }
            return x - (mo - y);
        }
    }
}
