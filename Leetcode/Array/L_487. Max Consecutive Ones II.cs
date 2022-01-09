// https://leetcode.com/problems/max-consecutive-ones-ii/

public class Solution {
    public int FindMaxConsecutiveOnes(int[] nums) {
        int max = 1;
        int left = 0; 
        int right = 0;
        int indexOfZero = -1;
        while(right <  nums.Length)
        {
            if(nums[right] == 0)
            {
                left = indexOfZero+1;
                indexOfZero = right;
            }
            max = Math.Max(max, right-left+1);     
          right = right + 1;

        }
        return max;
    }
}
