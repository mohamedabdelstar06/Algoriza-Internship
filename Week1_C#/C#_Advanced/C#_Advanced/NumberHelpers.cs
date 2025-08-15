namespace C__Advanced;


public static class NumberHelpers 
{ 
    public static bool IsBetween(this int value , int min , int max)
    {
        return value >= min && value <= max;
    }
}