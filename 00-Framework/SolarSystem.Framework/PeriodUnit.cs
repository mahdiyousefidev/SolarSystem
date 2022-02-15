namespace SolarSystem.Framework
{
    public class PeriodUnit
    {
        public PeriodUnit(string title)
        {
            Title = title;
        }
        public string Title { get; set; }
        // todo and the measure property

        public int ToDay()
        {
            switch (Title)
            {
                case "days":
                    return 1;

                case "months":
                    return 30;

                case "years":
                    return 365;
                default:
                    return -1;
                    break;
            }
        }
    }
}