public class Solution {
    public int MajorityElement(int[] nums) {
        int maxKey = 0;
        HashSet<int> mySet = new HashSet<int>();
        Dictionary<int, int> myMap = new Dictionary<int, int>();
        foreach (int el in nums) 
            mySet.Add(el);
        foreach (int el in mySet) 
            myMap.Add(el, nums.Count(i => i == el));
        foreach (int key in myMap.Keys)
            if (myMap[key] == myMap.Values.Max())
                maxKey = key;
        return maxKey;
    }
}