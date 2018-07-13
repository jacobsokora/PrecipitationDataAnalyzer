using System;
namespace PrecipitationExample
{
    public class Country
    {
        public string name
        {
            get;
        }
        public string region
        {
            get;
        }

        public Country(string name, string region)
        {
            this.name = name;
            this.region = region;
        }
    }
}
