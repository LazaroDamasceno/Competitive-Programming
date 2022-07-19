public class Solution {
    public int[] Intersection(int[] nums1, int[] nums2) {
        IEnumerable<int> both = nums1.Intersect(nums2);
        int[] answer = new int[both.Count()];
        int index = 0;
        foreach (int el in both) { answer[index++] = el; }
        return answer;
    }
}