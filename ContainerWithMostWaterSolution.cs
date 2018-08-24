using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    //C = A * B 起始状态 max = (right - left) * (Math.Min(height[left],height[right]))，然后two pointer， 每移一步算一次面积C和max比较
    public class ContainerWithMostWaterSolution
    {
        public int MaxArea(int[] height) {
            int len = height.Length;
            int left = 0;
            int right = len - 1;
            int max = (right - left) * (Math.Min(height[left],height[right]));
            int C = 0;

            while (left < right) {
                if (height[left] <= height[right])
                {
                    C = height[left] * (right - left);
                    left++;
                }
                else {
                    C = height[right] * (right - left);
                    right--;
                }
                max = Math.Max(max, C);
            }

            return max;
        }
    }
}
