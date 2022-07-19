public class Solution {
    public int SearchInsert(int[] nums, int target) {
        int answer = 0;
        if (nums.Contains(target) == true)
        {
            for (int index = 0; index < nums.Length; index++)
            {
                if (nums[index] == target)
                {
                    answer = index;
                }
            }
        }
        if (nums.Contains(target) == false)
        {
            List<int> newNums = Enumerable.ToList(nums);
            newNums.Add(target);
            newNums.Sort();
            nums = Enumerable.ToArray(newNums);
            for (int index = 0; index < nums.Length; index++)
            {
                if (nums[index] == target)
                {
                        answer = index;
                }
            }
        }
        return answer;
    }
}