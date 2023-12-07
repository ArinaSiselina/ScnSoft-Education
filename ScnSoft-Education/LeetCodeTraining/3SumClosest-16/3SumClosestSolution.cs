namespace LeetCodeTraining.ThreeSumClosest
{
    //https://leetcode.com/problems/3sum-closest/
    public class ThreeSumClosestSolution
    {
        public static int ThreeSumClosest(int[] nums, int target)
        {
            Array.Sort(nums);

            int closestSum = nums[0] + nums[1] + nums[2];

            for (int i = 0; i < nums.Length - 2; i++)
            {
                int left = i + 1, right = nums.Length - 1;
                while (left < right)
                {
                    int currSum = nums[i] + nums[left] + nums[right];

                    if (Math.Abs(currSum - target) < Math.Abs(closestSum - target))
                    {
                        closestSum = currSum;
                    }

                    if (currSum == target)
                        return closestSum;

                    if (currSum < target)
                    {
                        left++;
                        continue;
                    }

                    right--;
                }
            }

            return closestSum;
        }
    }
}
