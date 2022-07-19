public class Solution {
    public int[] SortedSquares(int[] nums) {
        for (int i = 0; i < nums.Length; i++) { nums[i] = nums[i] * nums[i]; }
        List<int> newNumsOne = nums.ToList();
        newNumsOne.Sort();
        int[] newNumsTwo = newNumsOne.ToArray();
        return newNumsTwo;
    }
}