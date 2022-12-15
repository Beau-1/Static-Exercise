using System;

namespace StaticExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var celsius = TempConverter.FahrenheitToCelsius(45);
            var fahrenheit = TempConverter.CelsiusToFahrenheit(80);

            Console.WriteLine($"It is {celsius}°C");

            Console.WriteLine($"It is {fahrenheit}°F");
        } 
    }
    
}
