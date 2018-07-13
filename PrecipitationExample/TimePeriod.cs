using System;
namespace PrecipitationExample
{
    public class TimePeriod
    {
        public int startYear
        {
            get;
        }
        public int endYear
        {
            get;
        }

        public TimePeriod(int startYear, int endYear)
        {
            this.startYear = startYear;
            this.endYear = endYear;
        }
    }
}
