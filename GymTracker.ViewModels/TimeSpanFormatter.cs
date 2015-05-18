using System;

namespace GymTracker.Models
{
    public static class TimeSpanFormatter
    {
        public static string ToDaysAgo(this TimeSpan timeSpan)
        {
            const string singular = "day";
            const string plural = "days";

            return ToNounAgo(timeSpan, singular, plural);
        }

        private static string ToNounAgo(TimeSpan timeSpan, string singularNoun, string pluralNoun)
        {
            int daysAgo = timeSpan.Days;

            NounState nounState = NounState.Plural;

            if (daysAgo == 1)
            {
                nounState = NounState.Singular;
            }

            string nounToUse = NounFinder(nounState, "day", "days");

            return string.Format("{0} {1} ago", daysAgo, nounToUse);
        }

        private static string NounFinder(NounState nounState, string singularVersion, string pluralVersion)
        {
            switch (nounState)
            {
                case NounState.Singular:
                    return singularVersion;

                case NounState.Plural:
                    return pluralVersion;

            }

            // If no noun state specified, return the more common plural version (worst case will say 1 days).
            return pluralVersion;
        }

        private enum NounState
        {
            Singular,
            Plural
        }
    }
}