using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw2_uni_tests_Hiker
{
    public class Hiker
    {
        public static object ClosestToZero(int[] list)
        {
            try
            {
                if (list == null) // check if the function got null
                {
                    throw new Exception("The list is null");
                }

                int closest = list[0]; // put the first number from the array to the variable

                for (int i = 1; i < list.Length; i++) // loop that will check the smallest distance from zero
                {
                    int positiveNum = Math.Abs(list[i]); // abs of the current loop value
                    int positiveClosest = Math.Abs(closest); // abs of the current smallest distance

                    if (positiveNum == positiveClosest && list[i] > closest) // Disance Is Equal And The Current Number Bigger Then The Closest Number
                    {
                        closest = list[i];
                    }

                    if (positiveClosest > positiveNum) // Check If Distance IsCloser To Zero With No Duplicated
                    {
                        closest = list[i];
                    }
                }

                return closest;
            }
            catch (Exception e)
            {

                return e.Message;
            }
        }

    }
}
