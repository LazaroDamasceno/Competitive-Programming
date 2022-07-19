public class Solution {
    public int LengthOfLastWord(string s) {
        string[] c = s.Trim().Split(' ');
        return c[c.Length-1].Length;
    }
}
