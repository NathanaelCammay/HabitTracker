using System;

namespace HabitTracker.Domain.ValueObjects
{
    public sealed record GymSession
    {
        public string WorkoutType { get; }
        public int DurationMinutes { get; }
        public double WeightKg { get; }

        public GymSession(string workoutType, int durationMinutes, double weightKg)
        {
            if (string.IsNullOrWhiteSpace(workoutType))
            {
                throw new ArgumentException("Workout type is required.", nameof(workoutType));
            }

            if (durationMinutes <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(durationMinutes), "Duration must be greater than zero.");
            }

            if (weightKg < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(weightKg), "Weight cannot be negative.");
            }

            WorkoutType = workoutType;
            DurationMinutes = durationMinutes;
            WeightKg = weightKg;
        }
    }
}
