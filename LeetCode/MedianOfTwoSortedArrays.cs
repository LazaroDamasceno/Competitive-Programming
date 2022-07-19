public class Solution 
{
    public double FindMedianSortedArrays(int[] nums1, int[] nums2)    
    {
        List<int> nums3 = new List<int>();
        foreach (var item in nums1) { nums3.Add(item); }
        foreach (var item in nums2) { nums3.Add(item); }
        nums3.Sort();
        if (nums3.Count % 2 != 0) { return nums3[(nums3.Count-1)/2]; }
        else { return (nums3[(nums3.Count-1)/2] + nums3[((nums3.Count-1)/2)+1]) / 2.0; }
    }
}
