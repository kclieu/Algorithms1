using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algos
{
    public static class BitManipulations
    {
        //O(n) where n is number of bits in integer
        //Best case is given interger is 0, function never executes while loop
        public static int NumberofOnesInBinary(int number)
        {
            int numOnes = 0;
            while (number != 0) {
                if ((number & 1) == 1)
                    numOnes++;

                number = number >> 1;
            }

            return numOnes;
        }

        public static bool GetBit(int num, int n)
        {
            //int mask = 1 << n;
            return (num & (1 << n)) != 0;
        }

        public static int SetBit(int num, int n)
        {
            return num | (1 << n);
        }

        public static int ClearBit(int num, int n)
        {
            int mask = ~(1 << n);
            return num & mask;
        }

        //public static int clearBitMSBthroughI(int num, int i);

        //public static int ClearBitsIthrough0(int num, int i )
    }
}
