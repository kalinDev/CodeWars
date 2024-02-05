namespace KataSolution;

public static class Kata
{
    public static int СenturyFromYear(int year) => 
        (int)Math.Ceiling((decimal)year / 100);
}