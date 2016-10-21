using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algos
{
    public static class KnapSack
    {
        public static int GetKnapSack(int w, List<Pair<int, int>> items)
        {
            int[] V = new int[w + 1];

            foreach (Pair<int, int> item in items)
            {
                for (int j = w; j >= item.GetFirst(); j--)
                {
                    V[j] = Math.Max(V[j], V[j - item.GetFirst()] + item.GetSecond()); 
                }
            }

            return V[w];
        }
    }
}
