﻿namespace LeetCodeTraining.RemoveElement
{
    //https://leetcode.com/problems/remove-element/
    public class RemoveElementSolution
    {
        public static int RemoveElement(int[] nums, int val)
        {
            int k = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != val)
                {
                    nums[k++] = nums[i];
                }
            }

            return k;
        }
    }
}