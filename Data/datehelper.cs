using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using System.Globalization;

namespace spirit.Data
{
    public static class DateHelper
    {

        public const String DATE_FORMAT = "yyyy/MM/dd";

        public const String TIME_FORMAT = "hh:mm:ss";

        public const String DATE_TIME_FORMAT = "dd/MM/yyyy hh:mm:ss";

        public static String GetFormattedDate(DateTime value)
        {
            return value.ToString(DATE_FORMAT);
        }

        public static String GetFormattedDate(String value)
        {
            return GetFormattedDateAsDate(value).ToString(DATE_FORMAT);
        }

        public static String GetFormattedDateTime(DateTime value)
        {
            return value.ToString(DATE_TIME_FORMAT);
        }


        public static DateTime GetFormattedDateAsDate(String value)
        {
            var culture = new CultureInfo("es-ES");
            var date = DateTime.MinValue;
            var result = DateTime.TryParseExact(value, DATE_FORMAT, culture, DateTimeStyles.None, out date);
            return date;
        }

    }
}
