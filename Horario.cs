using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cosmos.HAL;
using SideralOS;

namespace SideralOS
{
    public class Horario
    {
        static int Hora() { return RTC.Hour; }

        static int Minute() { return RTC.Minute; }

        static int Second() { return RTC.Second; }

        static int Century() { return RTC.Century; }

        static int Year() { return RTC.Year; }

        static int Month() { return RTC.Month; }

        static int DayOfMonth() { return RTC.DayOfTheMonth; }

        static int DayOfWeek() { return RTC.DayOfTheWeek; }

        static string getTime24(bool hora, bool min, bool sec)
        {
            string timeStr = "";
            if (hora)
            {
                if (Hora().ToString().Length == 1)
                {
                    timeStr += "0" + Hora().ToString();
                }
                else
                {
                    timeStr += Hora().ToString();
                }
            }
            if (min)
            {
                if (Minute().ToString().Length == 1)
                {
                    timeStr += ":";
                    timeStr += "0" + Minute().ToString();
                }
                else
                {
                    timeStr += ":";
                    timeStr += Minute().ToString();
                }
            }
            if (sec)
            {
                if (Second().ToString().Length == 1)
                {
                    timeStr += ":";
                    timeStr += "0" + Second().ToString();
                }
                else
                {
                    timeStr += ":";
                    timeStr += Second().ToString();
                }
            }
            return timeStr;
        }

        static string getTime12(bool hour, bool min, bool sec)
        {
            string timeStr = "";
            if (hour)
            {
                if (Hora() > 12)
                    timeStr += Hora() - 12;
                else
                    timeStr += Hora();
            }
            if (min)
            {
                if (Minute().ToString().Length == 1)
                {
                    timeStr += ":";
                    timeStr += "0" + Minute().ToString();
                }
                else
                {
                    timeStr += ":";
                    timeStr += Minute().ToString();
                }
            }
            if (sec)
            {
                if (Second().ToString().Length == 1)
                {
                    timeStr += ":";
                    timeStr += "0" + Second().ToString();
                }
                else
                {
                    timeStr += ":";
                    timeStr += Second().ToString();
                }
            }
            if (hour)
            {
                if (Hora() > 12)
                    timeStr += " PM";
                else
                    timeStr += " AM";
            }
            return timeStr;
        }

       
        public static string TimeString(bool hour, bool min, bool sec)
        {
          switch (Kernel.langSelected)
            {
                case "fr_FR":
                    return getTime24(hour, min, sec);
                case "en_US":
                    return getTime12(hour, min, sec);
                case "nl_NL":
                    return getTime24(hour, min, sec);
                case "it_IT":
                    return getTime12(hour, min, sec);
                default:
                    return getTime12(hour, min, sec);
            }
        }

        /// <summary>
        /// Year String
        /// </summary>
        /// <returns>Actual Year</returns>
        public static string YearString()
        {
            int intyear = Year();
            string stringyear = intyear.ToString();

            if (stringyear.Length == 2)
            {
                stringyear = "20" + stringyear;
            }
            return stringyear;
        }

        /// <summary>
        /// Month String
        /// </summary>
        /// <returns>Actual Month</returns>
        public static string MonthString()
        {
            int intmonth = Month();
            string stringmonth = intmonth.ToString();

            if (stringmonth.Length == 1)
            {
                stringmonth = "0" + stringmonth;
            }
            return stringmonth;
        }

        /// <summary>
        /// Day String
        /// </summary>
        /// <returns>Actual Day</returns>
        public static string DayString()
        {
            int intday = DayOfMonth();
            string stringday = intday.ToString();

            if (stringday.Length == 1)
            {
                stringday = "0" + stringday;
            }
            return stringday;
        }


    }
}
