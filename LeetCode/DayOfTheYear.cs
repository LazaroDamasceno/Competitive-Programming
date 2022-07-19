public class Solution 
{
    public int DayOfYear(string date) 
    {
        DateTime dt = Convert.ToDateTime(date);
        return dt.DayOfYear;
    }
}
