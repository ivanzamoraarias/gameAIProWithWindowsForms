using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace windowsAppGame.commons.randomNumbers
{
    class Shuffle : RandomListGenerator
    {
        SortedSet<int> orderedSet;
        Shuffle(SortedSet<int> set)
        {
            orderedSet = set;
        }
        public IList GetRandomList()
        {
            List<int> R = orderedSet.ToList();
            for(int i = 0; i <= R.Count - 2; i++)
            {
                int j = new Random().Next(i, R.Count);
                SwapIntegers(R[i], R[j]);
            }
            return R;
        }
        private void SwapIntegers(int a, int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
    }
}
