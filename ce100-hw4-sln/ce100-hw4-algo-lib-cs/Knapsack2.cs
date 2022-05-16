using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

/*
 * @file Algo_lib.cs
 * @author Rabia SÜME
 * @date 16 MAY 2022
 *
 * @brief <b> HW-4 Functions </b>
 *
 * HW-4 Algo Lib Functions Header
 *
 * @see http://bilgisayar.mmf.erdogan.edu.tr/en/
 *
 */

namespace ce100_hw4_algo_lib_cs
{
    public class Knapsack2
    {
        /** 
        * @name  printknapSack
        * 
        * @brief Prints the items which are put 
        *        in a knapsack of capacity W
        * 
        * @param [in] fiW [\b int]  function index of  in the serie
        * 
        * @param [in] fiWT [\b int[]]  function index of  in the serie
        * 
        * @param [in] fiWT [\b int[]]  function index of  in the serie
        * 
        * @param [in] fiWT [\b int]  function index of  in the serie
        * 
        * @retval [\b string] return KnapSack 0-1 as a string.
        * 
        **/
        public static string printknapSack(int fiW, int[] fiWT,
                                int[] fiVAL, int fiN)
        {
            int i, w;
            string print = "";
            int[,] K = new int[fiN + 1, fiW + 1];

            // Build table K[][] in bottom up manner
            for (i = 0; i <= fiN; i++)
            {
                for (w = 0; w <= fiW; w++)
                {
                    if (i == 0 || w == 0)
                        K[i, w] = 0;
                    else if (fiWT[i - 1] <= w)
                        K[i, w] = Math.Max(fiVAL[i - 1] +
                                K[i - 1, w - fiWT[i - 1]], K[i - 1, w]);
                    else
                        K[i, w] = K[i - 1, w];
                }
            }

            // stores the result of Knapsack
            int res = K[fiN, fiW];


            w = fiW;
            for (i = fiN; i > 0 && res > 0; i--)
            {

                // either the result comes from the top
                // (K[i-1][w]) or from (val[i-1] + K[i-1]
                // [w-wt[i-1]]) as in Knapsack table. If
                // it comes from the latter one/ it means
                // the item is included.
                if (res == K[i - 1, w])
                    continue;
                else
                {
                    // This item is included.
                    print += fiWT[i - 1] + ", ";

                    // Since this weight is included its
                    // value is deducted
                    res -= fiVAL[i - 1];
                    w -= fiWT[i - 1];
                }
            }
            return print.Remove(print.Length - 2);
        }
    }
}
