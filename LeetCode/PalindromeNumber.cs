public class Solution {
    public bool IsPalindrome(int x) {
        string xOne = x.ToString();
        string xTwo = "";
        for (int i = xOne.Length - 1; i >= 0; i--)
        {
            xTwo += xOne[i];
        }
        return xOne == xTwo;
    }
}