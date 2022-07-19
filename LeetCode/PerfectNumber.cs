public class Solution {
    public bool CheckPerfectNumber(int num) {
        List<int> sequence = new List<int>();
        for (int n = 1; n < num; n++) 
            if (num % n == 0)
                sequence.Add(n);
        if (sequence.Sum() == num) return true;
        else return false;
    }
}
