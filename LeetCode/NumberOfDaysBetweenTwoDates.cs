public class Solution {
    public int DaysBetweenDates(string date1, string date2) {
        return Math.Abs((DateTime.Parse(date2) - DateTime.Parse(date1)).Days);
    }
}
