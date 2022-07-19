public class Solution {
    public int[] SmallerNumbersThanCurrent(int[] nums) {
        var quantities = new int[nums.Length];
        for (int i = 0; i < quantities.Length; i++)
            quantities[i] = nums.Count(g => g < nums[i]);
        return quantities;
    }
}
