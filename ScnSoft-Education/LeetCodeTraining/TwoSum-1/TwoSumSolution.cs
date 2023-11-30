namespace LeetCodeTraining.TwoSum1
{
    //https://leetcode.com/problems/two-sum/
    public class TwoSumSolution
    {
        public static int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> numsDict = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                int targetLeft = target - nums[i];
                if (numsDict.ContainsKey(targetLeft))
                {
                    return new int[] { i, numsDict[targetLeft] };
                }
                numsDict.TryAdd(nums[i], i);
            }
            return new int[] { };
        }
    }
}
