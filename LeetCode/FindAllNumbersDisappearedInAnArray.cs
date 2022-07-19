public class Solution {
    public IList<int> FindDisappearedNumbers(int[] nums) {
        int[] allNums = Enumerable.Range(1, nums.Length).ToArray();
        int[] exceptions = allNums.Except(nums).ToArray();
        IList<int> result = new List<int>();
        foreach (int item in exceptions) { result.Add(item); }
        return result;
    }
}