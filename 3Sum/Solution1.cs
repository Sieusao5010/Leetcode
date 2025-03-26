﻿namespace _3Sum
{
    public class Solution1
    {
        public IList<IList<int>> ThreeSum(int[] nums)
        {
            int left, right, sum = 0;
            Array.Sort(nums);
            List<IList<int>> list = new List<IList<int>>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (i >0 && nums[i] == nums[i-1]) continue;
                left = i + 1;
                right = nums.Length - 1;

                while (left < right)
                {
                    sum = nums[i] + nums[left] + nums[right];

                    if (sum == 0)
                    {
                        list.Add(new List<int>()
                        {
                            nums[i],nums[left],nums[right]
                        });

                        while (left < right && nums[left] == nums[left + 1]) { left++; }
                        while (left < right && nums[right] == nums[right - 1]) { right--; }


                        left++;
                        right--;
                    }
                    else if (sum > 0)
                    {
                        left++;
                    }
                    else { right--; }

                }

            }

            return list;
        }
    }
}
