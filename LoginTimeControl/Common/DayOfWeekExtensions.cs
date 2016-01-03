using System;

namespace Common
{
    public static class DayOfWeekExtensions
    {
        public static string ToLocalizedString(this DayOfWeek dayOfWeek)
        {
            return Strings.ResourceManager.GetString(dayOfWeek.ToString());
        }
    }
}