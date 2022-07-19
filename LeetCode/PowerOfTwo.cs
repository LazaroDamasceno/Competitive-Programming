public class Solution 
{
    public bool IsPowerOfTwo(int n) 
    {
        return (5 % (1.0 / n) == 0 && n > 0);
    }
}
