public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        int[] answer = new int[2];
        int a = -1;
        for (int b = 0; b < nums.Length; b++) {
            for (int c = b + 1; c < nums.Length; c++) {
                if (nums[b] + nums[c] == target) {
                    answer[++a] = b;
                    answer[++a] = c;
                }
            }
        }
        return answer;
    }
}