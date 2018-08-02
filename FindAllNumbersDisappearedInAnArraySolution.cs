using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    // Swap solution !nums[i] - 1 --> index      nums[i] <--> nums[index]
    public class FindAllNumbersDisappearedInAnArraySolution
    {
        public List<int> FindDisappearedNumbers(int[] nums) {
            List<int> result = new List<int>();
            int len = nums.Length;

            if (len == 0) {
                return result;
            }

            int i = 0;
            int index;

            while (i < len) {
                if (nums[i] == i + 1) {
                    i++;
                    continue;
                }

                index = nums[i] - 1;

                if (nums[i] == nums[index]) {
                    i++;
                    continue;
                }

                int temp = nums[i];
                nums[i] = nums[index];
                nums[index] = temp;
            }

            for (int j = 0; j < len; j++) {
                if (nums[j] != j + 1) {
                    result.Add(j + 1);
                }
            }
            return result;
        }
    }
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    //public List<Integer> findDisappearedNumbers(int[] nums)
    //{

    //    List<Integer> missing = new ArrayList<>();
    //    int[] a = nums;

    //    if (a.length == 0)
    //    {
    //        return missing;
    //    }

    //    int j;
    //    int i = 0;

    //    while (i < a.length)
    //    {
    //        if (a[i] == i + 1)
    //        {
    //            i++;
    //            continue;
    //        }

    //        j = a[i] - 1;

    //        if (a[i] == a[j])
    //        {
    //            i++;
    //            continue;
    //        }

    //        int t = a[i];
    //        a[i] = a[j];
    //        a[j] = t;
    //    }

    //    for (i = 0; i < a.length; i++)
    //    {
    //        if (a[i] != i + 1)
    //        {
    //            missing.add(i + 1);
    //        }
    //    }

    //    return missing;
    //}
}
