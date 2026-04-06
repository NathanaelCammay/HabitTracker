using System;
using System.Collections.Generic;
using System.Text;

namespace HabitTracker.Domain.ValueObjects
{
    public sealed record GymSession(
        string WorkoutType,
        int DurationMinutes,
        double WeightKg);
}
