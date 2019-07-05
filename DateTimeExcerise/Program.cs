using System;

namespace DateTimeExcerise
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Extract the date property and display the datetime value in formatted output
            //DateTime dateTime1 = new DateTime(2016, 8, 6, 11, 49, 0);


            //2. Display the day properties (year, month, day, hour, min, sec, millisec etc.

            //DateTime dateTime2 = new DateTime(display the number of days of the year between two specified years.);
            //DisplayTheDateProperties(dateTime2);

            //3. get the day of the week for a specified date
            //DateTime dateTime3 = new DateTime(2016, 11, 7);
            //DisplayDayForSpecifiedDate(dateTime3);

            //4.display the number of days of the year between two specified years
            DateTime dateTime4 = new DateTime(2016, 8, 6, 11, 49, 0);
            System.DateTime.DaysInMonth(12, 1);

        }
        public static void DisplayDateTimeValue(DateTime dateTime)
        {
            Console.WriteLine($"Complete date: {dateTime.ToString()}");
            Console.WriteLine($"Short date: {dateTime.ToShortDateString()}");
            Console.WriteLine("Display date using 24-hour clock format");
            Console.WriteLine(dateTime.ToString("g")); //g = general date time and short time

        }
        public static void DisplayTheDateProperties(DateTime dateTime)
        {
            Console.WriteLine($"year = {dateTime.Year}");
            Console.WriteLine($"month = {dateTime.Month}");
            Console.WriteLine($"day = {dateTime.Day}");
            Console.WriteLine($"hour = {dateTime.Hour}");
            Console.WriteLine($"minute = {dateTime.Minute}");
            Console.WriteLine($"second = {dateTime.Second}");
            Console.WriteLine($"millisecond = {dateTime.Millisecond}");
        }
        public static void DisplayDayForSpecifiedDate(DateTime dateTime)
        {
            var dateString = dateTime.ToShortDateString();
            var day = dateTime.DayOfWeek;

            Console.WriteLine($"The day of the week for {dateString} is {day}.");
        }
        public static void DisplayNoDaysBetweenTwoYears(DateTime dateTime, DateTime dateTime2)
        {

        }
    }
}
