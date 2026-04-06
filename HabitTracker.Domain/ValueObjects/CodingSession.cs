using System;
using System.Collections.Generic;
using System.Text;

namespace HabitTracker.Domain.ValueObjects
{
    public class CodingSession
    {
        public string Language { get; set; } = string.Empty;
        public int DurationMinutes { get; set; }
        public string Notes { get; set; } = string.Empty;
    }
}
