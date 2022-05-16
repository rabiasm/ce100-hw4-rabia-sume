using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using ce100_hw4_algo_lib_cs;

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
    public class Knapsack1
    {
        /** 
        * @name  KnapSack
        * 
        * @brief Returns the maximum value that
        *        can be put in a knapsack of capacity W
        *      
        * 
        * @param [in] fiW [\b int]  function index of  in the serie
        * 
        * @param [in] fiWT [\b int[]]  function index of  in the serie
        * 
        * @param [in] fiWT [\b int[]]  function index of  in the serie
        * 
        * @param [in] fiWT [\b int]  function index of  in the serie
        * 
        * @retval [\b int] return KnapSack 0-1 as an int array.
        * 
        **/
        public static int KnapSack(int fiW, int[] fiWT,
                            int[] fiVAL, int fiN)
        {
            int i, w;
            int[,] K = new int[fiN + 1, fiW + 1];

            // Build table K[][] in bottom
            // up manner
            for (i = 0; i <= fiN; i++)
            {
                for (w = 0; w <= fiW; w++)
                {
                    if (i == 0 || w == 0)
                        K[i, w] = 0;

                    else if (fiWT[i - 1] <= w)
                        K[i, w] = Math.Max(
                            fiVAL[i - 1]
                            + K[i - 1, w - fiWT[i - 1]],
                            K[i - 1, w]);
                    else
                        K[i, w] = K[i - 1, w];
                }
            }

            return K[fiN, fiW];
        }
    }
}
