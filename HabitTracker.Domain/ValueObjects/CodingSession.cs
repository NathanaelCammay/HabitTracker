using System;

namespace HabitTracker.Domain.ValueObjects
{
    public sealed record CodingSession
    {
        public string Language { get; }
        public int DurationMinutes { get; }
        public string Notes { get; }

        public CodingSession(string language, int durationMinutes, string notes)
        {
            if (string.IsNullOrWhiteSpace(language))
            {
                throw new ArgumentException("Language is required.", nameof(language));
            }

            if (durationMinutes <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(durationMinutes), "Duration must be greater than zero.");
            }

            if (string.IsNullOrWhiteSpace(notes))
            {
                throw new ArgumentException("Habit notes are required.", nameof(notes));
            }

            Language = language;
            DurationMinutes = durationMinutes;
            Notes = notes;
        }
    }
}
