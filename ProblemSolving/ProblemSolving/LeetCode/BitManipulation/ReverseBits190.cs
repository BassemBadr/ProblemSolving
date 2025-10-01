using System;

namespace ProblemSolving.LeetCode.BitManipulation
{
    public class ReverseBits190
    {
        //https://leetcode.com/problems/reverse-bits

        private static uint[] lookup;

        public ReverseBits190()
        {
            lookup = new uint[256];
            for (int i = 0; i < 256; i++)
            {
                uint reversed = 0;
                for (int j = 0; j < 8; j++)
                {
                    reversed = (reversed << 1) | (uint)((i >> j) & 1);
                }
                lookup[i] = reversed;
            }
        }
        
        public int ReverseBits(int n)
        {
            //  folowup : If this function is called many times, how would you optimize it?
            //  create and store lookup to for reversed forms of every 8 bit combination 
            //  then on 4 steps handle each 8 bits from lookup to get reversed form and add it to the end
            //  i.e. lookup & divide and conquer
            //  initialization is done one time only 
            //  each run for reverseBits does 4 lookup and shift operations
            uint un = (uint)n;
            return (int)(lookup[un & 0xFF] << 24 | lookup[(un >> 8) & 0xFF] << 16 | lookup[(un >> 16) & 0xFF] << 8 | lookup[un >> 24]);
        }

        private static int Solution1(ref int n)
        {
            //  this is a try for bit manibulation instead of math
            //  time O(32) could say O(1)
            //  space O(1)

            int result = 0; //  init result with all zeros
            for (int i = 0; i < 32; i++)    //  set loop for 32 round equivilant to 32 bit
            {
                //  shift result bits by 1 to the left this way by the end of the loops least bit will be at the left
                result <<= 1;
                //  (n & 1) extract least bit
                //  result != sets the least bit to the result
                result |= (n & 1);
                //  shift n one position to the right
                n >>= 1;
            }
            return result;
        }
    }
}
