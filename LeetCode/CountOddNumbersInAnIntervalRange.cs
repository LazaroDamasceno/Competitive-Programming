public class Solution {
    public int CountOdds(int low, int high) {
        int oddNumbers = 0;
        for (int i = low; i <= high; i++) {
            if (i % 2 != 0) {
                oddNumbers += 1;
            }
        }
        return oddNumbers;
    }
}
