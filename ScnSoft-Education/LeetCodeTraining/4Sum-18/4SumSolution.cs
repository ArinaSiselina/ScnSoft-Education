namespace LeetCodeTraining.FourSum
{
    //https://leetcode.com/problems/4sum/submissions/
    public class FourSumSolution
    {
        public static IList<IList<int>> FourSum(int[] nums, int target)
        {
            Array.Sort(nums);
            IList<IList<int>> result = new List<IList<int>>();

            if (nums.Length < 4)
            {
                return result;
            }

            for (int i = 0; i < nums.Length - 3; i++)
            {
                if (i > 0 && nums[i] == nums[i - 1]) 
                { 
                    continue;
                }
                    
                for (int j = i + 1; j < nums.Length - 2; j++)
                {
                    if (j > i + 1 && nums[j] == nums[j - 1])
                    {
                        continue;
                    }
                     
                    for (int k = j + 1; k < nums.Length - 1; k++)
                    {
                        if (k > j + 1 && nums[k] == nums[k - 1])
                        {
                            continue;
                        }
                            
                        int left = k + 1;

                        while (left < nums.Length)
                        {
                            long sum = (long)nums[i] + nums[j] + nums[k] + nums[left];

                            if (sum == target)
                            {
                                result.Add(new List<int> { nums[i], nums[j], nums[k], nums[left] });
                                while (left < nums.Length - 1 && nums[left] == nums[left + 1])
                                {
                                    left++;
                                }   
                            }

                            left++;
                        }
                    }
                }
            }

            return result;
        }
    }
}