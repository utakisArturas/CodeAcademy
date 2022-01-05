using System;
using System.Collections.Generic;

namespace homeWorks6
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            
            var dayOfWeek = new string[7] { "Sunday","Monday","Tuesday", "Wenesday", "Thursday", "Friday","Saturday" };
            var temperatureOfDay = new double[7];
            foreach (var day in dayOfWeek)
            {
                Console.Write(day + " ");
            }
            Console.ReadLine();

            Console.WriteLine("Enter tempreture of  7 days : ");
            for (int i = 0; i < temperatureOfDay.Length; i++)
            {
                temperatureOfDay[i] = Convert.ToDouble(Console.ReadLine());
            }

            //*min algoritmas ->
            var minTemperature = temperatureOfDay[0];
            foreach (var day in temperatureOfDay)
            {
                if (day < minTemperature)
                {
                    minTemperature = day;
                }
            }
            Console.WriteLine($"Minimal temperature of week is : {minTemperature}");

            //*max algoritmas ->
            var maxTemperature = temperatureOfDay[0];
            foreach (var day in temperatureOfDay)
            {
                if (day > maxTemperature)
                {
                    maxTemperature = day;
                }
            }
            Console.WriteLine($"Highest temperature of week is : {maxTemperature}");
            //* Sumos algoritmas ->
            double sumOfTemp = 0;
            for (int i = 0;i < temperatureOfDay.Length; i++)
            {
                sumOfTemp = sumOfTemp + temperatureOfDay[i];
            }
            //*avg temperaturu
            var avgTemp = sumOfTemp / temperatureOfDay.Length;
            Console.WriteLine($"Weekly avg temperature is : {avgTemp}");
            //* zemiau vidurkio ->
            double loverAvg = 0;
            for (int i = 0; i < temperatureOfDay.Length; i++)
            {
                if(temperatureOfDay[i] < avgTemp)
                {
                    loverAvg = temperatureOfDay[i];
                    Console.WriteLine($"Temperature lower average : {loverAvg}");
                }
            }
            //* auksciau vidurkio ->
            double higherAvg = 0;
            for (int i = 0; i < temperatureOfDay.Length; i++)
            {
                if (temperatureOfDay[i] > avgTemp)
                {
                    higherAvg = temperatureOfDay[i];
                    Console.WriteLine($"Temperature higher average : {higherAvg}");
                }
            }
            
        }
    }
}
