using System;
using System.Collections.Generic;
using System.Text;
using TimeZoneConverter;

namespace KitabMawkout.MyProcs
{
    public static class TimeConvertToLocal
    {
        /// <summary>
        /// Convert a prayer time to a specific local timezone.
        /// Accepts Windows IDs ("W. Europe Standard Time") or IANA IDs ("Africa/Algiers").
        /// If timezone is invalid or null, falls back to device local time.
        /// </summary>
        public static DateTime ConvertToLocal(DateTime time, string? timeZoneId)
        {
            if (string.IsNullOrWhiteSpace(timeZoneId))
                return time.ToLocalTime();

            try
            {
                TimeZoneInfo tz;

                // Try Windows timezone first
                try
                {
                    tz = TimeZoneInfo.FindSystemTimeZoneById(timeZoneId);
                }
                catch
                {
                    // Fallback: try IANA timezone (Android, Linux, macOS)
                    tz = TimeZoneInfo.FindSystemTimeZoneById(
                        TZConvert.IanaToWindows(timeZoneId)
                    );
                }

                return time.Kind == DateTimeKind.Utc
                    ? TimeZoneInfo.ConvertTimeFromUtc(time, tz)
                    : TimeZoneInfo.ConvertTime(time, tz);
            }
            catch
            {
                // Fallback if anything fails
                return time.ToLocalTime();
            }

        }
    }
}
