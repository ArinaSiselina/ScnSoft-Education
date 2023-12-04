namespace LeetCodeTraining.ThreeSum
{
    //https://leetcode.com/problems/3sum/
    public class ThreeSumSolution
    {
        public static IList<IList<int>> ThreeSum(int[] nums)
        {
            Array.Sort(nums);
            IList<IList<int>> result = new List<IList<int>>();

            for (int i = 0; i < nums.Length - 2; i++)
            {
                if (i == 0 || (i > 0 && nums[i] != nums[i - 1]))
                {
                    int left = i + 1, right = nums.Length - 1, target = -nums[i];

                    while (left < right)
                    {
                        if (nums[left] + nums[right] == target)
                        {
                            result.Add(new List<int> { nums[i], nums[left], nums[right] });

                            while (left < right && nums[left] == nums[left + 1]) left++;
                            while (left < right && nums[right] == nums[right - 1]) right--;

                            left++;
                            right--;
                        }

                        else if (nums[left] + nums[right] < target)
                        {
                            left++;
                        }

                        else
                        {
                            right--;
                        }
                    }
                }
            }

            return result;
        }
    }
}
