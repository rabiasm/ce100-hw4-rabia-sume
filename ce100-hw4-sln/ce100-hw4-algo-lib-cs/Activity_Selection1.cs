using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 *@file Algo_lib.cs
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
    public class Activity_Selection1
    {
        /* 
        * @name ActivitySelectionPrintMaxActivitie
        * 
        * @brief Prints a maximum set of activities
        * that can be done by a single
        *        person, one at a time.
        *        n --> Total number of activities
        *        s[] --> An array that contains start
        * time of all activities
        * f[] --> An array that contains finish
        * time of all activities
        *
        * @param [in] fiS[\b int[]] function index of  in the serie
        * 
        * @param[in] fiF [\b int[]]  function index of  in the serie
        * 
        * @param[in] fiN[\b int]  function index of  in the serie
        * 
        * @retval[\b int] return Topological Order as an int.
        * 
        */
        public static string ActivitySelectionPrintMaxActivitie(int[] fiS, int[] fiF, int fiN)
        {
            int i, j;


            // The first activity always gets selected
            i = 0;
            Console.Write(i + " ");
            string cal = "";
            // Consider rest of the activities
            for (j = 1; j < fiN; j++)
            {
                // If this activity has start time greater than or
                // equal to the finish time of previously selected
                // activity, then select it
                if (fiS[j] >= fiF[i])
                {
                    cal = j + ", ";
                    i = j;
                }
            }

            return cal.Remove(cal.Length - 2);
        }

    }
}
    

