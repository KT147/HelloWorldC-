namespace Structs
{
    public class Date
    {
        public static DateTime GetTomorrow()
        {
            return DateTime.Today.AddDays(1);
        }
        public static DateTime GetFirstDayOfYear(int year)
        {
            return new DateTime(year, 1, 1);
        }
    }

    public struct Event
    {
        public DateTime StartDate { get; }
        public DateTime EndDate { get;}
        
        public Event(DateTime start, DateTime end)
        {
            StartDate = start;
            EndDate = end;
        }

        public double GetDuration()
        {
            if (StartDate.Year == EndDate.Year)
            {
                return EndDate.DayOfYear - StartDate.DayOfYear;
            }
            else
            {
                int years = EndDate.Year - StartDate.Year;
                return (years * 365) + (EndDate.DayOfYear - StartDate.DayOfYear);
            }

        }

        public bool IsOverlapping(Event otherEvent)
        {
            return EndDate.Date < otherEvent.EndDate.Date;
        }
    }


}

