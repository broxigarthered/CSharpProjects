using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _1._0DifferenceBetweenDates
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            string dateStringFirst = Console.ReadLine();
            string dateStringSecond = Console.ReadLine();
            string format = "d.MM.yyyy";

            //converting the dates into days (numbers)
            DateTime startDate = DateTime.ParseExact(dateStringFirst, format,CultureInfo.InvariantCulture);
            DateTime endDate = DateTime.ParseExact(dateStringSecond, format,CultureInfo.InvariantCulture);

            //finding the result
            String result = (endDate - startDate).TotalDays.ToString();
            
            

            //TimeSpan diff = endDate.Subtract(startDate);
            //TimeSpan diff1 = endDate - startDate;
            
            Console.WriteLine(result);
        }
        // year.month.date
        //      TimeSpan ts = endDate - startDate;
    }
}
