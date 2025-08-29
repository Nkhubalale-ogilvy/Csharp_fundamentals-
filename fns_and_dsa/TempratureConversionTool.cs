class TemperatureConversionTool
{
    public static string CelsiusToFahrenheit(double celsius)
    {
        try
        {
            double result = (celsius * 9 / 5) + 32;
            return $"{result}°F";
        }
        catch (Exception e)
        {
            return $"Error: {e.Message}";
        }
    }

    public static string FahrenheitToCelsius(double fahrenheit)
    {
        try
        {
            double result = (fahrenheit - 32) * 5 / 9;
            return $"{result}°C";
        }
        catch (Exception e)
        {
            return $"Error: {e.Message}";
        }
    }
}