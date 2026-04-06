using System;
using System.Collections.Generic;
using System.Text;

namespace HabitTracker.Domain.ValueObjects
{
    public class GymSession
    {
        public string WorkoutType { get; set; } = string.Empty;
        public int DurationMinutes { get; set; }
        public double WeightKg { get; set; }
    }
}
