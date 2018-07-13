using System;
using System.Collections.Generic;
using System.IO;

namespace PrecipitationExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<Country, List<PrecipitationData>> data = new Dictionary<Country, List<PrecipitationData>>();
            using (var streamReader = new StreamReader("WorldPrecipitationData.csv"))
            {
                //Ignore the first line, because it's just titles for each "column"
                streamReader.ReadLine();
                while (!streamReader.EndOfStream)
                {
                    var line = streamReader.ReadLine();
                    var parts = line.Split(",");
                    var countryName = parts[0];
                    var regionName = parts[1];
                    var dateParts = parts[2].Split("-");
                    var startYear = int.Parse(dateParts[0]);
                    var endYear = int.Parse(dateParts[1]);
                    var precipitationValues = new double[13];
                    for (int i = 3; i < 16; i++)
                    {
                        precipitationValues[i - 3] = double.Parse(parts[i]);
                    }
                    var country = new Country(countryName, regionName);
                    if (!data.ContainsKey(country))
                    {
                        data.Add(country, new List<PrecipitationData>());
                    }
                    var timePeriod = new TimePeriod(startYear, endYear);
                    var precipitationData = new PrecipitationData(timePeriod, precipitationValues);
                    data.GetValueOrDefault(country, new List<PrecipitationData>()).Add(precipitationData);
                }
            }
        }
    }
}
