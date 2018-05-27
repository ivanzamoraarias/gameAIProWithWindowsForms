using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace windowsAppGame.commons.randomNumbers
{
    class AllPermutations : RandomListGenerator
    {
        int n;
        AllPermutations(int n)
        {
            this.n = n;
        }
        public List<int[]> getAllPermutations()
        {
            List<int[]> R = new List<int[]>();
            int[] C = new int[n];
            int[] O = new int[n];
            int[] S = new int[n];

            for (int i = 0; i <= (n - 1); i++)
            {
                C[i] = 0;
                O[i] = 1;
                S[i] = i;
            }
            int j;
            do
            {
                j = n - 1;
                int s = 0;
                int q = C[j] + O[j];
                for (int i = 0; i <= (n - 2); i++)
                {
                    R.Add(S);
                    int alfa = j - C[j] + s;
                    int beta = j - q + s;
                    SwapIntegers(S[alfa], S[beta]);
                    C[j] = q;
                    q = C[j] + O[j];
                }
                R.Add(S);

                while (q < 0)
                {
                    O[j] = -O[j];
                    j = j - 1;
                    q = C[j] + O[j];

                }

                while (q == (j + 1) && j != 0)
                {
                    s = s + 1;
                    O[j] = -O[j];
                    j = j - 1;
                    q = C[j] + O[j];

                }
                if (j != 0)
                {
                    int alfa = j - C[j] + s;
                    int beta = j - q + s;
                    SwapIntegers(S[alfa], S[beta]);
                    C[j] = q;

                }


            } while (j == 0);
            return R;
        }

        private void SwapIntegers(int a, int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        public IList GetRandomList()
        {
            return getAllPermutations();
        }
    }
}
