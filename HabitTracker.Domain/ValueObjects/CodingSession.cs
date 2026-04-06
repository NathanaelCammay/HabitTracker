using System;
using System.Collections.Generic;
using System.Text;

namespace HabitTracker.Domain.ValueObjects
{
    public sealed record CodingSession(
        string Language,
        int DurationMinutes,
        string Notes);
}
