namespace KataSolution;

public static class Kata
{
    public static int СenturyFromYear(int year) => 
        year * 0.01
        (int)Math.Ceiling((decimal)year / 100);
}