using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alghorithms.Famous_Alghorithmic_Solutions
{
    public class TwoSum_Problem
    {
        public void Test()
        {
            Console.WriteLine(String.Join(", ", TwoSum(new[] { 2, 7, 11, 15 }, 22)));
        }
        public static int[] TwoSum(int[] nums, int target)
        {
            int[] res = new int[2];
            #region Solution1
            //
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    for (int j = i + 1; j < nums.Length; j++)
            //    {
            //        if (nums[i] + nums[j] == target)
            //        {
            //            res[0] = i;
            //            res[1] = j;
            //            return res;
            //        }
            //    }

            //}

            #endregion

            #region Solution2

            for (int i = 0; i < nums.Length; i++)
            {
                var dif = target - nums[i];
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[j] == dif)
                    {
                        res[0] = i;
                        res[1] = j;
                        return res;
                    }

                }
            }
            #endregion

            return res;
        }
    }
}
