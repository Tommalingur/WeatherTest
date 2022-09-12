using CPrimer_Challenge_2;
using System;
using System.Reflection.Metadata.Ecma335;
/*Challenge 2:
Write a class called WeatherData 

This class should store data for the current weather conditions. The data should include properties for 

temperature  
humidity 
scale 

The class should allow the user to set the current temperature to be anywhere between -60 or +60 Celsius (-76 and 140 Fahrenheit). 
Should a temperature of higher or lower than this value be set the class should generate a message that states that a reading 
mistake must have been made since the value seems unrealistic.  
Humidity values should be allowed between 0% and 100%.  
The scale attribute should accept either ’C’ or ’F’ as its value.  
The class should have a method called Convert(). When the method is called the current scale should be changed from F to C or 
from C to F. The formula to convert between these values are Celsius = (Fahrenheit – 32) 5/9 Fahrenheit = (Celsius 9/5) + 32.  
Add any code you deem necessary to ensure the data is robust. 

Test the class using your own code. 
*/

internal class Program
{
    static void Main(string[] args)
    {

        WeatherData newData = new (0,0,"c");
        string scaleChooser;
        int currentTemp;
        int currentHum;

        Console.WriteLine("Please enter 'c' to get readings in Celsius, or 'f' to get readings in Fahrenheit");
        while (true)
        {
            scaleChooser = Console.ReadLine();
            if (scaleChooser == "c" || scaleChooser == "C")
            {
                newData.Celsius();
                break;
            } else if (scaleChooser == "f" || scaleChooser == "F")
            {
                newData.Fahrenheit();
                break;
            } else
            {
                Console.WriteLine("Please enter a valid letter. 'c' for Celsius or 'f' for Fahrenheit");
            }
        }
        Console.WriteLine($"The scale is °{newData.Scale}");

        Console.WriteLine($"Please enter the current °{newData.Scale} temperature");
        while(true)
        {
            currentTemp = Console.Read();
            if (newData.Scale == "c" && currentTemp <= 60 || currentTemp >= -60)
            {
                newData.Temperature = currentTemp;
                break;
            } else if (newData.Scale == "f" && currentTemp <= 140 || currentTemp >= -76)
            {
                newData.Temperature = currentTemp;
                break;
            } else
            {
                Console.WriteLine("The temperature entered is invalid. Please enter a valid temperature");
            }
        }
        Console.WriteLine($"The selected temperature is {newData.Temperature}°{newData.Scale}");

        Console.WriteLine("Please enter the curren percentege of humidity");
        while (true)
        {
            currentHum = Console.Read();
            if (currentHum <= 100 && currentHum >= 0)
            {
                newData.Humidity = currentHum;
                break;
            } else
            {
                Console.WriteLine("Invalid percentage, please enter a number between 0 and 100");
            }
        }
        Console.WriteLine($"The current temperature is {newData.Temperature}°{newData.Scale} with {newData.Humidity}% humidity");

    }
}