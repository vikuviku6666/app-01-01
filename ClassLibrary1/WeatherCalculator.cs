namespace ClassLibrary1;

public class WeatherCalculator
{
public static string DetermineSeason(DateOnly date)
{
    int month = date.Month;

    if (month >= 3 && month <= 5)
    {
      return "Spring";
    }
    if (month >= 6 && month <= 8)
    {
      return "Summer";
    }
    if (month >= 9 && month <= 11)
    {
      return "Autumn";
    }
    return "Winter";
}
}
