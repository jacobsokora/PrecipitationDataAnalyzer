using System;
using System.Collections.Generic;

namespace PrecipitationExample
{
    public class PrecipitationData
    {
        Dictionary<Period, double> amounts;
        public TimePeriod timePeriod
        {
            get;
        }

        public PrecipitationData(TimePeriod period, double[] values)
        {
            this.timePeriod = period;
            amounts = new Dictionary<Period, double>();
            for (int i = 0; i < values.Length; i++)
            {
                amounts.Add((Period)i, values[i]);
            }
        }

        public double GetPrecipitationFor(Period period)
        {
            return amounts.GetValueOrDefault(period, 0);
        }

        public double GetAnnualPrecipitation()
        {
            return amounts.GetValueOrDefault(Period.Year, 0);
        }
    }

    public enum Period
    {
        Year, January, February, March, April, May, June, July, August, September, October, November, December
    }
}
