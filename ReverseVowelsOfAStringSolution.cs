using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public class ReverseVowelsOfAStringSolution
    {
        //Two pointer s.toCharArray()
        public string ReverseVowels(string s) {
            char[] arr = s.ToCharArray();
            int len = arr.Length;
            int left = 0;
            int right = len - 1;

            while (left < right) {
                while (left < right){
                    if (arr[left] == 'a' || arr[left] == 'e' || arr[left] == 'i' || arr[left] == 'o' || arr[left] == 'u' || arr[left] == 'A' || arr[left] == 'E' || arr[left] == 'I' || arr[left] == 'O' || arr[left] == 'U') {
                        break;
                    }
                    left++;
                }

                while (left < right) {
                    if (arr[right] == 'a' || arr[right] == 'e' || arr[right] == 'i' || arr[right] == 'o' || arr[right] == 'u' || arr[right] == 'A' || arr[right] == 'E' || arr[right] == 'I' || arr[right] == 'O' || arr[right] == 'U')
                    {
                        break;
                    }
                    right--;
                }

                char temp = arr[left];
                arr[left] = arr[right];
                arr[right] = temp;
                left++;
                right--;
            }

            return new string(arr);
        }
    }
}
