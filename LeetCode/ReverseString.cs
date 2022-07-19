public class Solution 
{
    public void ReverseString(char[] s)
    {
            int indexA = 0;
            int indexB = s.Length - 1;
            while (indexA <= indexB)
            {
                char temp = s[indexA];
                s[indexA] = s[indexB];
                s[indexB] = temp;
                indexA++;
                indexB--;   
            }
    }
}
