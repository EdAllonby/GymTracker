using System;

namespace GymTracker.ViewModels
{
    public static class TimeSpanFormatter
    {
        public static string ToDaysAgo(this TimeSpan timeSpan)
        {
            const string singular = "Day";
            const string plural = "Days";

            return ToNounAgo(timeSpan.Days, singular, plural);
        }

        private static string ToNounAgo(int timeUnitDistance, string singularNoun, string pluralNoun)
        {
            NounState nounState;

            switch (timeUnitDistance)
            {
                case 0:
                    // Special case.
                    return "Today";
                case 1:
                    nounState = NounState.Singular;
                    break;
                default:
                    nounState = NounState.Plural;
                    break;
            }

            string nounToUse = NounFinder(nounState, singularNoun, pluralNoun);

            return $"{timeUnitDistance} {nounToUse} ago.";
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