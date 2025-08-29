class WeatherAdvice

{

    public static void Advise()
    {
        Console.WriteLine("What's the weather like today? (sunny/rainy/cold): ");
        string? weather = Console.ReadLine();

        if (weather != null)
        {

            switch (weather.ToLower())
            {
                case "sunny":
                    Console.WriteLine("Wear a t-shirt and sunglasses.");
                    break;

                case "rainy":
                    Console.WriteLine("Don't forget your umbrella and a raincoat.");
                    break;

                case "cold":
                    Console.WriteLine("Make sure to wear a warm coat and a scarf.");
                    break;

                default:
                    Console.WriteLine("Sorry, I don't have recommendations for this weather.");
                    break;
            }

        }
        
        else
        {
            Console.WriteLine("Input cannot be null. Please enter a valid weather condition.");
        }

    

     }

}
